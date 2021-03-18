using UnityEngine;
using static UnityEngine.Mathf;

namespace ShefGDS
{
	public static class EMath
	{
		public static float Remap(float value, float startMin, float startMax, float endMin, float endMax)
			=> ((value - startMin) / (startMax - startMin)) * (endMax - endMin) + endMin;
		
		public static Vector2 RotateVector(Vector2 vector, float theta)
		{
			var x = vector.x * Cos(theta) + vector.y * Sin(theta);
			var y = -vector.x * Sin(theta) + vector.y * Cos(theta);
			return new Vector2(x, y);
		}
	}
}