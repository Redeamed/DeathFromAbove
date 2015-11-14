using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
    Rigidbody myRigidBody;
    Transform source;
    public bool forward = true;
    public float speed = 6.0f;
	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody>();
        source = transform.GetChild(0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (forward)
        {
            myRigidBody.AddForce(source.forward * speed);
        }
	}
}
