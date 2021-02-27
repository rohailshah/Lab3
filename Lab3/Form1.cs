// Author: Rohail Shah
// Last Modified: February 26, 2021
// Description: 
// This program will take an input for each day in the week numbered from 1 to 7, and 
// record the information for 3 employees. The user input data will need to be validated 
// and, if it passes validation, the data will need to be displayed to the user. Once 
// the number of units has been entered for the 7 full days for all 3 employees, the 
// solution will calculate and display the average per employee, as well as the overall 
// company average.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        // Some constant defintions.
        const int NumberOfEmployees = 3;
        const int NumberOfDays = 7;

        // Class-level variable declarations.
        int currentEmployee = 0;
        int currentDay = 0;

        // Class-level variable that will contain the a total of the three employee average units shipped.
        int overallTotal = 0;

        // A 2D array that will contain number of employee from 1 to 3 and also number of days from 1 to 7.
        int[,] entryArray = new int[NumberOfEmployees, NumberOfDays];

        // Make arrays for output controls.
        TextBox[] employeeTextBoxes;
        Label[] employeeAverages;

        public Form1()
        {
            InitializeComponent();

            // Resets the form for new data entry, including resetting class variables and re-enabling controls 
            // and overall ensuring a consistent experience for the user.
            ResetForm();

            // Populate the arrays of controls.
            employeeTextBoxes = new TextBox[] { textBoxEmployee1Entries, textBoxEmployee2Entries, textBoxEmployee3Entries };
            employeeAverages = new Label[] { labelAverageEmployee1, labelAverageEmployee2, labelAverageEmployee3 };
        }

        /// <summary>
        /// Takes an input for each day in the week numbered from 1 to 7, and 
        /// records the information for 3 employees, validates, and displays data to the user. Once 
        /// the number of units has been entered for the 7 full days for all 3 employees, the button
        /// will calculate and display the average per employee, as well as the overall 
        /// company average.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            // Bring focus back to entry textbox for quick inputs.
            textBoxEntryNumber.SelectAll();
            textBoxEntryNumber.Focus();

            // Declare constants and variables.
            const int MinimumUnits = 0;
            const int MaximumUnits = 5000;

            // Validate that the number entered is a whole number.
            if (int.TryParse(textBoxEntryNumber.Text, out entryArray[currentEmployee, currentDay]))
            {
                // Validate that the number entered is between 0 and 5000.
                if (entryArray[currentEmployee, currentDay] >= MinimumUnits && entryArray[currentEmployee, currentDay] <= MaximumUnits)
                {
                    // Enter the current (valid) entry in the current employee's textbox.
                    employeeTextBoxes[currentEmployee].Text += entryArray[currentEmployee, currentDay] + "\r\n";
                    
                    // Check if we have entered day 7.
                    if (currentDay++ >= NumberOfDays - 1)
                    {
                        // Variable to store and increment units shipped being inputted.
                        int employeeTotal = 0;

                        // Calculate the employee's total units.
                        for (int day = 0; day < NumberOfDays; day++)
                        {
                            employeeTotal += entryArray[currentEmployee, day];
                        }

                        // Calculate and display the employee's average in their output label.
                        employeeAverages[currentEmployee].Text = "Average: " + Math.Round((double)employeeTotal / NumberOfDays, 2);
                        overallTotal += (employeeTotal / NumberOfDays);

                        // We have entered day 7! Reset the day and go to the next employee.
                        currentDay = 0;
                        currentEmployee++;

                        // Bold the heading of the remaining two columns.
                        labelEmployee1Prompt.Font = new Font(this.Font, FontStyle.Regular);
                        labelEmployee2Prompt.Font = new Font(this.Font, FontStyle.Bold);
                        labelEmployee3Prompt.Font = new Font(this.Font, FontStyle.Bold);
                    }

                    // Check if we have entered all employees.
                    if (currentEmployee >= NumberOfEmployees)
                    {
                        // Calculate and display the overall average.
                        labelAverageOutput.Text = "Overall Average: " + Math.Round((double)overallTotal / NumberOfEmployees, 2);

                        // Reset the current day, current employee and overall average back to 0.
                        currentDay = 0;
                        currentEmployee = 0;
                        overallTotal = 0;

                        // We have entered all workers! Disable the input controls and set focus appropriately.
                        textBoxEntryNumber.Enabled = false;
                        buttonEnter.Enabled = false;
                        buttonReset.Focus();
                    }

                    // Adjust the day and set the day counter.
                    labelDay.Text = "Day " + (currentDay + 1);
                }
                else
                {
                    // The value entered is less than 0 or greater than 5000.
                    MessageBox.Show("Enter a value between " + MinimumUnits + " and " + MaximumUnits + ".", "Invalid Entry!");
                    textBoxEntryNumber.SelectAll();
                    textBoxEntryNumber.Focus();
                }
            }
            else
            {
                // The value entered is not an integer
                MessageBox.Show("Entry must be a numeric whole number.", "Invalid Entry!");
                textBoxEntryNumber.SelectAll();
                textBoxEntryNumber.Focus();
            }
        }

        /// <summary>
        /// Resets the form for new data entry, including resetting class variables and re-enabling controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetForm()
        {
            // Clear the input and output fields.
            textBoxEntryNumber.Clear();
            textBoxEmployee1Entries.Clear();
            textBoxEmployee2Entries.Clear();
            textBoxEmployee3Entries.Clear();
            labelAverageEmployee1.Text = String.Empty;
            labelAverageEmployee2.Text = String.Empty;
            labelAverageEmployee3.Text = String.Empty;
            labelAverageOutput.Text = String.Empty;

            // Reset the global variables.
            currentDay = 0;
            labelDay.Text = "Day 1";
            
            // Reset the fonts to their default states.
            labelDay.Font = new Font(this.Font, FontStyle.Bold);
            labelEmployee1Prompt.Font = new Font(this.Font, FontStyle.Bold);
            labelEmployee2Prompt.Font = new Font(this.Font, FontStyle.Regular);
            labelEmployee3Prompt.Font = new Font(this.Font, FontStyle.Regular);

            // Re-enable any controls that may be disabled.
            textBoxEntryNumber.Enabled = true;
            buttonEnter.Enabled = true;

            // Set focus for easy data entry.
            textBoxEntryNumber.Focus();
        }

    }
}
