using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushInputHoloLens : MonoBehaviour {

    public LightningArtist latk;
    public HoloLensHandTracking.HandsTrackingController hands;
    public float smoothing = 0.5f;
    public bool doSmoothing = true;
    public int startingFrames = 12;

    private bool firstRun = true;

    private void Awake() {
        if (latk == null) latk = GetComponent<LightningArtist>();
    }

    private void Update() {
        if (firstRun) {
            for (int i = 0; i < startingFrames-1; i++) {
                latk.inputNewFrame();
            }
            latk.inputPlay();
            firstRun = false;
        }

        try {
            if (doSmoothing) {
                latk.target.position = Vector3.Lerp(latk.target.position, hands.lastPos, smoothing);
            } else {
                latk.target.position = hands.lastPos;
            }
        } catch (UnityException e) { }

        latk.clicked = hands.handPressed;
    }

}
