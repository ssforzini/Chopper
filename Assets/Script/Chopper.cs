using UnityEngine;

public class Chopper : MonoBehaviour {

	[SerializeField]private float movementSpeed;
	[SerializeField]private float rotationSpeed;
	[SerializeField]private float rotorSpeed;
	[SerializeField]private float backRotorSpeed;

	void Update () {

		transform.FindChild ("rotor").Rotate (Vector3.forward * Time.deltaTime * rotorSpeed);
		transform.FindChild ("rear rotor").Rotate (Vector3.forward * Time.deltaTime * backRotorSpeed);
		transform.FindChild ("rear rotor.001").Rotate (Vector3.back * Time.deltaTime * backRotorSpeed);
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate (Vector3.back * Time.deltaTime * movementSpeed);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate (Vector3.forward * Time.deltaTime * movementSpeed);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate (Vector3.down * Time.deltaTime * rotationSpeed);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate (Vector3.up * Time.deltaTime * rotationSpeed);
		}
		if(Input.GetKey(KeyCode.A)){
			transform.Translate (Vector3.up * Time.deltaTime * movementSpeed);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate (Vector3.down * Time.deltaTime * movementSpeed);
		}
	}
}
