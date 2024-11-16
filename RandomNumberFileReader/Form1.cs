//Jimmy Pham
//T00629354
//COMP 2211

namespace RandomNumberFileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;

            //sets count to 0
            int total = 0;
            int numbersCount = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) { 
            
                //select file to open
                inputFile = File.OpenText(openFileDialog1.FileName);

                while (inputFile.EndOfStream == false)
                {
                    numbersCount++;

                    //changes each line to int
                    bool numberEntered = int.TryParse(inputFile.ReadLine(), out int number);
                    if (numberEntered)
                    {
                        total += number;
                        NumberList.Items.Add(number);
                    }
                }

                //updates count to form1
                totalCount.Text = total.ToString();
                numberCount.Text = numbersCount.ToString();

                //close file
                inputFile.Close();
            }
        }
    }
}