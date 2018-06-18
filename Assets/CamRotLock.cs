using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotLock : MonoBehaviour
{
    public GameObject targetObject;
    private Vector3 ofset;


	// Use this for initialization
	void Start ()
	{
	    ofset = transform.position - targetObject.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

    void LateUpdate()
    {
        transform.position = targetObject.transform.position + ofset;
    }
}
