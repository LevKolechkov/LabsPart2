using Lab_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab3.Tests
{
  [TestClass]
  public class Lab_3Tests
  {
    [TestMethod]
    public void TestGetSizeOfMatrix()
    {
      int expectedSizeOfMatrix = 3;
      SquareMatrix squareMatrix = new SquareMatrix(expectedSizeOfMatrix);

      int sizeOfMatrix = squareMatrix.SizeOfMatrix;

      Assert.AreEqual(expectedSizeOfMatrix, sizeOfMatrix);
    }

    [TestMethod]
    public void TestToString()
    {
      SquareMatrix squareMatrix = new SquareMatrix(3);
      string sqMatrix = "";
      string toCheckString = "";

      int length = squareMatrix.GetSizeOfMatrix();
      for (int rowIndex = 0; rowIndex < length; ++rowIndex)
      {
        for (int columnIndex = 0; columnIndex < length; ++columnIndex)
        {
          sqMatrix += squareMatrix.sqMatrix[rowIndex, columnIndex] + " ";
        }
      }

      Assert.IsTrue(sqMatrix.GetType() == toCheckString.GetType());
    }

    [TestMethod]
    public void TestClone()
    {
      int sizeOfMatrix = 3;
      SquareMatrix sqMatrix = new SquareMatrix(sizeOfMatrix);
      SquareMatrix expectedMatrix = new SquareMatrix(sizeOfMatrix);
      
      for (int rowIndex = 0; rowIndex < sizeOfMatrix; ++rowIndex) 
      {
        for (int columnIndex = 0; columnIndex < sizeOfMatrix; ++columnIndex)
        {
          sqMatrix.sqMatrix[rowIndex, columnIndex] = expectedMatrix.sqMatrix[rowIndex, columnIndex];
        }
      }

      bool equal = true;
      for (int rowIndex = 0; rowIndex < sizeOfMatrix; ++rowIndex)
      {
        if (!equal) break;

        for (int columnIndex = 0; columnIndex < sizeOfMatrix; ++columnIndex)
        {
          if (sqMatrix.sqMatrix[rowIndex, columnIndex] != expectedMatrix[rowIndex, columnIndex])
          {
            equal = false;
            break;
          }
        }
      }

      Assert.AreEqual(equal, true);
    }

    [TestMethod]
    public void TestEquals()
    {
      int sizeOfMatrix = 3;
      SquareMatrix squareMatrix = new SquareMatrix(sizeOfMatrix);
      SquareMatrix callSquarematrix = squareMatrix.Clone() as SquareMatrix;
      bool expectedResult = true;

      try
      {
        if ((squareMatrix == null) || !callSquarematrix.GetType().Equals(squareMatrix.GetType()))
        {
          throw new Exception("Сравнение невозможно");
        }

        SquareMatrix anotherSqNatrix = squareMatrix.Clone() as SquareMatrix;

        if (squareMatrix.GetSizeOfMatrix() != anotherSqNatrix.GetSizeOfMatrix())
        {
          throw new Exception("Размеры матрицы не равны");
        }

        int length = squareMatrix.GetSizeOfMatrix();

        for (int rowIndex = 0; rowIndex < length; ++rowIndex)
        {
          for (int columnIndex = 0; columnIndex < length; ++columnIndex)
          {
            if (callSquarematrix[rowIndex, columnIndex] != anotherSqNatrix[rowIndex, columnIndex])
            {
              expectedResult = false;
            }
          }
        }
      }

      catch (Exception e) 
      {
        Console.WriteLine(e.Message);
        expectedResult = false;
      }

      Assert.AreEqual (expectedResult, true);
    }

    [TestMethod]
    public void TestMatrixDecompose()
    {
      int sizeOfMatrix = 3;
      SquareMatrix aloneSqMatrix = new SquareMatrix(sizeOfMatrix);
      SquareMatrix sqMatrix = new SquareMatrix(sizeOfMatrix);
      int[,] toRememberMatrix = sqMatrix.sqMatrix;

      Random random = new Random();

      int[] swapArray = new int[sizeOfMatrix];
      int toggle;

      for (int rowIndex = 0;  rowIndex < sizeOfMatrix; ++rowIndex) 
      {
        swapArray[rowIndex] = random.Next(-1000, 1000);
      }

      toggle = 1;

      for (int mainValueCoordinate = 0; mainValueCoordinate < sizeOfMatrix - 1; ++mainValueCoordinate)
      {
        int columnMax = Math.Abs(sqMatrix[mainValueCoordinate, mainValueCoordinate]);

        int permRow = mainValueCoordinate;

        for (int rowIndex = mainValueCoordinate + 1; rowIndex < sizeOfMatrix; ++rowIndex) 
        {
          if (sqMatrix[rowIndex, mainValueCoordinate] > columnMax)
          {
            columnMax = sqMatrix[rowIndex, mainValueCoordinate];

            permRow = rowIndex;
          }
        }

        if (permRow != mainValueCoordinate)
        {
          for (int columnIndex = 0; columnIndex < sizeOfMatrix; ++columnIndex)
          {
            sqMatrix[permRow, columnIndex] = sqMatrix[mainValueCoordinate, columnIndex];
            sqMatrix[mainValueCoordinate, columnIndex] = sqMatrix[permRow, columnIndex];
          }
          swapArray[mainValueCoordinate] = swapArray[permRow];
          swapArray[permRow] = swapArray[mainValueCoordinate];
        }

        for (int rowIndex = mainValueCoordinate + 1; rowIndex < sizeOfMatrix; ++rowIndex)
        {
          sqMatrix[rowIndex, mainValueCoordinate] /= sqMatrix[mainValueCoordinate, mainValueCoordinate];
          for (int columnIndex = mainValueCoordinate + 1; columnIndex < sizeOfMatrix; ++columnIndex)
          {
            sqMatrix[rowIndex, columnIndex] -= sqMatrix[mainValueCoordinate, mainValueCoordinate] * sqMatrix[mainValueCoordinate, columnIndex];
          }
        }
      }
      Assert.AreEqual(sqMatrix.sqMatrix, toRememberMatrix);
    }

    [TestMethod]
    public void TestGetHashCode()
    {
      int sizeOfMatrix = 3;
      SquareMatrix squareMatrix = new SquareMatrix(sizeOfMatrix);

      int squareMatrixHashCode = squareMatrix.GetHashCode();
      int expectedHashCode = int.Parse(ToString());

      Assert.AreEqual(expectedHashCode, squareMatrixHashCode);
    }

    [TestMethod]
    public void TestDeterminant()
    {
      int sizeOfMatrix = 3;
      SquareMatrix callSquareMatrix = new SquareMatrix(sizeOfMatrix);
      SquareMatrix squareMatrix = SquareMatrix.MatrixDecompose(callSquareMatrix, out int[] perm, out int toggle);

      int length = squareMatrix.GetSizeOfMatrix();

      if (squareMatrix == null)
      {
        throw new Exception("Ошибка определения матрицы");
      }

      int result = toggle;

      for (int mainValueCoordinate = 0; mainValueCoordinate < length; ++mainValueCoordinate) 
      {
        result *= squareMatrix[mainValueCoordinate, mainValueCoordinate];
      }

      Assert.AreEqual(result, squareMatrix.Determinant());
    }

    [TestMethod]
    public void TestInverse()
    {
      int sizeOfMatrix = 3;
      SquareMatrix squareMatrix = new SquareMatrix(sizeOfMatrix);
      bool isGood = true;

      int length = squareMatrix.GetSizeOfMatrix();

      int[,] inverse = new int[length, length];

      for (int rowIndex = 0; rowIndex < length; ++rowIndex) 
      {
        int main = rowIndex;

        int max = Math.Abs(squareMatrix[rowIndex, 0]);

        for (int columnIndex = rowIndex + 1; columnIndex < length; ++columnIndex)
        {
          int Abs = Math.Abs(squareMatrix[rowIndex, columnIndex]);

          if (Abs > max)
          {
            main = columnIndex;

            max = Abs;
          }
        }

        if (main != rowIndex)
        {
          for (int columnIndex = 0; columnIndex < length; ++columnIndex)
          {
            int temp = squareMatrix[rowIndex, columnIndex];
            squareMatrix[rowIndex, columnIndex] = squareMatrix[main, columnIndex];
            squareMatrix[main, columnIndex] = temp;

            temp = inverse[rowIndex, columnIndex];
            inverse[rowIndex, columnIndex] = inverse[main, columnIndex];
            inverse[main, columnIndex] = temp;
          }
        }

        int mainValue = squareMatrix[rowIndex, rowIndex];

        for (int columnIndex = rowIndex; columnIndex < length; ++columnIndex)
        {
          squareMatrix[rowIndex, columnIndex] /= mainValue;
        }

        for (int columnIndex = 0; columnIndex < length; ++columnIndex)
        {
          if (columnIndex != rowIndex)
          {
            int factor = squareMatrix[columnIndex, rowIndex];

            for (int thirdValue = rowIndex; thirdValue < length; ++thirdValue)
            {
              squareMatrix[columnIndex, thirdValue] -= factor * inverse[rowIndex, thirdValue];
            }

            for (int thirdValue = 0; thirdValue < length; ++thirdValue)
            {
              inverse[columnIndex, rowIndex] -= factor * inverse[rowIndex, thirdValue];
            }
          }
        }

        Assert.AreEqual(isGood, true);
      }
    }
  }
}
