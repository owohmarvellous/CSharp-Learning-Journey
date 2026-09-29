namespace Generics;

public class GenericStorage<T>
{
    private readonly T itemm;

    private GenericStorage(T item)
    {
        itemm = item;
    }

    public static GenericStorage<T> Create(T item)
    {
        return new GenericStorage<T>(item);
    }

    public T GetItem()
    {
        return itemm;
    }

}

