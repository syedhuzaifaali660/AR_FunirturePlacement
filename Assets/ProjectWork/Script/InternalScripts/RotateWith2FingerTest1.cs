using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DigitalRubyShared;

public class RotateWith2FingerTest1 : MonoBehaviour
{

    public GameObject Object;


    private PanGestureRecognizer panGesture;
    private RotateGestureRecognizer rotateGesture;


    private void RotateGestureCallback(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Executing)
        {
            Object.transform.Rotate(0.0f, rotateGesture.RotationRadiansDelta * -Mathf.Rad2Deg, 0.0f);
        }
    }

    private void CreateRotateGesture()
    {
        rotateGesture = new RotateGestureRecognizer();
        rotateGesture.StateUpdated += RotateGestureCallback;
        FingersScript.Instance.AddGesture(rotateGesture);
    }
    // Start is called before the first frame update
    void Start()
    {
        CreateRotateGesture();

    }

    private void LateUpdate()
    {

        int touchCount = Input.touchCount;
        if (FingersScript.Instance.TreatMousePointerAsFinger && Input.mousePresent)
        {
            touchCount += (Input.GetMouseButton(0) ? 1 : 0);
            touchCount += (Input.GetMouseButton(1) ? 1 : 0);
            touchCount += (Input.GetMouseButton(2) ? 1 : 0);
        }
        string touchIds = string.Empty;
        int gestureTouchCount = 0;
        foreach (GestureRecognizer g in FingersScript.Instance.Gestures)
        {
            gestureTouchCount += g.CurrentTrackedTouches.Count;
        }
        foreach (GestureTouch t in FingersScript.Instance.CurrentTouches)
        {
            touchIds += ":" + t.Id + ":";
        }

    
    }
}
