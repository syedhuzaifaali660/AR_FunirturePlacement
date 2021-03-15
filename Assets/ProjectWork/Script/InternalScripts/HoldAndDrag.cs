using DigitalRubyShared;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldAndDrag : MonoBehaviour
{

    private LongPressGestureRecognizer longPressGesture;

    public GameObject draggingAsteroid;


    private void BeginDrag(float screenX, float screenY)
    {
        Vector3 pos = new Vector3(screenX, screenY, 0.0f);
        pos = Camera.main.ScreenToWorldPoint(pos);
        RaycastHit2D hit = Physics2D.CircleCast(pos, 10.0f, Vector2.zero);
        if (hit.transform != null && hit.transform.gameObject.name == "Cube")
        {
            draggingAsteroid = hit.transform.gameObject;
            draggingAsteroid.GetComponent<Rigidbody>().velocity = Vector2.zero;
            draggingAsteroid.GetComponent<Rigidbody2D>().angularVelocity = 0.0f;
        }
        else
        {
            longPressGesture.Reset();
        }
    }

    private void DragTo(float screenX, float screenY)
    {
        if (draggingAsteroid == null)
        {
            return;
        }

        Vector3 pos = new Vector3(screenX, screenY, 0.0f);
        pos = Camera.main.ScreenToWorldPoint(pos);
        draggingAsteroid.GetComponent<Rigidbody2D>().MovePosition(pos);
    }

    private void EndDrag(float velocityXScreen, float velocityYScreen)
    {
        if (draggingAsteroid == null)
        {
            return;
        }

        Vector3 origin = Camera.main.ScreenToWorldPoint(Vector3.zero);
        Vector3 end = Camera.main.ScreenToWorldPoint(new Vector3(velocityXScreen, velocityYScreen, 0.0f));
        Vector3 velocity = (end - origin);
        draggingAsteroid.GetComponent<Rigidbody2D>().velocity = velocity;
        draggingAsteroid.GetComponent<Rigidbody2D>().angularVelocity = UnityEngine.Random.Range(5.0f, 45.0f);
        draggingAsteroid = null;

        //DebugText("Long tap flick velocity: {0}", velocity);
    }

    private void LongPressGestureCallback(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Began)
        {
            //DebugText("Long press began: {0}, {1}", gesture.FocusX, gesture.FocusY);
            BeginDrag(gesture.FocusX, gesture.FocusY);
        }
        else if (gesture.State == GestureRecognizerState.Executing)
        {
            //DebugText("Long press moved: {0}, {1}", gesture.FocusX, gesture.FocusY);
            DragTo(gesture.FocusX, gesture.FocusY);
        }
        else if (gesture.State == GestureRecognizerState.Ended)
        {
            //DebugText("Long press end: {0}, {1}, delta: {2}, {3}", gesture.FocusX, gesture.FocusY, gesture.DeltaX, gesture.DeltaY);
            EndDrag(longPressGesture.VelocityX, longPressGesture.VelocityY);
        }
    }

    private void CreateLongPressGesture()
    {
        longPressGesture = new LongPressGestureRecognizer();
        longPressGesture.MaximumNumberOfTouchesToTrack = 1;
        longPressGesture.StateUpdated += LongPressGestureCallback;
        FingersScript.Instance.AddGesture(longPressGesture);
    }

    // Start is called before the first frame update
    void Start()
    {
        CreateLongPressGesture();
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