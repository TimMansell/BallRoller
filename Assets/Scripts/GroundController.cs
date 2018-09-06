using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	

    private void FixedUpdate()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.right * moveVertical);
        transform.Rotate(Vector3.forward * moveHorizontal);
    }
}
