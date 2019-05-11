using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

    float movement = 0.0f;
    float moveSpeed = 400.0f;
	
	void Update ()
    {
        movement = Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed;
        FixedUpdate();
	}
    
    private void FixedUpdate()
    {
        transform.Translate(movement, 0, 0);
    }

}
