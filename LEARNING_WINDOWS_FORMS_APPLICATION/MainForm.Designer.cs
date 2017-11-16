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
			this.dataTextBox = new System.Windows.Forms.TextBox();
			this.dataListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// insertButton
			// 
			this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.insertButton.Location = new System.Drawing.Point(252, 12);
			this.insertButton.Name = "insertButton";
			this.insertButton.Size = new System.Drawing.Size(45, 23);
			this.insertButton.TabIndex = 1;
			this.insertButton.Text = "...";
			this.insertButton.UseVisualStyleBackColor = true;
			this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
			// 
			// dataTextBox
			// 
			this.dataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataTextBox.Location = new System.Drawing.Point(12, 12);
			this.dataTextBox.Name = "dataTextBox";
			this.dataTextBox.Size = new System.Drawing.Size(234, 23);
			this.dataTextBox.TabIndex = 0;
			// 
			// dataListBox
			// 
			this.dataListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataListBox.FormattingEnabled = true;
			this.dataListBox.ItemHeight = 16;
			this.dataListBox.Location = new System.Drawing.Point(12, 41);
			this.dataListBox.Name = "dataListBox";
			this.dataListBox.Size = new System.Drawing.Size(285, 132);
			this.dataListBox.TabIndex = 2;
			this.dataListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataListBox_KeyDown);
			// 
			// MainForm
			// 
			this.AcceptButton = this.insertButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 186);
			this.Controls.Add(this.dataListBox);
			this.Controls.Add(this.dataTextBox);
			this.Controls.Add(this.insertButton);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(325, 225);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button insertButton;
		private System.Windows.Forms.TextBox dataTextBox;
		private System.Windows.Forms.ListBox dataListBox;
	}
}
