using System.Collections;
using UnityEngine;

namespace ShefGDS
{
	[AddComponentMenu("Pong/Game Manager")]
	public class GameManager : MonoBehaviour
	{
		[SerializeField] Ball ball;

		[SerializeField] Transform ballNeutralPosition;

		[SerializeField, Min(0)] float deferredStartTimeout = 2;

		Player[] _players;

		void Start()
		{
			if (ball == null)
			{
				Debug.LogWarning(nameof(ball) + " is not set");
				return;
			}

			var neutralPos = ballNeutralPosition.position;
			ball.SetPosition(neutralPos);
			ball.SetVelocity(Vector2.zero);

			foreach (var goal in FindObjectsOfType<Goal>())
				goal.OnScoreEvent += OnGoalScored;
		}

		public void DeferredStartGame()
		{
			StartCoroutine(DeferredStart());
		}

		public void StartGame()
		{
			_players = FindObjectsOfType<Player>();
			var index = (int)(Random.value * _players.Length);
			var startPlayer = _players[index];

			var neutralPos = ballNeutralPosition.position;
			ball.SetPosition(neutralPos);
			ball.SetVelocity(startPlayer.Goal.transform.position - neutralPos);
		}

		void OnGoalScored(PlayerData playerData)
		{
			playerData.points++;	
		}

		IEnumerator DeferredStart()
		{
			yield return new WaitForSeconds(deferredStartTimeout);
			StartGame();
		}
	}
}