using Apollonbeat.View;
using System;
using static DxLibDLL.DX;

namespace Apollonbeat
{
    public class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            var prog = new Program();
            ChangeWindowMode(TRUE);
            SetWindowSize(1280, 720);
            SetGraphMode(1280, 720, 32);
            SetDrawScreen(DX_SCREEN_BACK);
            DxLib_Init();
            prog.GameLoop();
            DxLib_End();
        }

        public void GameLoop()
        {
            while (ScreenFlip() == 0 && ProcessMessage() == 0 && ClearDrawScreen() == 0)
            {
                DrawString(50, 50, "游ゴシック", GetColor(255, 255, 255));
            }
        }
    }
}
