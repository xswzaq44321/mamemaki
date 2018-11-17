using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace mamemaki
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			vmap = new VoronoiStruct.Voronoi();
			blueBrush = new SolidBrush(Color.Blue);
			circleSize = new Size(3, 3);
			bmp = new Bitmap(1, 1);
			g = Graphics.FromImage(bmp);
			width = (int)numericUpDown_width.Value;
			height = (int)numericUpDown_height.Value;
			pointCount = (int)numericUpDown_count.Value;
			pointMargin = (int)numericUpDown_margin.Value;
			map = new bool[1, 1];
		}

		int width, height, pointCount, pointMargin;
		VoronoiStruct.Voronoi vmap;
		Brush blueBrush;
		Size circleSize;
		Random rand = new Random();
		Graphics g;
		Bitmap bmp;
		bool[,] map;

		bool checkPointValid(bool[,] map, int a, int b)
		{
			int m = map.GetLength(0);
			int n = map.GetLength(1);
			for (int i = a - pointMargin; i <= a + pointMargin; ++i)
			{
				for (int j = b - pointMargin; j <= b + pointMargin; ++j)
				{
					if (i >= m || i < 0 || j >= n || j < 0)
						continue;
					if (map[i, j])
						return false;
				}
			}
			return true;
		}

		void drawMap(bool[,] map)
		{
			bmp = new Bitmap(width, height);
			g = Graphics.FromImage(bmp);
			pictureBox1.Image = bmp;

			for (int i = 0; i < map.GetLength(0); ++i)
			{
				for (int j = 0; j < map.GetLength(1); ++j)
				{
					if (map[i, j])
					{
						g.FillEllipse(blueBrush, i - circleSize.Width / 2, j - circleSize.Height / 2, circleSize.Width, circleSize.Height);
					}
				}
			}
			pictureBox1.Invalidate();
		}

		void makeVoronoi(bool[,] map, ref VoronoiStruct.Voronoi vmap)
		{
			int m = map.GetLength(0);
			int n = map.GetLength(1);
			vmap.width = m;
			vmap.height = n;
			for (int i = 0; i < m; ++i)
			{
				for (int j = 0; j < n; ++j)
				{
					if (map[i, j])
					{
						vmap.points.Add(new VoronoiStruct.Point(i, j));
					}
				}
			}
		}

		private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
		{
			makeVoronoi(map, ref vmap);
			string json = JsonConvert.SerializeObject(vmap, Formatting.Indented);
			Clipboard.SetText(json);
		}

		private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string json = Clipboard.GetText();
			try
			{
				vmap = JsonConvert.DeserializeObject<VoronoiStruct.Voronoi>(json);
			}
			catch
			{
				System.Diagnostics.Debug.WriteLine("Error deserializing json");
				return;
			}
			map = new bool[vmap.width, vmap.height];
			foreach (var item in vmap.points)
			{
				map[item.x, item.y] = true;
			}
			drawMap(map);
		}

		private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
				string json = sr.ReadToEnd();
				try
				{
					vmap = JsonConvert.DeserializeObject<VoronoiStruct.Voronoi>(json);
				}
				catch
				{
					System.Diagnostics.Debug.WriteLine("Error deserializing json");
					return;
				}
				map = new bool[vmap.width, vmap.height];
				foreach (var item in vmap.points)
				{
					map[item.x, item.y] = true;
				}
				drawMap(map);
			}
		}

		private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				makeVoronoi(map, ref vmap);
				string json = JsonConvert.SerializeObject(vmap, Formatting.Indented);
				System.IO.File.WriteAllText(saveFileDialog1.FileName, json);
			}
		}

		private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void numericUpDown_height_ValueChanged(object sender, EventArgs e)
		{
			height = (int)numericUpDown_height.Value;
		}

		private void numericUpDown_width_ValueChanged(object sender, EventArgs e)
		{
			width = (int)numericUpDown_width.Value;
		}

		private void numericUpDown_size_ValueChanged(object sender, EventArgs e)
		{
			int a = (int)numericUpDown_size.Value;
			circleSize = new Size(a, a);
			drawMap(map);
		}

		private void numericUpDown_margin_ValueChanged(object sender, EventArgs e)
		{
			pointMargin = (int)numericUpDown_margin.Value;
		}

		private void numericUpDown_count_ValueChanged(object sender, EventArgs e)
		{
			pointCount = (int)numericUpDown_count.Value;
		}

		private void button_generate_Click(object sender, EventArgs e)
		{
			map = new bool[width, height];
			System.Timers.Timer timer = new System.Timers.Timer();
			timer.Start();
			timer.Interval = 2000;
			bool timeout = false;
			int prevPointCount = 0;
			timer.Elapsed += (s, ev) =>
			{
				if (prevPointCount == progressBar1.Value)
					timeout = true;
				prevPointCount = progressBar1.Value;
				System.Diagnostics.Debug.WriteLine(progressBar1.Value);
			};
			progressBar1.Maximum = pointCount;
			progressBar1.Value = 0;
			for (int i = 0; i < pointCount; ++i)
			{
				int a = rand.Next(width);
				int b = rand.Next(height);
				if (checkPointValid(map, a, b))
				{
					map[a, b] = true;
					progressBar1.PerformStep();
					progressBar1.Invalidate();
				}
				else
				{
					--i;
				}
				if (timeout)
				{
					MessageBox.Show("Sorry, it seems like map is full.\r\nMaybe try smaller margin.", "", MessageBoxButtons.OK);
					progressBar1.Value = 0;
					break;
				}
			}
			timer.Stop();

			drawMap(map);
		}

	}
}
