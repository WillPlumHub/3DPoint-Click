using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {

    public static gameManager ins;


    [HideInInspector]
    public node currentNode;
    public item itemHeld;

    public cameraRig rig;

    void Awake() {
        ins = this;
    }

    void Update() {
        if (Input.GetMouseButtonDown(1) && currentNode.GetComponent<prop>() != null) {
            currentNode.GetComponent<prop>().loc.Arrive();
        }
    }
}
