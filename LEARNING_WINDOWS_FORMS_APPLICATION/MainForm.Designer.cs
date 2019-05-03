namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.insertButton = new System.Windows.Forms.Button();
			this.identityTextBox = new System.Windows.Forms.TextBox();
			this.identitiesListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// insertButton
			// 
			this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.insertButton.Location = new System.Drawing.Point(223, 12);
			this.insertButton.Name = "insertButton";
			this.insertButton.Size = new System.Drawing.Size(74, 23);
			this.insertButton.TabIndex = 1;
			this.insertButton.Text = "&Add";
			this.insertButton.UseVisualStyleBackColor = true;
			this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
			// 
			// identityTextBox
			// 
			this.identityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.identityTextBox.Location = new System.Drawing.Point(12, 12);
			this.identityTextBox.Name = "identityTextBox";
			this.identityTextBox.Size = new System.Drawing.Size(205, 23);
			this.identityTextBox.TabIndex = 0;
			// 
			// identitiesListBox
			// 
			this.identitiesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.identitiesListBox.FormattingEnabled = true;
			this.identitiesListBox.ItemHeight = 16;
			this.identitiesListBox.Location = new System.Drawing.Point(12, 41);
			this.identitiesListBox.Name = "identitiesListBox";
			this.identitiesListBox.Size = new System.Drawing.Size(285, 132);
			this.identitiesListBox.TabIndex = 2;
			this.identitiesListBox.DoubleClick += new System.EventHandler(this.IdentitiesListBox_DoubleClick);
			this.identitiesListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IdentitiesListBox_KeyDown);
			// 
			// MainForm
			// 
			this.AcceptButton = this.insertButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 186);
			this.Controls.Add(this.identitiesListBox);
			this.Controls.Add(this.identityTextBox);
			this.Controls.Add(this.insertButton);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(325, 225);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button insertButton;
		private System.Windows.Forms.TextBox identityTextBox;
		private System.Windows.Forms.ListBox identitiesListBox;
	}
}
