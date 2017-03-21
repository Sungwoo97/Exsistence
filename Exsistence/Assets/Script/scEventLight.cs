using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scEventLight : MonoBehaviour {
    public GameObject obj;

	// Use this for initialization
	void Start ()
    {
	
	}

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider coll)
    {
        Debug.Log("Triger 충돌하였음");
        if (coll.name == "Collider")
        {
            obj.SetActive(false);
        }
    }

}
