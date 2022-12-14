/*
authour paul lopez
date 11/11/24
an implement of an generic linked list
*/

internal class LinkedList<T>
{
    //todo: remove public modifier
    public class Node
    {
        //auto implemented properties
        public T Value{get;}
        public Node? Next {get; set;}

        public Node(T value)
        {
            this.Value =value;
            this.Next = null;
        }
    }

    //feild
    private int len;
    private Node? head;
    private Node? rear;
    public Node? Head
    {
        get{return this.head; }
    }

    public LinkedList() {}
    public void Append(T value)
    {
        //construct a node based off of the value
        Node node = new Node(value);
        this.len += 1;
        //ez case: the head is null (the list is empty!)
        if(this.rear == null)
        {
            this.head = node;
            this.rear = node;
            return;
        }
        // //find the end of the list
        // Node curr = head;
        // while (curr.Next != null)//while node has someone behind
        // {
        //     //go to next node
        //     curr = curr.Next;
        // }
        // //the curr we are lookuing at does not have someone behind rthem
        // //put node behind curr
        // curr.Next = node;
        this.rear.Next = node;
        this.rear = this.rear.Next;
    }
    
    public T? LookFor(T e)
    {
        // Lookup through list
        Node? curr = head;
        T? found = default(T);
        // curr.Value = default(T);
        while (curr != null)
        {
            if(curr.Value!.Equals(e))
            {
                found = curr.Value;
            }
            curr = curr.Next;
        }
        return found;
    }

    public override string ToString()
    {
        string listRepr = "";
        Node? curr = head;

        if (curr == null)
        {
            return "EMPTY";
        }
        while (curr.Next != null)
        {
            listRepr += curr.Value + " -> ";
            curr = curr.Next;
        }
        listRepr += curr.Value;
        // listRepr += "NULL";
        return "(" + listRepr + ")";

    }

    public void Prepend(T e)
    {
        Node node = new Node(e);
        this.len += 1;
        if(this.rear == null)
        {
            this.head = node;
            this.rear = node;
            return;
        }
        Node? Head = this.head;
        this.head = node;
        this.head.Next = Head;
    }

    public int Length()
    {
        return this.len;
    }

    public T? LookAtFirst( )
    {
        // If list is empty
        if (this.head == null)
        {
            return default(T);
        }
        return this.head.Value;
    }

    public T? RemoveFirst( )
    {
        if (this.head == null)
        {
            return default(T);
        }
        T headValue = this.head.Value;
        // Remove head
        this.head = this.head.Next;
        if(this.head == null)
        {
            this.rear = null;
        }

        return headValue;
    }
    public bool IsEmpty()
    {
        // if(this.head == null)
        // {
        //     return true;
        // }
        // else
        // {
        //     return false;
        // }
        return this.head == null;
    }
}