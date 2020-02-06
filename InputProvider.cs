using System;
using UnityEngine;

public class InputProvider : MonoBehaviour
{
	public event Action<float> OnMoveForward = delegate { };
	public event Action<float> OnMoveLeft = delegate { };
	public event Action<float> OnMoveRight = delegate { };
	public event Action<float> OnMoveBackward = delegate { };
	public event Action<float> OnHorizontalMouse = delegate { };
	public event Action<float> OnVerticalMouse = delegate { }; 

	protected void ExecuteOnMoveForward(float speed) { OnMoveForward(speed); }
	protected void ExecuteOnMoveLeft(float speed) { OnMoveLeft(speed); }
	protected void ExecuteOnMoveRight(float speed) { OnMoveRight(speed); }
	protected void ExecuteOnMoveBackward(float speed) { OnMoveBackward(speed); }
	protected void ExecuteOnHorizontalMouse(float value) { OnHorizontalMouse(value); }
	protected void ExecuteOnVerticalMouse(float value) { OnVerticalMouse(value); }
}
