using UnityEngine;
using System.Collections;

public class GravityManager : MonoBehaviour {
    public static GravityManager instance;
    public float force = -9.81f;
    Transform _target;
    public Transform target {get { return _target;} set{_target = value;}}
    public delegate void Gravitation();
    public event Gravitation eventGravitation;
	// Use this for initialization
	void Awake () 
    {
        if (!instance)
        {
            instance = this;
        }
        else 
        {
            Destroy(this);
        }
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        if (eventGravitation.GetInvocationList().Length > 0)
        {
            eventGravitation();
        }
	}

    void OnDestroy()
    {
        eventGravitation = null;
        instance = null;
    }

}
