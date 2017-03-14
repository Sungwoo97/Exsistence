using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCobjHUD : MonoBehaviour {
    public TextMesh hudText;
    public float objside;
    public bool interaction = false;
    private Transform interactionTr;
    private Transform playerTr;
    private MeshRenderer interactionMesh;
    private CapsuleCollider playerRd;
	// Use this for initialization
	void Start () {
        interactionTr = GameObject.Find("interaction").transform;
        playerTr = GameObject.Find("Capsule").transform;
        interactionMesh = GameObject.Find("interaction").GetComponent<MeshRenderer>();
        interactionMesh.enabled = false;
        playerRd = GameObject.Find("Capsule").GetComponent<CapsuleCollider>();
        objside = playerRd.radius;
    }

    // Update is called once per frame
    void Update() {
        float distance = Vector3.Distance(interactionTr.position, transform.position);
        if (distance <= objside)
        {
            interactionMesh.enabled = true;
            if (interaction != false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    print("e눌림");
                }
            }
        }
        else
        {
            interactionMesh.enabled = false;
        }
            }
}
