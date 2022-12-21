namespace ExcelReport
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NZC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChrochC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZalivkaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DlinaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShirinaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kvadr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtPlanov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить шаблон excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RCC,
            this.FamilyC,
            this.NZC,
            this.ChrochC,
            this.TKC,
            this.DtP,
            this.DtD,
            this.DtZ,
            this.ZalivkaC,
            this.DlinaC,
            this.ShirinaC,
            this.ColC,
            this.Kvadr,
            this.DtPlanov,
            this.TrC});
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 614);
            this.dataGridView1.TabIndex = 1;
            // 
            // RCC
            // 
            this.RCC.HeaderText = "РЦ";
            this.RCC.Name = "RCC";
            this.RCC.ReadOnly = true;
            // 
            // FamilyC
            // 
            this.FamilyC.HeaderText = "Фамилия";
            this.FamilyC.Name = "FamilyC";
            this.FamilyC.ReadOnly = true;
            // 
            // NZC
            // 
            this.NZC.HeaderText = "Номер заявки";
            this.NZC.Name = "NZC";
            this.NZC.ReadOnly = true;
            // 
            // ChrochC
            // 
            this.ChrochC.HeaderText = "Срочность";
            this.ChrochC.Name = "ChrochC";
            this.ChrochC.ReadOnly = true;
            // 
            // TKC
            // 
            this.TKC.HeaderText = "ТК";
            this.TKC.Name = "TKC";
            this.TKC.ReadOnly = true;
            // 
            // DtP
            // 
            this.DtP.HeaderText = "дата и время приема заявки";
            this.DtP.Name = "DtP";
            this.DtP.ReadOnly = true;
            // 
            // DtD
            // 
            this.DtD.HeaderText = "дата и время доставки заявки на РЦ";
            this.DtD.Name = "DtD";
            this.DtD.ReadOnly = true;
            // 
            // DtZ
            // 
            this.DtZ.HeaderText = "дата и время закрытия заявки в сервис деск заказчика";
            this.DtZ.Name = "DtZ";
            this.DtZ.ReadOnly = true;
            // 
            // ZalivkaC
            // 
            this.ZalivkaC.HeaderText = "Заливка";
            this.ZalivkaC.Name = "ZalivkaC";
            this.ZalivkaC.ReadOnly = true;
            // 
            // DlinaC
            // 
            this.DlinaC.HeaderText = "Длина";
            this.DlinaC.Name = "DlinaC";
            this.DlinaC.ReadOnly = true;
            // 
            // ShirinaC
            // 
            this.ShirinaC.HeaderText = "Ширина";
            this.ShirinaC.Name = "ShirinaC";
            this.ShirinaC.ReadOnly = true;
            // 
            // ColC
            // 
            this.ColC.HeaderText = "Кол-во";
            this.ColC.Name = "ColC";
            this.ColC.ReadOnly = true;
            // 
            // Kvadr
            // 
            this.Kvadr.HeaderText = "Квадратура";
            this.Kvadr.Name = "Kvadr";
            this.Kvadr.ReadOnly = true;
            // 
            // DtPlanov
            // 
            this.DtPlanov.HeaderText = "Плановая Дата";
            this.DtPlanov.Name = "DtPlanov";
            this.DtPlanov.ReadOnly = true;
            // 
            // TrC
            // 
            this.TrC.HeaderText = "Трэк-Номер";
            this.TrC.Name = "TrC";
            this.TrC.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 715);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NZC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChrochC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZalivkaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DlinaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShirinaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kvadr;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtPlanov;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrC;
    }
}

