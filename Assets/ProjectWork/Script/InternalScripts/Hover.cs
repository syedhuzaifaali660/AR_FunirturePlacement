using UnityEngine;
using DG.Tweening;
using System.Collections;

public class Hover : MonoBehaviour
{
#region
    //[SerializeField] [Range(0, 100)] private float oscillationRate = 1;
    //[SerializeField] [Range(0, 1)] private float oscillationRange = 1;
    //[SerializeField] private float upperHeightLimit = 10;
    //[SerializeField] private float lowerHeightLimit = 1;
    public bool HoverVariable = false;
    //public Animator SofaAnimation;
    //public GameObject SofaAnimationDotween;
    //public SoundManager SM;

    
    float Timer2 = 0.4f;

    #endregion



    /* ----------------NOTE!!----------------------
              * ANIMATIONS NOT WORKING AS EXPECTED
              * SOLUTION ONE IS TO PUT OBJECT 
              * IN ANOTHER GAMEOBJECT 
              * AND THEN SET ANIMATION AGAIN
    */


    //public void MoveUP(){
    //    //SofaAnimation.Play("Sofa_MoveUP");
    //    SofaAnimationDotween.transform.DOMoveY(0.2f, Timer2);
    //    SM.SofaHoverAudioPlay();
    //}
    //public void MoveDown(){
    //    //SofaAnimation.Play("Sofa_MoveDown");
    //    SofaAnimationDotween.transform.DOMoveY(0f, Timer2).SetEase(Ease.OutBounce);
    //    SM.SofaHoverAudioStop();
    //}
    
    //#region /*CHECKING IF HOVER VARIABLE IS TRUE TO SET ANIMATOR TO FALSE & THIS IS DONE TO MAKE OBJECT HOVER IN AIR.*/

    //void LateUpdate()
    //{
    //    if (HoverVariable == true)
    //    {
    //        //StartCoroutine(SettingAnimatorToFalse());
    //        //transform.position = ClampHeight((Vector3.up * Mathf.Cos(Time.time * oscillationRate) * ClampRange(oscillationRange)) + transform.position);
    //    }

    //}
    //#endregion

    //private float ClampRange(float value)
    //{
    //    if (transform.position.y > upperHeightLimit)
    //        upperHeightLimit = transform.position.y;
    //    if (transform.position.y < lowerHeightLimit)
    //        lowerHeightLimit = transform.position.y - lowerHeightLimit;
    //    if (upperHeightLimit < lowerHeightLimit)
    //        upperHeightLimit = lowerHeightLimit + 0.1f;
    //    if (lowerHeightLimit > upperHeightLimit)
    //        lowerHeightLimit = upperHeightLimit + 0.1f;
    //    if (value != ((upperHeightLimit + lowerHeightLimit) / 2) - 0.25f)
    //        value = ((upperHeightLimit + lowerHeightLimit) / 2) - 0.25f;
    //    if (value != value * oscillationRange)
    //        value *= oscillationRange;

    //    value *= 0.01f;

    //    return value;
    //}

    //private Vector3 ClampHeight(Vector3 value)
    //{
    //    if (value.y < lowerHeightLimit)
    //        value.y = lowerHeightLimit;
    //    if (value.y > upperHeightLimit)
    //        value.y = upperHeightLimit;
    //    return value;
    //}

    #region MOVING OBJECT UP AND DOWN WITH RESPECT TO POSITION
    //public void MoveSofaUp()
    //{
    //    Vector3 newPosition = transform.position; // We store the current position
    //    newPosition.y = 0.5f * Time.deltaTime;
    //    transform.position = newPosition;
    //}

    //public void MoveSofaDown()
    //{
    //    Vector3 newPosition = transform.position ; // We store the current position
    //    newPosition.y = -0.051f * Time.deltaTime;
    //    transform.position = newPosition;   
    //}
    #endregion
    //float Timer = 0.21f;
    //void Start()
    //{
    //    //SofaAnimation = gameObject.GetComponent<Animator>();
    //}
    //IEnumerator SettingAnimatorToTrue()
    //{

    //    yield return new WaitForSeconds(Timer);
    //    //SofaAnimation.enabled = true;
    //    //Debug.Log("run by tick button");


    //}
    //IEnumerator SettingAnimatorToFalse()
    //{

    //    yield return new WaitForSeconds(Timer);
    //    //SofaAnimation.enabled = false;
    //    

    //}
    //public void SettingSofaAnimatorToTrue()
    //{
    //    StartCoroutine(SettingAnimatorToTrue());
    //    transform.position = ClampHeight((Vector3.up* Mathf.Cos(Time.time* oscillationRate) * ClampRange(oscillationRange)) + transform.position);
    //}

}
