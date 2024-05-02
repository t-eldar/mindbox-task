namespace GeometricShapes.Contracts;
/// <summary>
/// Represents geometric shape.
/// </summary>
public interface IShape
{
	/// <summary>
	/// Calculates shape's area.
	/// </summary>
	double GetArea();

	/// <summary>
	/// Calculates shape's perimeter.
	/// </summary>
	double GetPerimeter();
}
