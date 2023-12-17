namespace AlgorithmsAndDataStructures.Extensions
{
    public static class EnumerableExtenssions
    {
        public static string ToArrayString<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
            {
                return "null";
            }

            return "[" + string.Join(", ", collection.Select(x => x.ToString())) + "]";
        }
    }
}
