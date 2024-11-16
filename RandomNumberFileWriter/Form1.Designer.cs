namespace RandomNumber
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            enterNumber = new TextBox();
            saveButton = new Button();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(enterNumber);
            groupBox1.Controls.Add(saveButton);
            groupBox1.Location = new Point(66, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(664, 293);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Save to File";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 125);
            label1.Name = "label1";
            label1.Size = new Size(401, 32);
            label1.TabIndex = 2;
            label1.Text = "Enter amount of Random Numbers: ";
            // 
            // enterNumber
            // 
            enterNumber.Location = new Point(413, 125);
            enterNumber.Name = "enterNumber";
            enterNumber.Size = new Size(200, 39);
            enterNumber.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(213, 204);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 46);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save to File";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 451);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox enterNumber;
        private Button saveButton;
        private SaveFileDialog saveFileDialog1;
    }
}