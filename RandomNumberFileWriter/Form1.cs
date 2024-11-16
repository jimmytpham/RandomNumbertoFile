//Jimmy Pham
//T00629354
//COMP 2211

namespace RandomNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;

            //check to see if the text entered is an integer
            bool numberEntered = int.TryParse(enterNumber.Text, out int randomCount);

            //If loop if the number is an integer, else enter valid number
            if (numberEntered)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //saves the file as a txt file
                    outputFile = File.CreateText(saveFileDialog1.FileName + ".txt");

                    Random rand = new Random();

                    int count = 1;

                    while (count <= randomCount)
                    {
                        outputFile.WriteLine(rand.Next(1, 101));
                        count++;
                    }
                    outputFile.Close();
                    MessageBox.Show("Numbers saved to: " + saveFileDialog1.FileName + ".txt");
                }
                else
                {
                    MessageBox.Show("Cancelled!");
                }

            }
            else
            {
                MessageBox.Show("Enter a valid number!");
            }

        }
    }
}