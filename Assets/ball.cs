using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		// gameover
		if(transform.position.y < -5.0f)
		{
			Application.LoadLevel("result");
		}	
		
	}
	
	private void OnCollisionStay(Collision collision)
	{
		if(Input.acceleration.magnitude > 1.5f || Input.GetKey(KeyCode.Space))
		{
			rigidbody.velocity = new Vector3(rigidbody.velocity.x,
											 10.0f,
											 rigidbody.velocity.z);
		}

	}
}
