﻿
namespace Student_datavase
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
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label_dep = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label_desig = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label_empid = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label_salary = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(124, 334);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(138, 66);
            this.bt1.TabIndex = 31;
            this.bt1.Text = "Add";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(255, 178);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(187, 22);
            this.txt4.TabIndex = 23;
            // 
            // label_dep
            // 
            this.label_dep.AutoSize = true;
            this.label_dep.Location = new System.Drawing.Point(121, 184);
            this.label_dep.Name = "label_dep";
            this.label_dep.Size = new System.Drawing.Size(82, 17);
            this.label_dep.TabIndex = 22;
            this.label_dep.Text = "Department";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(255, 132);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(187, 22);
            this.txt3.TabIndex = 21;
            // 
            // label_desig
            // 
            this.label_desig.AutoSize = true;
            this.label_desig.Location = new System.Drawing.Point(121, 138);
            this.label_desig.Name = "label_desig";
            this.label_desig.Size = new System.Drawing.Size(83, 17);
            this.label_desig.TabIndex = 20;
            this.label_desig.Text = "Designation";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(255, 81);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(187, 22);
            this.txt2.TabIndex = 19;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(121, 87);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(45, 17);
            this.label_name.TabIndex = 18;
            this.label_name.Text = "Name";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(255, 36);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(187, 22);
            this.txt1.TabIndex = 17;
            // 
            // label_empid
            // 
            this.label_empid.AutoSize = true;
            this.label_empid.Location = new System.Drawing.Point(121, 42);
            this.label_empid.Name = "label_empid";
            this.label_empid.Size = new System.Drawing.Size(55, 17);
            this.label_empid.TabIndex = 16;
            this.label_empid.Text = "Emp_id";
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(255, 228);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(187, 22);
            this.txt5.TabIndex = 33;
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Location = new System.Drawing.Point(121, 234);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(48, 17);
            this.label_salary.TabIndex = 32;
            this.label_salary.Text = "Salary";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(324, 334);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(138, 66);
            this.btn2.TabIndex = 36;
            this.btn2.Text = "Read";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 492);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.label_dep);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.label_desig);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label_empid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label_dep;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label_desig;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label_empid;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.Button btn2;
    }
}

