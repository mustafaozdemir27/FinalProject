﻿using Core.Entities;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        // Çıplak Class Kalmasın
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
