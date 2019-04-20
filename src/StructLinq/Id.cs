namespace StructLinq
{
    public class Id<T>
    {
        private Id()
        {
        }
        public static readonly Id<T> Value = new Id<T>();
    }
}