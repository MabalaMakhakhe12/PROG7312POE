using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class BackgroundLoader
{
    public static void LoadBackground(Form form, PictureBox pictureBox)
    {
        string gifPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "bg.gif");

        if (File.Exists(gifPath))
        {
            Image backgroundImage = Image.FromFile(gifPath);

            form.Invoke(new Action(() =>
            {
                pictureBox.Image = backgroundImage;
            }));
        }
        else
        {
            MessageBox.Show("Background GIF not found at: " + gifPath);
        }
    }
}
