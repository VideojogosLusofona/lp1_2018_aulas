namespace Exercicio4
{
    public class Dog : Animal, IMammal
    {
        public int NumberOfNipples => 8;
        public override string Sound() => "Woof!";
    }
}
