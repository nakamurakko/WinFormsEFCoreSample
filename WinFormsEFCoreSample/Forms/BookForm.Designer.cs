namespace WinFormsEFCoreSample.Forms;

partial class BookForm
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
        this.InputItemsTableLayoutPanel = new TableLayoutPanel();
        this.TitleTextBox = new TextBox();
        this.TitleLabel = new Label();
        this.AuthorLabel = new Label();
        this.AuthorComboBox = new ComboBox();
        this.SaveButton = new Button();
        this.InputItemsTableLayoutPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // InputItemsTableLayoutPanel
        // 
        this.InputItemsTableLayoutPanel.ColumnCount = 2;
        this.InputItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
        this.InputItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.InputItemsTableLayoutPanel.Controls.Add(this.TitleTextBox, 1, 0);
        this.InputItemsTableLayoutPanel.Controls.Add(this.TitleLabel, 0, 0);
        this.InputItemsTableLayoutPanel.Controls.Add(this.AuthorLabel, 0, 1);
        this.InputItemsTableLayoutPanel.Controls.Add(this.AuthorComboBox, 1, 1);
        this.InputItemsTableLayoutPanel.Dock = DockStyle.Top;
        this.InputItemsTableLayoutPanel.Location = new Point(0, 0);
        this.InputItemsTableLayoutPanel.Name = "InputItemsTableLayoutPanel";
        this.InputItemsTableLayoutPanel.RowCount = 2;
        this.InputItemsTableLayoutPanel.RowStyles.Add(new RowStyle());
        this.InputItemsTableLayoutPanel.RowStyles.Add(new RowStyle());
        this.InputItemsTableLayoutPanel.Size = new Size(378, 74);
        this.InputItemsTableLayoutPanel.TabIndex = 1;
        // 
        // TitleTextBox
        // 
        this.TitleTextBox.Dock = DockStyle.Fill;
        this.TitleTextBox.Location = new Point(81, 3);
        this.TitleTextBox.Name = "TitleTextBox";
        this.TitleTextBox.Size = new Size(294, 31);
        this.TitleTextBox.TabIndex = 2;
        // 
        // TitleLabel
        // 
        this.TitleLabel.AutoSize = true;
        this.TitleLabel.Dock = DockStyle.Left;
        this.TitleLabel.Location = new Point(3, 0);
        this.TitleLabel.Name = "TitleLabel";
        this.TitleLabel.Padding = new Padding(3);
        this.TitleLabel.Size = new Size(72, 37);
        this.TitleLabel.TabIndex = 1;
        this.TitleLabel.Text = "タイトル";
        this.TitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AuthorLabel
        // 
        this.AuthorLabel.AutoSize = true;
        this.AuthorLabel.Dock = DockStyle.Left;
        this.AuthorLabel.Location = new Point(3, 37);
        this.AuthorLabel.Name = "AuthorLabel";
        this.AuthorLabel.Padding = new Padding(3);
        this.AuthorLabel.Size = new Size(54, 39);
        this.AuthorLabel.TabIndex = 0;
        this.AuthorLabel.Text = "著者";
        this.AuthorLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AuthorComboBox
        // 
        this.AuthorComboBox.DisplayMember = "AuthorName";
        this.AuthorComboBox.Dock = DockStyle.Fill;
        this.AuthorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.AuthorComboBox.FormattingEnabled = true;
        this.AuthorComboBox.Location = new Point(81, 40);
        this.AuthorComboBox.Name = "AuthorComboBox";
        this.AuthorComboBox.Size = new Size(294, 33);
        this.AuthorComboBox.TabIndex = 3;
        this.AuthorComboBox.ValueMember = "AuthorId";
        // 
        // SaveButton
        // 
        this.SaveButton.Dock = DockStyle.Top;
        this.SaveButton.Location = new Point(0, 74);
        this.SaveButton.Name = "SaveButton";
        this.SaveButton.Size = new Size(378, 34);
        this.SaveButton.TabIndex = 2;
        this.SaveButton.Text = "追加";
        this.SaveButton.UseVisualStyleBackColor = true;
        this.SaveButton.Click += this.SaveButton_Click;
        // 
        // BookForm
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(378, 124);
        this.Controls.Add(this.SaveButton);
        this.Controls.Add(this.InputItemsTableLayoutPanel);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.Name = "BookForm";
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "書籍情報";
        this.Load += this.BookForm_Load;
        this.InputItemsTableLayoutPanel.ResumeLayout(false);
        this.InputItemsTableLayoutPanel.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion
    private TableLayoutPanel InputItemsTableLayoutPanel;
    private TextBox TitleTextBox;
    private Label TitleLabel;
    private Label AuthorLabel;
    private ComboBox AuthorComboBox;
    private Button SaveButton;
}