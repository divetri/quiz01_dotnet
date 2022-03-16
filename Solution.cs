namespace Quiz01
{
    public class Solution
    {
        public static void Soal1()
        {
            Random RandomClass = new Random();
            bool correct = false;
            int x = RandomClass.Next(1, 10);
            Console.WriteLine("Guess magic number between 1-20");
            while (!correct)
            {
                Console.Write("Enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == x)
                {
                    Console.WriteLine("Tebakan kamu benar, angka yang ditebak " + x + "Tebak lagi?");
                    string next = Console.ReadLine();
                    if (next == "y" | next == "Y")
                    {
                        Soal1();
                    }
                    else if (next == "n" | next == "N")
                    {
                        Console.WriteLine("You are quit.");
                        break;
                    }
                }
                else if (guess != x)
                {
                    if (guess < x)
                    {
                        Console.WriteLine("Your guess is too low");
                    }
                    else if (guess > x)
                    {
                        Console.WriteLine("Your guess is too high");
                    }
                }
            }
        }
        public static void Soal2()
        {
            List<int> list = new List<int>();
            bool correct = false;
            while (!correct)
            {
                Console.Write("Enter integer [type '0' for exit]: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number != 0)
                {
                    list.Add(number);
                }
                else
                {
                    int[] terms = list.ToArray();
                    Console.WriteLine("Angka Terbesar: " + terms.Max());
                }
            }
        }
        public static void Soal3()
        {
            Console.Write("Enter numbers: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int digit = 1;
            while (number/10 > 0)
            {
                digit++;
                number /= 10;
            }
            Console.WriteLine(digit);
        }
        public static void Soal4()
        {
            Console.Write("Enter numbers: ");
            string n = Console.ReadLine();

            for (int i = n.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(n[i]);
            }

        }
        public static void Soal5()
        {
            Console.Write("Enter numbers: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    continue;
                }
            }
        }
        public static void Soal6()
        {
            Console.Write("Enter numbers: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                int faktor = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        faktor++;
                        break;
                    }
                }
                if (faktor == 0 && i > 1)
                    Console.Write(i + " ");
            }
        }
        public static void Soal7()
        {
            int p = 0;
            Console.Write("Enter strings: ");
            string x = Console.ReadLine();
            string n = x.ToLower();
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == n[n.Length - 1 - i])
                {
                    p += 1;
                }

            }
            if (p == n.Length)
            {
                Console.Write("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public static void Soal8()
        {
            Console.Write("Enter strings: ");
            string x = Console.ReadLine();
            string n = x.ToLower();
            int v = 0;
            int c = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == 'a' || n[i] == 'i' || n[i] == 'u' || n[i] == 'e' || n[i] == 'o')
                {
                    v++;
                }
                else
                {
                    c++;
                }
            }
            Console.WriteLine($"total vowel {v}");
            Console.WriteLine($"total consonant {c}");
        }
        public static void Soal9()
        {
            int s = 1;
            Console.Write("Enter strings: ");
            string n = Console.ReadLine();
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == ' ')
                {
                    s++;
                }
            }
            Console.WriteLine($"total words {s}");
        }
        public static void Soal11()
        {
            DateTime today = DateTime.Today;
            Console.Write("Hari "+today.DayOfWeek+": ");
            Console.WriteLine(today.ToShortDateString());
            int jumat = ((int)DayOfWeek.Friday - (int)today.DayOfWeek + 7) % 7;
            Console.WriteLine(jumat+" hari lagi!");
        }
        public static void Soal12()
        {
            int i = 0;
            bool correct = false;
            Console.Write("Enter strings: ");
            string n = Console.ReadLine();
            string text = n;
            Console.Write("Find strings: ");
            string x = Console.ReadLine();
            while (!correct)
            {
                if (n.IndexOf(x) >= 0)
                {
                    i++;
                    int nextIndex = n.IndexOf(x) + x.Length;
                    n = n.Substring(nextIndex);
                }
                else
                {
                    correct = true;
                    Console.WriteLine("Total kata yang muncul: "+i+" Dari text: "+text);
                }
            }
        }
    }
}
