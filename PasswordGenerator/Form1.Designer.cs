namespace PasswordGenerator
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_passwords = new System.Windows.Forms.ListBox();
            this.btn_password_gen = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkbx_numbers = new System.Windows.Forms.CheckBox();
            this.chkbx_capital_letters = new System.Windows.Forms.CheckBox();
            this.chkbx_special_characters = new System.Windows.Forms.CheckBox();
            this.chkbx_lowercase_letters = new System.Windows.Forms.CheckBox();
            this.txtbx_numbers = new System.Windows.Forms.TextBox();
            this.txtbx_capital_letters = new System.Windows.Forms.TextBox();
            this.txt_box_special_characters = new System.Windows.Forms.TextBox();
            this.txtbx_lowercase_letters = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_length = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbx_length);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbx_lowercase_letters);
            this.groupBox1.Controls.Add(this.txt_box_special_characters);
            this.groupBox1.Controls.Add(this.txtbx_capital_letters);
            this.groupBox1.Controls.Add(this.txtbx_numbers);
            this.groupBox1.Controls.Add(this.chkbx_lowercase_letters);
            this.groupBox1.Controls.Add(this.chkbx_special_characters);
            this.groupBox1.Controls.Add(this.chkbx_capital_letters);
            this.groupBox1.Controls.Add(this.chkbx_numbers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_password_gen);
            this.groupBox1.Controls.Add(this.txtbx_password);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generator";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_passwords);
            this.groupBox2.Location = new System.Drawing.Point(497, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 429);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Passwords";
            // 
            // lst_passwords
            // 
            this.lst_passwords.FormattingEnabled = true;
            this.lst_passwords.Location = new System.Drawing.Point(8, 21);
            this.lst_passwords.Name = "lst_passwords";
            this.lst_passwords.Size = new System.Drawing.Size(272, 407);
            this.lst_passwords.TabIndex = 0;
            this.lst_passwords.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_password_gen
            // 
            this.btn_password_gen.Location = new System.Drawing.Point(63, 389);
            this.btn_password_gen.Name = "btn_password_gen";
            this.btn_password_gen.Size = new System.Drawing.Size(345, 39);
            this.btn_password_gen.TabIndex = 1;
            this.btn_password_gen.Text = "Gernate Password!";
            this.btn_password_gen.UseVisualStyleBackColor = true;
            this.btn_password_gen.Click += new System.EventHandler(this.btn_password_gen_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(419, 388);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(54, 41);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add!";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(165, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Constraints";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Must Contain: ";
            // 
            // chkbx_numbers
            // 
            this.chkbx_numbers.AutoSize = true;
            this.chkbx_numbers.Location = new System.Drawing.Point(34, 102);
            this.chkbx_numbers.Name = "chkbx_numbers";
            this.chkbx_numbers.Size = new System.Drawing.Size(68, 17);
            this.chkbx_numbers.TabIndex = 9;
            this.chkbx_numbers.Text = "Numbers";
            this.chkbx_numbers.UseVisualStyleBackColor = true;
            // 
            // chkbx_capital_letters
            // 
            this.chkbx_capital_letters.AutoSize = true;
            this.chkbx_capital_letters.Location = new System.Drawing.Point(34, 139);
            this.chkbx_capital_letters.Name = "chkbx_capital_letters";
            this.chkbx_capital_letters.Size = new System.Drawing.Size(93, 17);
            this.chkbx_capital_letters.TabIndex = 10;
            this.chkbx_capital_letters.Text = "Capital Letters";
            this.chkbx_capital_letters.UseVisualStyleBackColor = true;
            // 
            // chkbx_special_characters
            // 
            this.chkbx_special_characters.AutoSize = true;
            this.chkbx_special_characters.Location = new System.Drawing.Point(34, 187);
            this.chkbx_special_characters.Name = "chkbx_special_characters";
            this.chkbx_special_characters.Size = new System.Drawing.Size(115, 17);
            this.chkbx_special_characters.TabIndex = 11;
            this.chkbx_special_characters.Text = "Special Characters";
            this.chkbx_special_characters.UseVisualStyleBackColor = true;
            // 
            // chkbx_lowercase_letters
            // 
            this.chkbx_lowercase_letters.AutoSize = true;
            this.chkbx_lowercase_letters.Location = new System.Drawing.Point(34, 232);
            this.chkbx_lowercase_letters.Name = "chkbx_lowercase_letters";
            this.chkbx_lowercase_letters.Size = new System.Drawing.Size(113, 17);
            this.chkbx_lowercase_letters.TabIndex = 12;
            this.chkbx_lowercase_letters.Text = "Lowercase Letters";
            this.chkbx_lowercase_letters.UseVisualStyleBackColor = true;
            // 
            // txtbx_numbers
            // 
            this.txtbx_numbers.Location = new System.Drawing.Point(213, 99);
            this.txtbx_numbers.Name = "txtbx_numbers";
            this.txtbx_numbers.Size = new System.Drawing.Size(162, 20);
            this.txtbx_numbers.TabIndex = 13;
            this.txtbx_numbers.Text = "1";
            // 
            // txtbx_capital_letters
            // 
            this.txtbx_capital_letters.Location = new System.Drawing.Point(213, 139);
            this.txtbx_capital_letters.Name = "txtbx_capital_letters";
            this.txtbx_capital_letters.Size = new System.Drawing.Size(162, 20);
            this.txtbx_capital_letters.TabIndex = 14;
            this.txtbx_capital_letters.Text = "1";
            // 
            // txt_box_special_characters
            // 
            this.txt_box_special_characters.Location = new System.Drawing.Point(213, 187);
            this.txt_box_special_characters.Name = "txt_box_special_characters";
            this.txt_box_special_characters.Size = new System.Drawing.Size(162, 20);
            this.txt_box_special_characters.TabIndex = 15;
            this.txt_box_special_characters.Text = "1";
            // 
            // txtbx_lowercase_letters
            // 
            this.txtbx_lowercase_letters.Location = new System.Drawing.Point(212, 229);
            this.txtbx_lowercase_letters.Name = "txtbx_lowercase_letters";
            this.txtbx_lowercase_letters.Size = new System.Drawing.Size(163, 20);
            this.txtbx_lowercase_letters.TabIndex = 16;
            this.txtbx_lowercase_letters.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(245, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "How Many? ";
            // 
            // txtbx_password
            // 
            this.txtbx_password.Location = new System.Drawing.Point(34, 363);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.ReadOnly = true;
            this.txtbx_password.Size = new System.Drawing.Size(403, 20);
            this.txtbx_password.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Length";
            // 
            // txtbx_length
            // 
            this.txtbx_length.Location = new System.Drawing.Point(274, 335);
            this.txtbx_length.Name = "txtbx_length";
            this.txtbx_length.ReadOnly = true;
            this.txtbx_length.Size = new System.Drawing.Size(163, 20);
            this.txtbx_length.TabIndex = 19;
            this.txtbx_length.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_lowercase_letters;
        private System.Windows.Forms.TextBox txt_box_special_characters;
        private System.Windows.Forms.TextBox txtbx_capital_letters;
        private System.Windows.Forms.TextBox txtbx_numbers;
        private System.Windows.Forms.CheckBox chkbx_lowercase_letters;
        private System.Windows.Forms.CheckBox chkbx_special_characters;
        private System.Windows.Forms.CheckBox chkbx_capital_letters;
        private System.Windows.Forms.CheckBox chkbx_numbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_password_gen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_passwords;
        public System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.TextBox txtbx_length;
        private System.Windows.Forms.Label label4;
    }
}

