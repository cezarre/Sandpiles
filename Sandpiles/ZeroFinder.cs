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

        public ZeroFinder()
        {
            this.size = 3;
            this.no_range = 4;

            createSandpiles();

        }

        void createSandpiles()
        {
            Sandpile sandFull = new Sandpile(new int[,] { { 3, 3, 3 }, { 3, 3, 3 }, { 3, 3, 3 } });

            int noOfiterations = (int)Math.Pow(this.no_range, this.size * this.size);
            for (int i=0; i<noOfiterations; i++)
            {
                int[,] grains2 = new int[this.size,this.size];

                grains2[0, 0] = (int)(i / Math.Pow(this.no_range, 8)) % this.no_range;
                grains2[0, 1] = (int)(i / Math.Pow(this.no_range, 7)) % this.no_range;
                grains2[0, 2] = (int)(i / Math.Pow(this.no_range, 6)) % this.no_range;
                grains2[1, 0] = (int)(i / Math.Pow(this.no_range, 5)) % this.no_range;
                grains2[1, 1] = (int)(i / Math.Pow(this.no_range, 4)) % this.no_range;
                grains2[1, 2] = (int)(i / Math.Pow(this.no_range, 3)) % this.no_range;
                grains2[2, 0] = (int)(i / Math.Pow(this.no_range, 2)) % this.no_range;
                grains2[2, 1] = (int)(i / Math.Pow(this.no_range, 1)) % this.no_range;
                grains2[2, 2] = (int)(i / Math.Pow(this.no_range, 0)) % this.no_range;

                Sandpile sand2 = new Sandpile(grains2);
                Sandpile sand_toTest = sandFull.addTo(sand2);
                
                if (sand_toTest.equals(sand_toTest.addTo(sand_toTest))) 
                {
                    this.zeroSand = sand_toTest;
                    return;
                }

                
            }
            Console.WriteLine("No zero sandpile");
            
        }
    }
}
