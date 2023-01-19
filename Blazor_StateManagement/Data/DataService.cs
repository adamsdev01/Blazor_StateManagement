using Blazor_StateManagement.Data.StateService;
using Blazor_StateManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_StateManagement.Data
{
    public class DataService
    {
        private readonly BlazorStateDbContext appDbContext;

        public DataService(BlazorStateDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Category> AddCategory(Category category)
        {
            appDbContext.Add(category);
            await appDbContext.SaveChangesAsync();

            return category;
        }

        public async Task<Product> AddProduct(Product product, StateContainerService state)
        {
            appDbContext.Add(product);
            await appDbContext.SaveChangesAsync();

            product.ProductId = state.Product.ProductId;

            return product;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await appDbContext.Categories.ToListAsync();
        }

    }
}
