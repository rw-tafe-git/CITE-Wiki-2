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
    //Student Riley, Date: 24/02/2023
    //Assessment Task 2
    public partial class FormCITEWiki2 : Form
    {
        public FormCITEWiki2()
        {
            InitializeComponent();
            //ButtonSave.Enabled = false;
            ButtonDelete.Enabled = false;
            ButtonEdit.Enabled = false;
        }

        static Stream myTraceTestFile = File.Create("TestFile.txt");
        TextWriterTraceListener myTraceListener = new TextWriterTraceListener(myTraceTestFile);

        //6.2 Create a global List<T> of type Information called Wiki.
        private List<Information> Wiki = new List<Information>();

        #region Buttons

        //6.3 Create a button method to ADD a new item to the list. Use a TextBox for the Name input, ComboBox for the Category, Radio group for the Structure and Multiline TextBox for the Definition.
        private void ButtonAdd_Click(object sender, MouseEventArgs e)
        {
            bool Valid = ValidName(TextBoxName.Text);

            if (Valid)
            {
                try
                {
                    Information newItem = new Information();
                    newItem.SetName(TextBoxName.Text);
                    newItem.SetCategory(ComboBoxCategory.Text);
                    newItem.SetStructure(GetRadioButton());
                    newItem.SetDefinition(TextBoxDefinition.Text);
                    Wiki.Add(newItem);
                    ClearTextBoxes();

                    DisplayWiki();
                }
                catch
                {
                    //Msg.Text = "New Wiki information NOT added"
                }
            }
        }


        private void ButtonEdit_Click(object sender, MouseEventArgs e)
        {
            Information editItem = new Information();
            editItem.SetName(TextBoxName.Text);
            editItem.SetCategory(ComboBoxCategory.Text);
            editItem.SetStructure(GetRadioButton());
            editItem.SetDefinition(TextBoxDefinition.Text);

            if (ListViewProperties.SelectedIndices[0] == -1)
            {
                //Msg.Text = "Not working";
            }
            else
            {
                int index = ListViewProperties.SelectedIndices[0];
                Wiki[index].SetName(editItem.GetName());
                Wiki[index].SetCategory(editItem.GetCategory());
                Wiki[index].SetStructure(editItem.GetStructure());
                Wiki[index].SetDefinition(editItem.GetDefinition());

                ButtonEdit.Enabled = false;
                ButtonDelete.Enabled = false;

                ClearTextBoxes();
                DisplayWiki();
            }
        }

        //6.9 Create a single custom method that will sort and then display the Name and Category from the wiki information in the list.
        private void DisplayWiki()
        {
            ListViewProperties.Items.Clear();
            Wiki.Sort();
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

            if (ListViewProperties.SelectedIndices[0] == -1)
            {
                //Msg.Text = "Not working";
            }
            else
            {
                int index = ListViewProperties.SelectedIndices[0];
                Wiki.RemoveAt(index);

                ButtonEdit.Enabled = false;
                ButtonDelete.Enabled = false;

                ClearTextBoxes();
                DisplayWiki();
            }
        }

        #endregion

        #region Methods
        //6.12 Create a custom method that will clear and reset the TextBoxes, ComboBox and Radio button
        private void ClearTextBoxes()
        {
            TextBoxName.Clear();
            TextBoxDefinition.Clear();
            ComboBoxCategory.SelectedIndex = 0;
            RbLinear.Checked = false;
            RbNonLinear.Checked = false;
        }

        //6.11 Create a ListView event so a user can select a Data Structure Name from the list of Names and the associated information will be displayed in the related text boxes combo box and radio button.
        private void ListViewProperties_Click(object sender, EventArgs e)
        {
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
            //else if (RbNALinear.Checked)
            //radioText = RbNALinear.Text;
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
            //SaveWikiData();
            Trace.Close();
        }

        #endregion

        #region BinarySearch
        //6.10 Create a button method that will use the builtin binary search to find a Data Structure name. If the record is found the associated details will populate the appropriate input controls and highlight the name in the ListView. At the end of the search process the search input TextBox must be cleared.
        private void ButtonSearch_Click(object sender, MouseEventArgs e)
        {
            /*BubbleSort();
            bool found = false; // assume the item has not been found
            int min = 0;
            int max = ptr; // max is the current size
            int foundIndex = 0;
            string findThis = TextBoxSearch.Text;
            while (min <= max)
            {
                int mid = ((min + max) / 2); // uses integer division
                if (findThis.CompareTo(DataTable[mid, 0]) == 0)
                {
                    found = true;
                    foundIndex = mid;
                    break;
                }
                else if (findThis.CompareTo(DataTable[mid, 0]) < 0)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            if (!found)
            {
                MessageBox.Show("Search failed: item not found");
            }
            else
            {
                MessageBox.Show("Success: the item was found");

                //Set the input textboxes to the datatables values of the found index
                TextBoxName.Text = DataTable[foundIndex, 0];
                TextBoxDefinition.Text = DataTable[foundIndex, 3];

                //Select the property in the list
                ListViewProperties.SelectedItems.Clear();
                ListViewProperties.Items[foundIndex].Selected = true;
                ListViewProperties.Select();

                selectedRow = foundIndex;

                ButtonEdit.Enabled = true;
                ButtonDelete.Enabled = true;
            }*/
        }

        #endregion

        #region File IO
        //6.8 Create a button method that will save the edited record of the currently selected item in the ListView. All the changes in the input controls will be written back to the list. Display an updated version of the sorted list at the end of this process.
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string fileName = "Wiki.bin";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Filter = "BIN|*.bin";
            saveFileDialog.Title = "Save your bin file";
            DialogResult sr = saveFileDialog.ShowDialog();
            if (sr == DialogResult.Cancel)
            {
                //saveFileDialog =
            }
            else
            {
                //saveFileDialog =
            }
        }

        //6.14 Create two buttons for the manual open and save option; this must use a dialog box to select a file or rename a saved file. All Wiki data is stored/retrieved using a binary reader/writer file format.
        private void ButtonOpen_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}