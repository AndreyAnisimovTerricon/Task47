int m = 3;
int n  = 4;
double[,] GetArray(int m, int n, double minValue, double maxValue) {
double[,] result = new double[m,n];
for( int i = 0;i < m;++i ) {
  for (int j =0;j < n;++j ) {
    result[i,j] = new Random().NextDouble()*100;
  }
}
return result;
}

 void PrintArray(double[,] array) {
    for (int i =0; i < array.GetLength(0);++i) {
        for (int j = 0; j < array.GetLength(1);++j) {
            Console.Write(Math.Round(array[i,j],1)+ " ");
            
        }
        Console.WriteLine();

    }
}
double[,] result = GetArray(m,n,-100,100);
PrintArray(result);