using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseHandTarget : MonoBehaviour {

    public float speed = 0.5f;

    private Transform target;

    void Update () {
		if (target == null) {
            target = GameObject.FindWithTag("HandTarget").transform;
            if (target == null) return;
        }

        transform.position = Vector3.Lerp(transform.position, target.position, speed);
	}
}
