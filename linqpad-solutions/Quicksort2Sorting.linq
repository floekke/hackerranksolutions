<Query Kind="Program">
  <NuGetReference>BenchmarkDotNet</NuGetReference>
  <Namespace>System</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.IO</Namespace>
</Query>

class Solution
{
	static List<int> QuickSort(List<int> ar)
	{
		if (ar.Count == 0 || ar.Count == 1)
			return ar;

		var p = Partition(ar);

		var left = QuickSort(p.Item1);
		left.Add(p.Item2);

		var right = QuickSort(p.Item3);

		return Merge(left, right);
	}

	static List<int> Merge(List<int> left, List<int> right)
	{
		left.AddRange(right);
		return left;
	}

	static Tuple<List<int>, int, List<int>> Partition(List<int> ar)
	{
		var pivot = ar[0];

		var left = new List<int>();
		var right = new List<int>();

		for (int i = 0; i < ar.Count; i++)
		{
			if (ar[i] > pivot) // right
			{
				right.Add(ar[i]);
			}
			else if (ar[i] < pivot) left
			{
				left.Add(ar[i]);
			}
		}

		return Tuple.Create(left, pivot, right);
	}

	static void Main()
	{
		QuickSort(new List<int> { 4, 5, 6, 2, 1 }).Dump();
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

		QuickSort(_ar.ToList());
	}
}
