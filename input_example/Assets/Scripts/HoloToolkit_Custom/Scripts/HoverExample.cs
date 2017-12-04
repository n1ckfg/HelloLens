using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverExample : MonoBehaviour {

    public Vector3 rot = Vector3.zero;

    private BasicController ctl;

    private void Awake() {
        ctl = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<BasicController>();
    }

    private void Update() {
        if (ctl.isLookingAt == gameObject.name) {
            transform.Rotate(rot);
        }
	}
}
