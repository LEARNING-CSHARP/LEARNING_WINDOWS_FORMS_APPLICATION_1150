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

		private void insertButton_Click(object sender, System.EventArgs e)
		{
			// **********
			//dataListBox.Items.Add(dataTextBox.Text);
			// **********

			// **********
			//dataTextBox.Text = dataTextBox.Text.Trim();

			//if (dataTextBox.Text != "")
			//{
			//	dataListBox.Items.Add(dataTextBox.Text);
			//}
			// **********

			// **********
			//dataTextBox.Text = dataTextBox.Text.Trim();

			//if (dataTextBox.Text != string.Empty)
			//{
			//	dataListBox.Items.Add(dataTextBox.Text);
			//}
			// **********

			// **********
			// "\n\r" -> System.Environment.NewLine
			// **********

			// **********
			//dataTextBox.Text = dataTextBox.Text.Trim();

			//if (dataTextBox.Text != string.Empty)
			//{
			//	if (!dataListBox.Items.Contains(dataTextBox.Text))
			//		dataListBox.Items.Add(dataTextBox.Text);
			//}
			// **********

			// **********
			//dataTextBox.Text = dataTextBox.Text.Trim();

			//if (dataTextBox.Text != string.Empty)
			//{
			//	if (dataListBox.Items.Contains(dataTextBox.Text) == false)
			//	{
			//		dataListBox.Items.Add(dataTextBox.Text);
			//	}
			//}
			// **********

			// **********
			//dataTextBox.Text = dataTextBox.Text.Trim();

			//dataTextBox.Text = dataTextBox.Text.Replace("  ", " ");
			//dataTextBox.Text = dataTextBox.Text.Replace("   ", " ");
			//dataTextBox.Text = dataTextBox.Text.Replace("    ", " ");
			//dataTextBox.Text = dataTextBox.Text.Replace("     ", " ");

			//if (dataTextBox.Text != string.Empty)
			//{
			//	if (dataListBox.Items.Contains(dataTextBox.Text) == false)
			//	{
			//		dataListBox.Items.Add(dataTextBox.Text);
			//	}
			//}
			// **********

			// **********
			//dataTextBox.Text =
			//	dataTextBox.Text.Trim();

			//while (dataTextBox.Text.Contains("  "))
			//{
			//	dataTextBox.Text =
			//		dataTextBox.Text.Replace("  ", " ");
			//}

			//if (dataTextBox.Text != string.Empty)
			//{
			//	if (dataListBox.Items.Contains(dataTextBox.Text) == false)
			//	{
			//		dataListBox.Items.Add(dataTextBox.Text);
			//	}
			//}
			// **********

			// **********
			//dataTextBox.Text =
			//	dataTextBox.Text.Trim();

			//while (dataTextBox.Text.Contains("  "))
			//{
			//	dataTextBox.Text =
			//		dataTextBox.Text.Replace("  ", " ");
			//}

			//if (dataTextBox.Text != string.Empty)
			//{
			//	if (dataListBox.Items.Contains(dataTextBox.Text) == false)
			//	{
			//		dataListBox.Items.Add(dataTextBox.Text);
			//	}

			//	dataTextBox.Text = string.Empty;
			//}
			// **********

			// **********
			//dataTextBox.Text =
			//	dataTextBox.Text.Trim();

			//while (dataTextBox.Text.Contains("  "))
			//{
			//	dataTextBox.Text =
			//		dataTextBox.Text.Replace("  ", " ");
			//}

			//if (dataTextBox.Text != string.Empty)
			//{
			//	if (dataListBox.Items.Contains(dataTextBox.Text) == false)
			//	{
			//		dataListBox.Items.Add(dataTextBox.Text);
			//	}

			//	dataTextBox.SelectAll();
			//}
			// **********

			// **********
			// **********
			// **********
			//dataTextBox.Text =
			//	dataTextBox.Text.Trim();

			//while (dataTextBox.Text.Contains("  "))
			//{
			//	dataTextBox.Text =
			//		dataTextBox.Text.Replace("  ", " ");
			//}

			//if (dataTextBox.Text != string.Empty)
			//{
			//	if (dataListBox.Items.Contains(dataTextBox.Text) == false)
			//	{
			//		dataListBox.Items.Add(dataTextBox.Text);
			//	}

			//	dataTextBox.Focus();

			//	// **********
			//	//dataTextBox.SelectAll();
			//	// **********

			//	// **********
			//	//dataTextBox.Select
			//	//	(start: 0, length: dataTextBox.Text.Length);
			//	// **********

			//	// **********
			//	dataTextBox.SelectionStart = 0;
			//	dataTextBox.SelectionLength = dataTextBox.Text.Length;
			//	// **********
			//}
			// **********
			// **********
			// **********

			// **********
			dataTextBox.Text =
				dataTextBox.Text.Trim();

			while (dataTextBox.Text.Contains("  "))
			{
				dataTextBox.Text =
					dataTextBox.Text.Replace("  ", " ");
			}

			if (dataTextBox.Text != string.Empty)
			{
				if (dataTextBox.Text.Length == 1)
				{
					dataTextBox.Text =
						dataTextBox.Text.ToUpper();
				}
				else
				{
					dataTextBox.Text =
						dataTextBox.Text.Substring(startIndex: 0, length: 1).ToUpper() +
						dataTextBox.Text.Substring(startIndex: 1).ToLower();
				}

				if (dataListBox.Items.Contains(dataTextBox.Text) == false)
				{
					dataListBox.Items.Add(dataTextBox.Text);
				}

				dataTextBox.Focus();
				dataTextBox.SelectAll();
			}
			// **********
		}

		private void dataListBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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
			//			dataListBox.Items.RemoveAt(dataListBox.SelectedIndex);
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
			//			if (dataListBox.SelectedIndex >= 0)
			//			{
			//				dataListBox.Items.RemoveAt(dataListBox.SelectedIndex);
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
			//			if (dataListBox.SelectedIndex >= 0)
			//			{
			//				int selectedIndex =
			//					dataListBox.SelectedIndex;

			//				dataListBox.Items.RemoveAt(selectedIndex);
			//				dataListBox.SelectedIndex = selectedIndex;
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
						if (dataListBox.SelectedIndex >= 0)
						{
							int selectedIndex =
								dataListBox.SelectedIndex;

							dataListBox.Items.RemoveAt(selectedIndex);

							if (selectedIndex > dataListBox.Items.Count - 1)
							{
								selectedIndex =
									dataListBox.Items.Count - 1;
							}

							dataListBox.SelectedIndex = selectedIndex;
						}
					}

					break;
				}
			}
			// **********
		}
	}
}
