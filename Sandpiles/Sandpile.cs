using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandpiles
{
    public class Sandpile
    {
        public int[,] grains { get; private set; }
        int no_range;
        int size;

        public Sandpile(int [,] grains, int size, int no_range)
        {
            this.no_range = no_range;
            this.size = size;

            this.grains = new int[this.size, this.size];
            Array.Copy(topple(grains), this.grains, grains.Length);          
        }

        int[,] topple(int[,] gaps)
        {
            int[,] g = new int[this.size, this.size];
            Array.Copy(gaps, g, g.Length);

            bool isToppled = false;
            while (!isToppled)
            {
                isToppled = true;
                for (int i = 0; i < this.size; i++)
                {
                    for (int j = 0; j < this.size; j++)
                    {
                        if (g[i, j] >= this.no_range)
                        {
                            if (i > 0)
                            {
                                g[i - 1, j]++;
                            }
                            if (i < this.size - 1)
                            {
                                g[i + 1, j]++;
                            }
                            if (j > 0)
                            {
                                g[i, j - 1]++;
                            }
                            if (j < this.size - 1)
                            {
                                g[i, j + 1]++;
                            }
                            g[i, j] -= this.no_range;

                            isToppled = false;
                        }

                    }
                }
            }

            return g;
        }

        public Sandpile addTo(Sandpile sand2)
        {
            int[,] grid2 = sand2.grains;
            int[,] finalGrid = new int[this.size, this.size];
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    finalGrid[i, j] = this.grains[i, j] + grid2[i, j];
                }
            }
            return new Sandpile(finalGrid, this.size, this.no_range);
        }

        public bool equals(Sandpile sand2)
        {
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    if (sand2.grains[i, j] != this.grains[i, j])
                    {
                        return false;
                    }
                }
            }
                    return true;
        }

        public void print ()
        {
            for (int i=0; i<this.size; i++)
            {
                for (int j=0; j<this.size; j++)
                {
                    Console.Write("{0} ", this.grains[i, j]);
                }
                Console.WriteLine();
            }
           
        }
    }
}
