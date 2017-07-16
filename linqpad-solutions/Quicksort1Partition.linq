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

		var left = new List<int>();
		var right = new List<int>();
		var equal = new List<int>();

		for (int i = 0; i < ar.Length; i++)
		{
			if (ar[i] == pivot)
			{
				equal.Add(ar[i]);
			}
			else if (ar[i] > pivot) // right
			{
				right.Add(ar[i]);
			}
			else if (ar[i] < pivot) // left
			{
				left.Add(ar[i]);
			}
		}


		Console.WriteLine(String.Join(" ", left.Concat(equal).Concat(right)));
	}

	static void Main()
	{
		partition(new[] { 4, 5, 6, 2, 1 });
	}

	/* Tail starts here */
	static void Main(String[] args)
	{

//		int _ar_size;
//		_ar_size = Convert.ToInt32(Console.ReadLine());
//		int[] _ar = new int[_ar_size];
//		String elements = Console.ReadLine();
//		String[] split_elements = elements.Split(' ');
//		for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
//		{
//			_ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
//		}
//
//		partition(_ar);
	}
}