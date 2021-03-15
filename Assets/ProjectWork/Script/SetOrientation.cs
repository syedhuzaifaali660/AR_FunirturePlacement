using UnityEngine;


public class SetOrientation : MonoBehaviour
{
    public UIHandleManager UI_Handler;


    void Update()
    {
        if (UI_Handler.UI_Screen0.activeInHierarchy 
            || 
            UI_Handler.UI_Screen1.activeInHierarchy 
            || 
            UI_Handler.UI_Screen2.activeInHierarchy)        {
            Screen.orientation = ScreenOrientation.Portrait;
            //text.text = "Potrait";
        }        else        {
            Screen.orientation = ScreenOrientation.AutoRotation;
            //text.text = "AutoRotate On";

        }

        if (UI_Handler.SofaButtonTapped1 == true){
            UI_Handler.CheckingScreenOrientationForBuyNow();
        }else{
            return;
        }

    }

    //public void Print()
    //{
    //    Debug.Log("activeSelf is : " + UI_Handler.UI_Screen0.activeSelf);
    //    Debug.Log("activeInHierarchy is : " + UI_Handler.UI_Screen0.activeInHierarchy);

    //}

}
