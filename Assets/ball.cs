using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.acceleration.magnitude > 1.5f || Input.GetKey(KeyCode.Space))
		{
			rigidbody.velocity = new Vector3(rigidbody.velocity.x,
											 5.0f,
											 rigidbody.velocity.z);
		}
	}
}