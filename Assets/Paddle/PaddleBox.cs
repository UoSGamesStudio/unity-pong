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
			Debug.Log(_boxMin + " " + _boxMax);
		}

		void OnValidate()
		{
			Vector2 position = transform.position;
			_boxMin = position - boxDimensions;
			_boxMax = position + boxDimensions;
		}

		public void RestrictPosition(ref Vector2 attemptedNewPos)
		{
			// Debug.Log(attemptedNewPos);
			attemptedNewPos.x = Mathf.Clamp(attemptedNewPos.x, _boxMin.x, _boxMax.x);
			attemptedNewPos.y = Mathf.Clamp(attemptedNewPos.y, _boxMin.y, _boxMax.y);
			// Debug.Log(attemptedNewPos);
		}
	}
}