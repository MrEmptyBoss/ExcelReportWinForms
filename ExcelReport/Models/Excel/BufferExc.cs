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
        List<Positons> Zayvki = new List<Positons>();
        public void infos(string RcT, string FamT, string NumberT, string CrochT, string TrackT, DateTime DtPT, DateTime DtDT, DateTime DtZT, DateTime DtPl, DataGridView dataTable)
        {


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
            string[,] tabledir = new string[strokss, column];

            for (int i = 0; i < strokss; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    tabledir[i, j] = spisok[j];
                }
                spisok.RemoveRange(0, column - 1);
                spisok.RemoveAt(0);

            };

            Zayvki.Clear();
            for (int j = 4; j < column; j++)
            {
                for (int i = 1; i < strokss; i++)
                {
                    double dl = Convert.ToDouble(tabledir[i, 1]);
                    double sh = Convert.ToDouble(tabledir[i, 2]);
                    double col = Convert.ToDouble(tabledir[i, j]);
                    double summ = dl * sh * col;
                    double res = Math.Round(summ / 1000000, 4);
                    Positons positons = new Positons() { RC = RcT, Family = FamT, Number = NumberT, Srochn = CrochT, TK = tabledir[0, j], Zalivka = tabledir[i, 0], Dlina = tabledir[i, 1], Shirina = tabledir[i, 2], col = tabledir[i, j], kvadr = res, Datepriema = DtPT, Datedostavki = DtDT, Datezakr = DtZT, DatePlanovay = DtPl };
                    Zayvki.Add(positons);

                };
            }
            dataTable.Rows.Clear();
            for (int i = 0; i < Zayvki.Count; i++)
            {
                dataTable.Rows.Add(Zayvki[i].RC, Zayvki[i].Family, Zayvki[i].Number, Zayvki[i].Srochn, Zayvki[i].TK, Zayvki[i].Datepriema, Zayvki[i].Datedostavki, Zayvki[i].Datezakr, Zayvki[i].Zalivka, Zayvki[i].Dlina, Zayvki[i].Shirina, Zayvki[i].col, Zayvki[i].kvadr, Zayvki[i].DatePlanovay, 0);
            }

        }
    }

    public class Positons
    {
        public string RC;
        public string Family;
        public string Number;
        public string Srochn;
        public string TK;
        public DateTime Datepriema;
        public DateTime Datedostavki;
        public DateTime Datezakr;
        public string Zalivka;
        public string Dlina;
        public string Shirina;
        public string col;
        public double kvadr;
        public DateTime DatePlanovay;
        //public string TrackNumber;
    }
}
