using GeometricShapes.Contracts;

namespace GeometricShapes.Shapes;

/// <summary>
/// Represents circle shape.
/// </summary>
public class Circle : IShape
{
	/// <summary>
	/// Creates circle with given radius.
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if radius is not positive.</exception>
	public Circle(double radius)
	{
		if (radius <= 0)
		{
			throw new ArgumentOutOfRangeException(nameof(radius), "Circle radius cannot be zero or negative");
		}

		Radius = radius;
	}

	public double Radius { get; private set; }
	public double GetArea()
	{
		return Math.PI * Math.Pow(Radius, 2);
	}

	public double GetPerimeter()
	{
		return 2 * Math.PI * Radius;
	}
}
