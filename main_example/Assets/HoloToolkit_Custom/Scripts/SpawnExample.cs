using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnExample : MonoBehaviour {

    public GameObject prefab;
    public Transform root;
    public Vector3 offset = Vector3.zero;

    private BasicController ctl;
    private HoloLensHandTracking.HandsTrackingController handMgr;

    private void Awake() {
        ctl = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<BasicController>();
        handMgr = GameObject.FindGameObjectWithTag("HandManager").GetComponent<HoloLensHandTracking.HandsTrackingController>();
    }

    private void Update() {
        if (handMgr.handDown) {
            Debug.Log("!!!" + ctl.lastHitPos);
            Instantiate(prefab, ctl.lastHitPos + offset, Quaternion.identity, root);
        }
    }

}
