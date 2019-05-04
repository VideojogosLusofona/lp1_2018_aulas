namespace Aula07
{
    class Color
    {
        // Auto-implemented properties
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; } = 255;

        // Greyscale property - does not need support variable
        public byte Greyscale
        {
            get
            {
                return (byte)((Red + Green + Blue) / 3);
            }
        }
    }
}