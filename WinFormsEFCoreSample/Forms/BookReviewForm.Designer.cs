namespace WinFormsEFCoreSample.Forms;

partial class BookReviewForm
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
        this.panel1 = new Panel();
        this.TitleTextBox = new TextBox();
        this.TitleLabel = new Label();
        this.BookReviewContentLabel = new Label();
        this.BookReviewContentTextBox = new TextBox();
        this.SaveButton = new Button();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.AutoSize = true;
        this.panel1.Controls.Add(this.TitleTextBox);
        this.panel1.Controls.Add(this.TitleLabel);
        this.panel1.Dock = DockStyle.Top;
        this.panel1.Location = new Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(778, 31);
        this.panel1.TabIndex = 0;
        // 
        // TitleTextBox
        // 
        this.TitleTextBox.Dock = DockStyle.Top;
        this.TitleTextBox.Location = new Point(72, 0);
        this.TitleTextBox.Name = "TitleTextBox";
        this.TitleTextBox.ReadOnly = true;
        this.TitleTextBox.Size = new Size(706, 31);
        this.TitleTextBox.TabIndex = 1;
        // 
        // TitleLabel
        // 
        this.TitleLabel.AutoSize = true;
        this.TitleLabel.Dock = DockStyle.Left;
        this.TitleLabel.Location = new Point(0, 0);
        this.TitleLabel.Name = "TitleLabel";
        this.TitleLabel.Padding = new Padding(3);
        this.TitleLabel.Size = new Size(72, 31);
        this.TitleLabel.TabIndex = 0;
        this.TitleLabel.Text = "タイトル";
        this.TitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BookReviewContentLabel
        // 
        this.BookReviewContentLabel.AutoSize = true;
        this.BookReviewContentLabel.Dock = DockStyle.Top;
        this.BookReviewContentLabel.Location = new Point(0, 31);
        this.BookReviewContentLabel.Name = "BookReviewContentLabel";
        this.BookReviewContentLabel.Padding = new Padding(3);
        this.BookReviewContentLabel.Size = new Size(54, 31);
        this.BookReviewContentLabel.TabIndex = 1;
        this.BookReviewContentLabel.Text = "書評";
        // 
        // BookReviewContentTextBox
        // 
        this.BookReviewContentTextBox.Dock = DockStyle.Fill;
        this.BookReviewContentTextBox.Location = new Point(0, 62);
        this.BookReviewContentTextBox.Multiline = true;
        this.BookReviewContentTextBox.Name = "BookReviewContentTextBox";
        this.BookReviewContentTextBox.Size = new Size(778, 282);
        this.BookReviewContentTextBox.TabIndex = 2;
        // 
        // SaveButton
        // 
        this.SaveButton.Dock = DockStyle.Bottom;
        this.SaveButton.Location = new Point(0, 310);
        this.SaveButton.Name = "SaveButton";
        this.SaveButton.Size = new Size(778, 34);
        this.SaveButton.TabIndex = 4;
        this.SaveButton.Text = "保存";
        this.SaveButton.UseVisualStyleBackColor = true;
        this.SaveButton.Click += this.SaveButton_Click;
        // 
        // BookReviewForm
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(778, 344);
        this.Controls.Add(this.SaveButton);
        this.Controls.Add(this.BookReviewContentTextBox);
        this.Controls.Add(this.BookReviewContentLabel);
        this.Controls.Add(this.panel1);
        this.Name = "BookReviewForm";
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "書評";
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label TitleLabel;
    private TextBox TitleTextBox;
    private Label BookReviewContentLabel;
    private TextBox BookReviewContentTextBox;
    private Button SaveButton;
}