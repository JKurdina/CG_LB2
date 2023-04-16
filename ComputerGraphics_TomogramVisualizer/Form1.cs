using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;

namespace TomogramVisualizer
{
   
  public partial class Form1 : Form
  {
    //создаем и инициализируем объект
    //Bin bin;

    // чтобы не запускать отрисовку пока не загружены данные
    bool loaded = false;

    int currentLayer = 0;
    bool needReload = false;
    int mode_draw = 0;

    public Form1()
    {
      InitializeComponent();
    }

    private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
    {

      OpenFileDialog dialog = new OpenFileDialog();

      if (dialog.ShowDialog() == DialogResult.OK)
      {
        string str = dialog.FileName;


        //bin.readBIN(str);
        Bin.readBIN(str);


        View.SetupView(glControl1.Width, glControl1.Height);

        loaded = true;

        glControl1.Invalidate();

        trackBar1.Maximum = Bin.Z - 1;
      }
    }

    private void glControl1_Paint(object sender, PaintEventArgs e)
    {
      if (loaded)
      {
        if (mode_draw == 1) View.DrawQuads(currentLayer);
        else if (mode_draw == 3) View.DrawQuadStrip(currentLayer);

        else if(mode_draw == 2)
        {
          if (needReload)
          {
            View.generateTextureImage(currentLayer);
            View.Load2DTexture();
            needReload = false;
          }
          View.DrawTexture();
        }
        glControl1.SwapBuffers();
      }
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
      currentLayer = trackBar1.Value;
      glControl1.Invalidate();
      needReload = true;
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      if (radioButton1.Checked)
      {
        mode_draw = 1;
        glControl1.Invalidate();
      }
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
      if (radioButton2.Checked)
      {
        mode_draw = 2;
        glControl1.Invalidate();

      }
    }

    private void trackBar2_Scroll(object sender, EventArgs e)
    {
      View.min = trackBar2.Value;
      needReload = true;
      glControl1.Invalidate();
    }

    private void trackBar3_Scroll(object sender, EventArgs e)
    {
      if (trackBar3.Value == 0) 
        View.width = 255;
      else 
        View.width = trackBar3.Value;
      needReload = true;
      glControl1.Invalidate();
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
      if (radioButton2.Checked)
      {
        mode_draw = 3;
        glControl1.Invalidate();
      }
    }

    
  }
}