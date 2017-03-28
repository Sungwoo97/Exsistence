using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scSound : MonoBehaviour, iEvent
{
    
    scRunner Runner;
    public AudioSource audio; //
    public AudioClip SoundClip;
    public string soundName = null;
    
    // Range
    [Range(0f, 15f)]
    public float soundMinDistance;
    [Range(15f, 30f)]
    public float soundMaxDistance;
    [Range(0f, 1f)]
    public float soundVolume=1f;
   

    // 체크박스 
    public bool loopSet; //몇 번 루프할건지(혹은 무한), 얼마나 지속되는지
    public bool rangeSet; // 이거 체크하면 게임안에서 크기 변경 가능함 
                 

    // Use this for initialization
    void Awake () {
        audio = gameObject.AddComponent<AudioSource>();
        audio.clip = SoundClip;
        //Runner.SetEvent(this); // 이거의 존재 의미를 잘 모르겠음  
        soundSet();
        


    }
	
	// Update is called once per frame
	void Update () {
        if (rangeSet == true)
        {
            soundSet();// 계속 값 바꾸고 싶어서 update에 놓음 
        }
    }

    public void soundSet()
    {
        
        audio.minDistance = soundMinDistance;
        audio.maxDistance = soundMaxDistance;
        audio.loop = loopSet;
        audio.volume = soundVolume;



        //Debug.Log(audio.minDistance + "audio.minDistance");
        //Debug.Log(audio.maxDistance + "audio.maxDistance");
    }

    public void Run()
    {
        audio.PlayOneShot(SoundClip);
    }
}
