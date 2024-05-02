namespace GeometricShapesTests;
public class DoubleExtensionsTests
{
	[Theory]
	[InlineData(1, 1, 1, true)]
	[InlineData(0.000012, 0.000011, 5, true)]
	[InlineData(0.000012, 0.000011, 6, false)]
	[InlineData(1, 0.000011, 1, false)]
	[InlineData(25, 25, 8, true)]
	[InlineData(16, 25, 8, false)]
	public void ApproximatelyEquals_ReturnsCorrectly(
		double first, 
		double second, 
		int precision, 
		bool expected
	)
	{
		var result = first.ApproximatelyEquals(second, precision);
		Assert.Equal(expected, result);
	}
}
