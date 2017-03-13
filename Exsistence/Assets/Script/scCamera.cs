using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scCamera : MonoBehaviour {
    private Transform tr;
    public float rotSpeed = 100.0f;
    
    // Use this for initialization
    void Start () {
        tr = GetComponent<Transform>();
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("tr.rotation.x: "+ tr.rotation.x);
        /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            Debug.Log(hit.collider.gameObject.name);
            Debug.DrawLine(ray.origin, hit.point);
            if (hit.collider.tag == "phone")
                Cursor.visible = true;

        }*/
        if (tr.rotation.x <= 0.45 && tr.rotation.x >= -0.45) 
            tr.Rotate(Vector3.left * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse Y")); //x -45~45
    }
}
