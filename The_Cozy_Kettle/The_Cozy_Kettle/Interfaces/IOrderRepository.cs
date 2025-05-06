using The_Cozy_Kettle.Models;

namespace The_Cozy_Kettle.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
