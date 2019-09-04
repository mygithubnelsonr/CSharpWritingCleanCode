using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanCodeNamesExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //PoorNamesExample poorNames = new PoorNamesExample();
            //poorNames.Method1("14473C1E.png");

            GoodNamesExamples goodNames = new GoodNamesExamples();
            //goodNames.GenerateImage("14473C1E.png");
            goodNames.Temp();

        }
    }

    // example of poor names
    public class PoorNamesExample
    {
        public Bitmap Method1(string n)
        {
            var b = new Bitmap(n);
            var g = Graphics.FromImage(b);

            g.DrawString("a", SystemFonts.DefaultFont, SystemBrushes.Desktop, new Point(0, 0));
            g.DrawString("b", SystemFonts.DefaultFont, SystemBrushes.Desktop, new Point(0, 20));
            g.DrawString("c", SystemFonts.DefaultFont, SystemBrushes.Desktop, new Point(0, 30));

            return b;

        }
    }

    // example of good names
    public class GoodNamesExamples
    {
        public Bitmap GenerateImage(string path)
        {
            var bitmap = new Bitmap(path);
            var graphics = Graphics.FromImage(bitmap);

            graphics.DrawString("a", SystemFonts.DefaultFont, SystemBrushes.Desktop, new Point(0, 0));
            graphics.DrawString("b", SystemFonts.DefaultFont, SystemBrushes.Desktop, new Point(0, 20));
            graphics.DrawString("c", SystemFonts.DefaultFont, SystemBrushes.Desktop, new Point(0, 30));

            return bitmap;

        }

        public void Temp()
        {
            Console.WriteLine($"{char.MinValue}, {char.MaxValue}");

        }

    }
}
