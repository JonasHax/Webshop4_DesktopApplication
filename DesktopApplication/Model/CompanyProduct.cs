using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Model {

    public class CompanyProduct {

        // Getters and setters.
        public int StyleNumber { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Boolean State { get; set; }

        public decimal Price { get; set; }

        public List<CompanyProductVersion> ProductVersions { get; set; }

        public CompanyProduct() {
            ProductVersions = new List<CompanyProductVersion>();
        }

        public CompanyProduct(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public override string ToString() {
            return $"Varenummer: {StyleNumber} \nNavn: {Name}\nPris: {Price},-\nBeskrivelse: {Description}\nTilgængelig: {State}"; /*\nLager: {Stock} \nStr.: {SizeCode} \nFarve: {ColorCode}*/
        }

        //public void AddProductVersion(ProductVersion prodVer) {
        //    ProductVersions.Add(prodVer);
        //}

        //public List<CompanyProductVersion> GetProductVersions() {
        //    return this.ProductVersions;
        //}
    }
}