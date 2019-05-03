namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}

		private void InsertButton_Click(object sender, System.EventArgs e)
		{
			// **********
			//identitiesListBox.Items.Add(identityTextBox.Text);
			// **********

			// **********
			//identityTextBox.Text = identityTextBox.Text.Trim();

			//if (identityTextBox.Text != "")
			//{
			//	identitiesListBox.Items.Add(identityTextBox.Text);
			//}
			// **********

			// **********
			//identityTextBox.Text = identityTextBox.Text.Trim();

			//if (identityTextBox.Text != string.Empty)
			//{
			//	identitiesListBox.Items.Add(identityTextBox.Text);
			//}
			// **********

			// **********
			// "" -> string.Empty
			// "\n\r" -> System.Environment.NewLine
			// **********

			// **********
			//identityTextBox.Text = identityTextBox.Text.Trim();

			//if (identityTextBox.Text != string.Empty)
			//	if (!identitiesListBox.Items.Contains(identityTextBox.Text))
			//		identitiesListBox.Items.Add(identityTextBox.Text);
			// **********

			// **********
			//identityTextBox.Text = identityTextBox.Text.Trim();

			//if (identityTextBox.Text != string.Empty)
			//{
			//	if (identitiesListBox.Items.Contains(identityTextBox.Text) == false)
			//	{
			//		identitiesListBox.Items.Add(identityTextBox.Text);
			//	}
			//}
			// **********

			// **********
			//identityTextBox.Text = identityTextBox.Text.Trim();

			//identityTextBox.Text = identityTextBox.Text.Replace("  ", " ");
			//identityTextBox.Text = identityTextBox.Text.Replace("   ", " ");
			//identityTextBox.Text = identityTextBox.Text.Replace("    ", " ");
			//identityTextBox.Text = identityTextBox.Text.Replace("     ", " ");

			//if (identityTextBox.Text != string.Empty)
			//{
			//	if (identitiesListBox.Items.Contains(identityTextBox.Text) == false)
			//	{
			//		identitiesListBox.Items.Add(identityTextBox.Text);
			//	}
			//}
			// **********

			// **********
			//identityTextBox.Text =
			//	identityTextBox.Text.Trim();

			//while (identityTextBox.Text.Contains("  "))
			//{
			//	identityTextBox.Text =
			//		identityTextBox.Text.Replace("  ", " ");
			//}

			//if (identityTextBox.Text != string.Empty)
			//{
			//	if (identitiesListBox.Items.Contains(identityTextBox.Text) == false)
			//	{
			//		identitiesListBox.Items.Add(identityTextBox.Text);
			//	}
			//}
			// **********

			// **********
			//identityTextBox.Text =
			//	identityTextBox.Text.Trim();

			//while (identityTextBox.Text.Contains("  "))
			//{
			//	identityTextBox.Text =
			//		identityTextBox.Text.Replace("  ", " ");
			//}

			//if (identityTextBox.Text != string.Empty)
			//{
			//	if (identitiesListBox.Items.Contains(identityTextBox.Text) == false)
			//	{
			//		identitiesListBox.Items.Add(identityTextBox.Text);
			//	}

			//	identityTextBox.Text = string.Empty;
			//}
			// **********

			// **********
			//identityTextBox.Text =
			//	identityTextBox.Text.Trim();

			//while (identityTextBox.Text.Contains("  "))
			//{
			//	identityTextBox.Text =
			//		identityTextBox.Text.Replace("  ", " ");
			//}

			//if (identityTextBox.Text != string.Empty)
			//{
			//	if (identitiesListBox.Items.Contains(identityTextBox.Text) == false)
			//	{
			//		identitiesListBox.Items.Add(identityTextBox.Text);
			//	}

			//	identityTextBox.SelectAll();
			//}
			// **********

			// **********
			// **********
			// **********
			//identityTextBox.Text =
			//	identityTextBox.Text.Trim();

			//while (identityTextBox.Text.Contains("  "))
			//{
			//	identityTextBox.Text =
			//		identityTextBox.Text.Replace("  ", " ");
			//}

			//if (identityTextBox.Text != string.Empty)
			//{
			//	if (identitiesListBox.Items.Contains(identityTextBox.Text) == false)
			//	{
			//		identitiesListBox.Items.Add(identityTextBox.Text);
			//	}

			//	identityTextBox.Focus();

			//	// **********
			//	//identityTextBox.SelectAll();
			//	// **********

			//	// **********
			//	//identityTextBox.Select
			//	//	(start: 0, length: identityTextBox.Text.Length);
			//	// **********

			//	// **********
			//	identityTextBox.SelectionStart = 0;
			//	identityTextBox.SelectionLength = identityTextBox.Text.Length;
			//	// **********
			//}
			// **********
			// **********
			// **********

			// **********
			if (identityTextBox.Text == null)
			{
				return;
			}

			identityTextBox.Text =
				identityTextBox.Text.Trim();

			while (identityTextBox.Text.Contains("  "))
			{
				identityTextBox.Text =
					identityTextBox.Text.Replace("  ", " ");
			}

			if (identityTextBox.Text != string.Empty)
			{
				if (identityTextBox.Text.Length == 1)
				{
					identityTextBox.Text =
						identityTextBox.Text.ToUpper();
				}
				else
				{
					identityTextBox.Text =
						identityTextBox.Text.Substring(startIndex: 0, length: 1).ToUpper() +
						identityTextBox.Text.Substring(startIndex: 1).ToLower();
				}

				if (identitiesListBox.Items.Contains(identityTextBox.Text) == false)
				{
					identitiesListBox.Items.Add(identityTextBox.Text);
				}

				identityTextBox.Focus();
				identityTextBox.SelectAll();
			}
			// **********
		}

		private void IdentitiesListBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			// **********
			//if (e.KeyCode == System.Windows.Forms.Keys.Delete)
			//{
			//}
			// **********

			// **********
			//switch (e.KeyCode)
			//{
			//	case System.Windows.Forms.Keys.Delete:
			//	{
			//		break;
			//	}
			//}
			// **********

			// **********
			//switch (e.KeyCode)
			//{
			//	case System.Windows.Forms.Keys.Delete:
			//	{
			//		if ((e.Alt == false) &&
			//			(e.Shift == false) &&
			//			(e.Control == false))
			//		{
			//			identitiesListBox.Items.RemoveAt(identitiesListBox.SelectedIndex);
			//		}

			//		break;
			//	}
			//}
			// **********

			// **********
			//switch (e.KeyCode)
			//{
			//	case System.Windows.Forms.Keys.Delete:
			//	{
			//		if ((e.Alt == false) &&
			//			(e.Shift == false) &&
			//			(e.Control == false))
			//		{
			//			if (identitiesListBox.SelectedIndex >= 0)
			//			{
			//				identitiesListBox.Items.RemoveAt(identitiesListBox.SelectedIndex);
			//			}
			//		}

			//		break;
			//	}
			//}
			// **********

			// **********
			//switch (e.KeyCode)
			//{
			//	case System.Windows.Forms.Keys.Delete:
			//	{
			//		if ((e.Alt == false) &&
			//			(e.Shift == false) &&
			//			(e.Control == false))
			//		{
			//			if (identitiesListBox.SelectedIndex >= 0)
			//			{
			//				int selectedIndex =
			//					identitiesListBox.SelectedIndex;

			//				identitiesListBox.Items.RemoveAt(selectedIndex);
			//				identitiesListBox.SelectedIndex = selectedIndex;
			//			}
			//		}

			//		break;
			//	}
			//}
			// **********

			// **********
			switch (e.KeyCode)
			{
				case System.Windows.Forms.Keys.Delete:
				{
					if ((e.Alt == false) &&
						(e.Shift == false) &&
						(e.Control == false))
					{
						if (identitiesListBox.SelectedIndex >= 0)
						{
							int selectedIndex =
								identitiesListBox.SelectedIndex;

							identitiesListBox.Items.RemoveAt(selectedIndex);

							if (selectedIndex > identitiesListBox.Items.Count - 1)
							{
								selectedIndex =
									identitiesListBox.Items.Count - 1;
							}

							identitiesListBox.SelectedIndex = selectedIndex;
						}
					}

					break;
				}
			}
			// **********
		}

		private void IdentitiesListBox_DoubleClick(object sender, System.EventArgs e)
		{
			object selectedItem =
				identitiesListBox.SelectedItem;

			if (selectedItem != null)
			{
				identityTextBox.Text = selectedItem.ToString();

				identityTextBox.Focus();
			}
		}

		private void MainForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case System.Windows.Forms.Keys.F1:
				{
					if ((e.Control == false) && (e.Alt == false) && (e.Shift == false))
					{
						System.Windows.Forms.MessageBox.Show("Hello, World!");
					}

					break;
				}
			}
		}
	}
}
