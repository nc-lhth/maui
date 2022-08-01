﻿using System;
using Microsoft.Maui.Controls.Shapes;
using NUnit.Framework;

namespace Microsoft.Maui.Controls.Core.UnitTests
{
	public class StrokeShapeTests : BaseTestFixture
	{
		StrokeShapeTypeConverter _strokeShapeTypeConverter;

		[SetUp]
		public override void Setup()
		{
			base.Setup();

			_strokeShapeTypeConverter = new StrokeShapeTypeConverter();
		}

		[TestCase("rectangle")]
		[TestCase("Rectangle")]
		public void TestRectangleConstructor(string value)
		{
			Rectangle rectangle = _strokeShapeTypeConverter.ConvertFromInvariantString(value) as Rectangle;

			Assert.IsNotNull(rectangle);
		}

		[TestCase("roundRectangle")]
		[TestCase("RoundRectangle")]
		[TestCase("roundRectangle 12")]
		[TestCase("roundRectangle 12, 6, 24, 36")]
		[TestCase("roundRectangle 12, 12, 24, 12")]
		[TestCase("RoundRectangle 12")]
		[TestCase("RoundRectangle 12, 6, 24, 36")]
		[TestCase("RoundRectangle 12, 12, 24, 12")]
		public void TestRoundRectangleConstructor(string value)
		{
			RoundRectangle roundRectangle = _strokeShapeTypeConverter.ConvertFromInvariantString(value) as RoundRectangle;

			Assert.IsNotNull(roundRectangle);

			if (!string.Equals("roundRectangle", value, StringComparison.OrdinalIgnoreCase))
			{
				Assert.AreNotEqual(roundRectangle.CornerRadius.TopLeft, 0);
				Assert.AreNotEqual(roundRectangle.CornerRadius.TopRight, 0);
				Assert.AreNotEqual(roundRectangle.CornerRadius.BottomLeft, 0);
				Assert.AreNotEqual(roundRectangle.CornerRadius.BottomRight, 0);
			}
		}

		[TestCase("path")]
		[TestCase("Path")]
		[TestCase("path M8.4580019,25.5C8.4580019,26.747002 10.050002,27.758995 12.013003,27.758995 13.977001,27.758995 15.569004,26.747002 15.569004,25.5z M19.000005,10C16.861005,9.9469986 14.527004,12.903999 14.822002,22.133995 14.822002,22.133995 26.036002,15.072998 20.689,10.681999 20.183003,10.265999 19.599004,10.014999 19.000005,10z M4.2539991,10C3.6549998,10.014999 3.0710002,10.265999 2.5649996,10.681999 -2.7820019,15.072998 8.4320009,22.133995 8.4320009,22.133995 8.7270001,12.903999 6.3929995,9.9469986 4.2539991,10z M11.643,0C18.073003,0 23.286002,5.8619995 23.286002,13.091995 23.286002,20.321999 18.684003,32 12.254,32 5.8239992,32 1.8224728E-07,20.321999 0,13.091995 1.8224728E-07,5.8619995 5.2129987,0 11.643,0z")]
		[TestCase("path M16.484421,0.73799322C20.831404,0.7379931 24.353395,1.1259904 24.353395,1.6049905 24.353395,2.0839829 20.831404,2.4719803 16.484421,2.47198 12.138443,2.4719803 8.6154527,2.0839829 8.6154527,1.6049905 8.6154527,1.1259904 12.138443,0.7379931 16.484421,0.73799322z M1.9454784,0.061995983C2.7564723,5.2449602 12.246436,11.341911 12.246436,11.341911 13.248431,19.240842 9.6454477,17.915854 9.6454477,17.915854 7.9604563,18.897849 6.5314603,17.171859 6.5314603,17.171859 4.1084647,18.29585 3.279473,15.359877 3.2794733,15.359877 0.82348057,15.291876 1.2804796,11.362907 1.2804799,11.362907 -1.573514,10.239915 1.2344746,6.3909473 1.2344746,6.3909473 -1.3255138,4.9869594 1.9454782,0.061996057 1.9454784,0.061995983z M30.054371,0C30.054371,9.8700468E-08 33.325355,4.9249634 30.765367,6.3289513 30.765367,6.3289513 33.574364,10.177919 30.71837,11.30191 30.71837,11.30191 31.175369,15.22988 28.721384,15.297872 28.721384,15.297872 27.892376,18.232854 25.468389,17.110862 25.468389,17.110862 24.040392,18.835847 22.355402,17.853852 22.355402,17.853852 18.752417,19.178845 19.753414,11.279907 19.753414,11.279907 29.243385,5.1829566 30.054371,0z")]
		[TestCase("Path M8.4580019,25.5C8.4580019,26.747002 10.050002,27.758995 12.013003,27.758995 13.977001,27.758995 15.569004,26.747002 15.569004,25.5z M19.000005,10C16.861005,9.9469986 14.527004,12.903999 14.822002,22.133995 14.822002,22.133995 26.036002,15.072998 20.689,10.681999 20.183003,10.265999 19.599004,10.014999 19.000005,10z M4.2539991,10C3.6549998,10.014999 3.0710002,10.265999 2.5649996,10.681999 -2.7820019,15.072998 8.4320009,22.133995 8.4320009,22.133995 8.7270001,12.903999 6.3929995,9.9469986 4.2539991,10z M11.643,0C18.073003,0 23.286002,5.8619995 23.286002,13.091995 23.286002,20.321999 18.684003,32 12.254,32 5.8239992,32 1.8224728E-07,20.321999 0,13.091995 1.8224728E-07,5.8619995 5.2129987,0 11.643,0z")]
		[TestCase("Path M16.484421,0.73799322C20.831404,0.7379931 24.353395,1.1259904 24.353395,1.6049905 24.353395,2.0839829 20.831404,2.4719803 16.484421,2.47198 12.138443,2.4719803 8.6154527,2.0839829 8.6154527,1.6049905 8.6154527,1.1259904 12.138443,0.7379931 16.484421,0.73799322z M1.9454784,0.061995983C2.7564723,5.2449602 12.246436,11.341911 12.246436,11.341911 13.248431,19.240842 9.6454477,17.915854 9.6454477,17.915854 7.9604563,18.897849 6.5314603,17.171859 6.5314603,17.171859 4.1084647,18.29585 3.279473,15.359877 3.2794733,15.359877 0.82348057,15.291876 1.2804796,11.362907 1.2804799,11.362907 -1.573514,10.239915 1.2344746,6.3909473 1.2344746,6.3909473 -1.3255138,4.9869594 1.9454782,0.061996057 1.9454784,0.061995983z M30.054371,0C30.054371,9.8700468E-08 33.325355,4.9249634 30.765367,6.3289513 30.765367,6.3289513 33.574364,10.177919 30.71837,11.30191 30.71837,11.30191 31.175369,15.22988 28.721384,15.297872 28.721384,15.297872 27.892376,18.232854 25.468389,17.110862 25.468389,17.110862 24.040392,18.835847 22.355402,17.853852 22.355402,17.853852 18.752417,19.178845 19.753414,11.279907 19.753414,11.279907 29.243385,5.1829566 30.054371,0z")]
		public void TestPathConstructor(string value)
		{
			Path path = _strokeShapeTypeConverter.ConvertFromInvariantString(value) as Path;

			Assert.IsNotNull(path);
			if (!string.Equals("path", value, StringComparison.OrdinalIgnoreCase))
			{
				Assert.IsNotNull(path.Data);
			}
		}

