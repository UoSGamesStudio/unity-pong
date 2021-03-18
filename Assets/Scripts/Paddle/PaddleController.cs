using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ShefGDS.Paddle
{
	[AddComponentMenu("Paddle/Paddle Controller")]
	public class PaddleController : MonoBehaviour
	{
		[SerializeField] PlayerData owningPlayerData;

		[NonSerialized] public Vector2 BallLaunchDirection = Vector2.left;
		
		Action<Vector2> _onMove;
		
		readonly IList<IPaddleComponent> _components = new List<IPaddleComponent>();

		Vector2 _moveVector;
		
		public event Action<Vector2> OnMoveEvent
		{
			add => _onMove += value;
			remove => _onMove -= value;
		}

		public IPaddleBox PaddleBox { get; set; } = new NullPaddleBox();

		public void AddPaddleComponent(IPaddleComponent paddleComponent) => _components.Add(paddleComponent);

		public void RemovePaddleComponent(IPaddleComponent paddleComponent) => _components.Remove(paddleComponent);

		public void SetPlayerData(PlayerData playerData) => owningPlayerData ??= playerData;

		// Called by a Unity Event
		public void OnMove(InputAction.CallbackContext context)
		{
			_moveVector = context.ReadValue<Vector2>();
			_onMove?.Invoke(_moveVector);
		}

		void Update()
		{
			for (var i = _components.Count - 1; i > -1; i--)
				_components[i].Tick(_moveVector);
		}

		void OnCollisionEnter2D(Collision2D other)
		{
			var ball = other.gameObject.GetComponent<Ball>();
			if (!ball)
				return;
			
			ball.SetVelocity(BallLaunchDirection * ball.Speed);
		}
	}
}