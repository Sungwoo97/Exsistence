﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 작성자 : 우신현

public class scEventRunnerTime : MonoBehaviour {

    iEvent evt;
    public int evtidx;  //이벤트 인덱스 변수
    public bool MainEvent = true;  //메인 이벤트, 서브 이벤트 구분 변수
    public float sec;

    void Awake() { }
    void Start() { }
    void Update() { }

    public void SetEvent(iEvent ev)
    {
        evt = ev;
    }

    void OnTriggerEnter(Collider coll)    //충돌처리
    {
        Debug.Log("충돌하였음");
        /*
        Debug.Log(evtidx);
        Debug.Log(scGameManager.instance.eventIndex);
        */

        if (evtidx == scGameManager.instance.eventIndex)
        {
            StartCoroutine(Silhaeng());
        }
    }

    IEnumerator Silhaeng()
    {
        yield return new WaitForSeconds(sec);
        evt.Run();

        if (MainEvent)
        { scGameManager.instance.eventIndex++; }
        /*
         Debug.Log("GameManager의 eventIndex : " + scGameManager.instance.eventIndex);
        Debug.Log("Runner의 evtidx : " + evtidx);
        */
    }
}