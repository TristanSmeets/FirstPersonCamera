using UnityEngine;

public class Controllable : MonoBehaviour
{
	public void MoveForward(float speed)
	{
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

	public void MoveLeft(float speed)
	{
		transform.Translate(Vector3.left * speed * Time.deltaTime);
	}

	public void MoveRight(float speed)
	{
		transform.Translate(Vector3.right * speed * Time.deltaTime);
	}

	public void MoveBackward(float speed)
	{
		transform.Translate(Vector3.back * speed * Time.deltaTime);
	}

	public void HorizontalRotation(float value)
	{
		transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.eulerAngles.x, value, transform.rotation.eulerAngles.z));
	}

	public void VerticalRotation(float value)
	{
		transform.rotation = Quaternion.Euler(new Vector3(value, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z));
	}
}
