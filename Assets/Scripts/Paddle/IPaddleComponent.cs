using UnityEngine;

namespace ShefGDS.Paddle
{
	public interface IPaddleComponent
	{
		void Tick(Vector2 move);
	}
}