using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public ColorRGB colorRGB { get; set; }
        public Color color { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            colorRGB = new ColorRGB();
            colorRGB.red = 0;
            colorRGB.green = 0;
            colorRGB.blue = 0;
        }
        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
           this.iCanvas.Strokes.Clear();
        }
        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_Highlight(object sender, RoutedEventArgs e)
        {
            this.iCanvas.EditingMode = InkCanvasEditingMode.Select;
        }
        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            string imgPath = @"C:\Users\Пользователь\Desktop\imagen.png"; 
            MemoryStream ms = new MemoryStream();
            FileStream fileStream = new FileStream(imgPath, FileMode.Create);
            RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap((int)iCanvas.Width, (int)iCanvas.Height, 96, 96, PixelFormats.Default);
            renderTargetBitmap.Render(iCanvas);
            PngBitmapEncoder pngEnc = new PngBitmapEncoder();
            pngEnc.Frames.Add(BitmapFrame.Create(renderTargetBitmap));
            pngEnc.Save(fileStream);
            fileStream.Close();
            MessageBox.Show("Файл сохранен, " + imgPath);
        }
        public class ColorRGB
        {
            public byte red { get; set; }
            public byte green { get; set; }
            public byte blue { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 0;
            colorRGB.green = 0;
            colorRGB.blue = 0;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 127;
            colorRGB.green = 127;
            colorRGB.blue = 127;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 136;
            colorRGB.green = 0;
            colorRGB.blue = 21;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 237;
            colorRGB.green = 28;
            colorRGB.blue = 36;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 255;
            colorRGB.green = 127;
            colorRGB.blue = 39;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 255;
            colorRGB.green = 242;
            colorRGB.blue = 0;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 34;
            colorRGB.green = 177;
            colorRGB.blue = 76;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 0;
            colorRGB.green = 162;
            colorRGB.blue = 232;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 63;
            colorRGB.green = 72;
            colorRGB.blue = 204;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 163;
            colorRGB.green = 73;
            colorRGB.blue = 164;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 255;
            colorRGB.green = 255;
            colorRGB.blue = 255;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 195;
            colorRGB.green = 195;
            colorRGB.blue = 195;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 185;
            colorRGB.green = 122;
            colorRGB.blue = 87;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 255;
            colorRGB.green = 174;
            colorRGB.blue = 201;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 255;
            colorRGB.green = 201;
            colorRGB.blue = 14;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 239;
            colorRGB.green = 228;
            colorRGB.blue = 176;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 181;
            colorRGB.green = 230;
            colorRGB.blue = 29;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 153;
            colorRGB.green = 217;
            colorRGB.blue = 234;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 153;
            colorRGB.green = 217;
            colorRGB.blue = 234;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            colorRGB = new ColorRGB();
            colorRGB.red = 200;
            colorRGB.green = 191;
            colorRGB.blue = 231;
            color = Color.FromRgb(colorRGB.red, colorRGB.green, colorRGB.blue);
            this.iCanvas.DefaultDrawingAttributes.Color = color;
        }
    }
}
