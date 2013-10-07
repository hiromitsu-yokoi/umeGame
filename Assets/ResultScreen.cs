using UnityEngine;
using System.Collections;

public class ResultScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// scene change
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			Application.LoadLevel("title");
		}
	
		// scene change
		if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			Application.LoadLevel("game");
		}

	}
}
