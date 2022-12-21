using ExcelReport.Models.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelReport
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string RC = RcText.Text;
                string Family = FamText.Text;
                string Number = NumberText.Text;
                string Srochn = CrochText.Text;
                DateTime Datepriema = Convert.ToDateTime(DtPText.Text);
                DateTime Datedostavki = Convert.ToDateTime(DtDText.Text);
                DateTime Datezakr = Convert.ToDateTime(DtZText.Text);
                DateTime DatePlanovay = Convert.ToDateTime(DtPlanovText.Text);
                string TrackNumber = TrackText.Text;
                BufferExc buffer = new BufferExc();
                buffer.infos(RC, Family, Number, Srochn, TrackNumber, Datepriema, Datedostavki, Datezakr, DatePlanovay, dataGridView1);
                MessageBox.Show("Готово");
            }
            catch (Exception ex)//если в try возникнет исключение, обрабатываем его ниже в catch, к примеру выводим сообщение с текстом ошибки
            {
                MessageBox.Show("Заполните все поля, чтоб вычислить дирформу");
            }
            

            
        }
    }
}
