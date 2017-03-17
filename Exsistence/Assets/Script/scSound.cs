using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scSound : MonoBehaviour {
    
    public AudioSource audio; //
    public AudioClip SoundClip;
    [Range(0f, 15f)]
    public float soundMinDistance;
    [Range(15f, 30f)]
    public float soundMaxDistance;
    public bool rangeSet; // 이거 체크하면 게임안에서 크기 변경 가능함 
   

    // Use this for initialization
    void Start () {
        audio = gameObject.AddComponent<AudioSource>();
        audio.clip = SoundClip;
        soundSet(soundMinDistance,soundMaxDistance);


    }
	
	// Update is called once per frame
	void Update () {
        if (rangeSet == true)
        {
            soundSet(soundMinDistance, soundMaxDistance);// 계속 값 바꾸고 싶어서 update에 놓음 
        }
    }

    public void soundSet( float soundMinDistance , float soundMaxDistance)
    {
        
        audio.minDistance = soundMinDistance;
        audio.maxDistance = soundMaxDistance;

        //Debug.Log(audio.minDistance + "audio.minDistance");
        //Debug.Log(audio.maxDistance + "audio.maxDistance");
    }

    public void soundRun()
    {
        audio.PlayOneShot(SoundClip);
    }
}
