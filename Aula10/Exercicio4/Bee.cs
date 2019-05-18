namespace Exercicio4
{
    public class Bee : Animal, ICanFly
    {
        public int NumberOfWings => 4;
        public override string Sound() => "Bzzzz";
    }
}
