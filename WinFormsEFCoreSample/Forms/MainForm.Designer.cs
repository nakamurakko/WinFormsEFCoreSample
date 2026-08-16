namespace WinFormsEFCoreSample;

partial class MainForm
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
        this.OperationPanel = new Panel();
        this.AddAuthorButton = new Button();
        this.AddBookButton = new Button();
        this.ClearSearchResultButton = new Button();
        this.SearchButton = new Button();
        this.SearchAuthorNameTextBox = new TextBox();
        this.SearchAuthorLabel = new Label();
        this.SearchTitleTextBox = new TextBox();
        this.SearchTitleLabel = new Label();
        this.DataListPanel = new Panel();
        this.BookDataGridView = new DataGridView();
        this.TitleColumn = new DataGridViewTextBoxColumn();
        this.AuthorColumn = new DataGridViewTextBoxColumn();
        this.BookReviewContentColumn = new DataGridViewTextBoxColumn();
        this.EditColumn = new DataGridViewButtonColumn();
        this.BookReviewColumn = new DataGridViewButtonColumn();
        this.OperationPanel.SuspendLayout();
        this.DataListPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.BookDataGridView).BeginInit();
        this.SuspendLayout();
        // 
        // OperationPanel
        // 
        this.OperationPanel.Controls.Add(this.AddAuthorButton);
        this.OperationPanel.Controls.Add(this.AddBookButton);
        this.OperationPanel.Controls.Add(this.ClearSearchResultButton);
        this.OperationPanel.Controls.Add(this.SearchButton);
        this.OperationPanel.Controls.Add(this.SearchAuthorNameTextBox);
        this.OperationPanel.Controls.Add(this.SearchAuthorLabel);
        this.OperationPanel.Controls.Add(this.SearchTitleTextBox);
        this.OperationPanel.Controls.Add(this.SearchTitleLabel);
        this.OperationPanel.Dock = DockStyle.Top;
        this.OperationPanel.Location = new Point(0, 0);
        this.OperationPanel.Name = "OperationPanel";
        this.OperationPanel.Padding = new Padding(3);
        this.OperationPanel.Size = new Size(982, 37);
        this.OperationPanel.TabIndex = 1;
        // 
        // AddAuthorButton
        // 
        this.AddAuthorButton.AutoSize = true;
        this.AddAuthorButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.AddAuthorButton.Dock = DockStyle.Left;
        this.AddAuthorButton.Location = new Point(826, 3);
        this.AddAuthorButton.Name = "AddAuthorButton";
        this.AddAuthorButton.Size = new Size(108, 31);
        this.AddAuthorButton.TabIndex = 3;
        this.AddAuthorButton.Text = "著者を追加";
        this.AddAuthorButton.UseVisualStyleBackColor = true;
        this.AddAuthorButton.Click += this.AddAuthorButton_Click;
        // 
        // AddBookButton
        // 
        this.AddBookButton.AutoSize = true;
        this.AddBookButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.AddBookButton.Dock = DockStyle.Left;
        this.AddBookButton.Location = new Point(736, 3);
        this.AddBookButton.Name = "AddBookButton";
        this.AddBookButton.Size = new Size(90, 31);
        this.AddBookButton.TabIndex = 6;
        this.AddBookButton.Text = "本を追加";
        this.AddBookButton.UseVisualStyleBackColor = true;
        this.AddBookButton.Click += this.AddBookButton_Click;
        // 
        // ClearSearchResultButton
        // 
        this.ClearSearchResultButton.AutoSize = true;
        this.ClearSearchResultButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.ClearSearchResultButton.Dock = DockStyle.Left;
        this.ClearSearchResultButton.Location = new Point(587, 3);
        this.ClearSearchResultButton.Name = "ClearSearchResultButton";
        this.ClearSearchResultButton.Size = new Size(149, 31);
        this.ClearSearchResultButton.TabIndex = 5;
        this.ClearSearchResultButton.Text = "検索結果をクリア";
        this.ClearSearchResultButton.UseVisualStyleBackColor = true;
        this.ClearSearchResultButton.Click += this.ClearSearchResultButton_Click;
        // 
        // SearchButton
        // 
        this.SearchButton.AutoSize = true;
        this.SearchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.SearchButton.Dock = DockStyle.Left;
        this.SearchButton.Location = new Point(529, 3);
        this.SearchButton.Name = "SearchButton";
        this.SearchButton.Size = new Size(58, 31);
        this.SearchButton.TabIndex = 4;
        this.SearchButton.Text = "検索";
        this.SearchButton.UseVisualStyleBackColor = true;
        this.SearchButton.Click += this.SearchButton_Click;
        // 
        // SearchAuthorNameTextBox
        // 
        this.SearchAuthorNameTextBox.Dock = DockStyle.Left;
        this.SearchAuthorNameTextBox.Location = new Point(329, 3);
        this.SearchAuthorNameTextBox.Name = "SearchAuthorNameTextBox";
        this.SearchAuthorNameTextBox.Size = new Size(200, 31);
        this.SearchAuthorNameTextBox.TabIndex = 3;
        // 
        // SearchAuthorLabel
        // 
        this.SearchAuthorLabel.AutoSize = true;
        this.SearchAuthorLabel.Dock = DockStyle.Left;
        this.SearchAuthorLabel.Location = new Point(275, 3);
        this.SearchAuthorLabel.Name = "SearchAuthorLabel";
        this.SearchAuthorLabel.Padding = new Padding(3);
        this.SearchAuthorLabel.Size = new Size(54, 31);
        this.SearchAuthorLabel.TabIndex = 2;
        this.SearchAuthorLabel.Text = "著者";
        this.SearchAuthorLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // SearchTitleTextBox
        // 
        this.SearchTitleTextBox.Dock = DockStyle.Left;
        this.SearchTitleTextBox.Location = new Point(75, 3);
        this.SearchTitleTextBox.Name = "SearchTitleTextBox";
        this.SearchTitleTextBox.Size = new Size(200, 31);
        this.SearchTitleTextBox.TabIndex = 1;
        // 
        // SearchTitleLabel
        // 
        this.SearchTitleLabel.AutoSize = true;
        this.SearchTitleLabel.Dock = DockStyle.Left;
        this.SearchTitleLabel.Location = new Point(3, 3);
        this.SearchTitleLabel.Name = "SearchTitleLabel";
        this.SearchTitleLabel.Padding = new Padding(3);
        this.SearchTitleLabel.Size = new Size(72, 31);
        this.SearchTitleLabel.TabIndex = 0;
        this.SearchTitleLabel.Text = "タイトル";
        this.SearchTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // DataListPanel
        // 
        this.DataListPanel.Controls.Add(this.BookDataGridView);
        this.DataListPanel.Dock = DockStyle.Fill;
        this.DataListPanel.Location = new Point(0, 37);
        this.DataListPanel.Name = "DataListPanel";
        this.DataListPanel.Size = new Size(982, 534);
        this.DataListPanel.TabIndex = 2;
        // 
        // BookDataGridView
        // 
        this.BookDataGridView.AllowUserToAddRows = false;
        this.BookDataGridView.AllowUserToDeleteRows = false;
        this.BookDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.BookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.BookDataGridView.Columns.AddRange(new DataGridViewColumn[] { this.TitleColumn, this.AuthorColumn, this.BookReviewContentColumn, this.EditColumn, this.BookReviewColumn });
        this.BookDataGridView.Dock = DockStyle.Fill;
        this.BookDataGridView.Location = new Point(0, 0);
        this.BookDataGridView.Name = "BookDataGridView";
        this.BookDataGridView.RowHeadersVisible = false;
        this.BookDataGridView.RowHeadersWidth = 62;
        this.BookDataGridView.Size = new Size(982, 534);
        this.BookDataGridView.TabIndex = 1;
        this.BookDataGridView.CellContentClick += this.BookDataGridView_CellContentClick;
        // 
        // TitleColumn
        // 
        this.TitleColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        this.TitleColumn.DataPropertyName = "Title";
        this.TitleColumn.FillWeight = 30F;
        this.TitleColumn.HeaderText = "タイトル";
        this.TitleColumn.MinimumWidth = 8;
        this.TitleColumn.Name = "TitleColumn";
        this.TitleColumn.ReadOnly = true;
        this.TitleColumn.Width = 102;
        // 
        // AuthorColumn
        // 
        this.AuthorColumn.DataPropertyName = "AuthorName";
        this.AuthorColumn.FillWeight = 30F;
        this.AuthorColumn.HeaderText = "著者";
        this.AuthorColumn.MinimumWidth = 8;
        this.AuthorColumn.Name = "AuthorColumn";
        this.AuthorColumn.ReadOnly = true;
        // 
        // BookReviewContentColumn
        // 
        this.BookReviewContentColumn.DataPropertyName = "BookReviewContent";
        this.BookReviewContentColumn.FillWeight = 40F;
        this.BookReviewContentColumn.HeaderText = "書評";
        this.BookReviewContentColumn.MinimumWidth = 8;
        this.BookReviewContentColumn.Name = "BookReviewContentColumn";
        this.BookReviewContentColumn.ReadOnly = true;
        // 
        // EditColumn
        // 
        this.EditColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        this.EditColumn.HeaderText = "";
        this.EditColumn.MinimumWidth = 8;
        this.EditColumn.Name = "EditColumn";
        this.EditColumn.Resizable = DataGridViewTriState.True;
        this.EditColumn.Text = "編集";
        this.EditColumn.UseColumnTextForButtonValue = true;
        this.EditColumn.Width = 8;
        // 
        // BookReviewColumn
        // 
        this.BookReviewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        this.BookReviewColumn.HeaderText = "";
        this.BookReviewColumn.MinimumWidth = 8;
        this.BookReviewColumn.Name = "BookReviewColumn";
        this.BookReviewColumn.Resizable = DataGridViewTriState.True;
        this.BookReviewColumn.Text = "書評";
        this.BookReviewColumn.UseColumnTextForButtonValue = true;
        this.BookReviewColumn.Width = 8;
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(982, 571);
        this.Controls.Add(this.DataListPanel);
        this.Controls.Add(this.OperationPanel);
        this.Name = "MainForm";
        this.Text = "WinFormsEFCoreSample";
        this.OperationPanel.ResumeLayout(false);
        this.OperationPanel.PerformLayout();
        this.DataListPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.BookDataGridView).EndInit();
        this.ResumeLayout(false);
    }

    #endregion
    private Panel OperationPanel;
    private Panel DataListPanel;
    private TextBox SearchTitleTextBox;
    private Label SearchTitleLabel;
    private Button AddBookButton;
    private Button ClearSearchResultButton;
    private Button SearchButton;
    private TextBox SearchAuthorNameTextBox;
    private Label SearchAuthorLabel;
    private Button AddAuthorButton;
    private DataGridView BookDataGridView;
    private DataGridViewTextBoxColumn TitleColumn;
    private DataGridViewTextBoxColumn AuthorColumn;
    private DataGridViewTextBoxColumn BookReviewContentColumn;
    private DataGridViewButtonColumn EditColumn;
    private DataGridViewButtonColumn BookReviewColumn;
}
