using UnityEngine;

namespace ShefGDS
{
	public class GameManager : MonoBehaviour
	{
		[SerializeField] Ball ball;

		[SerializeField] Transform neutralPosition;

		void Start()
		{
			if (ball == null)
				Debug.LogWarning(nameof(ball) + " is not set");
		}
		
		public void StartGame()
		{
			ball.transform.position = neutralPosition.position;
		}

		public void OnGoalScored(Player player)
		{
			
		}
	}
}