using UnityEngine;
using System.Collections;

[RequireComponent(typeof(prop))]
public abstract class interactable : MonoBehaviour {

	void Start () {
        this.enabled = false;
	}

    public virtual void Interact() {
        Debug.Log("interacting with " + name);
    }
}