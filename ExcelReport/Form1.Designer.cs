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
            this.label1 = new System.Windows.Forms.Label();
            this.RcText = new System.Windows.Forms.TextBox();
            this.FamText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CrochText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtPText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DtDText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DtZText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DtPlanovText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TrackText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить заявку из буфера обмена";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 570);
            this.dataGridView1.TabIndex = 1;
            // 
            // RCC
            // 
            this.RCC.HeaderText = "РЦ";
            this.RCC.Name = "RCC";
            this.RCC.ReadOnly = true;
            this.RCC.Width = 50;
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
            this.TKC.Width = 50;
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
            this.ZalivkaC.Width = 60;
            // 
            // DlinaC
            // 
            this.DlinaC.HeaderText = "Длина";
            this.DlinaC.Name = "DlinaC";
            this.DlinaC.ReadOnly = true;
            this.DlinaC.Width = 60;
            // 
            // ShirinaC
            // 
            this.ShirinaC.HeaderText = "Ширина";
            this.ShirinaC.Name = "ShirinaC";
            this.ShirinaC.ReadOnly = true;
            this.ShirinaC.Width = 60;
            // 
            // ColC
            // 
            this.ColC.HeaderText = "Кол-во";
            this.ColC.Name = "ColC";
            this.ColC.ReadOnly = true;
            this.ColC.Width = 50;
            // 
            // Kvadr
            // 
            this.Kvadr.HeaderText = "Квадратура";
            this.Kvadr.Name = "Kvadr";
            this.Kvadr.ReadOnly = true;
            this.Kvadr.Width = 80;
            // 
            // DtPlanov
            // 
            this.DtPlanov.HeaderText = "Плановая Дата";
            this.DtPlanov.Name = "DtPlanov";
            this.DtPlanov.ReadOnly = true;
            this.DtPlanov.Width = 80;
            // 
            // TrC
            // 
            this.TrC.HeaderText = "Трек-Номер";
            this.TrC.Name = "TrC";
            this.TrC.ReadOnly = true;
            this.TrC.Width = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(305, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "РЦ";
            // 
            // RcText
            // 
            this.RcText.Location = new System.Drawing.Point(308, 31);
            this.RcText.Name = "RcText";
            this.RcText.Size = new System.Drawing.Size(100, 20);
            this.RcText.TabIndex = 3;
            // 
            // FamText
            // 
            this.FamText.Location = new System.Drawing.Point(417, 31);
            this.FamText.Name = "FamText";
            this.FamText.Size = new System.Drawing.Size(100, 20);
            this.FamText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(414, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // NumberText
            // 
            this.NumberText.Location = new System.Drawing.Point(526, 31);
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(100, 20);
            this.NumberText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(523, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер заявки";
            // 
            // CrochText
            // 
            this.CrochText.Location = new System.Drawing.Point(635, 31);
            this.CrochText.Name = "CrochText";
            this.CrochText.Size = new System.Drawing.Size(100, 20);
            this.CrochText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(632, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Срочность";
            // 
            // DtPText
            // 
            this.DtPText.Location = new System.Drawing.Point(744, 31);
            this.DtPText.Name = "DtPText";
            this.DtPText.Size = new System.Drawing.Size(100, 20);
            this.DtPText.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(741, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата приема заказа";
            // 
            // DtDText
            // 
            this.DtDText.Location = new System.Drawing.Point(909, 31);
            this.DtDText.Name = "DtDText";
            this.DtDText.Size = new System.Drawing.Size(100, 20);
            this.DtDText.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(906, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата доставки заказа";
            // 
            // DtZText
            // 
            this.DtZText.Location = new System.Drawing.Point(308, 86);
            this.DtZText.Name = "DtZText";
            this.DtZText.Size = new System.Drawing.Size(100, 20);
            this.DtZText.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(305, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Дата закрытия заказа";
            // 
            // DtPlanovText
            // 
            this.DtPlanovText.Location = new System.Drawing.Point(488, 86);
            this.DtPlanovText.Name = "DtPlanovText";
            this.DtPlanovText.Size = new System.Drawing.Size(100, 20);
            this.DtPlanovText.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(485, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Плановая дата заказа";
            // 
            // TrackText
            // 
            this.TrackText.Location = new System.Drawing.Point(671, 73);
            this.TrackText.Multiline = true;
            this.TrackText.Name = "TrackText";
            this.TrackText.Size = new System.Drawing.Size(338, 54);
            this.TrackText.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(668, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Трек-номера";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 715);
            this.Controls.Add(this.TrackText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DtPlanovText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DtZText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DtDText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DtPText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CrochText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FamText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RcText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RcText;
        private System.Windows.Forms.TextBox FamText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CrochText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DtPText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DtDText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DtZText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DtPlanovText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TrackText;
        private System.Windows.Forms.Label label9;
    }
}

