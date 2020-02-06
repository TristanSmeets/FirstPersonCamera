using UnityEngine;

[RequireComponent(typeof(Controllable), typeof(UserInput))]
public class CameraMovement : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
		Controllable controllable = GetComponent<Controllable>();
		InputProvider inputProvider = GetComponent<InputProvider>();

		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;

		//Hook up the components
		inputProvider.OnMoveForward += controllable.MoveForward;
		inputProvider.OnMoveBackward += controllable.MoveBackward;
		inputProvider.OnMoveLeft += controllable.MoveLeft;
		inputProvider.OnMoveRight += controllable.MoveRight;
		inputProvider.OnVerticalMouse += controllable.VerticalRotation;
		inputProvider.OnHorizontalMouse += controllable.HorizontalRotation;
	}
}
