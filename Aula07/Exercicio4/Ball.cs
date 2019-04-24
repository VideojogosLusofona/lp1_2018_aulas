// Fully documented version of this exercise available at
// http://starboundsoftware.com/books/c-sharp/try-it-out/designing-and-building-classes
namespace Exercicio4
{
    class Ball
    {
        // Instance variables
        private Color color;
        private float radius;
        private int timesThrown;

        // Constructors
        public Ball(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            this.timesThrown = 0;
        }

        // Operational methods
        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
            {
                timesThrown++;
            }
        }

        // Getters
        public int GetTimesThrown()
        {
            return timesThrown;
        }
    }
}
