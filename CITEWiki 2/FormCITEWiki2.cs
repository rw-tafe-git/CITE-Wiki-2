using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.IO;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CITEWiki
{
    //Student Riley, id 30002737, Date: 24/02/2023
    //Assessment Task 2
    public partial class FormCITEWiki2 : Form
    {
        public FormCITEWiki2()
        {
            InitializeComponent();
        }

        static Stream myTraceTestFile = File.Create("TestFile.txt");
        TextWriterTraceListener myTraceListener = new TextWriterTraceListener(myTraceTestFile);

        //6.2 Create a global List<T> of type Information called Wiki.
        private List<Information> Wiki = new List<Information>();

        #region Buttons

        //6.3 Create a button method to ADD a new item to the list. Use a TextBox for the Name input, ComboBox for the Category, Radio group for the Structure and Multiline TextBox for the Definition.
        private void ButtonAdd_Click(object sender, MouseEventArgs e)
        {
            Trace.Listeners.Add(myTraceListener);

            bool validName = ValidName(TextBoxName.Text);

            try
            {
                //Check if the name is not a duplicate and that all input fields are filled
                if (validName && !string.IsNullOrEmpty(TextBoxName.Text) && !string.IsNullOrEmpty(ComboBoxCategory.Text) && !string.IsNullOrEmpty(GetRadioButton()) && !string.IsNullOrEmpty(TextBoxDefinition.Text))
                {

                    //Create a temporary information class
                    Information newItem = new Information();
                    newItem.SetName(TextBoxName.Text);
                    newItem.SetCategory(ComboBoxCategory.Text);
                    newItem.SetStructure(GetRadioButton());
                    newItem.SetDefinition(TextBoxDefinition.Text);
                    Wiki.Add(newItem);
                    ClearTextBoxes();

                    DisplayTable();

                    Trace.WriteLine("Add Method = List box record added");
                    Msg.Text = "New Wiki information added";
                }
                else
                {
                    Trace.WriteLine("Add Method = List box record not added");
                    Msg.Text = "Fill in all input values to add record, no duplicate names";
                }
            }
            catch
            {
                Trace.WriteLine("Add Method = List box record not added");
                Msg.Text = "Fill in all input values to add record, no duplicate names";
            }
        }

        //6.8 Create a button method that will save the edited record of the currently selected item in the ListView. All the changes in the input controls will be written back to the list. Display an updated version of the sorted list at the end of this process.
        private void ButtonEdit_Click(object sender, MouseEventArgs e)
        {
            Trace.Listeners.Add(myTraceListener);

            bool validName = ValidName(TextBoxName.Text);

            //Create a temporary information class
            Information editItem = new Information();
            editItem.SetName(TextBoxName.Text);
            editItem.SetCategory(ComboBoxCategory.Text);
            editItem.SetStructure(GetRadioButton());
            editItem.SetDefinition(TextBoxDefinition.Text);

            try
            {
                if (ListViewProperties.SelectedIndices[0] != -1 && validName && !string.IsNullOrEmpty(TextBoxName.Text) && !string.IsNullOrEmpty(ComboBoxCategory.Text) && !string.IsNullOrEmpty(GetRadioButton()) && !string.IsNullOrEmpty(TextBoxDefinition.Text))
                {
                    //Get selected index and then set it's properties from the temporary one
                    int index = ListViewProperties.SelectedIndices[0];
                    Wiki[index].SetName(editItem.GetName());
                    Wiki[index].SetCategory(editItem.GetCategory());
                    Wiki[index].SetStructure(editItem.GetStructure());
                    Wiki[index].SetDefinition(editItem.GetDefinition());

                    ButtonEdit.Enabled = false;
                    ButtonDelete.Enabled = false;

                    ClearTextBoxes();
                    DisplayTable();

                    Trace.WriteLine("Edit Method = record {0} edited", index.ToString());
                    Msg.Text = "Wiki information edited";
                }
                else
                {
                    Trace.WriteLine("Edit Method = List box record not edited");
                    Msg.Text = "Select a record from the List box for editing";
                }
            }
            catch
            {
                Trace.WriteLine("Edit Method = List box record not edited");
                Msg.Text = "Select a record from the List box for editing";
            }
        }

        //6.9 Create a single custom method that will sort and then display the Name and Category from the wiki information in the list.
        private void DisplayTable()
        {
            ListViewProperties.Items.Clear();
            Wiki.Sort();

            //loop though the wiki list and then add it's values to the listviewproperties
            foreach (var item in Wiki)
            {
                ListViewItem lviName = new ListViewItem(item.GetName());
                lviName.SubItems.Add(item.GetCategory());
                ListViewProperties.Items.Add(lviName);
            }
        }

        //6.7 Create a button method that will delete the currently selected record in the ListView. Ensure the user has the option to backout of this action by using a dialog box.Display an updated version of the sorted list at the end of this process.
        private void ButtonDelete_Click(object sender, MouseEventArgs e)
        {
            Trace.Listeners.Add(myTraceListener);

            try
            {
                if (ListViewProperties.SelectedIndices[0] != -1)
                {
                    DialogResult result = MessageBox.Show("Do you want to delete this entry?", "Delete Entry", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        //Get selected index and then remove it from the wiki list
                        int index = ListViewProperties.SelectedIndices[0];
                        Wiki.RemoveAt(index);

                        ButtonEdit.Enabled = false;
                        ButtonDelete.Enabled = false;

                        ClearTextBoxes();
                        DisplayTable();

                        Trace.WriteLine("Delete Method = record {0} deleted", index.ToString());
                        Msg.Text = "Wiki information deleted";
                    }

                }
            }
            catch
            {
                Trace.WriteLine("Delete Method = List box record not deleted");
                Msg.Text = "Select a record from the List box for deleting";
            }
        }

        #endregion

        #region Methods
        //6.12 Create a custom method that will clear and reset the TextBoxes, ComboBox and Radio button
        private void ClearTextBoxes()
        {
            TextBoxName.Clear();
            ComboBoxCategory.SelectedIndex = 0;
            TextBoxDefinition.Clear();
            RbLinear.Checked = false;
            RbNonLinear.Checked = false;
        }

        //6.13 Create a double click event on the Name TextBox to clear the TextBboxes, ComboBox and Radio button.
        private void TextBoxName_DoubleClick(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        //6.11 Create a ListView event so a user can select a Data Structure Name from the list of Names and the associated information will be displayed in the related text boxes combo box and radio button.
        private void ListViewProperties_Click(object sender, EventArgs e)
        {
            //Get selected item index and it's properties for editing
            int currentItem = ListViewProperties.SelectedIndices[0];
            TextBoxName.Text = Wiki[currentItem].GetName();
            ComboBoxCategory.Text = Wiki[currentItem].GetCategory();
            SetRadioButton(currentItem);
            TextBoxDefinition.Text = Wiki[currentItem].GetDefinition();

            ButtonEdit.Enabled = true;
            ButtonDelete.Enabled = true;
        }

        //6.4 Create a custom method to populate the ComboBox when the Form Load method is called. The six categories must be read from a simple text file.
        private void FillComboBox()
        {
            //Get string values from a file and add them to the combobox
            string[] dataString = File.ReadAllLines(@"categories.txt");
            for (int x = 0; x < dataString.Length; x++)
            {
                ComboBoxCategory.Items.Add(dataString[x]);
            }
        }

        //6.5 Create a custom ValidName method which will take a parameter string value from the Textbox Name and returns a Boolean after checking for duplicates.Use the built in List<T> method “Exists” to answer this requirement.
        private bool ValidName(String a)
        {
            Trace.Listeners.Add(myTraceListener);
            Trace.WriteLine("Method name ValidName");
            if (Wiki.Exists(dup => dup.GetName() == a))
            {
                Trace.WriteLine("Valid Name = false");
                return false;
            }
            else
            {
                Trace.WriteLine("Valid Name = true");
                return true;
            }
        }

        //6.6 Create two methods to highlight and return the values from the Radio button GroupBox.The first method must return a string value from the selected radio button(Linear or Non-Linear). The second method must send an integer index which will highlight an appropriate radio button.
        private string GetRadioButton()
        {
            string radioText = "";
            if (RbLinear.Checked)
                radioText = RbLinear.Text;
            else if (RbNonLinear.Checked)
                radioText = RbNonLinear.Text;
            return radioText;
        }

        private void SetRadioButton(int item)
        {
            if (Wiki[item].GetStructure() == "Linear")
                RbLinear.Checked = true;
            else if (Wiki[item].GetStructure() == "Non-Linear")
                RbNonLinear.Checked = true;
        }

        private void FormCITEWiki2_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        //6.15 The Wiki application will save data when the form closes.
        private void WikiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Prevent the application form closing to display save prompt
            e.Cancel = true;

            DialogResult result = MessageBox.Show("Save changes before closing?", "Save Changes", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                SaveDialog(true);
            }
            else if (result == DialogResult.No)
            {
                Trace.Close();

                //To prevent the save prompt from looping, we use ExitThread
                Application.ExitThread();
            }
        }

        #endregion

        #region BinarySearch
        //6.10 Create a button method that will use the builtin binary search to find a Data Structure name. If the record is found the associated details will populate the appropriate input controls and highlight the name in the ListView. At the end of the search process the search input TextBox must be cleared.
        private void ButtonSearch_Click(object sender, MouseEventArgs e)
        {
            Information item = new Information();
            item.SetName(TextBoxSearch.Text);
            int foundIndex = Wiki.BinarySearch(item);

            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine("Search index " + foundIndex);

            if (foundIndex > -1)
            {
                ListViewProperties.SelectedItems.Clear();
                ListViewProperties.Items[foundIndex].Selected = true;
                ListViewProperties.Focus();
                TextBoxName.Text = Wiki[foundIndex].GetName();
                ComboBoxCategory.Text = Wiki[foundIndex].GetCategory();
                SetRadioButton(foundIndex);
                TextBoxDefinition.Text = Wiki[foundIndex].GetDefinition();

                ButtonEdit.Enabled = true;
                ButtonDelete.Enabled = true;

                Trace.WriteLine("Index found " + foundIndex);
                Msg.Text = "Search success: Wiki item found";
            }
            else
            {
                Trace.WriteLine("Index not found " + foundIndex);
                Msg.Text = "Search failed: Wiki item not found";
                ClearTextBoxes();
            }
            TextBoxSearch.Clear();
            TextBoxSearch.Focus();
        }

        #endregion

        #region File IO

        //6.14 Create two buttons for the manual open and save option; this must use a dialog box to select a file or rename a saved file. All Wiki data is stored/retrieved using a binary reader/writer file format.
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveDialog();
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            OpenDialog();
        }

        private void SaveDialog(bool exiting = false)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.Write("Opened save dialog");

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Filter = "BIN|*.bin";
            saveFileDialog.Title = "Save your bin file";
            DialogResult sr = saveFileDialog.ShowDialog();

            if (sr == DialogResult.OK)
            {
                try
                {
                    using (var stream = File.Open(saveFileDialog.FileName, FileMode.Create))
                    {
                        using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                        {
                            foreach (var item in Wiki)
                            {
                                writer.Write(item.GetName());
                                writer.Write(item.GetCategory());
                                writer.Write(item.GetStructure());
                                writer.Write(item.GetDefinition());
                            }
                        }
                    }
                    Trace.Write("Wiki information = saved");
                    Msg.Text = "Saved Wiki information to bin file";
                }
                catch (IOException)
                {
                    Trace.Write("Wiki information = not saved");
                    Msg.Text = "Could not save Wiki information";
                }

                //If exiting then exit the application
                if (exiting)
                {
                    Trace.Close();
                    Application.ExitThread();
                }
            }
        }
        private void OpenDialog()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "BIN Files|*.bin";
            openFileDialog.Title = "Open a bin file";
            DialogResult sr = openFileDialog.ShowDialog();

            if (sr == DialogResult.OK)
            {
                Wiki.Clear();

                if (File.Exists(openFileDialog.FileName))
                {
                    try
                    {
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open))
                        {
                            using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                            {
                                while (stream.Position < stream.Length)
                                {
                                    Information newItem = new Information();
                                    newItem.SetName(reader.ReadString());
                                    newItem.SetCategory(reader.ReadString());
                                    newItem.SetStructure(reader.ReadString());
                                    newItem.SetDefinition(reader.ReadString());
                                    Wiki.Add(newItem);
                                }
                            }
                        }

                        ClearTextBoxes();
                        DisplayTable();

                        Trace.Write("Wiki information = opened");
                        Msg.Text = "Loaded Wiki information from bin file";
                    }
                    catch (IOException)
                    {
                        Trace.Write("Wiki information = not opened");
                        Msg.Text = "Could not open Wiki information";
                    }
                }
            }
        }
        #endregion
    }
}