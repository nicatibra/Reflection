namespace Casting.Models
{
    internal abstract class Fruit
    {
        public decimal Price;
        public string Sort;

        protected Fruit(decimal price, string sort)
        {
            Price = price;
            Sort = sort;
        }
        public abstract void Taste();
    }
}
