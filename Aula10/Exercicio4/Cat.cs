namespace Exercicio4
{
    public class Cat : Animal, IMammal
    {
        public int NumberOfNipples => 6;
        public override string Sound() => "Miau";
    }
}
