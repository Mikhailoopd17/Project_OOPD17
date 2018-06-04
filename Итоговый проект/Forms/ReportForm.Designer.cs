namespace Итоговый_проект.Forms
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.dfdds = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNmae = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDateSP = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDateFP = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPhoneSpare = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCompanySP = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSecondParent = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPhoneFparent = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblCompanyFP = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblFirstParent = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGVdata = new System.Windows.Forms.DataGridView();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_четверть = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.II_четверть = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.III_четверть = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IV_четверть = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdata)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(219, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Отчет по ученику";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 636);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Распечатать отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фамилия:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbladress);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblClass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.dfdds);
            this.groupBox1.Controls.Add(this.lblFname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblNmae);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 107);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ученик";
            // 
            // lbladress
            // 
            this.lbladress.AutoSize = true;
            this.lbladress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbladress.Location = new System.Drawing.Point(173, 76);
            this.lbladress.Name = "lbladress";
            this.lbladress.Size = new System.Drawing.Size(57, 20);
            this.lbladress.TabIndex = 19;
            this.lbladress.Text = "adress";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Домашний адрес:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Location = new System.Drawing.Point(498, 56);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 20);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(372, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Дата рождения";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClass.Location = new System.Drawing.Point(498, 36);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(45, 20);
            this.lblClass.TabIndex = 15;
            this.lblClass.Text = "class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(372, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Класс";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Location = new System.Drawing.Point(498, 16);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(54, 20);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "phone";
            // 
            // dfdds
            // 
            this.dfdds.AutoSize = true;
            this.dfdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dfdds.Location = new System.Drawing.Point(372, 16);
            this.dfdds.Name = "dfdds";
            this.dfdds.Size = new System.Drawing.Size(107, 20);
            this.dfdds.TabIndex = 12;
            this.dfdds.Text = "№ телефона";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFname.Location = new System.Drawing.Point(108, 56);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(83, 20);
            this.lblFname.TabIndex = 11;
            this.lblFname.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Отчетство:";
            // 
            // lblNmae
            // 
            this.lblNmae.AutoSize = true;
            this.lblNmae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNmae.Location = new System.Drawing.Point(108, 36);
            this.lblNmae.Name = "lblNmae";
            this.lblNmae.Size = new System.Drawing.Size(40, 20);
            this.lblNmae.TabIndex = 9;
            this.lblNmae.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Имя:";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSname.Location = new System.Drawing.Point(108, 16);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(85, 20);
            this.lblSname.TabIndex = 7;
            this.lblSname.Text = "Фамилия:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDateSP);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblDateFP);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblPhoneSpare);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblCompanySP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblSecondParent);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblPhoneFparent);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblCompanyFP);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblFirstParent);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(31, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 152);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Родители";
            // 
            // lblDateSP
            // 
            this.lblDateSP.AutoSize = true;
            this.lblDateSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateSP.Location = new System.Drawing.Point(565, 89);
            this.lblDateSP.Name = "lblDateSP";
            this.lblDateSP.Size = new System.Drawing.Size(41, 20);
            this.lblDateSP.TabIndex = 31;
            this.lblDateSP.Text = "date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(439, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Дата рождения";
            // 
            // lblDateFP
            // 
            this.lblDateFP.AutoSize = true;
            this.lblDateFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateFP.Location = new System.Drawing.Point(565, 16);
            this.lblDateFP.Name = "lblDateFP";
            this.lblDateFP.Size = new System.Drawing.Size(41, 20);
            this.lblDateFP.TabIndex = 29;
            this.lblDateFP.Text = "date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(439, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Дата рождения";
            // 
            // lblPhoneSpare
            // 
            this.lblPhoneSpare.AutoSize = true;
            this.lblPhoneSpare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneSpare.Location = new System.Drawing.Point(172, 109);
            this.lblPhoneSpare.Name = "lblPhoneSpare";
            this.lblPhoneSpare.Size = new System.Drawing.Size(54, 20);
            this.lblPhoneSpare.TabIndex = 27;
            this.lblPhoneSpare.Text = "phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(46, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "№ телефона";
            // 
            // lblCompanySP
            // 
            this.lblCompanySP.AutoSize = true;
            this.lblCompanySP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompanySP.Location = new System.Drawing.Point(262, 129);
            this.lblCompanySP.Name = "lblCompanySP";
            this.lblCompanySP.Size = new System.Drawing.Size(83, 20);
            this.lblCompanySP.TabIndex = 25;
            this.lblCompanySP.Text = "Отчество";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(46, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Место работы, должность";
            // 
            // lblSecondParent
            // 
            this.lblSecondParent.AutoSize = true;
            this.lblSecondParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecondParent.Location = new System.Drawing.Point(46, 89);
            this.lblSecondParent.Name = "lblSecondParent";
            this.lblSecondParent.Size = new System.Drawing.Size(97, 20);
            this.lblSecondParent.TabIndex = 23;
            this.lblSecondParent.Text = "2 родитель";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(17, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "2)";
            // 
            // lblPhoneFparent
            // 
            this.lblPhoneFparent.AutoSize = true;
            this.lblPhoneFparent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneFparent.Location = new System.Drawing.Point(172, 36);
            this.lblPhoneFparent.Name = "lblPhoneFparent";
            this.lblPhoneFparent.Size = new System.Drawing.Size(54, 20);
            this.lblPhoneFparent.TabIndex = 21;
            this.lblPhoneFparent.Text = "phone";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(46, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "№ телефона";
            // 
            // lblCompanyFP
            // 
            this.lblCompanyFP.AutoSize = true;
            this.lblCompanyFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompanyFP.Location = new System.Drawing.Point(262, 56);
            this.lblCompanyFP.Name = "lblCompanyFP";
            this.lblCompanyFP.Size = new System.Drawing.Size(83, 20);
            this.lblCompanyFP.TabIndex = 11;
            this.lblCompanyFP.Text = "Отчество";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(46, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(210, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Место работы, должность";
            // 
            // lblFirstParent
            // 
            this.lblFirstParent.AutoSize = true;
            this.lblFirstParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstParent.Location = new System.Drawing.Point(46, 16);
            this.lblFirstParent.Name = "lblFirstParent";
            this.lblFirstParent.Size = new System.Drawing.Size(97, 20);
            this.lblFirstParent.TabIndex = 7;
            this.lblFirstParent.Text = "1 родитель";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(17, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 20);
            this.label20.TabIndex = 6;
            this.label20.Text = "1)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGVdata);
            this.groupBox3.Location = new System.Drawing.Point(31, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 304);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Табель";
            // 
            // DGVdata
            // 
            this.DGVdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Название,
            this.I_четверть,
            this.II_четверть,
            this.III_четверть,
            this.IV_четверть,
            this.Column1});
            this.DGVdata.Location = new System.Drawing.Point(21, 19);
            this.DGVdata.Name = "DGVdata";
            this.DGVdata.Size = new System.Drawing.Size(581, 279);
            this.DGVdata.TabIndex = 1;
            this.DGVdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVdata_CellContentClick);
            // 
            // Название
            // 
            this.Название.HeaderText = "Наименование предмета";
            this.Название.Name = "Название";
            this.Название.Width = 150;
            // 
            // I_четверть
            // 
            this.I_четверть.HeaderText = "1 четверть";
            this.I_четверть.Name = "I_четверть";
            this.I_четверть.Width = 70;
            // 
            // II_четверть
            // 
            this.II_четверть.HeaderText = "2 четверть";
            this.II_четверть.Name = "II_четверть";
            this.II_четверть.Width = 70;
            // 
            // III_четверть
            // 
            this.III_четверть.HeaderText = "3 четверть";
            this.III_четверть.Name = "III_четверть";
            this.III_четверть.Width = 70;
            // 
            // IV_четверть
            // 
            this.IV_четверть.HeaderText = "4 четверть";
            this.IV_четверть.Name = "IV_четверть";
            this.IV_четверть.Width = 70;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Итог";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 636);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 662);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Name = "ReportForm";
            this.Text = "Отчет по ученику";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button button1;
        public System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbladress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label dfdds;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNmae;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPhoneSpare;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCompanySP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSecondParent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPhoneFparent;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblCompanyFP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblFirstParent;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DGVdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_четверть;
        private System.Windows.Forms.DataGridViewTextBoxColumn II_четверть;
        private System.Windows.Forms.DataGridViewTextBoxColumn III_четверть;
        private System.Windows.Forms.DataGridViewTextBoxColumn IV_четверть;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblDateSP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDateFP;
        private System.Windows.Forms.Label label9;
    }
}