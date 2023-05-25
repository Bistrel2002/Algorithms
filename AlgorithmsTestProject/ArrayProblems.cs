namespace AlgorithmsTestProject;

public static class ArrayProblems
{
    public static bool AreArraysEqual<T>(T[] xs, T[] ys)
    {
        if (ReferenceEquals(xs, ys))
            return true;

        if (xs == null || ys == null)
            return false;

        if (xs.Length != ys.Length)
            return false;

        var comparer = EqualityComparer<T>.Default;
        for (int i = 0; i < xs.Length; i++)
        {
            if (!comparer.Equals(xs[i], ys[i])) return false;
        }
        return true;
    }

    public static void Swap<T>(T[] xs, int a, int b)
    {
        T temp = xs[a];
        xs[a] = xs[b];
        xs[b] = temp;
    }

    public static T FirstElement<T>(T[] xs)
    {
        if (xs.Length == 0)
        {
            throw new Exception("The array are out of bounds");
        }
        return xs[0];
    }

    public static T LastElement<T>(T[] xs)
    {
        if (xs.Length == 0)
        {
            throw new Exception("The array are out of bounds");
        }
        return xs[xs.Length - 1];
    }

    public static T MiddleElement<T>(T[] xs)
    {
        if (xs.Length == 0)
        {
            throw new Exception("The array are out of bounds");
        }
        return xs[xs.Length/2];
    }

    public static void Reverse<T>(T[] xs)
    {
        int i = 0;
        int j = xs.Length - 1;
        while (i < j) 
        {
            T temp = xs[i];
            xs[i] = xs[j];
            xs[j] = temp;

            i++;
            j--;
        }
    }

    public static int CountElement<T>(T[] xs, T element)
    {
        int i = 0;
        for (int j = 0; j < xs.Length; j++)
        {
            if (EqualityComparer<T>.Default.Equals(xs[j], element)) 
            {
                i++;
            }
        }
        return i;
    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        throw new NotImplementedException();
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {
        int i = 0;
        for( int j = 0; j < xs.Length; j++)
        {
            if (predicate(xs[j])) 
            {
                i++;
            }
        }
        return i;
    }

    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        throw new NotImplementedException();
    }
}