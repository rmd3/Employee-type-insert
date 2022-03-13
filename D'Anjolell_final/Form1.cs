using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Anjolell_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Richard D'Anjolell
            //Declare Variable
            fileOutput fileProduct = new fileOutput();

            //If else statements to see which kind of employee the user is entering
            if (radbtnBase.Checked)
            {
                baseEmployee baseWorker = new baseEmployee();
                try
                {
                    //Fill in data from user textboxes
                    baseWorker.baseName = txtName.Text;
                    baseWorker.baseEmail = txtEmail.Text;
                    baseWorker.baseAddress = txtAddress.Text;

                    //Output data to messagebox
                    MessageBox.Show("Name: " + baseWorker.baseName + "\n" + "Email: " + baseWorker.baseEmail + "\n" + 
                        "Address: " + baseWorker.baseAddress);

                    //Set array to items in baseWorker
                    fileProduct.arrayOutput = new string[] {baseWorker.baseName, baseWorker.baseEmail, baseWorker.baseAddress };

                    //Create employeeInformation.txt file
                    fileProduct.outputFile = File.CreateText("employeeInformation.txt");

                    //Output data to employeeInformation.txt file
                    for (int index = 0; index < fileProduct.arrayOutput.Length; index++)
                    {
                        fileProduct.outputFile.WriteLine(fileProduct.arrayOutput[index]);
                    }
                    fileProduct.outputFile.Close();
                }
                catch (Exception error)
                {
                    //Error messagebox
                    MessageBox.Show(error.Message);
                }
            }
            else if (radbtnSuper.Checked)
            {
                superEmployee superWorker = new superEmployee();
                try
                {
                    //Fill in data from user textboxes
                    superWorker.baseName = txtName.Text;
                    superWorker.baseEmail = txtEmail.Text;
                    superWorker.baseAddress = txtAddress.Text;
                    superWorker.superRate = double.Parse(txtRate.Text);
                    superWorker.superHours = int.Parse(txtHours.Text);

                    //If else statements to set ranges for hourly rate and hours worked
                    if (double.Parse(txtRate.Text) < 10 || double.Parse(txtRate.Text) > 42.5)
                    {
                        //Error messagebox
                        MessageBox.Show("Hourly Rate must be between 10 and 42.50!");

                        //Exit program
                        Application.Exit();
                    }
                    else if (int.Parse(txtHours.Text) < 0 || int.Parse(txtHours.Text) > 80)
                    {
                        //Error messagebox
                        MessageBox.Show("Hours Worked must be between 0 and 80!");

                        //Exit program
                        Application.Exit();
                    }

                    //Output data to messagebox
                    MessageBox.Show("Name: " + superWorker.baseName + "\n" + "Email: " + superWorker.baseEmail + "\n" +
                        "Address: " + superWorker.baseAddress + "\n" + "Hourly Rate: $" + superWorker.superRate + "\n" +
                        "Hours Worked: " + superWorker.superHours);

                    //Set array to items in superWorker
                    fileProduct.arrayOutput = new string[] {superWorker.baseName, superWorker.baseEmail, 
                        superWorker.baseAddress, superWorker.superRate.ToString(), superWorker.superHours.ToString()};

                    //Create employeeInformation.txt file
                    fileProduct.outputFile = File.CreateText("employeeInformation.txt");

                    //Output data to employeeInformation.txt file
                    for (int index = 0; index < fileProduct.arrayOutput.Length; index++)
                    {
                        fileProduct.outputFile.WriteLine(fileProduct.arrayOutput[index]);
                    }
                    fileProduct.outputFile.Close();
                }
                catch (Exception error)
                {
                    //Error messagebox
                    MessageBox.Show(error.Message);
                }
            }
            else if (radbtnAdvanced.Checked)
            {
                advancedEmployee advancedWorker = new advancedEmployee();
                try
                {
                    //Fill in data from user textboxes
                    advancedWorker.baseName = txtName.Text;
                    advancedWorker.baseEmail = txtEmail.Text;
                    advancedWorker.baseAddress = txtAddress.Text;
                    advancedWorker.superRate = double.Parse(txtRate.Text);
                    advancedWorker.superHours = int.Parse(txtHours.Text);
                    advancedWorker.advancedLevel = comboLevel.Text;
                    advancedWorker.advancedOffice = int.Parse(txtOffice.Text);

                    //If else statements to set ranges for hourly rate and hours worked
                    if (double.Parse(txtRate.Text) < 10 || double.Parse(txtRate.Text) > 42.5)
                    {
                        //Error messagebox
                        MessageBox.Show("Hourly Rate must be between 10 and 42.50!");

                        //Exit program
                        Application.Exit();
                    }
                    else if (int.Parse(txtHours.Text) < 0 || int.Parse(txtHours.Text) > 80)
                    {
                        //Error messagebox
                        MessageBox.Show("Hours Worked must be between 0 and 80!");

                        //Exit program
                        Application.Exit();
                    }

                    //Output data to messagebox
                    MessageBox.Show("Name: " + advancedWorker.baseName + "\n" + "Email: " + advancedWorker.baseEmail + "\n" +
                        "Address: " + advancedWorker.baseAddress + "\n" + "Hourly Rate: $" + advancedWorker.superRate + "\n" +
                        "Hours Worked: " + advancedWorker.superHours + "\n" + "Permisson Level: " + 
                        advancedWorker.advancedLevel + "\n" + "Office Number: " + advancedWorker.advancedOffice);

                    //Set array to items in advancedWorker
                    fileProduct.arrayOutput = new string[] {advancedWorker.baseName, advancedWorker.baseEmail,
                        advancedWorker.baseAddress, advancedWorker.superRate.ToString(), 
                        advancedWorker.superHours.ToString(), advancedWorker.advancedLevel, advancedWorker.advancedOffice.ToString()};

                    //Create employeeInformation.txt file
                    fileProduct.outputFile = File.CreateText("employeeInformation.txt");

                    //Output data to employeeInformation.txt file
                    for (int index = 0; index < fileProduct.arrayOutput.Length; index++)
                    {
                        fileProduct.outputFile.WriteLine(fileProduct.arrayOutput[index]);
                    }
                    fileProduct.outputFile.Close();
                }
                catch (Exception error)
                {
                    //Error messagebox
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void radbtnBase_CheckedChanged(object sender, EventArgs e)
        {
            //If else statement to determine what information needs to be visible to be entered
            if (radbtnBase.Checked)
            {
                groupBase.Visible = true;
                groupSuper.Visible = false;
                groupAdvanced.Visible = false;
            }
            else if (radbtnSuper.Checked)
            {
                groupBase.Visible = true;
                groupSuper.Visible = true;
                groupAdvanced.Visible = false;
            }
            else if (radbtnAdvanced.Checked)
            {
                groupBase.Visible = true;
                groupSuper.Visible = true;
                groupAdvanced.Visible = true;
            }
        }

        private void radbtnSuper_CheckedChanged(object sender, EventArgs e)
        {
            //If else statement to determine what information needs to be visible to be entered
            if (radbtnBase.Checked)
            {
                groupBase.Visible = true;
                groupSuper.Visible = false;
                groupAdvanced.Visible = false;
            }
            else if (radbtnSuper.Checked)
            {
                groupBase.Visible = true;
                groupSuper.Visible = true;
                groupAdvanced.Visible = false;
            }
            else if (radbtnAdvanced.Checked)
            {
                groupBase.Visible = true;
                groupSuper.Visible = true;
                groupAdvanced.Visible = true;
            }
        }

        private void radbtnAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            //If else statement to determine what information needs to be visible to be entered
            if (radbtnBase.Checked)
            {
                groupBase.Visible = true;
                groupSuper.Visible = false;
                groupAdvanced.Visible = false;
            }
            else if (radbtnSuper.Checked)
            {
                groupBase.Visible = true;
                groupSuper.Visible = true;
                groupAdvanced.Visible = false;
            }
            else if (radbtnAdvanced.Checked)
            {
                groupBase.Visible = true;
                groupSuper.Visible = true;
                groupAdvanced.Visible = true;
            }
        }
    }
}
