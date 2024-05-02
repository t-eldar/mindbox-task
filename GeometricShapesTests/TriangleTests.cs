namespace GeometricShapesTests;
public class TriangleTests
{
	private const int DoubleComparePrecision = 8;

	[Theory]
	[InlineData(0, 1, 1)]
	[InlineData(1, 0, 1)]
	[InlineData(1, 1, 0)]
	[InlineData(-1, 1, 1)]
	[InlineData(1, -1, 1)]
	[InlineData(1, 1, -1)]
	public void Ctor_ThrowsArgumentOutOfRange(double first, double second, double third)
	{
		Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(first, second, third));
	}

	[Theory]
	[InlineData(1, 1, 1, 3)]
	[InlineData(0.1, 0.1, 0.1, 0.3)]
	[InlineData(100_000.1, 0.1, 0.1, 100_000.3)]
	public void GetPerimeter_ReturnsCorrectly(double first, double second, double third, double expected)
	{
		var triangle = new Triangle(first, second, third);
		var result = triangle.GetPerimeter();
		Assert.Equal(expected, result, DoubleComparePrecision);
	}

	[Theory]
	[InlineData(1, 1, 1, 0.4330127018922193)]
	[InlineData(10.1, 10.1, 1, 5.0438080851673961)]
	[InlineData(3, 4, 5, 6)]
	public void GetArea_ReturnsCorrectly(double first, double second, double third, double expected)
	{
		var triangle = new Triangle(first, second, third);
		var result = triangle.GetArea();
		Assert.Equal(expected, result, DoubleComparePrecision);
	}

	[Theory]
	[InlineData(1, 1, 1, false)]
	[InlineData(10, 10, 1, false)]
	[InlineData(3, 4, 5, true)]
	[InlineData(4, 3, 5, true)]
	[InlineData(5, 4, 3, true)]
	public void IsRectangular_ReturnsCorrectly(double first, double second, double third, bool expected)
	{
		var triangle = new Triangle(first, second, third);
		var result = triangle.IsRectangular();
		Assert.Equal(expected, result);
	}
}
