using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandpiles
{
    class ZeroFinder
    {
        int size;
        int no_range;

        public Sandpile zeroSand { get; private set; }

        public ZeroFinder(int size, int no_range)
        {
            this.size = size;
            this.no_range = no_range;

            createSandpiles();

        }

        int [,] fullFillSandPile(int s)
        {
            int[,] grains = new int[this.size, this.size];

            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    grains[i, j] = s;
                }
            }

            return grains;
        }

        void createSandpiles()
        {
            Sandpile sandFull = new Sandpile(fullFillSandPile(this.no_range-1), this.size, this.no_range);

            long noOfiterations = (long)Math.Pow(this.no_range, this.size * this.size);
            for (int i=0; i<noOfiterations; i++)
            {
                int[,] grains2 = new int[this.size,this.size];

                for (int j = 0; j < this.size; j++)
                {
                    for (int k = 0; k < this.size; k++)
                    {
                        grains2[j, k] = (int)(i / Math.Pow(this.no_range, j * this.size + k)) % this.no_range;
                    }
                }
 

                Sandpile sand2 = new Sandpile(grains2, this.size, this.no_range);
                Sandpile sand_toTest = sandFull.addTo(sand2);
                
                if (sand_toTest.equals(sand_toTest.addTo(sand_toTest))) 
                {
                    this.zeroSand = sand_toTest;
                    this.zeroSand.print();
                    return;
                }

                
            }
            Console.WriteLine("No zero sandpile");
            
        }
    }
}
