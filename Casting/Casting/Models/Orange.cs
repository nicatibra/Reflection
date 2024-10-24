namespace Casting.Models
{
    internal class Orange : Fruit
    {
        public int VitaminC;

        public Orange(decimal price, string sort, int vitaminc) : base(price, sort)
        {
            VitaminC = vitaminc;
        }

        public override void Taste()
        {
            Console.WriteLine("Orange is sweet."); ;
        }
    }
}
