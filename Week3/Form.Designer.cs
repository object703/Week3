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
            label1.Location = new Point(285, 15);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 3;
            label1.Text = "OR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 142);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 4;
            label2.Text = "Select array index";
            // 
            // cb_index
            // 
            cb_index.FormattingEnabled = true;
            cb_index.Location = new Point(133, 139);
            cb_index.Name = "cb_index";
            cb_index.Size = new Size(65, 23);
            cb_index.TabIndex = 5;
            cb_index.SelectedIndexChanged += cb_index_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 171);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 6;
            label3.Text = "Selected value:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 200);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 8;
            label4.Text = "New value:";
            // 
            // txt_newValue
            // 
            txt_newValue.Location = new Point(133, 197);
            txt_newValue.Name = "txt_newValue";
            txt_newValue.Size = new Size(100, 23);
            txt_newValue.TabIndex = 9;
            // 
            // txt_selectedValue
            // 
            txt_selectedValue.Enabled = false;
            txt_selectedValue.Location = new Point(133, 168);
            txt_selectedValue.Name = "txt_selectedValue";
            txt_selectedValue.Size = new Size(100, 23);
            txt_selectedValue.TabIndex = 10;
            // 
            // btn_newValue
            // 
            btn_newValue.Location = new Point(239, 197);
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
            txt_values.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.Location = new Point(285, 44);
            label5.Name = "label5";
            label5.Size = new Size(162, 41);
            label5.TabIndex = 13;
            label5.Text = "Comma separated values, no spaces or other characters";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 450);
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
    }
}
