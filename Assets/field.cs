using UnityEngine;
using System.Collections;

public class field : MonoBehaviour {
	
	static float fSlope; 
	
	// Use this for initialization
	void Start () {
		
		fSlope = 25.4f;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 VecRoll;
		Vector3 Roll;
		VecRoll = Input.acceleration;
/*
		Roll.x = VecRoll.y;
		Roll.y = 0.0f;
		Roll.z = -VecRoll.x;
		
		transform.Rotate(Roll);
*/		
		Roll.x = VecRoll.x * fSlope;
		Roll.y = -9.8f;
		Roll.z = (VecRoll.y + 0.7f ) * fSlope;
		
		if(Input.GetKey(KeyCode.A))
		{
			Roll.x = -fSlope;			
		}
		if(Input.GetKey(KeyCode.D))
		{
			Roll.x = fSlope;						
		}
		if(Input.GetKey(KeyCode.S))
		{
			Roll.z = -fSlope;		
		}
		if(Input.GetKey(KeyCode.W))
		{
			Roll.z = fSlope;		
		}
		
		Physics.gravity = Roll;
	}
}
