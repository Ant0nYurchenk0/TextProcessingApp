namespace TextProcessingApp
{
    partial class TextProcessingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DictionaryTable = new System.Windows.Forms.DataGridView();
            this.OpenTxtFile = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.FindWordLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RepetitionsTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DictionaryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepetitionsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DictionaryTable
            // 
            this.DictionaryTable.AllowUserToAddRows = false;
            this.DictionaryTable.BackgroundColor = System.Drawing.Color.Lavender;
            this.DictionaryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DictionaryTable.Location = new System.Drawing.Point(12, 67);
            this.DictionaryTable.Name = "DictionaryTable";
            this.DictionaryTable.ReadOnly = true;
            this.DictionaryTable.RowHeadersWidth = 62;
            this.DictionaryTable.RowTemplate.Height = 33;
            this.DictionaryTable.Size = new System.Drawing.Size(390, 548);
            this.DictionaryTable.TabIndex = 0;
            this.DictionaryTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DictionaryTable_CellDoubleClick);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(12, 12);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(112, 34);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FilePathLabel.Location = new System.Drawing.Point(145, 17);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(0, 25);
            this.FilePathLabel.TabIndex = 2;
            // 
            // FindWordLabel
            // 
            this.FindWordLabel.AutoSize = true;
            this.FindWordLabel.Location = new System.Drawing.Point(408, 67);
            this.FindWordLabel.Name = "FindWordLabel";
            this.FindWordLabel.Size = new System.Drawing.Size(144, 25);
            this.FindWordLabel.TabIndex = 3;
            this.FindWordLabel.Text = "Find repetitions: ";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Enabled = false;
            this.SearchTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchTextBox.Location = new System.Drawing.Point(549, 67);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(223, 31);
            this.SearchTextBox.TabIndex = 4;
            this.SearchTextBox.Text = "Double-click word to copy";
            // 
            // SearchButton
            // 
            this.SearchButton.Enabled = false;
            this.SearchButton.Location = new System.Drawing.Point(778, 65);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(80, 34);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RepetitionsTable
            // 
            this.RepetitionsTable.AllowUserToAddRows = false;
            this.RepetitionsTable.BackgroundColor = System.Drawing.Color.Lavender;
            this.RepetitionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RepetitionsTable.Location = new System.Drawing.Point(463, 105);
            this.RepetitionsTable.Name = "RepetitionsTable";
            this.RepetitionsTable.ReadOnly = true;
            this.RepetitionsTable.RowHeadersWidth = 62;
            this.RepetitionsTable.RowTemplate.Height = 33;
            this.RepetitionsTable.Size = new System.Drawing.Size(390, 511);
            this.RepetitionsTable.TabIndex = 6;
            // 
            // TextProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(865, 627);
            this.Controls.Add(this.RepetitionsTable);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.FindWordLabel);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.DictionaryTable);
            this.Name = "TextProcessingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Processing Form";
            ((System.ComponentModel.ISupportInitialize)(this.DictionaryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepetitionsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DictionaryTable;
        private OpenFileDialog OpenTxtFile;
        private Button OpenFileButton;
        private Label FilePathLabel;
        private Label FindWordLabel;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private DataGridView RepetitionsTable;
    }
}