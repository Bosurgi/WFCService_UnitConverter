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
        /// Checks if the input is a valid number.
        /// </summary>
        /// <param name="input">the user input</param>
        /// <returns>true if the string can be converted into a number, false otherwise</returns>
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

        /// <summary>
        /// Method to parse the user input and converting the string into normalized variable.
        /// </summary>
        /// <param name="input">the user input</param>
        /// <returns>the input converted into double.</returns>
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
        /// Event triggered when Convert button is clicked.
        /// It will take the input and call the API.
        /// If API offline it will report to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            // Initialising the variables
            string selector = measureSelector.Text.Trim().ToUpper();    // Measure unit from the combo box
            string input = inputTextBox.Text.Trim();                    // The user input
            double valueToConvert;                                      // The value to convert
            double output;                                              // The result

            // If there is an invalid input or no text, it will communicate an error.
            if (!CheckInput(inputTextBox.Text) || inputTextBox.Text.Equals(""))
            {
                errorLabel.Text = "Insert a valid value to convert";
            }
            // If no unit measure selected will report the user.
            else if (measureSelector.Text.Equals(""))
            {
                errorLabel.Text = "Insert a valid measurament unit.";
            }

            else
            {
                // Converting the input
                valueToConvert = ParseInput(input);
                
                // Resetting the error label from previous errors.
                errorLabel.Text = "";
                try
                {
                    // Calling the API
                    ConverterClient converter = new ConverterClient();
                    switch (selector)
                    {
                        // Converting from Inches
                        case "IN.":
                            output = converter.ConvertInchesToCentimeters(valueToConvert);
                            outputTextBox.Text = Convert.ToString(output) + " CM";
                            break;

                        // Converting from Feet
                        case "FT.":
                            output = output = converter.ConvertFeetToMeters(valueToConvert);
                            outputTextBox.Text = Convert.ToString(output) + " M";
                            break;
                        // Converting from Miles
                        case "MI.":
                            output = output = converter.ConvertMilesToKm(valueToConvert);
                            outputTextBox.Text = Convert.ToString(output) + " KM";
                            break;
                        // Converting from Pounds
                        case "LB.":
                            output = output = converter.ConvertPoundsToKilograms(valueToConvert);
                            outputTextBox.Text = Convert.ToString(output) + " KG";
                            break;
                    }
                }
                // If the client is offline it will communicate it to the user.
                catch (EndpointNotFoundException)
                {
                    errorLabel.Text = "Client offline. Try again.";
                }
            }
        } // End method

        /// <summary>
        /// Constructor of the Converter which initialise the form
        /// </summary>
        public ClientConverter()
        {
            InitializeComponent();
        }
    }
}
