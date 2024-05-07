using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers;

[ApiController]
[Route("[Action]")]
public class Productshop : ControllerBase
{
    //Constractor
    
    private readonly Context db;
    public Productshop(Context x)
    {
       db=x;        
    } 

    //insert
    [HttpPost]
    public string Insert(Product pr)
    {
        db.Tbl_Product.Add(pr);
        db.SaveChanges();


        return "Product Added";

    }

    //Get All
    [HttpGet]
    public List<Product> GetAll()
    {
        return db.Tbl_Product.ToList();
    }

    //delete 
    [HttpDelete]
    public string Delete(int id)
    {
        var pr = db.Tbl_Product.Find(id);
        db.Tbl_Product.Remove(pr);
        db.SaveChanges();
        return "Product Deleted";
    }

}
