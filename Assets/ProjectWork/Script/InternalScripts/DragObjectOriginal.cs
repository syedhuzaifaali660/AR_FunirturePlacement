using UnityEngine;
using System.Collections;

public class DragObjectOriginal : MonoBehaviour
{
    #region OLD TOUCH SCRIPT

    public Touch touch;
    private float speedModifier;

    // Start is called before the first frame update
    void Start()
    {
        speedModifier = 0.001f;
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.touchCount > 0)
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        // The GameObject this script attached should be on layer "Surface"
        if (Physics.Raycast(ray, out hit, LayerMask.GetMask("Surface")))
            {
                touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Moved)
                {
                    transform.position = new Vector3(
                        transform.position.x + touch.deltaPosition.x * speedModifier,
                        transform.position.y,
                        transform.position.z + touch.deltaPosition.y * speedModifier);
                }
            }
        
    }


    #endregion

    #region NEW SCRIPT

    //private float dist;
    //private bool dragging = false;
    //private Vector3 offset;
    //private Transform toDrag;

    //void Update()
    //{
    //    Vector3 v3;

    //    if (Input.touchCount != 1)
    //    {
    //        dragging = false;
    //        return;
    //    }

    //    Touch touch = Input.touches[0];
    //    Vector3 pos = touch.position;

    //    if (touch.phase == TouchPhase.Began)
    //    {
    //        Debug.Log("Touch Phase Begin");
    //        RaycastHit hit;
    //        Ray ray = Camera.main.ScreenPointToRay(pos);
    //        //if (Physics.Raycast(ray, out hit) && (hit.collider.tag == "SofaMesh"))
    //        if (Physics.Raycast(ray, out hit) && hit.transform.name == "SofaMesh")
    //        {
    //            Debug.Log("Here");
    //            Debug.Log("Raycast Hit SofaMesh");
    //            toDrag = hit.transform;
    //            dist = hit.transform.position.z - Camera.main.transform.position.z;
    //            v3 = new Vector3(pos.x, pos.y, dist);
    //            v3 = Camera.main.ScreenToWorldPoint(v3);
    //            offset = toDrag.position - v3;
    //            dragging = true;
    //        }
    //    }
    //    if (dragging && touch.phase == TouchPhase.Moved)
    //    {
    //        Debug.Log("Dragging and moved");
    //        //removing dist to check if it will stop moving up and down and adding 0 instead

    //        v3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
    //        v3 = Camera.main.ScreenToWorldPoint(v3);
    //        toDrag.position = v3 + offset;
    //        //v3.z = 0.0f;
    //    }
    //    if (dragging && (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled))
    //    {
    //        Debug.Log("not dragging");
    //        dragging = false;
    //    }
    //}

    #endregion

    #region NEW SCRIPT 2

    //private float dist;
    //private Transform toDrag;
    //private bool dragging = false;
    //private Vector3 offset ;

    //void Update()
    //{

    //      Vector3 v3;
    //      Vector3 pos;
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        RaycastHit hit;
    //        Ray ray = Camera.main.ScreenPointToRay(pos);
    //        if (Physics.Raycast(ray, out hit) && (hit.collider.tag == "Drag"))
    //        {
    //            toDrag = hit.transform;
    //            dist = hit.transform.position.z - Camera.main.transform.position.z;
    //            v3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
    //            v3 = Camera.main.ScreenToWorldPoint(v3);
    //            offset = toDrag.position - v3;
    //            dragging = true;
    //        }
    //    }
    //    if (Input.GetMouseButton(0) && dragging)
    //    {
    //        v3 =new  Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
    //        v3 = Camera.main.ScreenToWorldPoint(v3);
    //        toDrag.position = v3 + offset;
    //    }
    //    if (Input.GetMouseButtonUp(0))
    //    {
    //        dragging = false;
    //    }
    //}

    #endregion



    #region  NEW SCRIPT 3 //not working properly

    //private bool holding;

    //void Start()
    //{
    //    holding = false;
    //}

    //void Update()
    //{

    //    if (holding)
    //    {
    //        Move();
    //    }

    //    // One finger
    //    if (Input.touchCount == 1)
    //    {

    //        // Tap on Object
    //        if (Input.GetTouch(0).phase == TouchPhase.Began)
    //        {
    //            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
    //            RaycastHit hit;

    //            if (Physics.Raycast(ray, out hit, 100f))
    //            {
    //                if (hit.transform == transform)
    //                {
    //                    holding = true;
    //                }
    //            }
    //        }

    //        // Release
    //        if (Input.GetTouch(0).phase == TouchPhase.Ended)
    //        {
    //            holding = false;
    //        }
    //    }
    //}

    //void Move()
    //{
    //    RaycastHit hit;
    //    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
    //    // The GameObject this script attached should be on layer "Surface"
    //    if (Physics.Raycast(ray, out hit, 30.0f, LayerMask.GetMask("Surface")))
    //    {
    //        transform.position = new Vector3(hit.point.x,
    //                                         transform.position.y,
    //                                         hit.point.z);
    //    }

    //}
    #endregion
}

