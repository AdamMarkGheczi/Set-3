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
            // KMP substring search
            int i, j;

            int ns;
            Console.WriteLine("Introduceti ns");
            ns = int.Parse(Console.ReadLine());
            int[] s = new int[ns];

            for (i = 0; i < ns; i++)
            {
                Console.WriteLine("Introduceti termenul");
                s[i] = int.Parse(Console.ReadLine());
            }

            int np;
            Console.WriteLine("Introduceti np");
            np = int.Parse(Console.ReadLine());
            int[] p = new int[np];

            for (i = 0; i < np; i++)
            {
                Console.WriteLine("Introduceti termenul");
                p[i] = int.Parse(Console.ReadLine());
            }

            int[] T = new int[np];
            T[0] = 0;

            i = 1;
            j = 0;

            while (i < np)
            {
                if (p[i] == p[j])
                {
                    T[i] = j + 1;
                    i++;
                    j++;
                }
                else
                {
                    if (j == 0)
                    {
                        T[i] = 0;
                        i++;
                    }
                    else
                        j = T[j - 1];
                }
            }

            i = 0;
            j = 0;

            int count = 0;

            while (i < ns)
            {
                if (s[i] == p[j])
                {
                    if(j == np-1)
                    {
                        j = 0;
                        count++;
                    }
                    else
                    {
                        i++;
                        j++;
                    }
                }
                else
                {
                    if (j == 0)
                    {
                        i++;
                    }
                    else
                    {
                        j = T[j - 1];
                    }
                }
            
            }

            Console.WriteLine($"p apare {count} ori in s");

        }

        public static void p20()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            
            int[] s1 = new int[n];
            int[] s2 = new int[n];

            Console.WriteLine("s1");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                s1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("s2");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                s2[i] = int.Parse(Console.ReadLine());
            }

            for(int rotations = 0; rotations < n; rotations++)
            {
                int matches = 0;
                for(int i = 0; i < n; i++)
                {
                    if (s1[i] == s2[i]) matches++;
                }

                int temp = s1[0];
                for (int i = 0; i < n - 1; i++) s1[i] = s1[i + 1];
                s1[n - 1] = temp;

                Console.WriteLine($"Numarul de suprapuneri pentru {rotations} rotiri este {matches}");
            }

        }

        public static void p21()
        {
            int n1;
            Console.WriteLine("Introduceti n1");
            n1 = int.Parse(Console.ReadLine());
            int[] t1 = new int[n1];

            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t1[i] = int.Parse(Console.ReadLine());
            }

            int n2;
            Console.WriteLine("Introduceti n2");
            n2 = int.Parse(Console.ReadLine());
            int[] t2 = new int[n2];

            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t2[i] = int.Parse(Console.ReadLine());
            }

            bool equal = true;
            for(int i = 0; i < n1 && i < n2; i++)
            {
                if (t1[i] != t2[i])
                {
                    if (t1[i] < t2[i]) Console.WriteLine("t1 este primul");
                    else Console.WriteLine("t2 este primul");
                    equal = false;
                } 

            }

            if (equal) Console.WriteLine("t1 si t2 sunt egale");
        }

        public static void p22()
        {
            int n1;
            Console.WriteLine("Introduceti n1");
            n1 = int.Parse(Console.ReadLine());
            int[] v1 = new int[n1];

            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("Introduceti termenul");
                v1[i] = int.Parse(Console.ReadLine());
            }

            int n2;
            Console.WriteLine("Introduceti n2");
            n2 = int.Parse(Console.ReadLine());
            int[] v2 = new int[n2];

            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine("Introduceti termenul");
                v2[i] = int.Parse(Console.ReadLine());
            }

            int[] union = new int[n1+n2];
            int[] intersection = new int[Math.Min(n1, n2)];
            int[] difference1 = new int[n1];
            int[] difference2 = new int[n2];
            int ul = 0, il = 0, d1l = 0, d2l = 0;

            // reunire
            for (int i = 0; i < n1; i++)
            {
                bool contains = false;
                for(int j=0; j<ul; j++)
                    if (union[j] == v1[i])
                    {
                        contains = true;
                        break;
                    }

                if (!contains)
                {
                    union[ul] = v1[i];
                    ul++;
                }
            }

            for (int i = 0; i < n2; i++)
            {
                bool contains = false;
                for (int j = 0; j < ul; j++)
                    if (union[j] == v2[i])
                    {
                        contains = true;
                        break;
                    }

                if (!contains)
                {
                    union[ul] = v2[i];
                    ul++;
                }
            }

            // intersectia
            for (int i = 0; i < n1; i++)
            {
                bool contains = false;
                for (int j = 0; j < n2; j++)
                    if (v2[j] == v1[i])
                    {
                        contains = true;
                        break;
                    }

                if (contains)
                {
                    intersection[il] = v1[i];
                    il++;
                }
            }


            // diferenta1
            for (int i = 0; i < n1; i++)
            {
                bool contains = false;
                for (int j = 0; j < il; j++)
                    if (intersection[j] == v1[i])
                    {
                        contains = true;
                        break;
                    }

                if (!contains)
                {
                    difference1[d1l] = v1[i];
                    d1l++;
                }
            }

            // diferenta2
            for (int i = 0; i < n2; i++)
            {
                bool contains = false;
                for (int j = 0; j < il; j++)
                    if (intersection[j] == v2[i])
                    {
                        contains = true;
                        break;
                    }

                if (!contains)
                {
                    difference2[d2l] = v2[i];
                    d2l++;
                }
            }


            Console.Write("v1 reunit cu v2: ");
            for (int i = 0; i < ul; i++)
                Console.Write(union[i] + " ");

            Console.WriteLine();

            Console.Write("v1 intersectat cu v2: ");
            for (int i = 0; i < il; i++)
                Console.Write(intersection[i] + " ");

            Console.WriteLine();

            Console.Write("v1 - v2: ");
            for (int i = 0; i < d1l; i++)
                Console.Write(difference1[i] + " ");

            Console.WriteLine();

            Console.Write("v2 - v1: ");
            for (int i = 0; i < d2l; i++)
                Console.Write(difference2[i] + " ");

            Console.WriteLine();

        }

        public static void p23()
        {
            int n1;
            Console.WriteLine("Introduceti n1");
            n1 = int.Parse(Console.ReadLine());
            int[] v1 = new int[n1];

            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("Introduceti termenul");
                v1[i] = int.Parse(Console.ReadLine());
            }

            int n2;
            Console.WriteLine("Introduceti n2");
            n2 = int.Parse(Console.ReadLine());
            int[] v2 = new int[n2];

            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine("Introduceti termenul");
                v2[i] = int.Parse(Console.ReadLine());
            }

            int[] union = new int[n1 + n2];
            int[] intersection = new int[Math.Min(n1, n2)];
            int[] difference1 = new int[n1];
            int[] difference2 = new int[n2];
            int ul = 0, il = 0, d1l = 0, d2l = 0;

            // reunire
            int a=0, b=0;

            while (a < n1 && b < n2)
            {
                if (v1[a] == v2[b])
                {
                    union[ul] = v1[a];
                    a++;
                    b++;
                }
                else
                {
                    if (v1[a] < v2[b])
                    {
                        union[ul] = v1[a];
                        ul++;
                        a++;
                    }
                    else
                    {
                        union[ul] = v2[b];
                        ul++;
                        b++;
                    }
                }
            }

            for (; a < n1; a++)
            {
                union[ul] = v1[a];
                ul++;
            }

            for (; b < n2; b++)
            {
                union[ul] = v2[b];
                ul++;
            }

            // intersectie

            a = 0; b = 0;

            while (a < n1 && b < n2)
            {
                if (v1[a] == v2[b])
                {
                    intersection[il] = v1[a];
                    il++;
                    a++;
                    b++;
                }
                else
                {
                    if (v1[a] < v2[b]) a++;
                    else b++;
                }
            }

            // diferenta1

            a = 0; b = 0;
            while (a < n1 && b < il)
            {
                if (v1[a] == intersection[b])
                {
                    a++;
                    b++;
                }
                else
                {
                    if (v1[a] < intersection[b])
                    {
                        difference1[d1l] = v1[a];
                        d1l++;
                        a++;
                    }
                    else b++;
                }
            }

            for (; a < n1; a++)
            {
                difference1[d1l] = v1[a];
                d1l++;
            }

            // diferenta2

            a = 0; b = 0;
            while (a < n2 && b < il)
            {
                if (v2[a] == intersection[b])
                {
                    a++;
                    b++;
                }
                else
                {
                    if (v2[a] < intersection[b])
                    {
                        difference2[d2l] = v2[a];
                        d2l++;
                        a++;
                    }
                    else b++;
                }
            }

            for (; a < n2; a++)
            {
                difference2[d2l] = v2[a];
                d2l++;
            }

            Console.Write("v1 reunit cu v2: ");
            for (int i = 0; i < ul; i++)
                Console.Write(union[i] + " ");

            Console.WriteLine();

            Console.Write("v1 intersectat cu v2: ");
            for (int i = 0; i < il; i++)
                Console.Write(intersection[i] + " ");

            Console.WriteLine();

            Console.Write("v1 - v2: ");
            for (int i = 0; i < d1l; i++)
                Console.Write(difference1[i] + " ");

            Console.WriteLine();

            Console.Write("v2 - v1: ");
            for (int i = 0; i < d2l; i++)
                Console.Write(difference2[i] + " ");

            Console.WriteLine();
        }

        public static void p24()
        {
            int n1;
            Console.WriteLine("Introduceti n1 (valoarea maxima)");
            n1 = int.Parse(Console.ReadLine());
            int[] v1 = new int[n1+1];

            for (int i = 0; i <= n1; i++)
            {
                Console.WriteLine("Introduceti termenul (-1 = oprire)");
                int x = int.Parse(Console.ReadLine());
                if (x == -1) break;
                v1[x] = 1;
            }

            int n2;
            Console.WriteLine("Introduceti n2 (valoarea maxima)");
            n2 = int.Parse(Console.ReadLine());
            int[] v2 = new int[n2+1];

            for (int i = 0; i <= n1; i++)
            {
                Console.WriteLine("Introduceti termenul (-1 = oprire)");
                int x = int.Parse(Console.ReadLine());
                if (x == -1) break;
                v2[x] = 1;
            }

            int[] union = new int[Math.Max(n1+1, n2+1)];
            int[] intersection = new int[Math.Min(n1+1, n2+1)];
            int[] difference1 = new int[n1+1];
            int[] difference2 = new int[n2+1];

            // reunire
            for (int i = 0; i <= n1; i++)
                if (v1[i] == 1) union[i] = 1;

            for (int i = 0; i <= n2; i++)
                if (v2[i] == 1) union[i] = 1;

            // intersectia

            for (int i = 0; i <= n1; i++)
            {
                if(i <= n2)
                    if (v1[i] == 1 && v2[i] == 1) intersection[i] = 1;
            }

            // diferenta1

            for (int i = 0; i <= n1; i++)
            {
                if (i >= intersection.Length && v1[i] == 1) difference1[i] = 1;
                else
                    if (v1[i] == 1 && intersection[i] == 0) difference1[i] = 1;
            }

            // diferenta2

            for (int i = 0; i <= n2; i++)
            {
                if (i >= intersection.Length && v2[i] == 1) difference2[i] = 1;
                else
                    if (v2[i] == 1 && intersection[i] == 0) difference2[i] = 1;
            }

            Console.Write("v1 reunit cu v2: ");
            for (int i = 0; i < union.Length; i++)
                if (union[i] == 1) Console.Write(i + " ");

            Console.WriteLine();

            Console.Write("v1 intersectat cu v2: ");
            for (int i = 0; i < intersection.Length; i++)
                if (intersection[i] == 1) Console.Write(i + " ");

            Console.WriteLine();

            Console.Write("v1 - v2: ");
            for (int i = 0; i < difference1.Length; i++)
                if (difference1[i] == 1) Console.Write(i + " ");

            Console.WriteLine();

            Console.Write("v2 - v1: ");
            for (int i = 0; i < difference2.Length; i++)
                if (difference2[i] == 1) Console.Write(i + " ");

            Console.WriteLine();
        }

        public static void p25()
        {
            int n1;
            Console.WriteLine("Introduceti n1");
            n1 = int.Parse(Console.ReadLine());
            int[] v1 = new int[n1];

            for (int l = 0; l < n1; l++)
            {
                Console.WriteLine("Introduceti termenul");
                v1[l] = int.Parse(Console.ReadLine());
            }

            int n2;
            Console.WriteLine("Introduceti n2");
            n2 = int.Parse(Console.ReadLine());
            int[] v2 = new int[n2];

            for (int l = 0; l < n2; l++)
            {
                Console.WriteLine("Introduceti termenul");
                v2[l] = int.Parse(Console.ReadLine());
            }

            int[] v3 = new int[v1.Length + v2.Length];
            int k = 0;
            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j])
                {
                    v3[k] = v1[i];
                    i++;
                    k++;
                }
                else
                {
                    v3[k] = v2[j];
                    j++;
                    k++;
                }
            }

            while (i < v1.Length)
            {
                v3[k] = v1[i];
                i++;
                k++;
            }

            while (j < v2.Length)
            {
                v3[k] = v2[j];
                j++;
                k++;
            }

            Console.WriteLine();
            foreach (int x in v3) Console.Write(x + " ");
            Console.WriteLine();
        }

        public static void p26()
        {
            int n1;
            Console.WriteLine("Introduceti n1");
            n1 = int.Parse(Console.ReadLine());
            int[] v1 = new int[n1];

            for (int l = 0; l < n1; l++)
            {
                Console.WriteLine("Introduceti termenul");
                v1[l] = int.Parse(Console.ReadLine());
            }

            int n2;
            Console.WriteLine("Introduceti n2");
            n2 = int.Parse(Console.ReadLine());
            int[] v2 = new int[n2];

            for (int l = 0; l < n2; l++)
            {
                Console.WriteLine("Introduceti termenul");
                v2[l] = int.Parse(Console.ReadLine());
            }

            int[] sum = new int[Math.Max(n1, n2) + 1];
            int[] difference = new int[Math.Max(n1, n2)];
            int[] product = new int[n1 + n2];

            // suma
            int carry = 0;
            for (int i = n1 - 1, j = n2 - 1, k = sum.Length - 1; i >= 0 || j >= 0; i--, j--, k--)
            {
                if (i < 0)
                {
                    sum[k] = (v2[j] + carry) % 10;
                    carry = (v2[j] + carry) / 10;
                }
                if (j < 0)
                {
                    sum[k] = (v1[i] + carry) % 10;
                    carry = (v1[i] + carry) / 10;
                }
                if (i >= 0 & j >= 0)
                {
                    sum[k] = (v1[i] + v2[j] + carry) % 10;
                    carry = (v1[i] + v2[j] + carry) / 10;
                }

            }
            if (carry != 0) sum[0] = carry;
            if (sum[0] == 0)
            {
                int[] temp = new int[sum.Length - 1];
                for(int i = 0; i < temp.Length; i++) temp[i] = sum[i + 1];
                sum = temp;
            }

            // diferenta

            bool negativeResult = false;

            int[] temp1 = new int[n1];
            int[] temp2 = new int[n2];

            Array.Copy(v1, temp1, n1);
            Array.Copy(v2, temp2, n2);

            if (n1 < n2) negativeResult = true;
            else if (n1 == n2)
            {
                for (int i = 0; i < n1; i++)
                {
                    if (v1[i] != v2[i])
                    {
                        negativeResult = v1[i] < v2[i];
                        break;
                    }
                }
            }

            if(negativeResult) (temp1, temp2) = (temp2, temp1);

            for (int i = temp1.Length-1, j = temp2.Length - 1, k = difference.Length - 1; i >= 0 || j >= 0; i--, j--, k--)
            {
                if (j < 0) difference[k] = temp1[i];
                else if (temp1[i] < temp2[j])
                {
                    int l;
                    for (l = i - 1; temp1[l] == 0 && l >= 0; l--) temp1[l] = 9;
                    temp1[l]--;

                    difference[k] = temp1[i] - temp2[j] + 10;
                }
                else difference[k] = temp1[i] - temp2[j];
            }

            int leadingZeros = 0;
            for (leadingZeros = 0; leadingZeros < difference.Length && difference[leadingZeros] == 0; leadingZeros++);

            if(leadingZeros > 0)
            {
                int[] temp = new int[difference.Length - leadingZeros];
                for (int i = 0; i < temp.Length; i++) temp[i] = difference[i + leadingZeros];
                difference = temp;
            }

            // produs
            for (int i = n2 - 1; i >= 0; i--)
            {
                carry = 0;
                int k = product.Length - 1 - (n2 - 1 - i);
                for (int j = n1 - 1; j >= 0; j--, k--)
                {
                    int temp = (product[k] + v2[i] * v1[j] + carry);
                    product[k] = temp % 10;
                    carry = temp / 10;
                }
                for(; carry != 0; k--)
                {
                    int temp = product[k] + carry;
                    product[k] = temp % 10;
                    carry = temp / 10;
                }
            }
            if (product[0] == 0)
            {
                int[] temp = new int[product.Length - 1];
                for (int i = 0; i < temp.Length; i++) temp[i] = product[i + 1];
                product = temp;
            }

            Console.Write("a + b = ");
            foreach(int x in sum) Console.Write(x);
            Console.WriteLine();

            Console.Write("a - b = ");
            if (negativeResult) Console.Write("-");
            foreach (int x in difference) Console.Write(x);
            Console.WriteLine();

            Console.Write("a * b = ");
            foreach (int x in product) Console.Write(x);
            Console.WriteLine();
        }

        public static void p27()
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

            Console.WriteLine("Introduceti indexul");
            int index = int.Parse(Console.ReadLine());


            int element = 0;
            int count;
            for (int i = 0; i < n; i++)
            {
                count = 0;
                for (int j = 0; j < n; j++)
                    if (t[j] < t[i]) count++;

                if (count == index) 
                {
                    element = t[i];
                    break;
                }
            }

            Console.WriteLine($"Valoarea la indexul {index} dupa sortare este {element}");
        }

        public static void quicksort(int[] t, int left, int right)
        {
            if (right <= left) return;
            if (right - left == 1)
            {
                if (t[left] > t[right]) (t[left], t[right]) = (t[right], t[left]);
                return;
            }

            int pivot = (left + right) / 2;
            (t[pivot], t[right]) = (t[right], t[pivot]);

            int i = left, j = right - 1;

            while (i < j)
            {
                for (; i <= j && t[i] <= t[right]; i++) ;
                for (; i <= j && t[j] >= t[right]; j--) ;
                if (i < j)
                    (t[i], t[j]) = (t[j], t[i]);
            }

            (t[i], t[right]) = (t[right], t[i]);

            if (i == left) quicksort(t, left, right);
            else quicksort(t, left, i - 1);

            if (i == right) quicksort(t, left, right);
            else quicksort(t, i + 1, right);
        }
        public static void p28()
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

            quicksort(t, 0, n-1);

            Console.WriteLine("Sortat cu quicksort");
            foreach (int i in t) Console.Write(i + " ");
            Console.WriteLine();
        }

        public static int[] mergesort(int[] t)
        {
            if (t.Length == 1) return t;

            int[] t1 = new int[t.Length / 2 + t.Length % 2];
            int[] t2 = new int[t.Length / 2];

            int i, j;

            for (i = 0; i < t1.Length; i++) t1[i] = t[i];
            for (i = t1.Length, j = 0; i < t.Length; i++, j++) t2[j] = t[i];

            t1 = mergesort(t1);
            t2 = mergesort(t2);


            int[] t3 = new int[t1.Length + t2.Length];
            int k = 0;
            i = 0; j = 0;

            while (i < t1.Length && j < t2.Length)
            {
                if (t1[i] < t2[j])
                {
                    t3[k] = t1[i];
                    i++;
                    k++;
                }
                else
                {
                    t3[k] = t2[j];
                    j++;
                    k++;
                }
            }

            while (i < t1.Length)
            {
                t3[k] = t1[i];
                i++;
                k++;
            }

            while (j < t2.Length)
            {
                t3[k] = t2[j];
                j++;
                k++;
            }

            return t3;
        }
        public static void p29()
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

            t = mergesort(t);

            Console.WriteLine("Sortat cu mergesort");
            foreach (int i in t) Console.Write(i + " ");
            Console.WriteLine();
        }

        public static void p30()
        {
            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] E = new int[n];
            int[] W = new int[n];

            Console.WriteLine("E:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                E[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("W:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                W[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    if (E[j] > E[j+1])
                    {
                        (E[j], E[j + 1]) = (E[j + 1], E[j]);
                        (W[j], W[j + 1]) = (W[j + 1], W[j]);
                    }
                    else if (E[j] == E[j + 1] && W[j] < W[j + 1])
                    {
                        (E[j], E[j + 1]) = (E[j + 1], E[j]); // aceasta linie poate fi omisa
                        (W[j], W[j + 1]) = (W[j + 1], W[j]);
                    }
                }
            }

            Console.WriteLine();
            foreach (int i in E) Console.Write(i + " ");
            Console.WriteLine();
            foreach (int i in W) Console.Write(i + " ");
            Console.WriteLine();
        }

        public static void p31()
        {
            // Moore voting algorithm

            int n;
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti termenul");
                t[i] = int.Parse(Console.ReadLine());
            }

            int count = 1;
            int index = 0;

            for (int i = 1; i < n; i++)
            {
                if (count == 0) index = i;
                if (t[i] == t[index]) count++;
                else count--;
            }

            if (count == 0) Console.WriteLine("Nu exista element majoritate");
            else
            {
                count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (t[i] == t[index]) count++;
                }

                if (count <= n / 2) Console.WriteLine("Nu exista element majoritate");
                else Console.WriteLine($"Elementul majoritate este {t[index]}");
            }
        }
    }
}