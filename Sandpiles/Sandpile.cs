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


        public Sandpile(int [,] grains)
        {
            this.grains = new int[3, 3];
            Array.Copy(topple(grains), this.grains, grains.Length);
                        
        }

        int[,] topple(int[,] gaps)
        {
            int[,] g = new int[3, 3];
            Array.Copy(gaps, g, g.Length);

            bool isToppled = false;
            while (!isToppled)
            {
                isToppled = true;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (g[i, j] > 3)
                        {
                            if (i > 0)
                            {
                                g[i - 1, j]++;
                            }
                            if (i < 2)
                            {
                                g[i + 1, j]++;
                            }
                            if (j > 0)
                            {
                                g[i, j - 1]++;
                            }
                            if (j < 2)
                            {
                                g[i, j + 1]++;
                            }
                            g[i, j] -= 4;

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
            int[,] finalGrid = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    finalGrid[i, j] = this.grains[i, j] + grid2[i, j];
                }
            }
            return new Sandpile(finalGrid);
        }

        public bool equals(Sandpile sand2)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
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
            Console.WriteLine("{0}-{1}-{2}", this.grains[0, 0], this.grains[0, 1], this.grains[0, 2]);
            Console.WriteLine("{0}-{1}-{2}", this.grains[1, 0], this.grains[1, 1], this.grains[1, 2]);
            Console.WriteLine("{0}-{1}-{2}", this.grains[2, 0], this.grains[2, 1], this.grains[2, 2]);
        }
    }
}
