using UnityEngine;

namespace ShefGDS.Paddle
{
	public interface IPaddleBox
	{
		Vector2 BoxDimensions { get; }

		void RestrictPosition(ref Vector2 attemptedNewPos);
	}
}