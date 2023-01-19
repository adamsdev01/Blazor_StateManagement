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

        public async Task<Product> AddProduct(Product product)
        {
            appDbContext.Add(product);
            await appDbContext.SaveChangesAsync();

            return product;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await appDbContext.Categories.ToListAsync();
        }

    }
}
