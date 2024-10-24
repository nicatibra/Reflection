namespace Casting.Models
{
    internal class PineApple : Fruit
    {
        public int VitaminE;
        public int VitaminD;

        public PineApple(decimal price, string sort, int vitamine, int vitamind) : base(price, sort)
        {
            VitaminE = vitamine;
            VitaminD = vitamind;
        }

        public override void Taste()
        {
            Console.WriteLine("Pineapple is sweet and tart.");
        }
    }
}
