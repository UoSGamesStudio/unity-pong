using UnityEngine;

namespace ShefGDS.Paddle
{
	public class NullPaddleBox : IPaddleBox
	{
		public Vector2 BoxDimensions => Vector2.zero;
		public void RestrictPosition(ref Vector2 attemptedNewPos)
		{ }
	}
}