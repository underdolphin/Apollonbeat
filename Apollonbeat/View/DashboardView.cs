using Apollonbeat.View.Elements;
using static DxLibDLL.DX;

namespace Apollonbeat.View
{
    public class DashboardView
    {
        public DashboardView() { }

        public void Start()
        {
            var button1 = new Button
            {
                BackgroundColor = (R: 120, G: 120, B: 120),
                ForegroundColor = (R: 255, G: 255, B: 255),
                FontHandle = CreateFontToHandle("Segoe UI", 24, 4, DX_FONTTYPE_ANTIALIASING_8X8),
                Position = (X: 10, Y: 10),
                Size = (Width: 200, Height: 100),
                FontMargin = (Left: 10, Top: 10),
                Content = "Test"
            };

            while (ScreenFlip() == 0 && ProcessMessage() == 0 && ClearDrawScreen() == 0)
            {
                button1.Display();
            }
          
        }
    }
}