using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimSoftCaseServer
{
	public partial class Form2 : Form
	{

		public int _x;
		public int _y;
		public int  width = 600;
		public int height = 450;

		public Form2()
		{
			this.Width = width;
			this.Height = height;
			_x = width / 2;
			_y = height /2;

			InitializeComponent();
		}

		private void Form2_Paint(object sender, PaintEventArgs e)
		{
			Pen pen = new Pen(Color.Black, 3);
			e.Graphics.DrawRectangle(pen, _x, _y, 30, 20);
		}

		private void Form2_KeyDown(object sender, KeyEventArgs e)
		{
	
				if (e.KeyCode == Keys.Right)
				{
					_x += 5;
					if(_x >= width)
					{
						_x =width;
					}
					Invalidate();
				}
				else if (e.KeyCode == Keys.Left)
				{
					_x -= 5;
					if(_x <= 0)
					{
						_x = 0;
					}
					Invalidate();
				}
				else if (e.KeyCode == Keys.Up)
				{
					_y -= 5;
					if(_y <= 0)
					{
						_y = 0;
					}
					Invalidate();
				}
				else if (e.KeyCode == Keys.Down)
				{
					_y += 5;
					if(_y >= height)
					{
						_y = height;
					}
					Invalidate();
				}
				else
				{

				}

		}
	}
}
