namespace Итоговый_проект.Forms
{
    partial class listForm
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
            this.components = new System.ComponentModel.Container();
            this.DGVdata = new System.Windows.Forms.DataGridView();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_четверть = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.II_четверть = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.III_четверть = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IV_четверть = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFio = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdata)).BeginInit();
            this.SuspendLayout();
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
            this.DGVdata.Location = new System.Drawing.Point(5, 60);
            this.DGVdata.Name = "DGVdata";
            this.DGVdata.Size = new System.Drawing.Size(534, 305);
            this.DGVdata.TabIndex = 0;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(419, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "generate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО ученика:";
            // 
            // lblFio
            // 
            this.lblFio.AutoSize = true;
            this.lblFio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFio.Location = new System.Drawing.Point(138, 29);
            this.lblFio.Name = "lblFio";
            this.lblFio.Size = new System.Drawing.Size(21, 19);
            this.lblFio.TabIndex = 3;
            this.lblFio.Text = "--";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(419, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 414);
            this.Controls.Add(this.DGVdata);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblFio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "listForm";
            this.Text = "RatingForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVdata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_четверть;
        private System.Windows.Forms.DataGridViewTextBoxColumn II_четверть;
        private System.Windows.Forms.DataGridViewTextBoxColumn III_четверть;
        private System.Windows.Forms.DataGridViewTextBoxColumn IV_четверть;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.Label lblFio;
    }
}