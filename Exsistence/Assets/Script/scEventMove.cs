using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEventMove : MonoBehaviour {
    public GameObject moveobj;
    public Transform startObj, endObj;
    public Vector3 startVec, endVec;
    public float speed = 1.0F;
    private float startTime;
    private float length;
    // Use this for initialization
    void Start () {
        //startTime = Time.time;
        
	}
	
	// Update is called once per frame
	void Update () {
        move();

    }

    void move()
    {
        startVec =startObj.transform.position;
        endVec = endObj.transform.position;
        moveobj.transform.position =Vector3.Lerp(startVec, endVec, 0.5f);
    }

    /*
    void move(Vector3 startVec ,Vector3 endVec)
    {
        length = Vector3.Distance(startVec, endVec);
    }
    void move(Object startObj , Object endObj)
    {
        //startVec = 
        length = Vector3.Distance(startVec, endVec);
    }
    */
}
