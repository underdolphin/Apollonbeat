using static DxLibDLL.DX;

namespace Apollonbeat.View.Elements
{
    public class Button : Elements
    {
        public int FontHandle { get; set; }
        public (int Left, int Top) FontMargin { get; set; }
        public string Content { get; set; }
        public override void Display()
        {
            DrawBox(
                Position.X,
                Position.Y,
                Size.Width - 1,
                Size.Height - 1,
                GetColor(BackgroundColor.R, BackgroundColor.G, BackgroundColor.B), TRUE);

            DrawStringToHandle(
                Position.X + FontMargin.Left,
                Position.Y + FontMargin.Top,
                Content,
                GetColor(ForegroundColor.R, ForegroundColor.G, ForegroundColor.B),
                FontHandle);
        }
    }
}