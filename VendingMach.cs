using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class VendingMach
    {
        public void Vending()
        {
            int[] notes = { 1000, 500, 200, 100, 50, 10, 5, 2, 1 };
            int[] stores= new int[notes.Length];
            int changeFor = 2500;
            for (int i = 0; i < notes.Length; i++)
            {
                if (changeFor / notes[i] > 0)
                {
                    stores[i] = changeFor / notes[i];
                    changeFor -= notes[i] * stores[i];
                }
            }
            for (int i = 0;i < stores.Length; i++)
            {
                if (stores[i] != 0)
                {
                    Console.WriteLine(notes[i]+" "+stores[i]);
                }
            }
        }
    }
}
