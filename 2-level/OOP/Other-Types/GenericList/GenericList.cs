using System;
using System.Linq;
using System.Text;

[Version(2.11)]
class GenericList<T> where T : IComparable<T>
{
    const int DefaultCapacity = 16;

    private T[] elements;
    private int count = 0;

    public GenericList(int capacity = DefaultCapacity)
    {
        elements = new T[capacity];
    }

    public int Count
    {
        get
        {
            return this.count;
        }
    }

    public void Add(T element)
    {
        if (this.count >= this.elements.Length)
        {
            T[] elementsDoubleLength = new T[this.elements.Length * 2];
            Array.Copy(this.elements, elementsDoubleLength, this.elements.Length);
            this.elements = elementsDoubleLength;
        }

        this.elements[this.count] = element;
        ++this.count;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
            }
            T result = elements[index];
            return result;
        }

        set
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
            }

            this.elements[index] = value;
        }
    }

    public void Remove(int index)
    {
        if (index < 0 || index >= this.count)
        {
            throw new IndexOutOfRangeException(String.Format("Invalid index: {0}", index));
        }

        T[] newElements = new T[this.elements.Length - 1];

        Array.Copy(this.elements, 0, newElements, 0, index);
        Array.Copy(this.elements, index + 1, newElements, index, newElements.Length - index);

        this.elements = newElements;
        --this.count;
    }

    public void Insert(T element, int index)
    {
        if (index >= this.count)
        {
            throw new ArgumentException(String.Format("Invalid index: {0}", index));
        }

        T[] newElements = new T[this.elements.Length + 1];

        Array.Copy(this.elements, 0, newElements, 0, index);
        newElements[index] = element;
        Array.Copy(this.elements, index, newElements, index + 1, this.elements.Length - index);

        this.elements = newElements;
        ++this.count;
    }

    public void Clear()
    {
        this.elements = new T[DefaultCapacity];
        this.count = 0;
    }

    public int GetIndex(T element)
    {
        int index = Array.IndexOf(this.elements, element);
        if (index < 0)
        {
            throw new ArgumentException(String.Format("Invalid value: {0}", element));
        }
        return index;
    }

    public bool Contains(T element)
    {
        if (this.elements.Contains(element))
        {
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        if (this.count == 0)
        {
            return "";
        }

        StringBuilder result = new StringBuilder();

        foreach (var element in this.elements)
        {
            result.Append(element).Append(", ");
        }

        return result.ToString().TrimEnd(' ', ',');
    }

    public T Max()
    {
        var maxElement = this.elements[0];

        foreach (var element in this.elements)
        {
            if (maxElement.CompareTo(element) < 0)
            {
                maxElement = element;
            }
        }

        return maxElement;
    }

    public T Min()
    {
        var minElement = this.elements[0];

        foreach (var element in this.elements)
        {
            if (minElement.CompareTo(element) > 0)
            {
                minElement = element;
            }
        }

        return minElement;
    }
}
