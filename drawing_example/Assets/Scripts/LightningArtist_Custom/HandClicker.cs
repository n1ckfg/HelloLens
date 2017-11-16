using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandClicker : MonoBehaviour {

    public Transform tracker;
    public HoloLensHandTracking.HandsTrackingController hands;
    public HoloToolkit.Unity.InputModule.AnimatedCursor cursor;
    public bool handDown = false;
    public bool handPressed = false;
    public bool handUp = false;
    public Vector3 pos = Vector3.zero;
    public float smoothing = 0.5f;
    
    private void Update () {
        handDown = false;
        handUp = false;

        if ("" + cursor.CursorState == "Select") {
            if (!handPressed) {
                handDown = true;
                debugHand();
            }
            handPressed = true;
        } else {
            if (handPressed) {
                handUp = true;
                debugHand();
            }
            handPressed = false;
        }

        try {
            pos = Vector3.Lerp(pos, hands.lastPos, smoothing);
            tracker.position = pos;
        } catch (UnityException e) { }
	}

    void debugHand() {
        Debug.Log("Hand DOWN: " + handDown + ", UP: " + handUp);
    }

}
