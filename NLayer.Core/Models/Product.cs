﻿namespace NLayer.Core.Models
{
    //isimlendirmelerde _Id kullanmamamızın sebebi EFCore otomatik olarak bunları foreign key olarak algılıyor.
    //_ kullanılırsa algılamıyor.
    //_ kullanılırsa foreign key verilmesi gerekiyor.
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ProductFeature ProductFeature { get; set; }
    }
}
