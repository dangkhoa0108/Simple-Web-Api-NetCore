namespace SimpleWebApiNetCore.Entity
{
    public abstract class KeyEntity<T>
    {
        public T Id { get; set; }
    }
}
