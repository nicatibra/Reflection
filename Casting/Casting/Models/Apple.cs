namespace Casting.Models
{
    internal class Apple : Fruit
    {
        public int VitaminA;
        public int VitaminB;

        public Apple(decimal price, string sort, int vitamina, int vitaminb) : base(price, sort)
        {
            VitaminA = vitamina;
            VitaminB = vitaminb;
        }

        public override void Taste()
        {
            Console.WriteLine("Apple is  sweet, tart, or a little of both."); ;
        }
    }
}
