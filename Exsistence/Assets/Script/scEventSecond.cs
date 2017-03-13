using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEventSecond : MonoBehaviour, iEvent {

    public scRunner Runner;

    // Use this for initialization
    void Start () {
        Runner.SetEvent(this);
        Runner.evtidx++;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Run()
    {
        Debug.Log("이벤트 실행 됨2");
    }
}
