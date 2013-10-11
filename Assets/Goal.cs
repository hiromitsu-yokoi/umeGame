using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	private void OnCollisionEnter(Collision collision)
	{	
		if(	collision.gameObject.tag == "Player"	&&
			Item.nNum == 0)
		{
			Application.LoadLevel("result");
		}
	} 
}
