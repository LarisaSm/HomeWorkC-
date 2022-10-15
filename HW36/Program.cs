int[] data = new int[] { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = new int[] { 2, 3, 3, 1 };


FillPrint.FillPrint.PrintMassive(Function1(data, info));
System.Console.WriteLine();


int[] Function1(int[] data, int[] info)
{

  int count = 0;
  int[] result = new int[info.Length];
  for (int i = 0; i < info.Length; i++)
  {
    int[] bin = new int[info[i]];

    for (int j = 0; j < info[i]; j++)
    {

      bin[j] = data[count];
      count++;
    }
    result[i] = BinToDec(bin);
  }
  return result;
}


int BinToDec(int[] data)
{
  Array.Reverse(data);
  int result = 0;
  for (int i = 0; i < data.Length; i++)
  {
    result = data[i] * Convert.ToInt32(Math.Pow(2, i)) + result;
  }
  return result;
}



