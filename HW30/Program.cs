
Console.Write("Введите размер массива через пробел: ");
int[] sizeArray = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();



int[,] numbers = new int[sizeArray[0], sizeArray[1]];
FillArraySpiral(numbers);
FillPrint.FillPrint.PrintMassive(numbers);



void FillArraySpiral(int[,] array)
{


  // int count = 1;
  int size = array.GetLength(0) * array.GetLength(1);
  int jMax = array.GetLength(1);
  // int indexI;
  // int indexJ;
  int iMax = array.GetLength(0);
  int i = 0;
  int j = 0;
  int iMin = 1;
  int jMin = 0;
  int direction = 0; // 0 - горизонталь 1 вертикаль 2 обратная горизонталь 3 обратная вертикаль


  for (int count = 1; count <= size; count++)
  {
    array[i, j] = count;

    switch (direction)
    {

      case 0:
        j++;
        if (j == jMax - 1)
        {
          direction = 1;
          jMax--;
        }
        break;
      case 1:


        i++;
        if (i == iMax - 1)
        {
          direction = 2;
          iMax--;
        }
        break;

      case 2:
        j--;
        if (j == jMin)
        {
          direction = 3;
          jMin++;
        }
        break;

      case 3:
        i--;
        if (i == iMin)
        {
          direction = 0;
          iMin++;
        }
        break;
    }
  }

}