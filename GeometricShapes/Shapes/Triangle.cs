using GeometricShapes.Contracts;
using GeometricShapes.Extensions;

namespace GeometricShapes.Shapes;
/// <summary>
/// Represents triangle shape.
/// </summary>
public class Triangle : IShape
{
	/// <summary>
	/// Creates triangles with given sides
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if side values are not positive</exception>
	public Triangle(double firstSide, double secondSide, double thirdSide)
	{
		if (firstSide <= 0)
		{
			throw new ArgumentOutOfRangeException(nameof(firstSide),"Triangle side cannot be zero or negative");
		}
		if (secondSide <= 0)
		{
			throw new ArgumentOutOfRangeException(nameof(secondSide), "Triangle side cannot be zero or negative");
		}
		if (thirdSide <= 0)
		{
			throw new ArgumentOutOfRangeException(nameof(thirdSide), "Triangle side cannot be zero or negative");
		}

		FirstSide = firstSide;
		SecondSide = secondSide;
		ThirdSide = thirdSide;
	}
	public double FirstSide { get; private set; }
	public double SecondSide { get; private set; }
	public double ThirdSide { get; private set; }

	public double GetPerimeter()
	{
		return FirstSide + SecondSide + ThirdSide;
	}
	public double GetArea()
	{
		var semiPerimeter = GetPerimeter() / 2;

		return Math.Sqrt(
			semiPerimeter
			* (semiPerimeter - FirstSide)
			* (semiPerimeter - SecondSide)
			* (semiPerimeter - ThirdSide)
		);
	}
	public bool IsRectangular()
	{
		return Math.Pow(FirstSide, 2).ApproximatelyEquals(
			Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2),
			8
		) || Math.Pow(SecondSide, 2).ApproximatelyEquals(
			Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2),
			8
		) || Math.Pow(ThirdSide, 2).ApproximatelyEquals(
			Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2),
			8
		);
	}
}
