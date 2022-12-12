namespace StringLibrary;
public class Matrix
    {
        private int [,] matrix;
        int m, n;

        public int Sum1 = 0;
        public int Sum2 = 0;
        public int FullSum = 0;

        public Matrix()
        {

        }
        public void GenerateMatrix1 (int M1, int N1)
        {
            m = M1; n = N1;

            Random r = new Random();

            matrix = new int[M1, N1];

            for (int i = 0; i < M1; i++)
                for (int j = 0; j < N1; j++)
                    matrix[i, j] = r.Next(100, 999);
        }
        public void GenerateMatrix2 (int M2, int N2)
        {
            m = M2; n = N2;

            Random r = new Random();

            matrix = new int[M2, N2];

            for (int i = 0; i < M2; i++)
                for (int j = 0; j < N2; j++)
                    matrix[i, j] = r.Next(100, 999);
        }

        public void MatrixSave(string pFileName)
        {
            if (matrix.Length > 0)
            {
                if (File.Exists(pFileName))
                    File.Delete(pFileName);

                FileInfo f = new FileInfo(pFileName);
                TextWriter tw = f.CreateText();

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                        tw.Write("{0} ", matrix[i, j]);

                    tw.WriteLine();
                }

                tw.Close();
            }
        }

        public Boolean LoadMatrixNeededNums1(string pFileName)
        {
            if (File.Exists(pFileName))
            {
                try
                {
                    TextReader tr = File.OpenText(pFileName);
                    string StrNum;
                    string[] SubStr;
                    
                    for(int i = 0; i < n; i++ )
                    {
                    StrNum = tr.ReadLine();
                    SubStr = StrNum.Split(new char[] {' '}, n);
                    Sum1 += Convert.ToInt32(SubStr[n-i-1]);
                    if (i % 2 != 0)
                    {
                        for(int j = 0; j < n; j++)
                            if (SubStr[j] != SubStr[n-i-1])
                                Sum1 += Convert.ToInt32(SubStr[j]);
                    }                    
                    }
                    tr.Close();

                    return true;                 
                }
                catch
                {
                    return false;
                }

            }

            return false;
        }
                public Boolean LoadMatrixNeededNums2(string pFileName)
        {
            if (File.Exists(pFileName))
            {
                try
                {
                    TextReader tr = File.OpenText(pFileName);
                    string StrNum;
                    string[] SubStr;
                    
                    for(int i = 0; i < n; i++ )
                    {
                    StrNum = tr.ReadLine();
                    SubStr = StrNum.Split(new char[] {' '}, n);
                    Sum2 += Convert.ToInt32(SubStr[n-i-1]);
                    if (i % 2 != 0)
                    {
                        for(int j = 0; j < n; j++)
                            if (SubStr[j] != SubStr[n-i-1])
                                Sum2 += Convert.ToInt32(SubStr[j]);
                    }                    
                    }
                    tr.Close();

                    return true;                 
                }
                catch
                {
                    return false;
                }

            }

            return false;
        }

        public void PrintMatrix1()
        {
            if (matrix.Length > 0)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == m-1 && j == n-1)
                        {
                            Console.Write("{0}  ", matrix[i, j]);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write("{0}  ", matrix[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(Sum1);
                Console.WriteLine();
            }
        }
        public void PrintMatrix2()
        {
            if (matrix.Length > 0)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == m-1 && j == n-1)
                        {
                            Console.Write("{0}  ", matrix[i, j]);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write("{0}  ", matrix[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(Sum2);
                Console.WriteLine();
            }
        }

        public void printFullSum()
        {
            Console.WriteLine(Sum1+Sum2);
        }
        
    }

