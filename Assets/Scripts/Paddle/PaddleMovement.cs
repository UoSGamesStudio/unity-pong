using UnityEngine;

namespace ShefGDS.Paddle
{
	[AddComponentMenu("Pong/Paddle/Paddle Movement")]
	[RequireComponent(typeof(PaddleController), typeof(Rigidbody2D))]
	public class PaddleMovement : PaddleComponentMonoBehaviour
	{
		[SerializeField] float moveSpeed = 5;
		
		Rigidbody2D _rigidbody;

		void Start()
		{
			_rigidbody = Controller.GetComponent<Rigidbody2D>();
		}

		public override void Tick(Vector2 move)
		{
			var newPos = move * (moveSpeed * Time.deltaTime) + _rigidbody.position;
			Controller.PaddleBox.RestrictPosition(ref newPos);

			_rigidbody.MovePosition(newPos);
		}
	}
}