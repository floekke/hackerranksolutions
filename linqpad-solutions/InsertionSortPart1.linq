<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.Linq</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.IO</Namespace>
</Query>

class InsertionSortPart1
{

    // 
    public static int[] insertionSort(int[] ar)
    {
        // ar contains sorted ++ unsorted element

        var insert = ar[ar.Length - 1];

        for (int i = ar.Length - 2; i >= 0; i--)
        {
            if (ar[i] > insert) // only shift!
            {
                ar[i + 1] = ar[i]; // shift right
                PrintArray(ar);
            }
            else if (ar[i] < insert) // insert to right
            {
                ar[i + 1] = insert; 
                PrintArray(ar);
                break;
            }

            if (i == 0 && ar[i] > insert) // only insert
            {
                ar[i] = insert;
                PrintArray(ar);
                break;
            }
            else if(i == 0 && ar[i] < insert)
            {

            }
        }

        return ar;

    }

    static void PrintArray(int[] ar)
    {
        var s = string.Join(" ", ar.Select(x => x.ToString()));
        Console.WriteLine(s);
    }

    /* Tail starts here */
    static void Main(String[] args)
    {
        int _ar_size;
        _ar_size = Convert.ToInt32(Console.ReadLine());
        int[] _ar = new int[_ar_size];
        String elements = Console.ReadLine();
        String[] split_elements = elements.Split(' ');
        for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
        {
            _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
        }

        insertionSort(_ar);
    }

	static void Main()
	{
		insertionSort(new[] { 1, 2, 4, 0 });
	}
}