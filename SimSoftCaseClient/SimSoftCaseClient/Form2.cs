using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimSoftCaseClient
{


	public partial class Form2 : Form
	{

		private int _x;
		private int _y;
		private int rectSizeX;
		private int rectSizeY;
		public Form2(int x,int y,int sizeX, int sizeY)
		{
			_x = x;
			_y = y;
			rectSizeX = sizeX;
			rectSizeY = sizeY;
			InitializeComponent();
		}

		private void Form2_Paint(object sender, PaintEventArgs e)
		{
			Pen pen = new Pen(Color.Black, 3);
			e.Graphics.DrawRectangle(pen, _x, _y, rectSizeX, rectSizeY);
		}

		public void NewCoordValue(int x,int y)
		{
			if(_x == x && _y == y)
			{
				_x = x;
				_y = y;
			}
			else
			{
				_x = x;
				_y = y;
				Invalidate();
			}

			
		}
	}
}
