using DesktopApplication.Model;
using DesktopApplication.ProductService;
using DesktopApplication.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Service {

    public class ServiceProduct : IUseProductService {

        public ServiceProduct() {
        }

        public List<string> GetAllCategories() {
            ProductServiceClient proxy = new ProductServiceClient();
            return proxy.GetAllCategories().ToList();
        }

        public List<string> GetAllColors() {
            ProductServiceClient proxy = new ProductServiceClient();
            return proxy.GetAllColors().ToList();
        }

        public List<string> GetAllSizes() {
            ProductServiceClient proxy = new ProductServiceClient();
            return proxy.GetAllSizes().ToList();
        }

        //public CompanyProduct CreateProduct(Product prod) {
        //    throw new NotImplementedException();
        //}

        public CompanyProduct GetProductById(int id) {
            ProductServiceClient proxy = new ProductServiceClient();
            ConvertDataModel converter = new ConvertDataModel();
            CompanyProduct product = converter.ConvertFromServiceProduct(proxy.GetProduct(id));

            return product;
        }

        public bool InsertProduct(Product productToInsert) {
            ProductServiceClient proxy = new ProductServiceClient();
            return proxy.InsertProduct(productToInsert);
        }

        //     public CompanyProduct CreateProduct(Product prod)
        //      {
        //          int id = 1;
        //          ProductServiceClient proxy = new ProductServiceClient();
        //          ConvertDataModel converter = new ConvertDataModel();
        ////          CompanyProduct product = converter.ConvertToServiceProduct(proxy.CreateProduct(prod));
        //          CompanyProduct product = converter.ConvertFromServiceProduct(proxy.GetProduct(id));     // Erstattes af ovenstående linje, kun for at kunne køre programmet!

        //          return product;
        //      }

        /*  public int CreateAuction(decimal bid, int status,
           decimal currentPrice, decimal maxPrice, DateTime endDate, string title, string description, string category, string ownerId)
          {
              AuctionModel data = new AuctionModel
              {
                  Bid = bid,
                  Status = status,
                  CurrentPrice = currentPrice,
                  MaxPrice = maxPrice,
                  EndDate = endDate,
                  Title = title,
                  Description = description,
                  Category = category,
                  OwnerId = ownerId
              };
              string sql = @"insert into dbo.Auction (status, currentPrice, maxPrice, bid, endDate, title, description, category, ownerId)
              values (0, @CurrentPrice, @MaxPrice, @Bid, @EndDate, @Title, @Description, @Category, @OwnerId);";

              return SqlDataAccess.SaveData(sql, data);
          }
          */
    }
}