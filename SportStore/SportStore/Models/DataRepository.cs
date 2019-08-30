using System.Collections.Generic;
using System.Linq;

namespace SportStore.Models
{
    public class DataRepository: IRepository
    {
        //private List<Product> data = new List<Product>();
        private DataContext context;
        public DataRepository(DataContext ctx) => context = ctx;
        public IEnumerable<Product> Products => context.Products.ToArray();
        public void AddProduct(Product product)
        {
            //this.data.Add(product);
            this.context.Products.Add(product);
            this.context.SaveChanges();
        }
    }
}