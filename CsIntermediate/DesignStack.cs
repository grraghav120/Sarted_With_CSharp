using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1.CsIntermediate
{
    internal class DesignStack
    {
        private readonly ArrayList stack = new ArrayList();
        public void Push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("Object can't be NULL");
            }
            else
            {
                stack.Add(obj);
            }
        }
        public object Pop()
        {
            if(stack.Count <= 0)
            {
                throw new InvalidOperationException("Stack is Empty!");
            }
            else
            {
                int n=stack.Count;
                var val = stack[n - 1];
                stack.RemoveAt(n-1);
                return val;
            }
        }
        public void Clear()
        {
            stack.Clear();
        }
    }
}
