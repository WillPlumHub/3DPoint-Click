using UnityEngine;
using System.Collections;

public abstract class stateReactor : MonoBehaviour {

    public switcher switcher;

    protected virtual void Awake() {
        switcher.Change += React;
    }

    public virtual void React() {
        Debug.Log(name + "'s state is " + switcher.state);
    }
}