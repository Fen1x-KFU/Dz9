using System;

public class Singleton
{
    private Singleton() {}
    public static Singleton source = null;
    public static Singleton Source
    {
        get
        {
            if (source == null)
            {
                source = new Singleton();
            }
        return source;
        }
    }
}

public class Program
{
    static void Main()
    {
        Singleton bob = new Singleton();
    }
}




