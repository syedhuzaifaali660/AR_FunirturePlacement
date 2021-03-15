using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Playables;

public class UIAnimationManager : MonoBehaviour
{
    #region Variables
    [Header("ANIMATIONS")]
    public Animator Screen3Model;
    public Animator OuterButtonAnimation;
    public Animator OutterCamAnimation;
    //public Animator Dimensions;
    public PlayableDirector HowToUseTimeline;
    public PlayableDirector TimelineDimensions;

    [Header("SCRIPT REFERENCES")]
    public UIHandleManager  UIHandlerScript;

    [Header("UI ELEMENTS")]
    public Button OutterButtonInteractiveCam;
    public Button OutterButtonInteractiveT1;
    public Button OutterButtonInteractiveT2;
    public Button OutterButtonInteractiveT3;
    
    //public Text text;


    int count2 = 1;
    #endregion


    #region TIMELINE ANIMATIONS FUNCTIONS
    public void CheckIfTimelineStopped()
    {
        HowToUseTimeline.stopped += OnPlayableDirectorStopped;

    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        if (HowToUseTimeline == aDirector)
        {
            //Debug.Log("PlayableDirector named " + aDirector.name + " is now stopped.");
            OutterButtonInteractiveCam.interactable = true;
            OutterButtonInteractiveT1.interactable = true;
            OutterButtonInteractiveT2.interactable = true;
            OutterButtonInteractiveT3.interactable = true;
            //UIHandlerScript.SofaAppear();
            


        }
    }

    public void PlayHowToUseTimelineClip()
    {
        HowToUseTimeline.Play();
    }

    public void Model_UpDownAnimation()
    {
        if (count2 == 1)
        {
            Screen3Model.Play("Model_Upward");
            count2 = 2;
            UIHandlerScript.UI_OuterButtonDisappear();

        }
        else
        {
            Screen3Model.Play("Model_Downward");
            count2 = 1;
            UIHandlerScript.UI_OuterButtonAppear();
            

        }
    }

    public void DimensionsTimelineClip()
    {
        TimelineDimensions.Play();
    }

#endregion


    void Update()
    {
        CheckIfTimelineStopped();

        if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        {
            //codes for Landspace;
            OutterCamAnimation.Play("Capture_Landscape");
            OuterButtonAnimation.Play("OuterButtonAnimation_MoveDownOnLandscapeMode");            
            //text.text = "LandscapeLeft";
            //Debug.Log("landscape");
        }
        //else if (Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        //{
        //    //codes for Landspace;
        //    
        //    OuterButtonAnimation.Play("OuterButtonAnimation_MoveDownOnLandscapeMode");
        //    //OuterButtonAnimation.Play("OuterButtonHolder_CamLandScape");
        //    //text.text = "LandscapeRight"; 
        //    //Debug.Log("landscape");
        //}

        else if (Input.deviceOrientation == DeviceOrientation.Portrait)
        {

            //codes for portrait
            OutterCamAnimation.Play("Capture_Potrait");
            OuterButtonAnimation.Play("OuterButtonAnimation_MoveDownOnPotraitMode");        
            //text.text = "Potrait";
            //Debug.Log("potrait");
        }
    }

    //public void WallSelectButtonAnimation()
    //{
    //    if (count == 1)
    //    {

    //        WallSelectionUI.DOAnchorPos(new Vector2(0, 0), 0.25f, true);
    //        ButtonWallSelectionAnimation.DOAnchorPos(new Vector2(456, -11), 0.25f, true);
    //        ButtonWallSelectionAnimation.DORotate(new Vector3(0, 0, 180), 0.25f);
    //        count = 2;
    //    }
    //    else
    //    {
    //        WallSelectionUI.DOAnchorPos(new Vector2(-861, 0), 0.25f, true);
    //        ButtonWallSelectionAnimation.DOAnchorPos(new Vector2(6, 28), 0.15f, true);
    //        ButtonWallSelectionAnimation.DORotate(new Vector3(0, 0, 0), 0.15f);
    //        count = 1;

    //    }
    //}
}
