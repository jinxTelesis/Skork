﻿using System.Drawing;

namespace Skork.keywords {
    class SkorkDown {



        public void down(SkorkSprite s, int x = 1) {
            if (s.Location.Y - 1 < 0 && x > 0) {
                s.Location = new Point(s.Location.X, s.Location.Y - 1);
                System.Windows.Forms.MessageBox.Show("DOWN " + x);
                down(s, --x);
            } else { return; }
        }
    }
}
