using UnityEngine;
using UnityEngine.InputSystem;

namespace ShefGDS.Paddle
{
	[AddComponentMenu("Pong/Paddle")]
	[RequireComponent(typeof(PlayerInput), typeof(Rigidbody2D), typeof(Collider2D))]
	public class Paddle : MonoBehaviour
	{
		[SerializeField] Player player;

		[SerializeField] float moveSpeed = 5;

		Rigidbody2D _rigidbody;
		IPaddleBox _paddleBox;

		Vector2 _moveVector;

		void Awake()
		{
			_rigidbody = GetComponent<Rigidbody2D>();
			_paddleBox = GetComponentInParent<IPaddleBox>() ?? new NullPaddleBox();
		}

		void Update()
		{
			var newPos = _moveVector * (moveSpeed * Time.deltaTime) + _rigidbody.position;
			_paddleBox.RestrictPosition(ref newPos);

			_rigidbody.MovePosition(newPos);
		}

		// Called by a Unity Event
		public void OnMove(InputAction.CallbackContext context)
		{
			_moveVector = context.ReadValue<Vector2>();
		}
	}
}