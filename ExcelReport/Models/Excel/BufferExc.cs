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
            int column = spisokmustemp.FindIndex(x => x == "");
            int strokss = spisokmustemp.Count / column - 1;
      
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
            string [,] tabledir = new string[strokss, column];

            for (int i = 0; i < strokss; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    tabledir[i, j] = spisok[j];
                }
                spisok.RemoveRange(0, column - 1);
                spisok.RemoveAt(0);

            };

            int sd = 1;


        }
    }
}
