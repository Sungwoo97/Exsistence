﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 작성자 : 우신현

public class scEventFirst : MonoBehaviour , iEvent{

    public scEventRunner Runner;
    
    // Use this for initialization
    void Start () {
        Runner.SetEvent(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Run()
    {
        Debug.Log("first 이벤트 실행 됨");
    }

}