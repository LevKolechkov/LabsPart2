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
      textBox1 = new TextBox();
      label1 = new Label();
      textBox2 = new TextBox();
      textBox3 = new TextBox();
      label2 = new Label();
      label3 = new Label();
      button1 = new Button();
      button2 = new Button();
      button3 = new Button();
      SuspendLayout();
      // 
      // textBox1
      // 
      textBox1.Location = new Point(63, 60);
      textBox1.Multiline = true;
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(664, 198);
      textBox1.TabIndex = 0;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(363, 21);
      label1.Name = "label1";
      label1.Size = new Size(50, 20);
      label1.TabIndex = 1;
      label1.Text = "label1";
      // 
      // textBox2
      // 
      textBox2.Location = new Point(63, 309);
      textBox2.Name = "textBox2";
      textBox2.Size = new Size(277, 27);
      textBox2.TabIndex = 2;
      // 
      // textBox3
      // 
      textBox3.Location = new Point(450, 309);
      textBox3.Name = "textBox3";
      textBox3.Size = new Size(277, 27);
      textBox3.TabIndex = 3;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(173, 286);
      label2.Name = "label2";
      label2.Size = new Size(50, 20);
      label2.TabIndex = 4;
      label2.Text = "label2";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(567, 286);
      label3.Name = "label3";
      label3.Size = new Size(50, 20);
      label3.TabIndex = 5;
      label3.Text = "label3";
      // 
      // button1
      // 
      button1.Location = new Point(63, 372);
      button1.Name = "button1";
      button1.Size = new Size(131, 61);
      button1.TabIndex = 6;
      button1.Text = "button1";
      button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      button2.Location = new Point(596, 372);
      button2.Name = "button2";
      button2.Size = new Size(131, 61);
      button2.TabIndex = 7;
      button2.Text = "button2";
      button2.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      button3.Location = new Point(330, 372);
      button3.Name = "button3";
      button3.Size = new Size(131, 61);
      button3.TabIndex = 8;
      button3.Text = "button3";
      button3.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(button3);
      Controls.Add(button2);
      Controls.Add(button1);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(textBox3);
      Controls.Add(textBox2);
      Controls.Add(label1);
      Controls.Add(textBox1);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox textBox1;
    private Label label1;
    private TextBox textBox2;
    private TextBox textBox3;
    private Label label2;
    private Label label3;
    private Button button1;
    private Button button2;
    private Button button3;
  }
}