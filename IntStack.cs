class IntStack
{
    // Field
    private IntLinkedList il;

    public IntStack( )
    { 
        il = new IntLinkedList( );
    }

    public void Push(int value)
    {
        il.Prepend(value);
    }

    public int? Peek( )
    {
        return il.LookAtFirst( );
    }

    public int? Pop( )
    {
        return il.RemoveFirst( );
    }
    public bool isEmpty()
    {
        return il.IsEmpty();
    }
}
