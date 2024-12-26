using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace Tyuiu.FrankoVA.Sprint7.Project.V9.Lib
{
    public class DataService
    {
        public string[,] LoadDataSet(string path)
        {
            string[] words = File.ReadAllLines(path, Encoding.Default);
            int columns = words[0].Split(';').Length;
            int rows = words.Length;
            string[,] basa = new string[rows, columns];
            for (int i = 0; i < words.Length; i++)
            {
                string numIndex = words[i];
                string[] numArray = numIndex.Split(';');
                for (int j = 0; j < numArray.Length; j++) basa[i, j] = numArray[j];
            }
            return basa;
        }
        public string[,] SortUbyv(string[,] basa, int column)
        {
            int[] door = new int[basa.GetLength(0) - 1];
            door[door.Length - 1] = Convert.ToInt32(basa[basa.GetLength(0) - 1, column]);
            for (int i = 0; i < door.Length - 1; i++)
            {
                door[i] = Convert.ToInt32(basa[i + 1, column]);
            }

            Array.Sort(door, (x, y) => y.CompareTo(x));

            string[,] SortedBasa = new string[basa.GetLength(0), basa.GetLength(1)];

            for (int i = 0; i < SortedBasa.GetLength(1); i++)
            {
                SortedBasa[0, i] = basa[0, i];
            }

            for (int i = 0; i < SortedBasa.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < basa.GetLength(0); j++)
                {
                    if (door[i] == Convert.ToInt32(basa[j, column]))
                    {
                        for (int c = 0; c < SortedBasa.GetLength(1); c++)
                        {
                            SortedBasa[i + 1, c] = basa[j, c];
                        }
                        basa[j, column] = "-1";
                        break;
                    }
                }
            }
            return SortedBasa;
        }


        public string[,] SortVozr(string[,] basa, int column)
        {
            int[] input = new int[basa.GetLength(0) - 1];
            input[input.Length - 1] = Convert.ToInt32(basa[basa.GetLength(0) - 1, column]);
            for (int i = 0; i < input.Length - 1; i++)
            {
                input[i] = Convert.ToInt32(basa[i + 1, column]);
            }
            Array.Sort(input, (x, y) => x.CompareTo(y));
            string[,] sortedmx = new string[basa.GetLength(0), basa.GetLength(1)];

            for (int i = 0; i < sortedmx.GetLength(1); i++)
            {
                sortedmx[0, i] = basa[0, i];
            }

            for (int i = 0; i < sortedmx.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < basa.GetLength(0); j++)
                {
                    if (input[i] == Convert.ToInt32(basa[j, column]))
                    {
                        for (int c = 0; c < sortedmx.GetLength(1); c++)
                        {
                            sortedmx[i + 1, c] = basa[j, c];
                        }
                        basa[j, column] = "-1";
                        break;
                    }
                }
            }
            return sortedmx;
        }
    }
}
