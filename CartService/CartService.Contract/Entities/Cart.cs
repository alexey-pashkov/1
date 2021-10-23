using System.Collections.Generic;

namespace CartService.Contract.Entities
{
    /// <summary>
    /// Сущность корзины
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        public List<Product> Products { get; set; }
        /// <summary>
        /// Количество товаров
        /// </summary>
        public int ItemCount { get; set; }
        /// <summary>
        /// Цена всего заказа
        /// </summary>
        public decimal TotalPrice { get; set; }

    }
}
