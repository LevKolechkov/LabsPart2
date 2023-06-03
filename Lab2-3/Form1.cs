namespace Lab2_3
{
  public partial class Form1 : Form
  {
    Directory leftDirectory;
    Directory rightDirectory;

    public Form1()
    {
      InitializeComponent();
    }

    private string CallChange(string changeText)
    {
      leftDirectory = new Directory(leftDirectoryTextBox.Text, "Левая директория", nameOfFileTextBox.Text, null);
      rightDirectory = new Directory(rightDirectoryTextBox.Text, "Правая директория", nameOfFileTextBox.Text, leftDirectory);
      leftDirectory.brotherDirectory = rightDirectory;

      return leftDirectory.ChangeFile(changeText, false);
    }

    private string CallDelete()
    {
      leftDirectory = new Directory(leftDirectoryTextBox.Text, "Левая директория", nameOfFileTextBox.Text, null);
      rightDirectory = new Directory(rightDirectoryTextBox.Text, "Правая директория", nameOfFileTextBox.Text, leftDirectory);
      leftDirectory.brotherDirectory = rightDirectory;

      return leftDirectory.DeleteFile(false);
    }

    private string CallCreate()
    {
      leftDirectory = new Directory(leftDirectoryTextBox.Text, "Левая директория", nameOfFileTextBox.Text, null);
      rightDirectory = new Directory(rightDirectoryTextBox.Text, "Правая директория", nameOfFileTextBox.Text, leftDirectory);
      leftDirectory.brotherDirectory = rightDirectory;

      return leftDirectory.CreateFile(false);
    }

    private void changeButton_Click(object sender, EventArgs e)
    {
      stateTextBox.Visible = true;
      stateTextBox.Text = CallChange(writeTextBox.Text);
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
      stateTextBox.Visible = true;
      stateTextBox.Text = CallDelete();
    }

    private void createButton_Click(object sender, EventArgs e)
    {
      stateTextBox.Visible = true;
      stateTextBox.Text = CallCreate();
    }
  }
}