using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoronoiStruct
{
	class Voronoi
	{
		public Voronoi()
		{
			polygons = new List<Polygon>();
		}
		public Voronoi(int width, int height)
		{
			polygons = new List<Polygon>();
			this.width = width;
			this.height = height;
		}

		public int width, height;
		public List<Polygon> polygons;
	}

	class Polygon
	{
		public Polygon()
		{
			edges = new List<Edge>();
			focus = new Point();
		}
		public Polygon(VoronoiStruct.Point focus)
		{
			edges = new List<Edge>();
			this.focus = focus;
		}
		public Polygon(List<Edge> edges, VoronoiStruct.Point focus)
		{
			this.edges = new List<Edge>();
			this.focus = focus;
		}

		public List<Edge> edges;
		public VoronoiStruct.Point focus;
	}

	class Edge
	{
		public Edge()
		{
			parentID = new int[2];
			line = new Line();
		}

		public Line line;
		public int[] parentID;
	}

	struct Line
	{
		public Line(VoronoiStruct.Point a, VoronoiStruct.Point b)
		{
			this.a = a;
			this.b = b;
		}
		public Line(int ax, int ay, int bx, int by)
		{
			this.a = new VoronoiStruct.Point(ax, ay);
			this.b = new VoronoiStruct.Point(bx, by);
		}

		public VoronoiStruct.Point a, b;
	}

	struct Point
	{
		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public int x, y;
	}
}
