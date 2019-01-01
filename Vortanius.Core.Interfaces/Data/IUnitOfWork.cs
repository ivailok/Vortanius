using System.Threading.Tasks;

namespace Vortanius.Core.Interfaces.Data
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}