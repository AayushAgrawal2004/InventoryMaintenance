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
//FORM: FRMInventoryMaintenance.cs
//PURPOSE: The program shows all the inventory items from xml file.
//It allows to add a new item or delete an existing item with item no., description and price
//INPUT: investory items from the xml file.
//PROCESS:
//At the loading of the form, all the items are read from the xml file and
//displayed to the user.
//User has the option to add new item.
//If user chooses to add a new item a new item form is displayed.
//After saving the item, item is saved in the inventory xml file and
//showed in the form.
//User also has the option to delete an item from the investory.
//Selected item is removed from the xml file and in LBXItems.
//OUTPUT: It saves all the items in the xml file and also shows all the inventory items in LBXItems.
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.”


namespace InventoryMaintenance
{
    public partial class FRMInventoryMaintenance : Form
	{
		public FRMInventoryMaintenance()
		{
			InitializeComponent();
		}

        // Add a statement here that declares the list of items.
        List<InvItem> invItems = new List<InvItem>();

        /// <summary>
        /// load form with items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRMInvMaint_Load(object sender, System.EventArgs e)
		{
            // Add a statement here that gets the list of items.
            invItems = InvItemDB.GetItems();
            FillItemListBox();
		}

        /// <summary>
        /// fill items in the list
        /// </summary>
		private void FillItemListBox()
		{
			LBXItems.Items.Clear();
            // Add code here that loads the list box with the items in the list.
            foreach (InvItem invItem in invItems)
            {
                LBXItems.Items.Add(invItem.GetDisplayText());
            }
        }

        /// <summary>
        /// Add a new item in the xml file and show in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void BTNAdd_Click(object sender, System.EventArgs e)
		{
            // Add code here that creates an instance of the New Item form
            FRMNewItem newItemForm = new FRMNewItem();
            // and then gets a new item from that form.
            InvItem invItem = newItemForm.GetNewItem();
            if (invItem != null)
            {
                invItems.Add(invItem);
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }
        }
        /// <summary>
        /// Delete the selected item from the xml file and show in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void BTNDelete_Click(object sender, System.EventArgs e)
		{
			int i = LBXItems.SelectedIndex;
			if (i != -1)
			{
                // Add code here that displays a dialog box to confirm
                string strMessage = "Do you really want to delete?";
                DialogResult button = MessageBox.Show(strMessage, "Confirm Delete", MessageBoxButtons.YesNo);

                InvItem deleteInvItem = invItems[i];
                // the deletion and then removes the item from the list,
                // saves the list of products, and refreshes the list box
                // if the deletion is confirmed.
                if (button == DialogResult.Yes)
                {
                    invItems.Remove(deleteInvItem);
                    InvItemDB.SaveItems(invItems);
                    FillItemListBox();
                }
            }
		}

        /// <summary>
        /// close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void BTNExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}