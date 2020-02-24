using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseStorageSystem
{
    public class ProductModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string Supplier { get; set; }

        public string ProductInfo
        {
            get
            {
                return $"Nosaukums: {Name}, Apraksts: {Description}, Cena: {Price}, Daudzums: {Quantity}, Piegādātājs: {Supplier}";
            }
        }
    }
}
