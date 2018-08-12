using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobberBehavior : MonoBehaviour
{
    [Range(2.5f, 50.0f)]
    public float speed = 5.0f;

    private Rigidbody BobberRB;

	// Use this for initialization
	void Start ()
    {
        BobberRB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        BobberRB.AddForce(movement * speed);
    }
}
