using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra
{
    public class Deque<T>
    {
        public Deque()
        {
        }

        private DoubleLinkListNode<T> back;
        private DoubleLinkListNode<T> front;
        private int count;

        public void PushBack(T input)
        {
            count++;
            DoubleLinkListNode<T> tmp = new DoubleLinkListNode<T>() { Value = input };
            if (count > 1)
            {
                tmp.Next = null;
                tmp.Prev = back;
                back.Next = tmp;
                back = tmp;
            }
            else
            {
                front = tmp;
                back = tmp;
            }
        }

        public void PushFront(T input)
        {
            count++;
            DoubleLinkListNode<T> tmp = new DoubleLinkListNode<T>() { Value = input };
            if (count > 1)
            {
                tmp.Prev = null;
                tmp.Next = front;
                front.Prev = tmp;
                front = tmp;
            }
            else
            {
                front = tmp;
                back = tmp;
            }
        }

        public T PopBack()
        {
            if (count == 0) throw new Exception("Deque is empty can not pop");

            T res = back.Value;
            back = back.Prev;
            if (count > 1)
            {
                back.Next = null;
                count--;
            }
            else
            {
                count = 0;
                back = null;
                front = null;
            }
            return res;
        }

        public T PeekBack()
        {
            if (count == 0) throw new Exception("Deque is empty can not peek");
            T res = back.Value;
            return res;
        }

        public T PopFront()
        {
            if (count == 0) throw new Exception("Deque is empty can not pop");

            T res = front.Value;
            front = front.Next;
            if (count > 1)
            {
                front.Prev = null;
                count--;
            }
            else
            {
                count = 0;
                front = null;
                back = null;
            }
            return res;
        }

        public T PeekFront()
        {
            if (count == 0) throw new Exception("Deque is empty can not peek");
            T res = front.Value;
            return res;
        }


        public bool IsEmpty()
        {
            return count == 0;
        }
    }

    public class DoubleLinkListNode<T>
    {
        public DoubleLinkListNode<T> Prev;
        public DoubleLinkListNode<T> Next;
        public T Value;
    }
}
