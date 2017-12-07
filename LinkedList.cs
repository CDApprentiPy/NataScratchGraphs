using System;
using System.Collections.Generic;

namespace ScratchGraphs
{
    public class LLNode
    {
        public dynamic val {get;set;}
        public LLNode next {get;set;}
        
        public LLNode(dynamic val)
        {
            this.val = val;
            this.next = null;
        }

        public LLNode()
        {
            this.val = null;
            this.next = null;
        }
    }

    public class LinkedList
    {
        LLNode _head;
        int _count;
        LLNode pointer;
        delegate bool ActOnPointer(LLNode pointer);

        public LinkedList()
        {
            this._head = null;
            this._count = 0;
        }

        public void add(dynamic val)
        {
            LLNode newNode = new LLNode(val);
            if(_head == null)
            {
                this._head = newNode;
            }
            else
            {
                ActOnPointer nullifyer = delegate(LLNode pointer) { return false; };
                pointer = this.traverse(nullifyer);
                // while (pointer.next != null)
                // {
                //     pointer = pointer.next;
                // }
                pointer.next = newNode;
            }
            this._count++;
        }
        public LLNode head()
        {
            return _head;
        }

        public int count()
        {
            return _count;
        }

        public bool isEmpty()
        {
            if(this._head == null)
            {
                return true;
            }
            return false;
        }

        public bool Contains(dynamic val)
        {
            if(this._head == null)
            {
                return false;
            }
            ActOnPointer check = delegate(LLNode pointer){
                if(pointer.val == val)
                {
                    return true;
                }
                return false;
            };
            pointer = this.traverse(check);
            return check(pointer);
        }
        LLNode traverse(ActOnPointer function)
        {
            pointer = this._head;
            while(pointer.next != null)
            {
                if(function(pointer))
                {
                    break;
                }
                pointer = pointer.next;
            }
            return pointer;
        }
    }
}