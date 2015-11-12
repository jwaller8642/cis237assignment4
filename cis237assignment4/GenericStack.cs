using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    //Taken From inclass4
    class GenericStack<T>
    {
         private GenericNode<T> current;
        private GenericNode<T> last;
        
        public GenericNode<T> Head
        {
            get;
            set;
        }

        public GenericStack()
        {
            Head = null;
        }

        public void Add(T droid)
        {
            GenericNode<T> newNode = new GenericNode<T>();

            newNode.Data = droid;

            if(Head == null)
            {
                Head = newNode;
            }
            else
            {
                last.Next = newNode;
            }

            last = newNode;
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
                        
                        tempNode.Next = null;
                        
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
