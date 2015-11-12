using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    // Taken from inClass4
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

        public void Add(T droid)
        {
            GenericNode<T> node = new GenericNode<T>();

            node.Data = droid;

            if(Head == null)
            {
                Head = node;
            }
            else
            {
                last.Next = node;
            }

            last = node;
        }

        public bool Delete(int Position)
        {
            current = Head;

            if (Position == 1)
            {
                Head = current.Next;
                current.Next = null;
                current = null;
                return false;
            }

            if (Position > 1)
            {
                GenericNode<T> tempNode = Head;

                GenericNode<T> previousTempNode = null;

                int count = 0;

                while (tempNode != null)
                {

                    if (count == Position - 1)
                    {

                        previousTempNode.Next = tempNode.Next;

                        if (tempNode.Next == null)
                        {
                            last = previousTempNode;
                        }
                        //Remove the next pointer of the tempnode
                        tempNode.Next = null;
                        //Return True because it was successfull
                        return true;
                    }

                    count++;

                    previousTempNode = tempNode;

                    tempNode = tempNode.Next;
                }
            }
            return false;
        }
        public GenericNode<T> Retrive(int Position)
        {

            GenericNode<T> tempNode = Head;
            GenericNode<T> returnNode = null;
            int count = 0;

            while (tempNode != null)
            {
                if (count == Position - 1)
                {
                    returnNode = tempNode;
                    break;
                }
                count++;
                tempNode = tempNode.Next;
            }
            return returnNode;
        }

        
    }
}
