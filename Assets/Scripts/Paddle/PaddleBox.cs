using System;
using UnityEngine;

namespace ShefGDS.Paddle
{
	[AddComponentMenu("Pong/Paddle/Paddle Box")]
	public class PaddleBox : MonoBehaviour, IPaddleBox
	{
		[SerializeField] Vector2 boxDimensions = new Vector2(8, 5);

		public Vector2 BoxDimensions => boxDimensions;

		Vector2 _boxMin, _boxMax;
		
		void Start()
		{
			OnValidate();
		}

		void OnValidate()
		{
			Vector2 position = transform.position;
			var dimensions = boxDimensions * 0.5f;
			_boxMin = position - dimensions;
			_boxMax = position + dimensions;
		}

		public void RestrictPosition(ref Vector2 attemptedNewPos)
		{
			// Debug.Log(attemptedNewPos);
			attemptedNewPos.x = Mathf.Clamp(attemptedNewPos.x, _boxMin.x, _boxMax.x);
			attemptedNewPos.y = Mathf.Clamp(attemptedNewPos.y, _boxMin.y, _boxMax.y);
			// Debug.Log(attemptedNewPos);
		}

		void OnDrawGizmos()
		{
			Gizmos.color = new Color(0.3f, 0, 1, 0.5f);
			Gizmos.DrawWireCube(transform.position, boxDimensions);
		}
	}
}