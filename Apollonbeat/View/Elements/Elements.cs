namespace Apollonbeat.View.Elements
{
    public abstract class Elements
    {
        /// <summary>
        /// Screen display processing
        /// </summary>
        public abstract void Display();

        public (int Width, int Height) Size { get; set; }
        public (int X, int Y) Position { get; set; }
        public (int R, int G, int B) ForegroundColor { get; set; }
        public (int R, int G, int B) BackgroundColor { get; set; }

    }
}
