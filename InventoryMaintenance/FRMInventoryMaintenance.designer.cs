namespace InventoryMaintenance
{
	partial class FRMInventoryMaintenance
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.LBXItems = new System.Windows.Forms.ListBox();
            this.BTNExit = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBXItems
            // 
            this.LBXItems.FormattingEnabled = true;
            this.LBXItems.Location = new System.Drawing.Point(12, 12);
            this.LBXItems.Name = "LBXItems";
            this.LBXItems.Size = new System.Drawing.Size(325, 160);
            this.LBXItems.TabIndex = 10;
            // 
            // BTNExit
            // 
            this.BTNExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNExit.Location = new System.Drawing.Point(353, 72);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(104, 24);
            this.BTNExit.TabIndex = 9;
            this.BTNExit.Text = "E&xit";
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.Location = new System.Drawing.Point(353, 42);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(104, 24);
            this.BTNDelete.TabIndex = 8;
            this.BTNDelete.Text = "Delete Item...";
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(353, 12);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(104, 24);
            this.BTNAdd.TabIndex = 7;
            this.BTNAdd.Text = "Add Item...";
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // FRMInventoryMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNExit;
            this.ClientSize = new System.Drawing.Size(475, 181);
            this.Controls.Add(this.LBXItems);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FRMInventoryMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Maintenance";
            this.Load += new System.EventHandler(this.FRMInvMaint_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox LBXItems;
		private System.Windows.Forms.Button BTNExit;
		private System.Windows.Forms.Button BTNDelete;
		private System.Windows.Forms.Button BTNAdd;
	}
}

