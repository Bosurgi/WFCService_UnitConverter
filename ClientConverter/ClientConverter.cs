// Adding the reference for the service
using ClientConverter.ServiceReference;
using System;
using System.Windows.Forms;
using System.ServiceModel;

namespace ClientConverter
{
    public partial class ClientConverter : Form
    {
        /// <summary>
        /// Properties flags for the program to understand the selection of parameters.
        /// </summary>
        bool isFeet = false;
        bool isInches = false;
        bool isMiles = false;
        bool isPounds = false;

        public bool CheckInput(string input)
        {
            try
            {
                Convert.ToDouble(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public double ParseInput(string input)
        {
            if (CheckInput(input))
            {
                return Convert.ToDouble(input);
            }
            else
            {
                errorLabel.Text = "Invalid number";
                return 0;
            };
        }


        /// <summary>
        /// Constructor of the Converter which initialise the form
        /// </summary>
        public ClientConverter()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            string selector = measureSelector.Text.Trim().ToUpper();
            string input = inputTextBox.Text.Trim();
            double valueToConvert;
            double output;

            if (!CheckInput(inputTextBox.Text) || inputTextBox.Text.Equals(""))
            {
                errorLabel.Text = "Insert a valid value to convert";
            }
            else if (measureSelector.Text.Equals(""))
            {
                errorLabel.Text = "Insert a valid measurament unit.";
            }

            else
            {
                valueToConvert = ParseInput(input);

                ConverterClient converter = new ConverterClient();
                switch (selector)
                {
                    case "IN.":
                        output = converter.ConvertInchesToCentimeters(valueToConvert);
                        outputTextBox.Text = Convert.ToString(output);
                        break;

                    case "FT.":
                        output = output = converter.ConvertFeetToMeters(valueToConvert);
                        outputTextBox.Text = Convert.ToString(output);
                        break;

                    case "MI.":
                        output = output = converter.ConvertMilesToKm(valueToConvert);
                        outputTextBox.Text = Convert.ToString(output);
                        break;

                    case "LB.":
                        output = output = converter.ConvertPoundsToKilograms(valueToConvert);
                        outputTextBox.Text = Convert.ToString(output);
                        break;
                }
            }
        } // End method
    }
}
