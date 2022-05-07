
namespace Laboratorium_6
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
            this.btn_Ascending = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.btn_Descending = new System.Windows.Forms.Button();
            this.btn_capitalTransform = new System.Windows.Forms.Button();
            this.btn_lowercaseTransform = new System.Windows.Forms.Button();
            this.btn_jumpingTransform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_IfCapital = new System.Windows.Forms.Button();
            this.btn_IfLowercase = new System.Windows.Forms.Button();
            this.btn_IfNumber = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkbx_IsCapitalLetters = new System.Windows.Forms.CheckBox();
            this.checkbx_IsOdd = new System.Windows.Forms.CheckBox();
            this.checkbx_IsLength = new System.Windows.Forms.CheckBox();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_AvgLength = new System.Windows.Forms.Button();
            this.btn_MaxLength = new System.Windows.Forms.Button();
            this.btn_MinLength = new System.Windows.Forms.Button();
            this.checkbx_ChangeMode = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_PersonInputTooltip = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Ascending
            // 
            this.btn_Ascending.Location = new System.Drawing.Point(8, 29);
            this.btn_Ascending.Name = "btn_Ascending";
            this.btn_Ascending.Size = new System.Drawing.Size(116, 41);
            this.btn_Ascending.TabIndex = 0;
            this.btn_Ascending.Text = "Ascending";
            this.btn_Ascending.UseVisualStyleBackColor = true;
            this.btn_Ascending.Click += new System.EventHandler(this.btn_Ascending_Click);
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(292, 200);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(252, 21);
            this.txt_input.TabIndex = 1;
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(292, 242);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(253, 21);
            this.txt_output.TabIndex = 2;
            // 
            // btn_Descending
            // 
            this.btn_Descending.Location = new System.Drawing.Point(130, 29);
            this.btn_Descending.Name = "btn_Descending";
            this.btn_Descending.Size = new System.Drawing.Size(118, 41);
            this.btn_Descending.TabIndex = 6;
            this.btn_Descending.Text = "Descending";
            this.btn_Descending.UseVisualStyleBackColor = true;
            this.btn_Descending.Click += new System.EventHandler(this.btn_Descending_Click);
            // 
            // btn_capitalTransform
            // 
            this.btn_capitalTransform.Location = new System.Drawing.Point(8, 83);
            this.btn_capitalTransform.Name = "btn_capitalTransform";
            this.btn_capitalTransform.Size = new System.Drawing.Size(76, 39);
            this.btn_capitalTransform.TabIndex = 7;
            this.btn_capitalTransform.Text = "Capital letters";
            this.btn_capitalTransform.UseVisualStyleBackColor = true;
            this.btn_capitalTransform.Click += new System.EventHandler(this.btn_CapitalTransform_Click);
            // 
            // btn_lowercaseTransform
            // 
            this.btn_lowercaseTransform.Location = new System.Drawing.Point(90, 83);
            this.btn_lowercaseTransform.Name = "btn_lowercaseTransform";
            this.btn_lowercaseTransform.Size = new System.Drawing.Size(76, 39);
            this.btn_lowercaseTransform.TabIndex = 8;
            this.btn_lowercaseTransform.Text = "Lowercase letters";
            this.btn_lowercaseTransform.UseVisualStyleBackColor = true;
            this.btn_lowercaseTransform.Click += new System.EventHandler(this.btn_LowercaseTransform_Click);
            // 
            // btn_jumpingTransform
            // 
            this.btn_jumpingTransform.Location = new System.Drawing.Point(172, 83);
            this.btn_jumpingTransform.Name = "btn_jumpingTransform";
            this.btn_jumpingTransform.Size = new System.Drawing.Size(76, 39);
            this.btn_jumpingTransform.TabIndex = 9;
            this.btn_jumpingTransform.Text = "\"Jumping\" letters";
            this.btn_jumpingTransform.UseVisualStyleBackColor = true;
            this.btn_jumpingTransform.Click += new System.EventHandler(this.btn_JumpingTransform_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Output";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(292, 273);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(253, 44);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_IfCapital
            // 
            this.btn_IfCapital.Location = new System.Drawing.Point(6, 20);
            this.btn_IfCapital.Name = "btn_IfCapital";
            this.btn_IfCapital.Size = new System.Drawing.Size(109, 41);
            this.btn_IfCapital.TabIndex = 14;
            this.btn_IfCapital.Text = "Word with all capital letters";
            this.btn_IfCapital.UseVisualStyleBackColor = true;
            this.btn_IfCapital.Click += new System.EventHandler(this.btn_IfCapital_Click);
            // 
            // btn_IfLowercase
            // 
            this.btn_IfLowercase.Location = new System.Drawing.Point(6, 72);
            this.btn_IfLowercase.Name = "btn_IfLowercase";
            this.btn_IfLowercase.Size = new System.Drawing.Size(109, 41);
            this.btn_IfLowercase.TabIndex = 15;
            this.btn_IfLowercase.Text = "Word with all small letters";
            this.btn_IfLowercase.UseVisualStyleBackColor = true;
            this.btn_IfLowercase.Click += new System.EventHandler(this.btn_IfLowercase_Click);
            // 
            // btn_IfNumber
            // 
            this.btn_IfNumber.Location = new System.Drawing.Point(6, 121);
            this.btn_IfNumber.Name = "btn_IfNumber";
            this.btn_IfNumber.Size = new System.Drawing.Size(109, 41);
            this.btn_IfNumber.TabIndex = 16;
            this.btn_IfNumber.Text = "Number";
            this.btn_IfNumber.UseVisualStyleBackColor = true;
            this.btn_IfNumber.Click += new System.EventHandler(this.btn_IfNumber_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Ascending);
            this.groupBox1.Controls.Add(this.btn_Descending);
            this.groupBox1.Controls.Add(this.btn_jumpingTransform);
            this.groupBox1.Controls.Add(this.btn_capitalTransform);
            this.groupBox1.Controls.Add(this.btn_lowercaseTransform);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 129);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort and Transform";
            // 
            // checkbx_IsCapitalLetters
            // 
            this.checkbx_IsCapitalLetters.AutoSize = true;
            this.checkbx_IsCapitalLetters.Location = new System.Drawing.Point(6, 70);
            this.checkbx_IsCapitalLetters.Name = "checkbx_IsCapitalLetters";
            this.checkbx_IsCapitalLetters.Size = new System.Drawing.Size(133, 19);
            this.checkbx_IsCapitalLetters.TabIndex = 5;
            this.checkbx_IsCapitalLetters.Text = "Is first letter capital?";
            this.checkbx_IsCapitalLetters.UseVisualStyleBackColor = true;
            // 
            // checkbx_IsOdd
            // 
            this.checkbx_IsOdd.AutoSize = true;
            this.checkbx_IsOdd.Location = new System.Drawing.Point(6, 45);
            this.checkbx_IsOdd.Name = "checkbx_IsOdd";
            this.checkbx_IsOdd.Size = new System.Drawing.Size(96, 19);
            this.checkbx_IsOdd.TabIndex = 4;
            this.checkbx_IsOdd.Text = "Is word odd?";
            this.checkbx_IsOdd.UseVisualStyleBackColor = true;
            // 
            // checkbx_IsLength
            // 
            this.checkbx_IsLength.AutoSize = true;
            this.checkbx_IsLength.Location = new System.Drawing.Point(6, 20);
            this.checkbx_IsLength.Name = "checkbx_IsLength";
            this.checkbx_IsLength.Size = new System.Drawing.Size(158, 19);
            this.checkbx_IsLength.TabIndex = 3;
            this.checkbx_IsLength.Text = "Is length greater then 2?";
            this.checkbx_IsLength.UseVisualStyleBackColor = true;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(6, 95);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(240, 27);
            this.btn_Filter.TabIndex = 12;
            this.btn_Filter.Text = "Filter";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Filter);
            this.groupBox2.Controls.Add(this.checkbx_IsCapitalLetters);
            this.groupBox2.Controls.Add(this.checkbx_IsLength);
            this.groupBox2.Controls.Add(this.checkbx_IsOdd);
            this.groupBox2.Location = new System.Drawing.Point(293, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 129);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_IfCapital);
            this.groupBox3.Controls.Add(this.btn_IfNumber);
            this.groupBox3.Controls.Add(this.btn_IfLowercase);
            this.groupBox3.Location = new System.Drawing.Point(12, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 170);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "If contains";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_AvgLength);
            this.groupBox4.Controls.Add(this.btn_MaxLength);
            this.groupBox4.Controls.Add(this.btn_MinLength);
            this.groupBox4.Location = new System.Drawing.Point(140, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(131, 120);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aggregating";
            // 
            // btn_AvgLength
            // 
            this.btn_AvgLength.Location = new System.Drawing.Point(9, 20);
            this.btn_AvgLength.Name = "btn_AvgLength";
            this.btn_AvgLength.Size = new System.Drawing.Size(111, 27);
            this.btn_AvgLength.TabIndex = 14;
            this.btn_AvgLength.Text = "Average length";
            this.btn_AvgLength.UseVisualStyleBackColor = true;
            this.btn_AvgLength.Click += new System.EventHandler(this.btn_AvgLength_Click);
            // 
            // btn_MaxLength
            // 
            this.btn_MaxLength.Location = new System.Drawing.Point(9, 86);
            this.btn_MaxLength.Name = "btn_MaxLength";
            this.btn_MaxLength.Size = new System.Drawing.Size(111, 27);
            this.btn_MaxLength.TabIndex = 16;
            this.btn_MaxLength.Text = "Maximum length";
            this.btn_MaxLength.UseVisualStyleBackColor = true;
            this.btn_MaxLength.Click += new System.EventHandler(this.btn_MaxLength_Click);
            // 
            // btn_MinLength
            // 
            this.btn_MinLength.Location = new System.Drawing.Point(9, 53);
            this.btn_MinLength.Name = "btn_MinLength";
            this.btn_MinLength.Size = new System.Drawing.Size(111, 27);
            this.btn_MinLength.TabIndex = 15;
            this.btn_MinLength.Text = "Minimum length";
            this.btn_MinLength.UseVisualStyleBackColor = true;
            this.btn_MinLength.Click += new System.EventHandler(this.btn_MinLength_Click);
            // 
            // checkbx_ChangeMode
            // 
            this.checkbx_ChangeMode.AutoSize = true;
            this.checkbx_ChangeMode.Location = new System.Drawing.Point(9, 22);
            this.checkbx_ChangeMode.Name = "checkbx_ChangeMode";
            this.checkbx_ChangeMode.Size = new System.Drawing.Size(114, 19);
            this.checkbx_ChangeMode.TabIndex = 23;
            this.checkbx_ChangeMode.Text = "Select to person";
            this.checkbx_ChangeMode.UseVisualStyleBackColor = true;
            this.checkbx_ChangeMode.CheckedChanged += new System.EventHandler(this.checkbx_ChangeMode_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkbx_ChangeMode);
            this.groupBox5.Location = new System.Drawing.Point(140, 268);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(131, 49);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Change mode";
            // 
            // lbl_PersonInputTooltip
            // 
            this.lbl_PersonInputTooltip.AutoSize = true;
            this.lbl_PersonInputTooltip.Location = new System.Drawing.Point(290, 147);
            this.lbl_PersonInputTooltip.Name = "lbl_PersonInputTooltip";
            this.lbl_PersonInputTooltip.Size = new System.Drawing.Size(16, 15);
            this.lbl_PersonInputTooltip.TabIndex = 25;
            this.lbl_PersonInputTooltip.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 326);
            this.Controls.Add(this.lbl_PersonInputTooltip);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.txt_input);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LINQ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ascending;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button btn_Descending;
        private System.Windows.Forms.Button btn_capitalTransform;
        private System.Windows.Forms.Button btn_lowercaseTransform;
        private System.Windows.Forms.Button btn_jumpingTransform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_IfCapital;
        private System.Windows.Forms.Button btn_IfLowercase;
        private System.Windows.Forms.Button btn_IfNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkbx_IsCapitalLetters;
        private System.Windows.Forms.CheckBox checkbx_IsOdd;
        private System.Windows.Forms.CheckBox checkbx_IsLength;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_AvgLength;
        private System.Windows.Forms.Button btn_MaxLength;
        private System.Windows.Forms.Button btn_MinLength;
        private System.Windows.Forms.CheckBox checkbx_ChangeMode;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl_PersonInputTooltip;
    }
}

