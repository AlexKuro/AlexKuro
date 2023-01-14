namespace Example;
class Program
{
    static void Main(string[] args)
    {
        string NumbersFox(int a, int b)
        {
            string result = String.Empty;
            for (int i = a; i <= b; i++)
            {
                result += $"{i}";
            }
            return result;
        }

        string NumbersRec(int a, int b)
        {
            if (a < b) return $"{a}" + NumbersRec(a + 1, b);
            else return String.Empty;
        }

        int PowerFox(int a, int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++) result *= a;
            return result;
        }

        int PowerRec(int a, int n)
        {
            return n == 0 ? 1 : PowerRec(a, n - 1) * a;
            /* if (n == 0) return 1;
            else return PowerRec(a, n - 1) * a; */
        }

        /*  Console.WriteLine(NumbersFox(1, 10));
         Console.WriteLine(NumbersRec(1, 10)); */

        /* Console.WriteLine(PowerFox(2, 10));
        Console.WriteLine(PowerRec(2, 10));
        */

        void Example1()
        {
            string path = "D:/GeekBrains";
            DirectoryInfo di = new DirectoryInfo(path);
            System.Console.WriteLine(di.CreationTime);
            FileInfo[] fi = di.GetFiles();

            for (int i = 0; i < fi.Length; i++)
            {
                System.Console.WriteLine(fi[i].Name);
            }
        }

        void CatalogInfo(string path, string index = "")
        {
            DirectoryInfo catalog = new DirectoryInfo(path);
            DirectoryInfo[] catalogs = catalog.GetDirectories();
            for (int i = 0; i < catalogs.Length; i++)
            {
                Console.WriteLine($"{index}{catalogs[i].Name}");
                CatalogInfo(catalogs[i].FullName, index + " ");
            }

            FileInfo[] files = catalog.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine($"{index}{files[i].Name}");
            }

        }

        //Example1();
       string path = "D:/GeekBrains";
       CatalogInfo(path);


    }
}
