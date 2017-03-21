using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scRunner : MonoBehaviour {

    iEvent evt;
    public int evtidx = 0;  //이벤트 인덱스 변수
	// Use this for initialization
	void Awake () {
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void SetEvent(iEvent ev)
    {
        evt = ev;
    }

    void OnCollisionEnter(Collision coll)    //충돌처리
    {
        Debug.Log("충돌하였음"); //충돌감지
        if (true)
        {
            evt.Run();
            
            scGameManager.instance.eventIndex++;
            evtidx++;
            Debug.Log(scGameManager.instance.eventIndex);
        }
    }
    
    void OnTriggerEnter(Collider coll)
    {
        Debug.Log("Triger 충돌하였음");
        if(true)
        {
            scGameManager.instance.eventIndex++;
            evtidx++;
        }
    }
}

public interface iEvent
{
    void Run();
}
