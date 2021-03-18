using System;
using UnityEngine;

namespace ShefGDS.Paddle
{
	[RequireComponent(typeof(PaddleController))]
	public abstract class PaddleComponentMonoBehaviour : MonoBehaviour, IPaddleComponent
	{
		protected PaddleController Controller;

		void Awake()
		{
			Controller = GetComponent<PaddleController>();
			Controller.AddPaddleComponent(this);
		}

		void OnDestroy()
		{
			Controller.RemovePaddleComponent(this);
		}

		public abstract void Tick(Vector2 move);
	}
}