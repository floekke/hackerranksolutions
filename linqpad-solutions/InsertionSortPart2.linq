<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.IO</Namespace>
</Query>

class Solution
{
	static int[] InsertionSort(int[] ar)
	{
		for (int i = 0; i < ar.Length; i++)
		{
			InsertionSortInner(ar, i);
		}
		
		return ar;
	}

    // TODO: do
	static int[] InsertionSortInner(int[] ar, int soFar)
	{
		// ar contains sorted ++ unsorted element
		if(soFar == 0)  // e.g. 2
			return ar;

		var insert = ar[soFar];  // 2, 0

		for (int i = soFar - 1; i >= 0; i--)
		{
			if (ar[i] > insert) // only shift!
			{
				ar[i + 1] = ar[i]; // shift right
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
		}

		return ar;

	}

	static void Main()
	{
		PrintArray(InsertionSort(new[] { 3, 1, 2, 0, 10, 11, 45, 100 }));
	}

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

		InsertionSort(_ar);
	}

	static void PrintArray(int[] ar)
	{
		var s = string.Join(" ", ar.Select(x => x.ToString()));
		Console.WriteLine(s);
	}

}

