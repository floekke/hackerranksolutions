<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.IO</Namespace>
</Query>

class Solution
{
	static void partition(int[] ar)
	{
		var pivot = ar[0];

		var left = new int[] { };
		var right = new int[] { };
		var equal = new int[] { };

		for (int i = 0; i < ar.Length; i++)
		{
			if (ar[i] == pivot)
			{
				equal[equal.Length] = ar[i];
			}
			else if (ar[i] > pivot) // right
			{
				right[equal.Length] = ar[i];
			}
			else if (ar[i] < pivot) // left
			{
				left[equal.Length] = ar[i];
			}
		}

	}

	static void Main()
	{

	}

	static void Print(object[] os)
	{
		foreach (var o in os)
		{
			Console.WriteLine(o);
		}
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

		partition(_ar);
	}
}