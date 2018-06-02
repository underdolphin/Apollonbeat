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