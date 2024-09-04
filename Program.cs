namespace SortingAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[] { 13, 46, 24, 52, 20, 9 };
            //var sortedarray = SelectionSort(myarray);
            //var sortedarray = BubbleSortOptimized(myarray);
            //var sortedarray = InsertionSort(myarray);
            //RecursiveBubbleSort(myarray, myarray.Length);
            RecursiveInsertionSort(myarray,0,myarray.Length);
            foreach (int i in myarray)
            {
                Console.WriteLine(i);
            }
        }

        static void RecursiveInsertionSort(int[] a, int i, int n)
        {
            if (i == n) return;

            int j = i;
            while (j > 0 && a[j-1] > a[j])
            {
                int temp = a[j - 1];
                a[j-1] = a[j];
                a[j] = temp;
                j--;
            }
            RecursiveInsertionSort(a, i+1, n);
        }

        static void RecursiveBubbleSort(int[] a, int n)
        {

            if (n == 1) return;

            bool swap = false;

            for(int i = 0; i <= n-2;  i++)
            {
                if (a[i] > a[i+1])
                {
                    int temp = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = temp;
                    swap = true;
                }
            }

            if(swap == false)
            {
                Console.WriteLine("No Swap");
                return;
            }

            RecursiveBubbleSort(a, n-1);

        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] InsertionSort(int[] a)
        {
            int n = a.Length;
            for(int i = 0; i <= n-1; i++)
            {
                int j = i;
                while(j > 0 && a[j - 1] > a[j])
                {
                    int temp = a[j-1];
                    a[j-1] = a[j];
                    a[j] = temp;
                    j--;
                }
            }
            return a;
        }
        static int[] BubbleSortOptimized(int[] a)
        {
            int n = a.Length;
            int didSwap = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                        didSwap = 1;
                    }
                }
                if (didSwap == 0)
                    break;
            }
            return a;
        }

        static int[] BubbleSort(int[] a)
        {
            int n = a.Length;
            for(int i = n-1; i >= 0; i--)
            {
                for(int j = 0; j <= i-1; j++)
                {
                    if (a[j] > a[j+1])
                    {
                        int temp = a[j+1];
                        a[j+1] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;
        }

        static int[] SelectionSort(int[] a)
        { 
            int n = a.Length;
            for(int i = 0; i <= n - 2; i++)
            {
                int min = i;

                for(int j = i; j <= n - 1; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                        
                    }

                    int temp = a[min];
                    a[min] = a[i];
                    a[i] = temp;
                }
                
            }

            return a;
        }
    }
}