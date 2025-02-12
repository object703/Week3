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
            textBox1 = new TextBox();
            btn_arrayLength = new Button();
            btn_arrayValues = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // btn_arrayLength
            // 
            btn_arrayLength.Location = new Point(118, 11);
            btn_arrayLength.Name = "btn_arrayLength";
            btn_arrayLength.Size = new Size(161, 23);
            btn_arrayLength.TabIndex = 1;
            btn_arrayLength.Text = "Create array of length";
            btn_arrayLength.UseVisualStyleBackColor = true;
            // 
            // btn_arrayValues
            // 
            btn_arrayValues.Location = new Point(314, 11);
            btn_arrayValues.Name = "btn_arrayValues";
            btn_arrayValues.Size = new Size(161, 23);
            btn_arrayValues.TabIndex = 2;
            btn_arrayValues.Text = "Create array with values";
            btn_arrayValues.UseVisualStyleBackColor = true;
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
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 450);
            Controls.Add(label1);
            Controls.Add(btn_arrayValues);
            Controls.Add(btn_arrayLength);
            Controls.Add(textBox1);
            Name = "Form";
            Text = "Week 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btn_arrayLength;
        private Button btn_arrayValues;
        private Label label1;
    }
}
