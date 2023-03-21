
namespace StudentData
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
            this.bt1 = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label_dob = new System.Windows.Forms.Label();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.label_gender = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.label_sem = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label_mob = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label_en = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_tc = new System.Windows.Forms.Label();
            this.chk_tc = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(320, 453);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(138, 66);
            this.bt1.TabIndex = 31;
            this.bt1.Text = "Submit";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(367, 355);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 22);
            this.dtp1.TabIndex = 30;
            // 
            // label_dob
            // 
            this.label_dob.AutoSize = true;
            this.label_dob.Location = new System.Drawing.Point(236, 355);
            this.label_dob.Name = "label_dob";
            this.label_dob.Size = new System.Drawing.Size(90, 17);
            this.label_dob.TabIndex = 29;
            this.label_dob.Text = "Date of birth:";
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(479, 308);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(75, 21);
            this.rd2.TabIndex = 28;
            this.rd2.TabStop = true;
            this.rd2.Text = "Female";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(367, 308);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(59, 21);
            this.rd1.TabIndex = 27;
            this.rd1.TabStop = true;
            this.rd1.Text = "Male";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Location = new System.Drawing.Point(233, 312);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(60, 17);
            this.label_gender.TabIndex = 26;
            this.label_gender.Text = "Gender:";
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
            this.cmb1.Location = new System.Drawing.Point(367, 255);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 24);
            this.cmb1.TabIndex = 25;
            // 
            // label_sem
            // 
            this.label_sem.AutoSize = true;
            this.label_sem.Location = new System.Drawing.Point(233, 262);
            this.label_sem.Name = "label_sem";
            this.label_sem.Size = new System.Drawing.Size(72, 17);
            this.label_sem.TabIndex = 24;
            this.label_sem.Text = "Semester:";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(367, 214);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(187, 22);
            this.txt4.TabIndex = 23;
            // 
            // label_mob
            // 
            this.label_mob.AutoSize = true;
            this.label_mob.Location = new System.Drawing.Point(233, 220);
            this.label_mob.Name = "label_mob";
            this.label_mob.Size = new System.Drawing.Size(53, 17);
            this.label_mob.TabIndex = 22;
            this.label_mob.Text = "Mobile:";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(367, 168);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(187, 22);
            this.txt3.TabIndex = 21;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(233, 174);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(46, 17);
            this.label_email.TabIndex = 20;
            this.label_email.Text = "Email:";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(367, 117);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(187, 22);
            this.txt2.TabIndex = 19;
            // 
            // label_en
            // 
            this.label_en.AutoSize = true;
            this.label_en.Location = new System.Drawing.Point(233, 123);
            this.label_en.Name = "label_en";
            this.label_en.Size = new System.Drawing.Size(105, 17);
            this.label_en.TabIndex = 18;
            this.label_en.Text = "Enrollment No.:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(367, 72);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(187, 22);
            this.txt1.TabIndex = 17;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(233, 78);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(75, 17);
            this.label_name.TabIndex = 16;
            this.label_name.Text = "Full Name:";
            // 
            // label_tc
            // 
            this.label_tc.AutoSize = true;
            this.label_tc.Location = new System.Drawing.Point(236, 401);
            this.label_tc.Name = "label_tc";
            this.label_tc.Size = new System.Drawing.Size(150, 17);
            this.label_tc.TabIndex = 32;
            this.label_tc.Text = "Terms and Conditions:";
            // 
            // chk_tc
            // 
            this.chk_tc.AutoSize = true;
            this.chk_tc.Location = new System.Drawing.Point(411, 397);
            this.chk_tc.Name = "chk_tc";
            this.chk_tc.Size = new System.Drawing.Size(78, 21);
            this.chk_tc.TabIndex = 33;
            this.chk_tc.Text = "AGREE";
            this.chk_tc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.chk_tc);
            this.Controls.Add(this.label_tc);
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

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label_dob;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label label_sem;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label_mob;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label_en;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_tc;
        private System.Windows.Forms.CheckBox chk_tc;
    }
}

