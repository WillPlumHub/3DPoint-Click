using UnityEngine;
using System.Collections;

public class prop : node {

    public location loc;
    interactable inter;

    void Start () {
        inter = GetComponent<interactable>();
    }

    public override void Arrive() {
        if (inter != null && inter.enabled) {
            inter.Interact();
        }

        base.Arrive();

        //make this object interactable if prerequisite is met
        if (inter != null) {

            inter.enabled = true;
        }
    }

    public override void Leave()
    {
        base.Leave();

        if (inter != null) {
            inter.enabled = false;
        }
    }
}