		[TestCase("polygon")]
		[TestCase("Polygon")]
		[TestCase("polygon 10,110 60,10 110,110")]
		[TestCase("polygon 0 48, 0 144, 96 150, 100 0, 192 0, 192 96, 50 96, 48 192, 150 200 144 48")]
		[TestCase("Polygon 10,110 60,10 110,110")]
		[TestCase("Polygon 0 48, 0 144, 96 150, 100 0, 192 0, 192 96, 50 96, 48 192, 150 200 144 48")]
		public void TestPolygonConstructor(string value)
		{
			Polygon polygon = _strokeShapeTypeConverter.ConvertFromInvariantString(value) as Polygon;

			Assert.IsNotNull(polygon);
			if (!string.Equals("polygon", value, StringComparison.OrdinalIgnoreCase))
			{
				Assert.NotZero(polygon.Points.Count);
			}
		}

		[TestCase("line")]
		[TestCase("Line")]
		[TestCase("line 1 2")]
		[TestCase("Line 1 2 3 4")]
		public void TestLineConstructor(string value)
		{
			Line line = _strokeShapeTypeConverter.ConvertFromInvariantString(value) as Line;

			Assert.IsNotNull(line);
			if (!string.Equals("line", value, StringComparison.OrdinalIgnoreCase))
			{
				Assert.NotZero(line.X1);
				Assert.NotZero(line.Y1);
			}
		}

		[TestCase("polyline")]
		[TestCase("Polyline")]
		[TestCase("polyline 10,110 60,10 110,110")]
		[TestCase("polyline 0 48, 0 144, 96 150, 100 0, 192 0, 192 96, 50 96, 48 192, 150 200 144 48")]
		[TestCase("Polyline 10,110 60,10 110,110")]
		[TestCase("Polyline 0 48, 0 144, 96 150, 100 0, 192 0, 192 96, 50 96, 48 192, 150 200 144 48")]
		public void TestPolylineConstructor(string value)
		{
			Polyline polyline = _strokeShapeTypeConverter.ConvertFromInvariantString(value) as Polyline;

			Assert.IsNotNull(polyline);
			if (!string.Equals("polyline", value, StringComparison.OrdinalIgnoreCase))
			{
				Assert.NotZero(polyline.Points.Count);
			}
		}

		[TestCase("ellipse")]
		[TestCase("Ellipse")]
		public void TestEllipseConstructor(string value)
		{
			Ellipse ellipse = _strokeShapeTypeConverter.ConvertFromInvariantString(value) as Ellipse;

			Assert.IsNotNull(ellipse);
		}
	}
}