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
      writeTextBox = new TextBox();
      leftDirectoryTextBox = new TextBox();
      rightDirectoryTextBox = new TextBox();
      label2 = new Label();
      label3 = new Label();
      changeButton = new Button();
      createButton = new Button();
      deleteButton = new Button();
      stateTextBox = new TextBox();
      nameOfFileLabel = new Label();
      nameOfFileTextBox = new TextBox();
      SuspendLayout();
      // 
      // writeTextBox
      // 
      writeTextBox.Location = new Point(63, 60);
      writeTextBox.Multiline = true;
      writeTextBox.Name = "writeTextBox";
      writeTextBox.Size = new Size(665, 199);
      writeTextBox.TabIndex = 0;
      // 
      // leftDirectoryTextBox
      // 
      leftDirectoryTextBox.Location = new Point(63, 309);
      leftDirectoryTextBox.Name = "leftDirectoryTextBox";
      leftDirectoryTextBox.Size = new Size(277, 27);
      leftDirectoryTextBox.TabIndex = 2;
      leftDirectoryTextBox.Text = "C:\\";
      // 
      // rightDirectoryTextBox
      // 
      rightDirectoryTextBox.Location = new Point(450, 309);
      rightDirectoryTextBox.Name = "rightDirectoryTextBox";
      rightDirectoryTextBox.Size = new Size(277, 27);
      rightDirectoryTextBox.TabIndex = 3;
      rightDirectoryTextBox.Text = "D:\\";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(130, 285);
      label2.Name = "label2";
      label2.Size = new Size(137, 20);
      label2.TabIndex = 4;
      label2.Text = "Левая директория";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(521, 285);
      label3.Name = "label3";
      label3.Size = new Size(147, 20);
      label3.TabIndex = 5;
      label3.Text = "Правая директория";
      // 
      // changeButton
      // 
      changeButton.Location = new Point(63, 509);
      changeButton.Name = "changeButton";
      changeButton.Size = new Size(131, 61);
      changeButton.TabIndex = 6;
      changeButton.Text = "Изменить";
      changeButton.UseVisualStyleBackColor = true;
      changeButton.Click += changeButton_Click;
      // 
      // createButton
      // 
      createButton.Location = new Point(597, 509);
      createButton.Name = "createButton";
      createButton.Size = new Size(131, 61);
      createButton.TabIndex = 7;
      createButton.Text = "Создать";
      createButton.UseVisualStyleBackColor = true;
      createButton.Click += createButton_Click;
      // 
      // deleteButton
      // 
      deleteButton.Location = new Point(327, 509);
      deleteButton.Name = "deleteButton";
      deleteButton.Size = new Size(131, 61);
      deleteButton.TabIndex = 8;
      deleteButton.Text = "Удалить";
      deleteButton.UseVisualStyleBackColor = true;
      deleteButton.Click += deleteButton_Click;
      // 
      // stateTextBox
      // 
      stateTextBox.Location = new Point(161, 16);
      stateTextBox.Margin = new Padding(3, 4, 3, 4);
      stateTextBox.Name = "stateTextBox";
      stateTextBox.Size = new Size(490, 27);
      stateTextBox.TabIndex = 9;
      stateTextBox.Visible = false;
      // 
      // nameOfFileLabel
      // 
      nameOfFileLabel.AutoSize = true;
      nameOfFileLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      nameOfFileLabel.Location = new Point(115, 405);
      nameOfFileLabel.Name = "nameOfFileLabel";
      nameOfFileLabel.Size = new Size(175, 41);
      nameOfFileLabel.TabIndex = 10;
      nameOfFileLabel.Text = "Имя файла:";
      // 
      // nameOfFileTextBox
      // 
      nameOfFileTextBox.Location = new Point(450, 420);
      nameOfFileTextBox.Margin = new Padding(3, 4, 3, 4);
      nameOfFileTextBox.Name = "nameOfFileTextBox";
      nameOfFileTextBox.Size = new Size(277, 27);
      nameOfFileTextBox.TabIndex = 11;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 585);
      Controls.Add(nameOfFileTextBox);
      Controls.Add(nameOfFileLabel);
      Controls.Add(stateTextBox);
      Controls.Add(deleteButton);
      Controls.Add(createButton);
      Controls.Add(changeButton);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(rightDirectoryTextBox);
      Controls.Add(leftDirectoryTextBox);
      Controls.Add(writeTextBox);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
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