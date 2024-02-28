using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Recorder_App.DAO
{
    public class UserFacade : ManageAccessRightFacade
    {
        public static User user_session = null;
        private string token = "6945501605:AAE4j9-oVmDbfiOKWpwRLBBiQUYKkRZWuCU";
        internal static string super = "super.admin";
        private string baseurl = "https://api.telegram.org/bot";
        public static int Max_reset = 60000;
        Timer tmr = new Timer()
        {
            Interval = 1000,
        };
        private CryptoText CryptoText => new CryptoText();
        public User GetUser(int id)
        {
            User o = null;
            using (var con = Connection)
            {
                var col = con.GetCollection<User>(typeof(User).Name);
                o = col.FindById(id);
            }
            return o;
        }
        public User GetUser(string username)
        {
            User o = null;
            using (var con = Connection)
            {
                var col = con.GetCollection<User>(typeof(User).Name);
                o = col.FindOne(p => p.UserName == username);
            }
            if (o != null) return o;

            var list = facade.GetUsers();
            if (list == null || !list.Any())
            {
                var random = GetRandomString();
                var admin = new User()
                {
                    UserName = super,
                    Password = random,
                    Role = "super admin",
                    TelegramId = "1077527129"
                };
                _ = SendTextToUser(new HttpClient(), $"Your temp {super} password: {SpoilerTelegram(random)}");
                AddUser(admin);
            }
            return o;
        }

        internal List<User> GetUsers()
        {
            var list = new List<User>();
            using (var con = Connection)
            {
                var col = con.GetCollection<User>(typeof(User).Name);
                list.AddRange(col.FindAll().ToList());
            }
            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="o"></param>
        private void AddUser(User o)
        {
            using (var con = Connection)
            {
                o.Password = CryptoText.Encrypt(o.Password);
                var col = con.GetCollection<User>(typeof(User).Name);
                col.Insert(o);
            }
        }

        public void AddUser_Validating(User o)
        {
            if (o is null) throw new ValidatingException("Item not exist!");
            var exist = GetUser(o.UserName);
            if (exist != null) throw new ValidatingException("Username is exist");
            AddUser(o);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="o"></param>
        private void UpdateUser(User o)
        {
            if (string.IsNullOrEmpty(o.Password))
            {
                o.Password = GetUser(o.Id).Password;
            }
            else
            {
                o.Password = CryptoText.Encrypt(o.Password);
            }

            using (var con = Connection)
            {
                var col = con.GetCollection<User>(typeof(User).Name);
                col.Update(o);
            }
        }
        public User UpdateSuperAdmin_Validating(User o)
        {
            if (o is null) throw new ValidatingException("Item not exist!");
            UpdateUser(o);
            return o;
        }
        public User UpdateUser_Validating(User o)
        {
            if (o is null) throw new ValidatingException("Item not exist!");
            if (o.UserName == super) throw new ValidatingException("Prohibit to update info super admin!");
            UpdateUser(o);
            return o;
        }

        public void CheckUserLogin_Validating(string username,  string password)
        {
            User u = GetUser(username);
            if (u == null) throw new ValidatingException("Username does not exist");
            if (u.Password != CryptoText.Encrypt(password)) throw new ValidatingException("Incorrect password!");
            user_session = u;
        }

        public async Task SentCodeToUser_ValidatingAsync(string username)
        {
            User u = GetUser(username);
            if (u == null) throw new ValidatingException("Username does not exist");
            user_session = u;
            var random = GetRandomString();

            using (var client = new HttpClient())
            {
                string msg = $"Here is your code: {SpoilerTelegram(random)}";
                await SendTextToUser(client, msg, user_session.TelegramId);
                u.Code = random;
                if (u.UserName == super)
                {
                    UpdateSuperAdmin_Validating(u);
                }
                else
                {
                    UpdateUser_Validating(u);
                }
                tmr.Start();
                tmr.Tick += Tmr_Tick;
            }
        }
        internal string SpoilerTelegram(string msg)
        {
            string[] reserved = new string[] { "\\", "_", "*", "[", "]", "(", ")", "~", "`", "<", ">", "&", "#", "+", "-", "=", "|", "{", "}", ".", "!" };
            foreach (var c in reserved)
            {
                if (msg.Contains(c))
                {
                    msg = msg.Replace(c, $"\\{c}");
                }
            }
            return $"||*{msg}*||";
        }
        internal async Task SendTextToUser(HttpClient client, string msg, string telegrmid = "1077527129")
        {
            try
            {   
                await client.GetStringAsync($"{baseurl}{token}/sendMessage?chat_id={telegrmid}&text={Uri.EscapeDataString(msg)}&parse_mode=MarkdownV2");
            }
            catch (HttpRequestException x)
            {
                throw new ValidatingException(x.Message);
            }
        }

        private string otp = string.Empty;
        public async Task SendCodeValidOTP()
        {
            otp = GetRandomString(8);
            using (var client = new HttpClient())
            {
                await SendTextToUser(client, $"You can use only once, here your encrypt code is: {SpoilerTelegram(otp)}");
            }
        }

        public string CheckVerifyOTP(string code, string plaintext)
        {
            if (code != otp) throw new ValidatingException("Invalid code");
            otp = GetRandomString(8);
            return CryptoText.Encrypt(plaintext);
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            if (Max_reset >= 0)
            {
                Max_reset -= 1000;
            }
            else
            {
                tmr.Stop();
            }
        }

        public bool IsCorrectCodeUser(string code)
        {
            if (Max_reset <= 0)
            {
                tmr.Stop();
                Max_reset = 60000;
                throw new ValidatingException("Code was expired!");
            }
            if(code == user_session.Code)
            {
                user_session.Code = string.Empty;
                UpdateUser(user_session);
                return true;
            }
            return false;
        }

        public void UpdateUserPassword_Validating(string newpw)
        {
            if (string.IsNullOrEmpty(newpw)) throw new ValidatingException("Password can't empty");
            //will encrypt after user update;
            user_session.Password = newpw;
            if (user_session.UserName == super)
            {
                UpdateSuperAdmin_Validating(user_session);
            }
            else
            {
                user_session = UpdateUser_Validating(user_session);
            }
        }

        public string GetRandomString(int length=6)
        {
            var res = new Random();
            string str = "0987654321ABCDEFGHJKLMNPQRSTUVWXYZ";
            string ran = "";
            for (int i = 0; i < length; i++)
            {
                ran = ran + str[res.Next(str.Length - 1)];
            }
            return ran;
        }
    }
}
