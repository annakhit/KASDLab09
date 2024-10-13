using System;

internal class MyStack<T> : MyVector<T>
{
    public MyStack() : base()
    { }

    public void Push(T item) => AddElement(item);

    public T Pop()
    {
        uint index = (uint)(elementCount - 1);
        T result = Get(index);
        Remove(index);
        return result;
    }

    public T Peek() => LastElement();
    public bool Empty() => IsEmpty();

    public int Search(T item) => (elementCount - IndexOf(item));

    public new void Print()
    {
        for (int i = elementCount - 1; i >= 0; i--)
        {
            Console.WriteLine(elementData[i]);
        }
    }
}
