namespace Exercicio5
{
    public class Player
    {
        public PlayerType Type { get; set; }
        public string Name { get; set; }

        public override int GetHashCode() =>
            Type.GetHashCode() ^ Name.GetHashCode();

        public override bool Equals(object obj)
        {
            Player otherPlayer = obj as Player;
            if (otherPlayer == null) return false;
            return (Type == otherPlayer.Type) && (Name == otherPlayer.Name);
        }
    }
}
