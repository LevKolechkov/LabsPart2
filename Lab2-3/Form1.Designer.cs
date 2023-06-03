namespace Lab2_3
{
  partial class Form1
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
      this.writeTextBox = new System.Windows.Forms.TextBox();
      this.leftDirectoryTextBox = new System.Windows.Forms.TextBox();
      this.rightDirectoryTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.changeButton = new System.Windows.Forms.Button();
      this.createButton = new System.Windows.Forms.Button();
      this.deleteButton = new System.Windows.Forms.Button();
      this.stateTextBox = new System.Windows.Forms.TextBox();
      this.nameOfFileLabel = new System.Windows.Forms.Label();
      this.nameOfFileTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // writeTextBox
      // 
      this.writeTextBox.Location = new System.Drawing.Point(55, 45);
      this.writeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.writeTextBox.Multiline = true;
      this.writeTextBox.Name = "writeTextBox";
      this.writeTextBox.Size = new System.Drawing.Size(582, 150);
      this.writeTextBox.TabIndex = 0;
      // 
      // leftDirectoryTextBox
      // 
      this.leftDirectoryTextBox.Location = new System.Drawing.Point(55, 232);
      this.leftDirectoryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.leftDirectoryTextBox.Name = "leftDirectoryTextBox";
      this.leftDirectoryTextBox.Size = new System.Drawing.Size(243, 23);
      this.leftDirectoryTextBox.TabIndex = 2;
      this.leftDirectoryTextBox.Text = "С:";
      // 
      // rightDirectoryTextBox
      // 
      this.rightDirectoryTextBox.Location = new System.Drawing.Point(394, 232);
      this.rightDirectoryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rightDirectoryTextBox.Name = "rightDirectoryTextBox";
      this.rightDirectoryTextBox.Size = new System.Drawing.Size(243, 23);
      this.rightDirectoryTextBox.TabIndex = 3;
      this.rightDirectoryTextBox.Text = "D:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(114, 214);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(106, 15);
      this.label2.TabIndex = 4;
      this.label2.Text = "Левая директория";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(456, 214);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(114, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "Правая директория";
      // 
      // changeButton
      // 
      this.changeButton.Location = new System.Drawing.Point(55, 382);
      this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.changeButton.Name = "changeButton";
      this.changeButton.Size = new System.Drawing.Size(115, 46);
      this.changeButton.TabIndex = 6;
      this.changeButton.Text = "Изменить";
      this.changeButton.UseVisualStyleBackColor = true;
      this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
      // 
      // createButton
      // 
      this.createButton.Location = new System.Drawing.Point(522, 382);
      this.createButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.createButton.Name = "createButton";
      this.createButton.Size = new System.Drawing.Size(115, 46);
      this.createButton.TabIndex = 7;
      this.createButton.Text = "Создать";
      this.createButton.UseVisualStyleBackColor = true;
      this.createButton.Click += new System.EventHandler(this.createButton_Click);
      // 
      // deleteButton
      // 
      this.deleteButton.Location = new System.Drawing.Point(286, 382);
      this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.deleteButton.Name = "deleteButton";
      this.deleteButton.Size = new System.Drawing.Size(115, 46);
      this.deleteButton.TabIndex = 8;
      this.deleteButton.Text = "Удалить";
      this.deleteButton.UseVisualStyleBackColor = true;
      this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
      // 
      // stateTextBox
      // 
      this.stateTextBox.Location = new System.Drawing.Point(141, 12);
      this.stateTextBox.Name = "stateTextBox";
      this.stateTextBox.Size = new System.Drawing.Size(429, 23);
      this.stateTextBox.TabIndex = 9;
      this.stateTextBox.Visible = false;
      // 
      // nameOfFileLabel
      // 
      this.nameOfFileLabel.AutoSize = true;
      this.nameOfFileLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.nameOfFileLabel.Location = new System.Drawing.Point(101, 304);
      this.nameOfFileLabel.Name = "nameOfFileLabel";
      this.nameOfFileLabel.Size = new System.Drawing.Size(140, 32);
      this.nameOfFileLabel.TabIndex = 10;
      this.nameOfFileLabel.Text = "Имя файла:";
      // 
      // nameOfFileTextBox
      // 
      this.nameOfFileTextBox.Location = new System.Drawing.Point(394, 315);
      this.nameOfFileTextBox.Name = "nameOfFileTextBox";
      this.nameOfFileTextBox.Size = new System.Drawing.Size(243, 23);
      this.nameOfFileTextBox.TabIndex = 11;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(700, 439);
      this.Controls.Add(this.nameOfFileTextBox);
      this.Controls.Add(this.nameOfFileLabel);
      this.Controls.Add(this.stateTextBox);
      this.Controls.Add(this.deleteButton);
      this.Controls.Add(this.createButton);
      this.Controls.Add(this.changeButton);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.rightDirectoryTextBox);
      this.Controls.Add(this.leftDirectoryTextBox);
      this.Controls.Add(this.writeTextBox);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TextBox writeTextBox;
    private TextBox leftDirectoryTextBox;
    private TextBox rightDirectoryTextBox;
    private Label label2;
    private Label label3;
    private Button changeButton;
    private Button createButton;
    private Button deleteButton;
    private TextBox stateTextBox;
    private Label nameOfFileLabel;
    private TextBox nameOfFileTextBox;
  }
}