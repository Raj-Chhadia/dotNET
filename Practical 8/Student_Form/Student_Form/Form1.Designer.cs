
namespace Student_Form
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
            this.label_name = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label_en = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label_mob = new System.Windows.Forms.Label();
            this.label_sem = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.label_gender = new System.Windows.Forms.Label();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.label_dob = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.bt1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(51, 42);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(75, 17);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Full Name:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(185, 36);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(187, 22);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(185, 81);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(187, 22);
            this.txt2.TabIndex = 3;
            // 
            // label_en
            // 
            this.label_en.AutoSize = true;
            this.label_en.Location = new System.Drawing.Point(51, 87);
            this.label_en.Name = "label_en";
            this.label_en.Size = new System.Drawing.Size(105, 17);
            this.label_en.TabIndex = 2;
            this.label_en.Text = "Enrollment No.:";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(185, 132);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(187, 22);
            this.txt3.TabIndex = 5;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(51, 138);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(46, 17);
            this.label_email.TabIndex = 4;
            this.label_email.Text = "Email:";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(185, 178);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(187, 22);
            this.txt4.TabIndex = 7;
            // 
            // label_mob
            // 
            this.label_mob.AutoSize = true;
            this.label_mob.Location = new System.Drawing.Point(51, 184);
            this.label_mob.Name = "label_mob";
            this.label_mob.Size = new System.Drawing.Size(53, 17);
            this.label_mob.TabIndex = 6;
            this.label_mob.Text = "Mobile:";
            // 
            // label_sem
            // 
            this.label_sem.AutoSize = true;
            this.label_sem.Location = new System.Drawing.Point(51, 226);
            this.label_sem.Name = "label_sem";
            this.label_sem.Size = new System.Drawing.Size(72, 17);
            this.label_sem.TabIndex = 8;
            this.label_sem.Text = "Semester:";
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmb1.Location = new System.Drawing.Point(185, 219);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 24);
            this.cmb1.TabIndex = 9;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Location = new System.Drawing.Point(51, 276);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(60, 17);
            this.label_gender.TabIndex = 10;
            this.label_gender.Text = "Gender:";
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(185, 272);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(59, 21);
            this.rd1.TabIndex = 11;
            this.rd1.TabStop = true;
            this.rd1.Text = "Male";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(297, 272);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(75, 21);
            this.rd2.TabIndex = 12;
            this.rd2.TabStop = true;
            this.rd2.Text = "Female";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // label_dob
            // 
            this.label_dob.AutoSize = true;
            this.label_dob.Location = new System.Drawing.Point(54, 319);
            this.label_dob.Name = "label_dob";
            this.label_dob.Size = new System.Drawing.Size(90, 17);
            this.label_dob.TabIndex = 13;
            this.label_dob.Text = "Date of birth:";
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(185, 319);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 22);
            this.dtp1.TabIndex = 14;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(138, 417);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(138, 66);
            this.bt1.TabIndex = 15;
            this.bt1.Text = "Submit";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(133, 511);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(172, 29);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Open notepad";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 561);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.label_dob);
            this.Controls.Add(this.rd2);
            this.Controls.Add(this.rd1);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.label_sem);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.label_mob);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label_en);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label_en;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label_mob;
        private System.Windows.Forms.Label label_sem;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.Label label_dob;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

