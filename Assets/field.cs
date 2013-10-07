using UnityEngine;
using System.Collections;

public class field : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 VecRoll;
		Vector3 Roll;
		Quaternion FiledRoll;
		FiledRoll = transform.rotation;
		VecRoll = Input.acceleration;
		Roll.x = VecRoll.x * 12.8f;
		Roll.y = -9.8f;
		Roll.z = VecRoll.y * 12.8f;
		
		if(Input.GetKey(KeyCode.A))
		{
			Roll.x = -12.8f;			
		}
		if(Input.GetKey(KeyCode.D))
		{
			Roll.x = 12.8f;						
		}
		if(Input.GetKey(KeyCode.S))
		{
			Roll.z = -12.8f;		
		}
		if(Input.GetKey(KeyCode.W))
		{
			Roll.z = 12.8f;		
		}
		
		Physics.gravity = Roll;
	}
}
