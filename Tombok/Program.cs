﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
	class Program
	{
		static void Main(string[] args)
		{
			Program prog = new Program();
			//prog.Arrays();
			prog.Squares();


			Console.ReadKey();
		}
		
		private void Arrays()
		{
			int[] tomb1 = new int[100];
			int[] tomb2 = new int[200];

			Random r = new Random(0);
			for (int i = 0; i < tomb1.Length; i++)
			{
				tomb1[i] = r.Next(0, 1000);
			}
			for (int i = 0; i < tomb2.Length; i++)
			{
				tomb2[i] = r.Next(0, 1000);
			}
			Array.Sort(tomb1);
			Array.Sort(tomb2);
			int[] tomb3 = new int[tomb1.Length + tomb2.Length];
			int j = 0;
			int k = 0;
			for (int i = 0; i < tomb3.Length; i++)
			{
				if (tomb2.Length > k && tomb1.Length > j)
				{
					if (tomb1[j] < tomb2[k])
					{
						tomb3[i] = tomb1[j];
						j++;

					}
					else if (tomb1[j] == tomb2[k])
					{
						tomb3[i] = tomb2[k];
						tomb3[i + 1] = tomb1[j];
						k++;
						j++;
						i++;

					}
					else if (tomb1[j] > tomb2[k])
					{
						tomb3[i] = tomb2[k];
						k++;
					}
				}
			}
			for (int i = 0; i < tomb3.Length; i++)
			{
				Console.WriteLine($"{i}-{tomb3[i]}");
			}
		}

		private void Squares()
		{
			int[] squares = new int[100];
			List<int> remainder0 = new List<int>();
			List<int> remainder1 = new List<int>();
			List<int> remainder2 = new List<int>();

			for (int i = 0; i < squares.Length; i++)
			{
				squares[i] = (i+1)*(i+1);
				if (squares[i] % 3 == 0)
				{
					remainder0.Add(squares[i]);
				}
				if (squares[i] % 3 == 1)
				{
					remainder1.Add(squares[i]);
				}
				if (squares[i] % 3 == 2)
				{ 
					remainder2.Add(squares[i]);
				}
				//Console.WriteLine(squares[i]);
			}
		}
	}
}
