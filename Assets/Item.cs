using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	
	public static int nNum;
	
	// Use this for initialization
	void Start () {
		nNum++;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Player")
		{
			nNum--;
			Destroy(gameObject);
		}
	}
	
	int GetNumIten() {
		return nNum;
	}
}
