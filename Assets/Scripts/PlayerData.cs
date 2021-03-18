using ShefGDS.Input;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ShefGDS
{
	[CreateAssetMenu(menuName = "Player", order = 0)]
	public class PlayerData : ScriptableObject
	{
		public int points = 0;
		public ControlScheme controlScheme;
	}
}