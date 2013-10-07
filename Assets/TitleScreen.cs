using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// scene change
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			Application.LoadLevel("game");
		}
		
		// scene change
		if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			Application.LoadLevel("result");
		}

	}
}
