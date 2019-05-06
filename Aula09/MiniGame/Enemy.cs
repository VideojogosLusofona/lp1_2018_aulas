namespace Aula09
{
    public class Enemy : Character
    {
        public Enemy(string name)
        {
            Name = name;
            weapons = new Weapon[3];
            weapons[0] = new Gun(20.0f, 5);
            weapons[1] = new Gun(40.0f, 8);
            weapons[2] = new Sword(12.5f, 50.0f);
        }
    }
}
