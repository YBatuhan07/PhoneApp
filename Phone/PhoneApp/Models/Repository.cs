namespace PhoneApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new List<Product>();
        private static readonly List<Category> _categories = new List<Category>();

        static Repository()
        {
            _categories.Add(new Category
            {
                CategoryId = 1,
                Name = "Samsung",
            });
            _categories.Add(new Category
            {
                CategoryId = 2,
                Name = "iPhone",
            });
            _products.Add(new Product
            {
                ProductId = 1,
                Name = "Samsung S24 Ultra",
                CategoryId = 1,
                Image = "b_samsung-galaxy-s24-ultra-1.jpg",
                IsActive = true,
                Price = 92000
            });
            _products.Add(new Product
            {
                ProductId = 2,
                Name = "Samsung S24 Plus",
                CategoryId = 1,
                Image = "b_samsung-galaxy-s24-plus-1.jpg",
                IsActive = true,
                Price = 80000
            });
            _products.Add(new Product
            {
                ProductId = 3,
                Name = "Samsung S24",
                CategoryId = 1,
                Image = "b_samsung-galaxy-s24-256gb-2.jpg",
                IsActive = true,
                Price = 67000
            });
            _products.Add(new Product
            {
                ProductId = 4,
                Name = "iPhone 16 Pro Max",
                CategoryId = 2,
                Image = "b_apple-iphone-16-pro-max-1tb-2.jpg",
                IsActive = true,
                Price = 107500
            });
            _products.Add(new Product
            {
                ProductId = 5,
                Name = "iPhone 16 Pro",
                CategoryId = 2,
                Image = "b_apple-iphone-16-pro-1tb-2.jpg",
                IsActive = true,
                Price = 95000
            });
            _products.Add(new Product
            {
                ProductId = 6,
                Name = "iPhone 16 Plus",
                CategoryId = 2,
                Image = "b_apple-iphone-16-plus-512gb-2.jpg",
                IsActive = true,
                Price = 83000
            });
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }
        public static void EditProduct(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);
            if(entity != null)
            {
                entity.Name = updatedProduct.Name;
                entity.Price = updatedProduct.Price;
                entity.Image = updatedProduct.Image; 
                entity.CategoryId = updatedProduct.CategoryId;
                entity.IsActive = updatedProduct.IsActive;
            }
        }
        public static void EditIsActive(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);
            if (entity != null)
            {
               
                entity.IsActive = updatedProduct.IsActive;
            }
        }
        public static void DeleteProduct(Product deletedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == deletedProduct.ProductId);
            if (entity != null)
            {
                _products.Remove(entity);
            }
        }
    }
}
