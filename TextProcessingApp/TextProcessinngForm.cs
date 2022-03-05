namespace TextProcessingApp
{
    public partial class TextProcessingForm : Form
    {
        public TextProcessingForm()
        {
            InitializeComponent();
            OpenTxtFile.Filter = Global.FileFilters;
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (OpenTxtFile.ShowDialog() == DialogResult.OK)
            {
                Controller.ParseFile(OpenTxtFile.FileName);
                FilePathLabel.Text = OpenTxtFile.FileName;
                Controller.ShowDictionary(DictionaryTable);
                SearchButton.Enabled = true;
                SearchTextBox.Enabled = true;
            }
            else
            {
                SearchTextBox.Text = string.Empty;
                SearchButton.Enabled = false;
                SearchTextBox.Enabled = false;
                DictionaryTable.Rows.Clear();
                DictionaryTable.Columns.Clear();
                DictionaryTable.Refresh();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                RepetitionsTable.Rows.Clear();
                RepetitionsTable.Columns.Clear();
                RepetitionsTable.Refresh();
                Controller.ShowRepetitions(SearchTextBox.Text, RepetitionsTable);
            }
            catch (Exception ex)
            {
                SearchTextBox.ForeColor = Color.Red;
                SearchTextBox.Text = ex.Message;
                SearchTextBox.ForeColor = Color.Black;
            }
        }
        private void DictionaryTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SearchTextBox.Text = DictionaryTable.CurrentCell.Value.ToString();
        }
    }
}