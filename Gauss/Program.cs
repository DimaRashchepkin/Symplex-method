using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;
using System.Linq.Expressions;

namespace Gauss
{
	internal class Program
	{
        private const string fileIn = "input.txt";
        private const string fileOut = "output.txt";
        private static StreamReader reader = new StreamReader(fileIn);
        private static StreamWriter writer = new StreamWriter(fileOut);
        public static int n, m;
        public static int[] indexes;
        public static float[,] matrix;

        static void Main(string[] args)
		{
			GetMatrix();
            float[,] result = Gauss.Count();

            for (int i = 0; i < n; i++)
			{
                for (int j = 0; j < m; j++)
                {
					writer.Write(result[i, j]);
                    writer.Write("\t");
                }
                writer.Write("\n");
            }

			reader.Close();
            writer.Close();
			return;
        }

		private static void GetMatrix()
		{
			int[] buffer;

			try
			{
				buffer = GetIntegerLine();
				if (buffer.Length != 2)
				{
					throw new FormatException("Wrong format");
				}
			}
			catch (FormatException err)
			{
				Console.WriteLine(err.Message);
				return;
			}
			n = buffer[0];
			m = buffer[1];

			try
			{	
				indexes = GetIntegerLine();
				if (indexes.Length == 0 || indexes.Length > m)
				{
					throw new FormatException("Wrong format: wrong indexes");
				}
			}
			catch (FormatException err)
			{
				Console.WriteLine(err.Message);
				return;
			}

			matrix = new float[n, m];
			for (int i = 0; i < n; i++)
			{
				try
				{
					buffer = GetIntegerLine();
					if (buffer.Length != m)
					{
						throw new FormatException("Wrong format");
					}
				}
				catch (FormatException err)
				{
					Console.WriteLine(err.Message);
					return;
				}
				for (int j = 0; j < m; j++)
				{
					matrix[i, j] = buffer[j];
				}
			}   
		}

		private static int[] GetIntegerLine()
		{
			int i, buf;
			int[] result;
			string? str = reader.ReadLine();
			if (str == null)
			{
				throw new FormatException("Wrong format: str null");
			}
			string[] strs = str.Split(' ');

			result = new int[strs.Length];
			for (i = 0; i < strs.Length; i++)
			{
				try
				{
					buf = Convert.ToInt32(strs[i]);
				}
				catch (FormatException)
				{
					throw;
				}
				result[i] = buf;
			}

			return result;
		}
	}
}
