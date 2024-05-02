namespace GeometricShapes.Extensions;
public static class DoubleExtensions
{
	/// <summary>
	/// Compares double values with given precision.
	/// </summary>
	/// <param name="value">Comparing value.</param>
	/// <param name="precisionDigits">Precision digits.</param>
	public static bool ApproximatelyEquals(this double @this, double value, int precisionDigits)
	{
		var delta = Math.Pow(10, -precisionDigits);

		return Math.Abs(@this - value) < delta;
	}
}
