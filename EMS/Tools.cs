using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace EMS
{
    internal class Tools
    {

        public Tools()
        {
            if (File.Exists(getDir()))
            {
                fileExist = true;
            }
        }

        private string fileName = @"\DataSource.json";
        public bool fileExist = false;
        private string GenerateJson(List<EmployeeHiring> Obj)
        {
            return JsonConvert.SerializeObject(Obj.Where(c => c != null));
        }
        public void SaveFile(List<EmployeeHiring> Obj)
        {
            FileStream fParameter = new FileStream(getDir(), FileMode.Create, FileAccess.Write);
            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            m_WriterParameter.Write(GenerateJson(Obj));
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
        }
        public List<EmployeeHiring> LoadFile()
        {

            if (File.Exists(getDir()))
            {
                using StreamReader m_ReaderParameter = new(getDir());
                var json = m_ReaderParameter.ReadToEnd();
                m_ReaderParameter.Close();
                return JsonConvert.DeserializeObject<List<EmployeeHiring>>(json);
            }
            return null;

        }
        private string getDir()
        {
            string filepath = Path.GetDirectoryName(Application.ExecutablePath);
            filepath += fileName;
            return filepath;
        }

    }
}
