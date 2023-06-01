using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
  public class Directory
  {
    public string Direction { get; private set; }
    public string Name { get; private set; }
    public string NameOfFile { get; private set; }
    public Directory brotherDirectory { get; private set; }

    public Directory(string direction, string name, string nameOfFile, Directory broodaDirectory)
    {
      Name = name;
      NameOfFile = nameOfFile;
      Direction = direction + '\\' + nameOfFile;
      brotherDirectory = broodaDirectory;
    }

    public bool CheckIfFileExist()
    {
      if (File.Exists(this.Direction)) 
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public string ChangeFile(string changeText, bool recursionIsGoing)
    {
      if (!this.CheckIfFileExist())
      {
        return "Файла не существует";
      }
      else
      {
        File.WriteAllText(this.Direction, changeText);

        if (recursionIsGoing)
        {
          return $"Файл в директории под именем {this.brotherDirectory.Name} и {this.Name} изменён";
        }
        else
        {
          brotherDirectory.ChangeFile(changeText, true);
        }
      }

      return "Непредвиденная ошибка";
    }


    public string DeleteFile(bool recursionIsGoing) 
    {
      if (!this.CheckIfFileExist())
      {
        return "Файла не существует";
      }

      else 
      {
        File.Delete(this.Direction);

        if (recursionIsGoing)
        {
          return $"Файл в директории под именем {this.brotherDirectory.Name} и {this.Name} удалён";
        }
        else
        {
          brotherDirectory.DeleteFile(true);
        }
      }

      return "Непредвиденная ошибка";
    }

    public string CreateFile(bool recursionIsGoing) 
    {
      if (this.CheckIfFileExist())
      {
        return "Файл уже существует";
      }
      else
      {
        File.Create(this.Direction);

        if (recursionIsGoing)
        {
          return $"Файл в директории под именем {this.brotherDirectory.Name} и {this.Name} создан";
        }
        else
        {
          brotherDirectory.CreateFile(true);
        }
      }

      return "Непредвиденная ошибка";
    }
  }
}
