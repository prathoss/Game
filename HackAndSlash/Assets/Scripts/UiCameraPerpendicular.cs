using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiCameraPerpendicular : MonoBehaviour {

    public Camera Camera;

	// Use this for initialization
	void Start () {
        Camera = Camera.main;
        transform.Rotate(0, 180, 0);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 v = Camera.transform.position - transform.position;

        v.x = v.z = 0f;
        transform.LookAt(Camera.transform.position - v);
	}
}
