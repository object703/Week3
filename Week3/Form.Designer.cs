namespace Week3
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_length = new TextBox();
            btn_arrayLength = new Button();
            btn_arrayValues = new Button();
            label1 = new Label();
            label2 = new Label();
            cb_index = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txt_newValue = new TextBox();
            txt_selectedValue = new TextBox();
            btn_newValue = new Button();
            txt_values = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btn_max = new Button();
            btn_equal = new Button();
            btn_gcd = new Button();
            btn_count = new Button();
            btn_average = new Button();
            btn_toString = new Button();
            btn_sum = new Button();
            lbl_output = new Label();
            cb_1stIndex = new ComboBox();
            cb_2ndIndex = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            btn_add = new Button();
            btn_multiply = new Button();
            SuspendLayout();
            // 
            // txt_length
            // 
            txt_length.Location = new Point(12, 12);
            txt_length.Name = "txt_length";
            txt_length.Size = new Size(100, 23);
            txt_length.TabIndex = 0;
            // 
            // btn_arrayLength
            // 
            btn_arrayLength.Location = new Point(118, 11);
            btn_arrayLength.Name = "btn_arrayLength";
            btn_arrayLength.Size = new Size(161, 23);
            btn_arrayLength.TabIndex = 1;
            btn_arrayLength.Text = "Create array of length";
            btn_arrayLength.UseVisualStyleBackColor = true;
            btn_arrayLength.Click += btn_arrayLength_Click;
            // 
            // btn_arrayValues
            // 
            btn_arrayValues.Location = new Point(118, 40);
            btn_arrayValues.Name = "btn_arrayValues";
            btn_arrayValues.Size = new Size(161, 23);
            btn_arrayValues.TabIndex = 2;
            btn_arrayValues.Text = "Create array with values";
            btn_arrayValues.UseVisualStyleBackColor = true;
            btn_arrayValues.Click += btn_arrayValues_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label1.Location = new Point(285, 15);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 3;
            label1.Text = "OR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 101);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 4;
            label2.Text = "Select array index";
            // 
            // cb_index
            // 
            cb_index.FormattingEnabled = true;
            cb_index.Location = new Point(118, 98);
            cb_index.Name = "cb_index";
            cb_index.Size = new Size(65, 23);
            cb_index.TabIndex = 5;
            cb_index.SelectedIndexChanged += cb_index_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 130);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 6;
            label3.Text = "Selected value:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 159);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 8;
            label4.Text = "New value:";
            // 
            // txt_newValue
            // 
            txt_newValue.Location = new Point(118, 156);
            txt_newValue.Name = "txt_newValue";
            txt_newValue.Size = new Size(100, 23);
            txt_newValue.TabIndex = 9;
            // 
            // txt_selectedValue
            // 
            txt_selectedValue.Enabled = false;
            txt_selectedValue.Location = new Point(118, 127);
            txt_selectedValue.Name = "txt_selectedValue";
            txt_selectedValue.Size = new Size(100, 23);
            txt_selectedValue.TabIndex = 10;
            // 
            // btn_newValue
            // 
            btn_newValue.Location = new Point(224, 156);
            btn_newValue.Name = "btn_newValue";
            btn_newValue.Size = new Size(75, 23);
            btn_newValue.TabIndex = 11;
            btn_newValue.Text = "Edit value";
            btn_newValue.UseVisualStyleBackColor = true;
            btn_newValue.Click += btn_newValue_Click;
            // 
            // txt_values
            // 
            txt_values.Location = new Point(12, 41);
            txt_values.Name = "txt_values";
            txt_values.Size = new Size(100, 23);
            txt_values.TabIndex = 12;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label5.Location = new Point(285, 44);
            label5.Name = "label5";
            label5.Size = new Size(162, 41);
            label5.TabIndex = 13;
            label5.Text = "Comma separated values, no spaces or other characters";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 72);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 14;
            label6.Text = "Viewing/editing";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(58, 188);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 15;
            label7.Text = "Methods";
            // 
            // btn_max
            // 
            btn_max.Location = new Point(37, 243);
            btn_max.Name = "btn_max";
            btn_max.Size = new Size(75, 23);
            btn_max.TabIndex = 17;
            btn_max.Text = "Max value";
            btn_max.UseVisualStyleBackColor = true;
            btn_max.Click += btn_max_Click;
            // 
            // btn_equal
            // 
            btn_equal.Location = new Point(118, 214);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(75, 23);
            btn_equal.TabIndex = 18;
            btn_equal.Text = "Is equal";
            btn_equal.UseVisualStyleBackColor = true;
            btn_equal.Click += btn_equal_Click;
            // 
            // btn_gcd
            // 
            btn_gcd.Location = new Point(37, 214);
            btn_gcd.Name = "btn_gcd";
            btn_gcd.Size = new Size(75, 23);
            btn_gcd.TabIndex = 19;
            btn_gcd.Text = "GCD";
            btn_gcd.UseVisualStyleBackColor = true;
            btn_gcd.Click += btn_gcd_Click;
            // 
            // btn_count
            // 
            btn_count.Location = new Point(118, 243);
            btn_count.Name = "btn_count";
            btn_count.Size = new Size(75, 23);
            btn_count.TabIndex = 20;
            btn_count.Text = "Count";
            btn_count.UseVisualStyleBackColor = true;
            btn_count.Click += btn_count_Click;
            // 
            // btn_average
            // 
            btn_average.Location = new Point(118, 272);
            btn_average.Name = "btn_average";
            btn_average.Size = new Size(75, 23);
            btn_average.TabIndex = 23;
            btn_average.Text = "Average";
            btn_average.UseVisualStyleBackColor = true;
            btn_average.Click += btn_average_Click;
            // 
            // btn_toString
            // 
            btn_toString.Location = new Point(37, 301);
            btn_toString.Name = "btn_toString";
            btn_toString.Size = new Size(75, 23);
            btn_toString.TabIndex = 22;
            btn_toString.Text = "To string";
            btn_toString.UseVisualStyleBackColor = true;
            btn_toString.Click += btn_toString_Click;
            // 
            // btn_sum
            // 
            btn_sum.Location = new Point(37, 272);
            btn_sum.Name = "btn_sum";
            btn_sum.Size = new Size(75, 23);
            btn_sum.TabIndex = 21;
            btn_sum.Text = "Sum";
            btn_sum.UseVisualStyleBackColor = true;
            btn_sum.Click += btn_sum_Click;
            // 
            // lbl_output
            // 
            lbl_output.BackColor = SystemColors.Info;
            lbl_output.Location = new Point(199, 223);
            lbl_output.Name = "lbl_output";
            lbl_output.Size = new Size(248, 105);
            lbl_output.TabIndex = 24;
            lbl_output.Text = "---";
            // 
            // cb_1stIndex
            // 
            cb_1stIndex.FormattingEnabled = true;
            cb_1stIndex.Location = new Point(118, 185);
            cb_1stIndex.Name = "cb_1stIndex";
            cb_1stIndex.Size = new Size(36, 23);
            cb_1stIndex.TabIndex = 25;
            // 
            // cb_2ndIndex
            // 
            cb_2ndIndex.FormattingEnabled = true;
            cb_2ndIndex.Location = new Point(160, 185);
            cb_2ndIndex.Name = "cb_2ndIndex";
            cb_2ndIndex.Size = new Size(36, 23);
            cb_2ndIndex.TabIndex = 26;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(202, 188);
            label9.Name = "label9";
            label9.Size = new Size(206, 35);
            label9.TabIndex = 27;
            label9.Text = "Select 2 values from the array for the GCD and IsEqual methods";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(54, 333);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 28;
            label8.Text = "Mutators";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(37, 351);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 29;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.Location = new Point(118, 351);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(75, 23);
            btn_multiply.TabIndex = 30;
            btn_multiply.Text = "Multiply";
            btn_multiply.UseVisualStyleBackColor = true;
            btn_multiply.Click += btn_multiply_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 394);
            Controls.Add(btn_multiply);
            Controls.Add(btn_add);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(cb_2ndIndex);
            Controls.Add(cb_1stIndex);
            Controls.Add(lbl_output);
            Controls.Add(btn_average);
            Controls.Add(btn_toString);
            Controls.Add(btn_sum);
            Controls.Add(btn_count);
            Controls.Add(btn_gcd);
            Controls.Add(btn_equal);
            Controls.Add(btn_max);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_values);
            Controls.Add(btn_newValue);
            Controls.Add(txt_selectedValue);
            Controls.Add(txt_newValue);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cb_index);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_arrayValues);
            Controls.Add(btn_arrayLength);
            Controls.Add(txt_length);
            Name = "Form";
            Text = "Week 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_length;
        private Button btn_arrayLength;
        private Button btn_arrayValues;
        private Label label1;
        private Label label2;
        private ComboBox cb_index;
        private Label label3;
        private Label label4;
        private TextBox txt_newValue;
        private TextBox txt_selectedValue;
        private Button btn_newValue;
        private TextBox txt_values;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btn_max;
        private Button btn_equal;
        private Button btn_gcd;
        private Button btn_count;
        private Button btn_average;
        private Button btn_toString;
        private Button btn_sum;
        private Label lbl_output;
        private ComboBox cb_1stIndex;
        private ComboBox cb_2ndIndex;
        private Label label9;
        private Label label8;
        private Button btn_add;
        private Button btn_multiply;
    }
}
