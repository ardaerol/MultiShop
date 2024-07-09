using MultiShop.Catalog.Dtos.ProductImageDtos;

namespace MultiShop.Catalog.Services.ProductImageServices
{
    public interface IProductImageService
    {
        Task<List<ResultProductImageDto>> GetAllProductImagesAsync();
        Task CreateProductImageasync(CreateProductImageDto CreateProductImageDto);
        Task DeleteProductImageAsync(string id);
        Task UpdateProductImageAsync (UpdateProductImageDto UpdateProductImageDto);
        Task<GetByIdProductImageDto> GetByIdProductImageAsync (string id);
    }
}
