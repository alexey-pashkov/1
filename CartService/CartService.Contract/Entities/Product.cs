namespace CartService.Contract.Entities
{
    /// <summary>
    /// Сущность товара
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Count { get; set; }
        
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
    }
}