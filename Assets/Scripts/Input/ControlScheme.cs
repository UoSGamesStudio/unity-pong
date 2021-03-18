using UnityEngine;

namespace ShefGDS.Input
{
	[CreateAssetMenu(menuName = "Input/Control Scheme", order = 0)]
	public class ControlScheme : ScriptableObject
	{
		[SerializeField] string controlSchemeName = "KeyboardLeft";

		public string ControlSchemeName => controlSchemeName;

		public static implicit operator string(ControlScheme scheme) => scheme.controlSchemeName;
	}
}