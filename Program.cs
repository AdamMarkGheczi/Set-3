using System.Net;
using System.Reflection;

namespace Set_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul problemei, sau 0 pentru a opri programul: ");

            int n;
#pragma warning disable CS8604 // Possible null reference argument.
            n = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            while (n != 0)
            {
                CallMethod($"p{n}");
                Console.WriteLine("Introduceti numarul problemei, sau 0 pentru a opri programul: ");
                n = int.Parse(Console.ReadLine());
            }
        }

        public static void CallMethod(string method)
        {
            try
            {
                Type type = typeof(Program);
                MethodInfo methodInfo = type.GetMethod(method);
                methodInfo.Invoke(method, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadKey();
            }
        }

        public static void p1()
        {
            int n;
            Console.WriteLine("Introduceti n");
#pragma warning disable CS8604 // Possible null reference argument.
            n = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += t[i];
            }

            Console.WriteLine($"Suma elementelor este {sum}");
        }

        public static void p2()
        {
            int n;
            Console.WriteLine("Introduceti n");
#pragma warning disable CS8604 // Possible null reference argument.
            n = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t[i] = int.Parse(Console.ReadLine());
            }

            int k;
            Console.WriteLine("Introduceti k");
            k = int.Parse(Console.ReadLine());

            int pos = -1;

            for (int i = 0; i < n; i++)
            {
                if(t[i] == k)
                {
                    pos = i;
                    break;
                }
            }

            Console.WriteLine($"{k} apare la indexul {pos}");

        }

        public static void p3()
        {
            // 3n/2 comparatii

            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t[i] = int.Parse(Console.ReadLine());
            }



            if(n == 1)
            {
                Console.WriteLine("Minimul apare la indexul 0, iar maximul la indexul 0");
            }
            else
            {
                int min = t[0], max = t[0];
                int minIndex = 0, maxIndex = 0;

                if (t[0] > t[1])
                {
                    max = t[0];
                    min = t[1];
                    maxIndex = 0;
                    minIndex = 1;
                }
                else
                {
                    max = t[1];
                    min = t[0];
                    maxIndex = 1;
                    minIndex = 0;
                }

                int i;

                for (i = 2; i <= n - 2; i+=2)
                {
                    if (t[i] > t[i+1])
                    {
                        if (t[i] > max)
                        {
                            max = t[i];
                            maxIndex = i;
                        }

                        if (t[i+1] < min)
                        {
                            min = t[i+1];
                            minIndex = i+1;
                        }
                    }
                    else
                    {
                        if (t[i+1] > max)
                        {
                            max = t[i+1];
                            maxIndex = i+1;
                        }

                        if (t[i] < min)
                        {
                            min = t[i];
                            minIndex = i;
                        }
                    }
                }

                if(i != n)
                {
                    if (t[i+1] > max)
                    {
                        max = t[i+1];
                        maxIndex = i+1;
                    }

                    if (t[i + 1] < min)
                    {
                        min = t[i+1];
                        minIndex = i+1;
                    }
                }


            Console.WriteLine($"Minimul apare la indexul {minIndex}, iar maximul la indexul {maxIndex}");
            }

        }

        public static void p4()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t[i] = int.Parse(Console.ReadLine());
            }

            int max = t[0], min = t[0], minCount = 0, maxCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (t[i] == min) minCount++;
                if (t[i] == max) maxCount++;
                
                if (t[i] < min)
                {
                    min = t[i];
                    minCount = 1;
                }

                if (t[i] > max)
                {
                    max = t[i];
                    maxCount = 1;
                }
            }

            Console.WriteLine($"Minimul este {min} care apare de {minCount} ori");
            Console.WriteLine($"Maximul este {max} care apare de {maxCount} ori");
        }

        public static void p5()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] t1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t1[i] = int.Parse(Console.ReadLine());
            }

            int e, k;

            Console.WriteLine("Introduceti valoarea e");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti pozitia k");
            k = int.Parse(Console.ReadLine());

            int[] t2 = new int[n+1];


            for (int i = 0; i < k; i++)
                t2[i] = t1[i];

            t2[k] = e;

            for (int i = k; i < n; i++)
                t2[i + 1] = t1[i];

            for (int i = 0; i < n+1; i++)
            {
                Console.Write($"{t2[i]} ");
            }

            Console.WriteLine();
        }

        public static void p6()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] t1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduceti pozitia k");
            int k = int.Parse(Console.ReadLine());

            int[] t2 = new int[n-1];


            for (int i = 0; i < k; i++)
                t2[i] = t1[i];

            for (int i = k+1; i < n; i++)
                t2[i - 1] = t1[i];

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write($"{t2[i]} ");
            }

            Console.WriteLine();
        }

        public static void p7()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < n/2; i++)
            {
                int temp;
                temp = t[i];
                t[i] = t[n-i-1];
                t[n-i-1] = temp;
            }


            for (int i = 0; i < n; i++)
            {
                Console.Write($"{t[i]} ");
            }

            Console.WriteLine();
        }

        public static void p8()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t[i] = int.Parse(Console.ReadLine());
            }

            int temp = t[0];


            for (int i = 0; i < n-1; i++)
                t[i] = t[i + 1];


            t[n - 1] = temp;


            for (int i = 0; i < n; i++)
            {
                Console.Write($"{t[i]} ");
            }

            Console.WriteLine();
        }

        public static void p9()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Introduceti k");
            int k = int.Parse(Console.ReadLine());
            k %= n;

            int[] temp = new int[k];

            for (int i = 0; i < k; i++)
                temp[i] = t[i];


            for (int i = 0; i < n - k; i++)
                t[i] = t[i + k];

            for (int i = 0; i < k; i++)
                t[n-k+i] = temp[i];


            for (int i = 0; i < n; i++)
            {
                Console.Write($"{t[i]} ");
            }

            Console.WriteLine();
        }

        public static void p10()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Introduceti termenul cautat");
            int k = int.Parse(Console.ReadLine());

            int left = 0, right = n-1;

            int index = -1;

            while (right - left > 1)
            {
                if (t[(left + right) / 2] < k)
                {
                    left = (left + right) / 2;
                } else
                {
                    right = (right + left) / 2;
                }

                if (t[left] == k)
                {
                    index = left;
                    break;
                }
                if (t[right] == k)
                {
                    index = right;
                    break;
                }
            }
            

            Console.WriteLine($"{k} a fost gasit la indexul {index}");
        }

        public static void p11()
        {
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            
            int[] t = new int[n+1];
            for (int i = 0; i <= n; i++) t[i] = i;

            for (int i = 2; i <= n; i++)
            {
                if (t[i] != 0)
                {
                    for (int j = i*2; j <= n; j+=i)
                        t[j] = 0;
                }


            }

            for (int i = 2; i <= n; i++)
            {
                if (t[i] != 0)
                {
                    Console.Write($"{t[i]} ");
                }
            }

            Console.WriteLine();
        }

        public static void p12()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t[i] = int.Parse(Console.ReadLine());
            }

            int minIndex;
            for (int i = 0; i < n; i++)
            {
                minIndex = i;
                for (int j = i; j < n; j++)
                    if (t[j] < t[minIndex]) minIndex = j;

                int temp = t[i];
                t[i] = t[minIndex];
                t[minIndex] = temp;
            }

            for (int i = 0; i < n; i++)
                Console.Write($"{t[i]} ");

            Console.WriteLine();
        }

        public static void p13()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < n; i++)
            {
                int j = i;

                while(j > 0 && t[j - 1] > t[j])
                {
                    int temp = t[j];
                    t[j] = t[j - 1];
                    t[j - 1] = temp;

                    j--;
                }

            }

            for (int i = 0; i < n; i++)
                Console.Write($"{t[i]} ");

            Console.WriteLine();
        }

        public static void p14()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t[i] = int.Parse(Console.ReadLine());
            }

            int endPosition = n;

            for (int i = 0; i < endPosition; i++)
            {
                if (t[i] == 0)
                {
                    for (endPosition = endPosition - 1; endPosition > 0 && t[endPosition] == 0; endPosition--) ;
                    int temp = t[i];
                    t[i] = t[endPosition];
                    t[endPosition] = temp;
                }

            }

            for (int i = 0; i < n; i++)
                Console.Write($"{t[i]} ");

            Console.WriteLine();
        }

        public static void p15()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t[i] = int.Parse(Console.ReadLine());
            }

            int subtracted = 0;

            for (int i = 0; i < n - subtracted; i++)
            {
                for (int j = i+1; j < n - subtracted; j++)
                {
                    if (t[j] == t[i])
                    {
                        for (int k = j; k < n-subtracted-1; k++)
                        {
                            t[k] = t[k + 1];
                        }

                        subtracted++;
                    }
                }
            }

            for (int i = 0; i < n - subtracted; i++)
                Console.Write($"{t[i]} ");

            Console.WriteLine();
        }

        public static void p16()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t[i] = int.Parse(Console.ReadLine());
            }

            int gcd = t[0];

            int r = gcd;
            for (int i = 1; i < n; i++)
            {
                while ((gcd % t[i]) > 0)
                {
                    r = gcd % t[i];
                    gcd = t[i];
                    t[i] = r;
                }

                gcd = r;
            }


            Console.WriteLine($"Cel mai mare divizor comun este {gcd}");
        }

        public static void p17()
        {
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti b");
            int b = int.Parse(Console.ReadLine());

            int[] digits = new int[(int)Math.Log(n, b) + 1];

            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = n % b;
                n /= b;
            }


            for (int i = digits.Length-1; i >= 0; i--)
            {
                if (digits[i] < 10) Console.Write(digits[i]);
                else
                {
                    switch(digits[i])
                    {
                        case 10:
                            Console.Write("A");
                            break;

                        case 11: 
                            Console.Write("B");
                            break;

                        case 12:
                            Console.Write("C");
                            break;

                        case 13:
                            Console.Write("D");
                            break;

                        case 14:
                            Console.Write("E");
                            break;

                        case 15:
                            Console.Write("F");
                            break;

                    }
                }
            }

            Console.WriteLine();
        }

        public static void p18()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] t = new int[n+1];

            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine("Introduceti coeficientul");
                t[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduceti x");
            int x = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n + 1; i++)
                sum += (int)Math.Pow(x, i) * t[i];

            Console.WriteLine($"Valoarea polinomului in {x} este {sum}");
        }

        public static void p19()
        {
            
        }
    }
}