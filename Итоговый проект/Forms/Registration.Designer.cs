namespace Итоговый_проект
{
    partial class Registration
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
            this.tbRegName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRegSname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRegFname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRegLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRegPass1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblPas = new System.Windows.Forms.Label();
            this.tbRegPass2 = new System.Windows.Forms.TextBox();
            this.lblLogOk = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tbRegName
            // 
            this.tbRegName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegName.Location = new System.Drawing.Point(182, 79);
            this.tbRegName.Name = "tbRegName";
            this.tbRegName.Size = new System.Drawing.Size(164, 26);
            this.tbRegName.TabIndex = 2;
            this.toolTip2.SetToolTip(this.tbRegName, "Только буквы русского алфавита");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Для регистрации заполните следующие поля:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(316, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 42);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Фамилия:";
            // 
            // tbRegSname
            // 
            this.tbRegSname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegSname.Location = new System.Drawing.Point(182, 47);
            this.tbRegSname.Name = "tbRegSname";
            this.tbRegSname.Size = new System.Drawing.Size(164, 26);
            this.tbRegSname.TabIndex = 1;
            this.toolTip2.SetToolTip(this.tbRegSname, "Только буквы русского алфавита");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(75, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Отчество:";
            // 
            // tbRegFname
            // 
            this.tbRegFname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegFname.Location = new System.Drawing.Point(182, 111);
            this.tbRegFname.Name = "tbRegFname";
            this.tbRegFname.Size = new System.Drawing.Size(164, 26);
            this.tbRegFname.TabIndex = 3;
            this.toolTip2.SetToolTip(this.tbRegFname, "Только буквы русского алфавита");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Придумайте логин:";
            // 
            // tbRegLogin
            // 
            this.tbRegLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbRegLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegLogin.Location = new System.Drawing.Point(211, 163);
            this.tbRegLogin.Name = "tbRegLogin";
            this.tbRegLogin.Size = new System.Drawing.Size(167, 26);
            this.tbRegLogin.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbRegLogin, "Подсказка. Только цифры и латинские буквы ");
            this.tbRegLogin.TextChanged += new System.EventHandler(this.tbRegLogin_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(41, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Придумайте пароль:";
            // 
            // tbRegPass1
            // 
            this.tbRegPass1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegPass1.Location = new System.Drawing.Point(211, 202);
            this.tbRegPass1.Name = "tbRegPass1";
            this.tbRegPass1.PasswordChar = '+';
            this.tbRegPass1.Size = new System.Drawing.Size(167, 26);
            this.tbRegPass1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tbRegPass1, "Подсказка. Только цифры и латинские буквы ");
            this.tbRegPass1.TextChanged += new System.EventHandler(this.tbRegPass1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(41, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Повторите пароль:";
            // 
            // btnReg
            // 
            this.btnReg.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.Location = new System.Drawing.Point(63, 311);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(164, 42);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblPas
            // 
            this.lblPas.AutoSize = true;
            this.lblPas.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPas.Location = new System.Drawing.Point(212, 283);
            this.lblPas.Name = "lblPas";
            this.lblPas.Size = new System.Drawing.Size(0, 16);
            this.lblPas.TabIndex = 21;
            // 
            // tbRegPass2
            // 
            this.tbRegPass2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegPass2.Location = new System.Drawing.Point(211, 242);
            this.tbRegPass2.Name = "tbRegPass2";
            this.tbRegPass2.PasswordChar = '+';
            this.tbRegPass2.Size = new System.Drawing.Size(167, 26);
            this.tbRegPass2.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tbRegPass2, "Подсказка. Только цифры и латинские буквы ");
            this.tbRegPass2.TextChanged += new System.EventHandler(this.tbRegPass2_TextChanged);
            // 
            // lblLogOk
            // 
            this.lblLogOk.AutoSize = true;
            this.lblLogOk.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogOk.Location = new System.Drawing.Point(212, 144);
            this.lblLogOk.Name = "lblLogOk";
            this.lblLogOk.Size = new System.Drawing.Size(0, 16);
            this.lblLogOk.TabIndex = 22;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Подсказка";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 365);
            this.Controls.Add(this.lblLogOk);
            this.Controls.Add(this.tbRegPass2);
            this.Controls.Add(this.tbRegPass1);
            this.Controls.Add(this.lblPas);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRegLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRegFname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRegSname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRegName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Name = "Registration";
            this.Text = "Registration";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRegName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRegSname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRegFname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRegLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRegPass1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblPas;
        private System.Windows.Forms.TextBox tbRegPass2;
        private System.Windows.Forms.Label lblLogOk;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}