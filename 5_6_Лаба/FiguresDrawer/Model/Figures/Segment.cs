﻿using FiguresDrawer.Model.Structures;

namespace FiguresDrawer.Model.Figures
{
	public class Segment : Figure
	{
		public Segment(Point[] points) : base(points)
		{
		}

		public override double FindArea()
		{
			throw new System.InvalidOperationException("Can't calculate area of segment");
		}

		public override double FindPerimeter()
		{
			throw new System.InvalidOperationException("Can't calculate area of segment");
		}

		public override bool IsExisting()
		{
			Point[] points = GetPoints();

			return !GeometryMath.IsPointsEqual(points[0], points[1]);
		}
	}
}
