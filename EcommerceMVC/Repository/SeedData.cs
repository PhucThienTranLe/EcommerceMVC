using EcommerceMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Repository
{
    public class SeedData
    {
        public static void SeedingData(DataContext dataContext)
        {
            dataContext.Database.Migrate();
            if (!dataContext.Products.Any())
            {
                CategoryModel laptop = new CategoryModel { Name = "Laptop", Slug = "Laptop", Description = "Laptop", Status = 1 };
                CategoryModel phone = new CategoryModel { Name = "Phone", Slug = "Phone", Description = "Phone", Status = 1 };
                CategoryModel tablet = new CategoryModel { Name = "Tablet", Slug = "Tablet", Description = "Tablet", Status = 1 };
                BrandModel apple = new BrandModel { Name = "Apple", Slug = "Apple", Description = "Apple", Status = 1 };
                BrandModel samsung = new BrandModel { Name = "Samsung", Slug = "Samsung", Description = "Samsung", Status = 1 };
                dataContext.Products.AddRange(
                    new ProductModel { Name = "IPhone 16 Pro Max 256GB", Slug = "IPhone 16 Pro Max 256GB", Description = "IPhone 16 Pro Max sở hữu màn hình Super Retina XDR OLED 6.9 inch với công nghệ ProMotion, mang lại trải nghiệm hiển thị mượt mà và sắc nét, lý tưởng cho giải trí và làm việc. Với chipset A18 Pro mạnh mẽ, mẫu iPhone đời mới này cung cấp hiệu suất vượt trội, giúp xử lý mượt mà các tác vụ nặng như chơi game hay edit video. Chiếc điện thoại iPhone 16 mới này còn sở hữu hệ thống camera Ultra Wide 48MP cho khả năng chụp ảnh cực kỳ chi tiết, mang đến chất lượng hình ảnh ấn tượng trong mọi tình huống.", Image = "iphone-16-pro-max", Category = phone, Brand = apple, Price = 30490000 },
                    new ProductModel { Name = "MacBook Air M4 13 inch 2025 10CPU 8GPU 16GB 256GB", Slug = "MacBook Air M4 13 inch 2025 10CPU 8GPU 16GB 256GB", Description = "MacBook Air M4 13 inch 2025 10CPU 8GPU 16GB 256GB với cấu hình được xây dựng quanh chip Apple M4 thế hệ mới nhất, mang đến hiệu năng ấn tượng. Với 10 nhân CPU, chiếc MacBook Air M4 này cung cấp khả năng xử lý đa tác vụ nhanh chóng, mượt mà, từ công việc văn phòng, học tập đến duyệt web hay các ứng dụng sáng tạo. 8 nhân GPU tích hợp đảm bảo hiệu suất đồ họa tốt, đủ sức mạnh cho việc chỉnh sửa ảnh, biên tập video cơ bản và trải nghiệm giải trí sống động.", Image = "macbook-air-m4-2025", Category = laptop, Brand = apple, Price = 26490000 },
                    new ProductModel { Name = "Samsung Galaxy Tab S10 FE Wifi 8GB 128GB", Slug = "Samsung Galaxy Tab S10 FE Wifi 8GB 128GB", Description = "Máy tính bảng Samsung Galaxy Tab S10 FE Wifi sở hữu màn hình 10.9 inch sắc nét, giúp người dùng thoải thích làm việc và giải trí hiệu quả mọi lúc mọi nơi. Bộ xử lý Exynos cao cấp cùng RAM 8GB mang đến hiệu năng đa nhiệm vượt trội, xử lý tác vụ mượt mà. Cùng với đó là các tính năng AI mới, hữu ích cho công việc, giải trí hàng ngày của người dùng.", Image = "tablet-samsung-galaxy-tab-s10", Category = tablet, Brand = samsung, Price = 11990000 }
                );
                dataContext.SaveChanges();
            }
        }
    }
}
