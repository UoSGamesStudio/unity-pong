using System;
using ShefGDS.Paddle;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ShefGDS
{
	[AddComponentMenu("Pong/Player")]
	public class Player : MonoBehaviour
	{
		[SerializeField] PlayerData playerData;

		[SerializeField] Goal goal;

		[SerializeField] PaddleBox paddleBox;
		
		[SerializeField] GameObject paddleControllerPrefab;
		[SerializeField] PaddleController paddleController;

		public Goal Goal => goal;
		
		public PaddleController PaddleController { get; private set; }
		
		void Awake()
		{
			playerData ??= ScriptableObject.CreateInstance<PlayerData>();

			goal ??= GetComponentInChildren<Goal>();

			// PaddleController = PlayerInput
			// 	.Instantiate(paddleControllerPrefab, controlScheme: playerData.controlScheme, pairWithDevice: Keyboard.current)
			// 	.GetComponent<PaddleController>();
			
			// PaddleController.transform.SetParent(transform);
			
			paddleBox ??= GetComponentInChildren<PaddleBox>();
		}

		void Start()
		{
			goal.SetPlayerData(playerData);
			paddleController.SetPlayerData(playerData);
			paddleController.PaddleBox = paddleBox;
		}
	}
}