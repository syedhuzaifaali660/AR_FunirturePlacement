using UnityEngine;


public class RaycastSofa : MonoBehaviour
{

    
    [Header("SCRIPT REFERENCES")]
    public Hover hover;
    public UIHandleManager UI_Handler;

    [Header("GAMEOBJECTS")]
    public GameObject SofaObject;




    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select Stage
                if (hit.transform.name == "SofaMesh")
                {
                    //Debug.Log("tag : " + hit.transform.name);
                    //hover.MoveUP();
                    hover.HoverVariable = true;
                    UI_Handler.UI_TickButtonAppear();
                }
                else 
                {
                   

                }
            }
        }
        //this script should be on the object that it is manipulating
    }
}