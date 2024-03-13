namespace Delegates_Task3
{
    internal class Sort
    {
        internal delegate int[] sortDelegate(int[] array);
        internal enum SortTypes
        {
            SortAscend,
            SortDescend
        }

        internal sortDelegate GetSortDelegate(SortTypes sortType)
        {
            if (sortType == SortTypes.SortAscend)
            {
                return SortAscending;
            }
            else if (sortType == SortTypes.SortDescend)
            {
                return SortDescending;
            }
            else
            {
                throw new ArgumentException("Неверный тип сортировки");
            }
        }

        internal int[] SortAscending(int[] array)
        {
            Array.Sort(array);
            return array;
        }

        internal int[] SortDescending(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }
    }
}
