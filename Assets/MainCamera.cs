using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {
	
	float fLastTouchRange;
	float fCameraRange;
	float fAngle;

	// Use this for initialization
	void Start () {
		Vector3  vecCameraPos;

		fCameraRange = 30;
		fAngle = 50.0f / 180 * Mathf.PI;
		
		vecCameraPos.x = 0.0f;
		vecCameraPos.y = Mathf.Sin(fAngle) * fCameraRange;
		vecCameraPos.z = -Mathf.Cos(fAngle) * fCameraRange;
		
		transform.position = vecCameraPos;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(2 == Input.touchCount)
		{
			float fTouchRange;
			Vector3  vecCameraPos;
			
			Touch touch0 = Input.GetTouch(0);
			Touch touch1 = Input.GetTouch(1);
			
			fTouchRange = Vector3.Distance(touch0.position,touch1.position);

			if(touch1.phase == TouchPhase.Began )
	        {	
				fLastTouchRange = fTouchRange;
			
			}else if(touch0.phase == TouchPhase.Moved ||
					 touch1.phase == TouchPhase.Moved )
	        {	
				fCameraRange += (fLastTouchRange - fTouchRange) * 0.01f;
				
				vecCameraPos.x = 0.0f;
				vecCameraPos.y = Mathf.Sin(fAngle) * fCameraRange;
				vecCameraPos.z = -Mathf.Cos(fAngle) * fCameraRange;

				transform.position = vecCameraPos;
			}
		}
	}
}
