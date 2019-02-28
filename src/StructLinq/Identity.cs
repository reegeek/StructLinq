namespace StructLinq
{
    public class Identity<T>
    {
        private Identity()
        {
        }
        public static readonly Identity<T> Instance = new Identity<T>();
    }
}