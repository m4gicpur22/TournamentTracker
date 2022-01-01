using System;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrize : Form
    {
        public CreatePrize()
        {
            InitializeComponent();
        }

        private void FirstNameValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePrize_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                TrackerLIbrary.PrizeModel model = new TrackerLIbrary.PrizeModel(
                    PlaceNameValue.Text, 
                    PlaceNumberValue.Text, 
                    PrizeAmountValue.Text, 
                    PrizePercentageValue.Text);

                foreach(IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }

                PlaceNameValue.Text = "";
                PlaceNumberValue.Text = "";
                PrizeAmountValue.Text = "0";
                PrizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please try again.");
            }

        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;

            if(!int.TryParse(PlaceNumberValue.Text, out placeNumber))
            {
                output = false;
            }

            if(placeNumber < 1 || PlaceNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            if(!decimal.TryParse(PrizeAmountValue.Text, out prizeAmount) || !double.TryParse(PrizePercentageValue.Text, out prizePercentage))
            {
                output = false;
            }

            if(prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if(prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }


            return output;
        }
    }
}
