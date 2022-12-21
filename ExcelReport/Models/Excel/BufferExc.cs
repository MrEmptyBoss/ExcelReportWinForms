using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelReport.Models.Excel
{
    class BufferExc
    {
        public void infos()
        {
            List<string> filess = new List<string>();

            string ish = Clipboard.GetText();

            string ots = Regex.Replace(ish, @"\b мм\b|\b шт\b", "\n");

            string[] data = ots.Split('\t', '\r', '\n');
            List<string> spisokmustemp = new List<string>();

            for (int i = 0; i < data.Length; i++)
            {
                string slovo = data[i];

                spisokmustemp.Add(slovo);
            }
            int s = spisokmustemp.FindIndex(x => x == "");
      
            List<string> spisok = new List<string>();

            for (int i = 0; i < data.Length; i++)
            {
                string slovo = data[i];
                if (slovo == "")
                {

                }
                else if (slovo == ".")
                {

                }
                else if (slovo == ".pdf")
                {

                }

                else
                {
                    spisok.Add(slovo);
                }
            }
            var ss = 1;
            //string[] columns = 

        }
    }
}
