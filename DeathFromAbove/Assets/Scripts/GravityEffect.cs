using UnityEngine;
using System.Collections;

public class GravityEffect : MonoBehaviour {
    Rigidbody rigidBody;
	// Use this for initialization
	void Start () 
    {

        rigidBody = gameObject.GetComponent<Rigidbody>();
        GravityManager.instance.eventGravitation += EventGravitation;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
    void EventGravitation()
    {
        Vector3 diff = transform.position - GravityManager.instance.target.position;
        rigidBody.AddForce(diff.normalized * GravityManager.instance.force);

    }
   //void OnDisable()
   //{
   //
   //    GravityManager.instance.eventGravitation -= EventGravitation;
   //}
    void OnDestroy()
    {
        if(GravityManager.instance)
        GravityManager.instance.eventGravitation -= EventGravitation;
    }
}
