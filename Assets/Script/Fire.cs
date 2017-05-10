using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)){
			RaycastHit hit;

			Debug.DrawRay (transform.position, transform.forward * 200f);
			/*if(Physics.Raycast(transform.position,transform.right,out hit)){
				hit.rigidbody.AddForceAtPosition (transform.right * 10f, hit.point, ForceMode.Impulse);
			}*/
		}
	}
}
