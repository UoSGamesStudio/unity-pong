using UnityEngine;
using static ShefGDS.EMath;

namespace ShefGDS.Paddle
{
	[AddComponentMenu("Pong/Paddle/Paddle Rotation")]
	[RequireComponent(typeof(PaddleController))]
	public class PaddleRotation : PaddleComponentMonoBehaviour
	{
		[SerializeField, Range(0, 80)] float maxRotation = 60;
		[SerializeField, Min(0)] float rotationSpeed = 8;

		Transform _transform;
		
		float _currentRotation;

		void Start()
		{
			_transform = transform;
		}

		public override void Tick(Vector2 move)
		{
			var rotationWeight = -move.y;
			var targetRotation = Remap(rotationWeight, -1, 1, -maxRotation, maxRotation);
			_currentRotation = Mathf.MoveTowards(_currentRotation, targetRotation, rotationSpeed * Time.deltaTime);
			_transform.rotation = Quaternion.Euler(0, 0, _currentRotation);
		}
	}
}