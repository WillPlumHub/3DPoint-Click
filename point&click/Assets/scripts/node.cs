using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public abstract class node : MonoBehaviour {

    public Transform cameraPosition;
    public List<node> reachableNodes = new List<node>();

    [HideInInspector]
    public Collider col;

    void Start () {
        col = GetComponent<Collider>();
    }

    void OnMouseDown() {
        Arrive();
    }

    public virtual void Arrive() {
        //leave excisting current node
        if(gameManager.ins.currentNode != null)
        gameManager.ins.currentNode.Leave();

        //set tcurrent node
        gameManager.ins.currentNode = this;

        //move the camera
        gameManager.ins.rig.AlignTo(cameraPosition);

        //turn off our own collider
        if (col != null)
            col.enabled = false;

        //turn on all reachable node's colliders
        foreach (node node in reachableNodes) {
            if (node.col != null) {
                node.col.enabled = true;
            }
        }
    }

    public virtual void Leave() {
        //turn off all reachable node's colliders
        foreach (node node in reachableNodes)
        {
            if (node.col != null)
            {
                node.col.enabled = false;
            }
        }
    }
}