namespace RandomNumberFileReader
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
            ReadFile = new Button();
            numberCount = new Label();
            numberCountlabel = new Label();
            totalCount = new Label();
            totalCountLabel = new Label();
            NumberList = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ReadFile);
            groupBox1.Controls.Add(numberCount);
            groupBox1.Controls.Add(numberCountlabel);
            groupBox1.Controls.Add(totalCount);
            groupBox1.Controls.Add(totalCountLabel);
            groupBox1.Controls.Add(NumberList);
            groupBox1.Location = new Point(45, 47);
            groupBox1.Margin = new Padding(4, 2, 4, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 2, 4, 2);
            groupBox1.Size = new Size(711, 356);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Read From File";
            // 
            // ReadFile
            // 
            ReadFile.Location = new Point(63, 281);
            ReadFile.Margin = new Padding(6);
            ReadFile.Name = "ReadFile";
            ReadFile.Size = new Size(139, 49);
            ReadFile.TabIndex = 5;
            ReadFile.Text = "Read File";
            ReadFile.UseVisualStyleBackColor = true;
            ReadFile.Click += ReadFile_Click;
            // 
            // numberCount
            // 
            numberCount.BorderStyle = BorderStyle.FixedSingle;
            numberCount.Location = new Point(63, 198);
            numberCount.Margin = new Padding(6, 0, 6, 0);
            numberCount.Name = "numberCount";
            numberCount.Size = new Size(179, 32);
            numberCount.TabIndex = 4;
            // 
            // numberCountlabel
            // 
            numberCountlabel.AutoSize = true;
            numberCountlabel.Location = new Point(63, 157);
            numberCountlabel.Margin = new Padding(6, 0, 6, 0);
            numberCountlabel.Name = "numberCountlabel";
            numberCountlabel.Size = new Size(179, 32);
            numberCountlabel.TabIndex = 3;
            numberCountlabel.Text = "Number Count:";
            // 
            // totalCount
            // 
            totalCount.BorderStyle = BorderStyle.FixedSingle;
            totalCount.Location = new Point(63, 102);
            totalCount.Margin = new Padding(6, 0, 6, 0);
            totalCount.Name = "totalCount";
            totalCount.Size = new Size(179, 32);
            totalCount.TabIndex = 2;
            // 
            // totalCountLabel
            // 
            totalCountLabel.AutoSize = true;
            totalCountLabel.Location = new Point(63, 61);
            totalCountLabel.Margin = new Padding(6, 0, 6, 0);
            totalCountLabel.Name = "totalCountLabel";
            totalCountLabel.Size = new Size(70, 32);
            totalCountLabel.TabIndex = 1;
            totalCountLabel.Text = "Total:";
            // 
            // NumberList
            // 
            NumberList.FormattingEnabled = true;
            NumberList.ItemHeight = 32;
            NumberList.Location = new Point(373, 38);
            NumberList.Margin = new Padding(4, 2, 4, 2);
            NumberList.Name = "NumberList";
            NumberList.Size = new Size(303, 292);
            NumberList.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox NumberList;
        private Button ReadFile;
        private Label numberCount;
        private Label numberCountlabel;
        private Label totalCount;
        private Label totalCountLabel;
        private OpenFileDialog openFileDialog1;
    }
}