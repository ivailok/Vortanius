namespace Vortanius.Core.Domain.Entities.Data.Base
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}