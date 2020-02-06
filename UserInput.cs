using UnityEngine;

public class UserInput : InputProvider
{
	[SerializeField] float movementSpeed = 5;
	[SerializeField] bool inverseY = false;
	float horizontal, vertical;

	// Update is called once per frame
	void Update()
	{
		keyboardInput();
		mouseInput();
	}

	private void keyboardInput()
	{
		if (Input.GetKey(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
			ExecuteOnMoveForward(movementSpeed);
		if (Input.GetKey(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
			ExecuteOnMoveBackward(movementSpeed);
		if (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
			ExecuteOnMoveLeft(movementSpeed);
		if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
			ExecuteOnMoveRight(movementSpeed);
	}

	private void mouseInput()
	{
		horizontal += Input.GetAxis("Mouse X");
		vertical += Input.GetAxis("Mouse Y");
		vertical = Mathf.Clamp(vertical, -89, 89);
		if (inverseY)
			ExecuteOnVerticalMouse(-vertical);
		else
			ExecuteOnVerticalMouse(vertical);
		ExecuteOnHorizontalMouse(horizontal);
	}
}
