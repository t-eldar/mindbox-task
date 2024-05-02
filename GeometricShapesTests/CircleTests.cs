namespace GeometricShapesTests;
public class CircleTests
{
	private const int DoubleComparePrecision = 4;

	[Theory]
	[InlineData(0)]
	[InlineData(-10)]
	public void Ctor_ThrowsArgumentOutOfRange(double radius)
	{
		Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
	}

	[Theory]
	[InlineData(1, Math.PI)]
	[InlineData(14.6, 669.6619)]
	[InlineData(69.420, 15139.7635)]
	public void GetArea_ReturnsCorrectly(double radius, double expected)
	{
		var circle = new Circle(radius);
		var result = circle.GetArea();
		Assert.Equal(expected, result, DoubleComparePrecision);
	}

	[Theory]
	[InlineData(1, 6.283184)]
	[InlineData(121, 760.2654)]
	[InlineData(69.420, 436.1787)]
	public void GetPerimeter_ReturnsCorrectly(double radius, double expected)
	{
		var circle = new Circle(radius);
		var result = circle.GetPerimeter();
		Assert.Equal(expected, result, DoubleComparePrecision);
	}
}
