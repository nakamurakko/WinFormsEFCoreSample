namespace WinFormsEFCoreSample.Forms;

partial class AuthorForm
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
        this.AuthorNamePanel = new Panel();
        this.AuthorNameTextBox = new TextBox();
        this.AuthorNameLabel = new Label();
        this.AddButton = new Button();
        this.AuthorNamePanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // AuthorNamePanel
        // 
        this.AuthorNamePanel.Controls.Add(this.AuthorNameTextBox);
        this.AuthorNamePanel.Controls.Add(this.AuthorNameLabel);
        this.AuthorNamePanel.Dock = DockStyle.Top;
        this.AuthorNamePanel.Location = new Point(0, 0);
        this.AuthorNamePanel.Name = "AuthorNamePanel";
        this.AuthorNamePanel.Padding = new Padding(2);
        this.AuthorNamePanel.Size = new Size(378, 35);
        this.AuthorNamePanel.TabIndex = 0;
        // 
        // AuthorNameTextBox
        // 
        this.AuthorNameTextBox.Dock = DockStyle.Fill;
        this.AuthorNameTextBox.Location = new Point(74, 2);
        this.AuthorNameTextBox.Name = "AuthorNameTextBox";
        this.AuthorNameTextBox.Size = new Size(302, 31);
        this.AuthorNameTextBox.TabIndex = 1;
        // 
        // AuthorNameLabel
        // 
        this.AuthorNameLabel.AutoSize = true;
        this.AuthorNameLabel.Dock = DockStyle.Left;
        this.AuthorNameLabel.Location = new Point(2, 2);
        this.AuthorNameLabel.Name = "AuthorNameLabel";
        this.AuthorNameLabel.Padding = new Padding(3);
        this.AuthorNameLabel.Size = new Size(72, 31);
        this.AuthorNameLabel.TabIndex = 0;
        this.AuthorNameLabel.Text = "著者名";
        this.AuthorNameLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AddButton
        // 
        this.AddButton.AutoSize = true;
        this.AddButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.AddButton.Dock = DockStyle.Top;
        this.AddButton.Location = new Point(0, 35);
        this.AddButton.Name = "AddButton";
        this.AddButton.Size = new Size(378, 35);
        this.AddButton.TabIndex = 1;
        this.AddButton.Text = "追加";
        this.AddButton.UseVisualStyleBackColor = true;
        this.AddButton.Click += this.AddButton_Click;
        // 
        // AuthorForm
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(378, 84);
        this.Controls.Add(this.AddButton);
        this.Controls.Add(this.AuthorNamePanel);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.Name = "AuthorForm";
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "著者を追加";
        this.AuthorNamePanel.ResumeLayout(false);
        this.AuthorNamePanel.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Panel AuthorNamePanel;
    private TextBox AuthorNameTextBox;
    private Label AuthorNameLabel;
    private Button AddButton;
}