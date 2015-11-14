using UnityEngine;
using System.Collections;

public class PlanetScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GravityManager.instance.target = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Onestroy()
    {
        GravityManager.instance.target = null;
    }
}
