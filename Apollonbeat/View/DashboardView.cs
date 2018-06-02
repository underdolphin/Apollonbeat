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