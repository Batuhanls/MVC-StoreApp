using Entities.Models;

namespace Repositories.Extensions
{
    public static class ProductRepositoryExtension
    {
        public static IQueryable<Product>FilterByCategoryId(this IQueryable<Product>products,int? categoryId)
        {
if(categoryId is null)
return products;
else
return products.Where(prd=>prd.CategoryId.Equals(categoryId));
        }



public static IQueryable<Product>FilteredBySearchTerm(this IQueryable<Product> products, string? searchTerm)
{
    if (string.IsNullOrWhiteSpace(searchTerm))
    return products;

    else

   return  products.Where(prd=>prd.ProductName.ToLower()
    .Contains(searchTerm.ToLower()));   

}
public static IQueryable<Product>FilteredByPrice(this IQueryable<Product>products,int minPrice,int maxPrice,bool IsValidPrice)
{
    if(IsValidPrice)
    return products.Where(prd=>prd.Price>=minPrice&&prd.Price<=maxPrice);
    else 
    return products;
}

    }
}



