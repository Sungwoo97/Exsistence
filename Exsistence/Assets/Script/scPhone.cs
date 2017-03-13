using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scPhone : MonoBehaviour {
    GameObject phone;
    private int iphone = 0;
    // Use this for initialization
    void Start () {
        phone = transform.Find("phone").gameObject;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (iphone == 0)
            { phone.SetActiveRecursively(true); iphone = 1; }
            else
            { phone.SetActiveRecursively(false); iphone = 0; }
        }
        
    } 
}
