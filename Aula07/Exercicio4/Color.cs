// Fully documented version of this exercise available at
// http://starboundsoftware.com/books/c-sharp/try-it-out/designing-and-building-classes
namespace Exercicio4
{
    class Color
    {
        // Instance variables
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        // Constructors
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        // Getters
        public byte GetRed()
        {
            return red;
        }

        public byte GetGreen()
        {
            return green;
        }

        public byte GetBlue()
        {
            return blue;
        }

        public byte GetAlpha()
        {
            return alpha;
        }

        // Additional getter method - the difference in this one is that it
        // returns a value which is not directly part of the object state
        public byte GetGrayscale()
        {
            return (byte)((red + green + blue) / 3);
        }

        // Setters
        public void SetRed(byte red)
        {
            this.red = red;
        }

        public void SetGreen(byte green)
        {
            this.green = green;
        }

        public void SetBlue(byte blue)
        {
            this.blue = blue;
        }

        public void SetAlpha(byte alpha)
        {
            this.alpha = alpha;
        }
    }

}
