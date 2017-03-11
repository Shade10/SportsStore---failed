using System.Collections.Generic;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Models {
    public class ProductsListViewModel {
        public IEnumerable<Product> Products { get; set; }
        public PagingIfno PagingIfno { get; set; }
        public string CurrentCategory { get; set; }

    }
}