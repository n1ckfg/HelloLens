using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushSquare : LADrawing {

    public float size = 1f;

    private void Start() {
        if (createOnStart) makeSquare(transform.position, size);
    }

    public List<BrushStroke> makeSquare(Vector3 pos, float size) {
        float s = size / 2f;
        Vector3 p1 = new Vector3(-s, -s, 0f) + pos;
        Vector3 p2 = new Vector3(-s, s, 0f) + pos;
        Vector3 p3 = new Vector3(s, -s, 0f) + pos;
        Vector3 p4 = new Vector3(s, s, 0f) + pos;
        strokes.Add(makeLine(p1, p2));
        strokes.Add(makeLine(p1, p3));
        strokes.Add(makeLine(p4, p2));
        strokes.Add(makeLine(p4, p3));

        return strokes;
    }

}
