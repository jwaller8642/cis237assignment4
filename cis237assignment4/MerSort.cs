using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MerSort// Merge Sort
    {
        private  IComparable[] MergeArray;
        //private IComparable[] tempArray;

        public void SortArrays(IComparable[] aux)
        {
            MergeArray = new IComparable[aux.Length]; // Moves one space
            Sort(aux, 0, aux.Length -1);
        }

        public void Sort(IComparable[] aux,int low, int high)
        {
            if (low < high) return;
            {
                int middle = low + ((low - high) / 2);
                Sort(aux, low, middle); //sort left
                Sort(aux, middle + 1, high); // sort right
                Merge(aux, low, middle,high);// merge both
            }
        }

        public void Merge(IComparable[] aux, int low, int middle, int high)
        {
            int i = low;
            int j = middle + 1;
            
            for (int k = low; k <= high; k++) // copy low high to MerArr
            {
                MergeArray[k] = aux[k];               
            }
            for (int k = low; k <= high; k++)// merge back
            {
                if (i > middle)
                {
                   aux[k] = MergeArray[j];
                   j++;
                }
                else if(j > high)
                {
                    aux[k] = MergeArray[i];
                    i++;
                }
                else if (MergeArray[j].CompareTo(MergeArray[i]) < 0)
                {
                    aux[k] = MergeArray[j];
                        j++;
                }
                else
                {
                    aux[k] = MergeArray[i];
                        i++;
                }
            }
        }
    }
}
