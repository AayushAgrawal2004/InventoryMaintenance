using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//AUTHOR: Aayush Agrawal
//COURSE: ISTM 250.501
//FORM: FRMNewItem.cs
//PURPOSE: This form adds item in the inventory if all data entry is valid.
//INPUT: Item No from txtItemNo
//Description from txtDescription
//Price from txtPrice
//PROCESS:
//FRMInventoryMaintenance form calls AddNewItem function
//of this form when user selects the option to add a new item.
//User enters, Item No, Description, and Price.
//User entry is validated
//if all values are valid, then the new item object is returned to FRMInventoryMaintenance
//OUTPUT:
//New Item object which is returned to FRMInventoryMaintenance form
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.”

namespace InventoryMaintenance
{
    public partial class FRMNewItem : Form
    {
        public FRMNewItem()
        {
            InitializeComponent();
        }

        // Add a statement here that declares a new inventory item.
        private InvItem invItem = null;

        // Add a method here that gets and returns a new item.
        /// <summary>
        /// Show new item form, once saved the data, return the new item object
        /// </summary>
        /// <returns></returns>
        public InvItem GetNewItem()
        {

            ShowDialog();
            return invItem;
        }

        /// <summary>
        /// call validate method and then return new item to FRMInventoryMaintenance form
        /// close the New Item form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNSave_Click(object sender, EventArgs e)
        {

            if (IsValidData())
            {
                try
                {
                    // Add code here that populates a new item with the appropriate information and then closes the form.
                    invItem = new InvItem(Convert.ToInt32(txtItemNo.Text), txtDescription.Text, Convert.ToDecimal(txtPrice.Text));
                    Close();

                }
                catch (FormatException) //triggered if user inputs a non-numeric value 
                {
                    MessageBox.Show("Format error. Please enter a numeric value.", "Entry Error");
                }

                //specific catch block
                catch (OverflowException) //triggered if user inputs too large values
                {
                    MessageBox.Show("Overflow error. Please enter smaller numbers.", "Entry Error");
                }

                //generic catch block
                //catches any other type of error that the programmer is not anticipating
                //displays error message, type of error, and stack trace
                catch (Exception exAllExceptions)
                {
                    MessageBox.Show(exAllExceptions.Message + "\n\n" + exAllExceptions.GetType().ToString() + "\n" + exAllExceptions.StackTrace, "Error");
                }
            }
        }

        /// <summary>
        /// Validate input data
        /// </summary>
        /// <returns></returns>
        private bool IsValidData()
        {
            string strErrorMessage = ""; //this may or may not grow larger as we test our inputs.

            //add code here that checks each of the input textboxes and validates their input.
            strErrorMessage += Validator.IsPresent(txtItemNo.Text, txtItemNo.Tag.ToString());
            strErrorMessage += Validator.IsInteger(txtItemNo.Text, txtItemNo.Tag.ToString());
            strErrorMessage += Validator.IsPresent(txtDescription.Text, txtDescription.Tag.ToString());
            strErrorMessage += Validator.IsPresent(txtPrice.Text, txtPrice.Tag.ToString());
            strErrorMessage += Validator.IsDecimal(txtPrice.Text, txtPrice.Tag.ToString());

            if (strErrorMessage != "")
            {
                MessageBox.Show(strErrorMessage, "Entry Error");
                return false; 
            }
            else
            {
                return true; 
            }
        }
    }
}
