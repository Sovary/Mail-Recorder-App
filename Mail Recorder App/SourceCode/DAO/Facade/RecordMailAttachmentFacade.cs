using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Mail_Recorder_App.DAO
{
    public class RecordMailAttachmentFacade : DataAccess
    {
        protected void UploadFileMailAttach(IEnumerable<RecordMailAttachment> files, RecordMail rm)
        {
            string opName = $"{GetOperator(rm.OperatorId)?.Name}";
            string dateStr = $"{rm.Date:MMyyyy}";
            string path = Path.Combine(FilePath, opName, dateStr);
            var dir = Directory.CreateDirectory(path);
            var attach = new List<RecordMailAttachment>();
            foreach (var source in files)
            {
                string newFilename = $"{Path.GetFileNameWithoutExtension(source.Name)}_{DateTime.Now.ToString("ddMMyyHHmmss")}{Path.GetExtension(source.Name)}";
                string newPath = Path.Combine(path, newFilename);
                File.Copy(source.Path, newPath);
                attach.Add(new RecordMailAttachment()
                {
                    Name = source.Name,
                    Path = Path.Combine(opName,dateStr, newFilename),
                });
            }
            //in case add action only
            if (rm.Attach == null && attach.Any())
            {
                rm.Attach = attach.ToArray();
            }
            //in case update on exist object with new attachments 
            else if (rm.Attach.Any())
            {
                var t = new List<RecordMailAttachment>(rm.Attach);
                t.AddRange(attach);
                rm.Attach = t.ToArray();
            }
        }

        internal void DeleteFileMailAttach(params RecordMailAttachment[] ms)
        {
            if (ms == null) return;
            foreach (var r in ms)
            {
                File.Delete(Path.Combine(FilePath, r.Path));
            }
        }

        public void AddRecordMailAttachment_ValidatingOnly(RecordMail mail, params RecordMailAttachment[] atts)
        {
            foreach(var a in atts)
            {
                if (string.IsNullOrWhiteSpace(a.Name)) throw new ValidatingException("Invalid filename");
            }
        }
    }
}
