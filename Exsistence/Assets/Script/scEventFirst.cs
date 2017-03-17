using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEventFirst : MonoBehaviour , iEvent{

    public scRunner Runner;
    public scSound Sound;
    // Use this for initialization
    void Start () {
        Runner.SetEvent(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Run()
    {
        //Debug.Log("이벤트 실행 됨");
        

    }

}