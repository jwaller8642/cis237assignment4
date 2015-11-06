using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericQueue<T>
    {
        private GenericNode<T> current;
        private GenericNode<T> last;

        public GenericNode<T> Head
        {
            get;
            set;
        }

        public GenericQueue()
        {
            Head = null;
        }

        public void Add(IComparable droid)
        {
            GenericNode<T> node = new GenericNode<T>();

            node.GDroid = droid;
        }
    }
}
