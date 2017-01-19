using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject followObject;
    public float lerpValue;
    private Vector3 targetPosition;

	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.targetPosition = this.followObject.transform.position;
        float x = Lerp(lerpValue, this.transform.position.x, targetPosition.x);
        float y = Lerp(lerpValue, this.transform.position.y, targetPosition.y);
        this.transform.position = new Vector3(x, y, this.transform.position.z);
    }

    float Lerp(float a, float x1, float x2)
    {
        return (x2 - x1) * a + x1;

    }
}
