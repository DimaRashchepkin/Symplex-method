using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss
{
	internal class Gauss
	{
		private static float[,] result;

		public static float[,] Count()
		{
			result = new float[Program.n, Program.m];
			Array.Copy(Program.matrix, result, result.Length);
			// result = new float[Program.n, Program.m];

			for (int i = 0; i < Program.indexes.Length - 1; i++)
			{
				for (int j = i + 1; j < Program.indexes.Length; j++)
				{
					float koef = (float)result[j, Program.indexes[i]] / (float)result[i, Program.indexes[i]];
					SubtractLine(j, i, koef);
				}
			}

            for (int i = Program.indexes.Length - 1; i > 0; i--)
			{
				for (int j = i - 1; j >= 0 ; j--)
				{
					float koef = (float)result[j, Program.indexes[i]] / (float)result[i, Program.indexes[i]];
					SubtractLine(j, i, koef);
				}
			}

            return result;
		}

		private static void SubtractLine(int k, int l, float koef)
		{
			for (int i = 0; i < Program.m; i++)
			{
				result[k, i] -= result[l, i] * koef;
			}
		}
	}
}
