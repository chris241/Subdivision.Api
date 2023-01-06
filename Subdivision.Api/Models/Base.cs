namespace Subdivision.Api.Models
{
    public abstract class Base
    {
        public virtual Guid Id { get; set; }
        public virtual  long? Number { get; set; }
        public virtual string Name { get; set; }   

    }
}
