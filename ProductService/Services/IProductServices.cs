using ProductService.DTO;

namespace ProductService.Services
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductDTO>> GetAllProducts();
        Task<ProductDTO> GetProductById(int id);
        Task<ProductDTO> CreateProduct(ProductDTO productDto);
        Task UpdateProduct(int id, ProductDTO productDto);
        Task DeleteProduct(int id);
    }
}
