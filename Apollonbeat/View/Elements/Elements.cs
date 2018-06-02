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
