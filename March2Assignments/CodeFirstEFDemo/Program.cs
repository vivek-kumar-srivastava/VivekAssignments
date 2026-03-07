using CodeFirstEFDemo;
using CodeFirstEFDemo.Data;
using CodeFirstEFDemo.Models;
using Microsoft.EntityFrameworkCore;

var context = new AppDbContext();

//create category

//var electronics = new Category {Name = "Electronics" };
//context.Categories.Add(electronics);
//await context.SaveChangesAsync();

//context.Products.AddRange(
//    new Product { Name = "laptop", Price = 999.78M, category = electronics },
//    new Product { Name="Mouse",Price=212.12M, category = electronics }
//);

//await context.SaveChangesAsync();

//update

//var laptop = await context.Products.FirstAsync(p=>p.Name == "laptop");
//laptop.Price = 7899.67M;
//await context.SaveChangesAsync();

////delete
//context.Products.Remove(laptop);
//context.SaveChangesAsync();

//Querrying author with Courses
//var authors = await context.Authors.Include(x => x.Courses).ToListAsync();
//foreach(var auth in authors)
//{
//    Console.WriteLine($"Author: {auth.Name}");
//    foreach(var course in auth.Courses)
//    {
//        Console.WriteLine($"--{course.Title}--{course.Description}--{course.level}");
//    }
//}


//var newProduct = new Product { Name = "smartphone", Price = 7888.23M, CategoryId = 1 };
IProductRepository obj = new ProductRepository(context);
//await obj.AddAsync(newProduct);


//var toupdate = await obj.GetByIdAsync(newProduct.Id);
//if(toupdate != null)
//{
//    toupdate.Price = 20999.10M;
//    toupdate.Name = "OnePlus13";
//    obj.UpdateAsync(toupdate);
//    Console.WriteLine($"Updated: {toupdate.Name}--{toupdate.Price}");

//}


//var productTofetch = await obj.GetByIdAsync(newProduct.Id);

//if (productTofetch != null)
//{
//    productTofetch.Price = 555.67M;
//    productTofetch.Name = "normalphone";
//    await obj.UpdateAsync(productTofetch);
//    Console.WriteLine("success");

//}

//await obj.DeleteAsync(10);

IProductRepository obj2 = new ProductRepository(context);
//var newProd = new Product
//{
//    Name = "Tablet",
//    Price = 1232.12M,
//    CategoryId = 1
//};
//await obj2.AddAsync(newProd);

//var toupdate = await obj2.GetByIdAsync(11);
//if (toupdate != null)
//{
//    toupdate.Price = 1003.21M;
//    toupdate.Name = "IPhone";
//}
//await obj2.UpdateAsync(toupdate);


await obj2.DeleteAsync(11);
