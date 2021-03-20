using UnityEngine;
using System.Collections;

public class switcher : interactable {

    public bool state;

    //event setup
    public delegate void OnStateChange();
    public event OnStateChange Change;

    public override void Interact() {
        state = !state;
        if (Change != null) {
            Change();
        }
    }
}