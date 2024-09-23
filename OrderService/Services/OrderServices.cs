using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OrderService.Data;
using OrderService.DTO;
using OrderService.Model;

namespace OrderService.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly OrderDbContext _context;
        private readonly IMapper _mapper;

        public OrderServices(OrderDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderDTO>> GetAllOrders()
        {
            var orders = await _context.Orders.ToListAsync();
            return _mapper.Map<IEnumerable<OrderDTO>>(orders);
        }

        public async Task<OrderDTO> GetOrderById(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null) return null;
            return _mapper.Map<OrderDTO>(order);
        }

        public async Task<OrderDTO> CreateOrder(OrderDTO orderDto)
        {
            var order = _mapper.Map<Order>(orderDto);
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return _mapper.Map<OrderDTO>(order);
        }

        public async Task UpdateOrder(int id, OrderDTO orderDto)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null) return;

            _mapper.Map(orderDto, order);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }
    }
}

