namespace Aula09
{
    public class Player : Character
    {
        public Player(string name)
        {
            Name = name;
            weapons = new Weapon[2];
            weapons[0] = new Gun(100.0f, 25);
            weapons[1] = new Sword(29.5f, 70.0f);
        }
    }
}
