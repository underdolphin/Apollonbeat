/*Copyright 2018 underdolphin

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using Apollonbeat.View;
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
            prog.Initialize();
            DxLib_Init();
            prog.GameLoop();
            DxLib_End();
        }

        public void GameLoop()
        {
            while (ScreenFlip() == 0 && ProcessMessage() == 0 && ClearDrawScreen() == 0)
            {
                var dashboard = new DashboardView();
                dashboard.Start();
            }
        }

        public void Initialize()
        {

            ChangeWindowMode(TRUE);
            SetWindowSize(1280, 720);
            SetGraphMode(1280, 720, 32);
            SetDrawScreen(DX_SCREEN_BACK);
        }
    }
}
