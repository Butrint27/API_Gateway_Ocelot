using OrderService.DTO;

namespace OrderService.Services
{
    public interface IOrderServices
    {
        Task<IEnumerable<OrderDTO>> GetAllOrders();
        Task<OrderDTO> GetOrderById(int id);
        Task<OrderDTO> CreateOrder(OrderDTO orderDto);
        Task UpdateOrder(int id, OrderDTO orderDto);
        Task DeleteOrder(int id);
    }
}
