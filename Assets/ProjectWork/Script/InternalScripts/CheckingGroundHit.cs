using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class CheckingGroundHit : MonoBehaviour
{
    //public Text m_MyText;
    //private Transform newPosition;

    void Start()
    {
        //Text sets your text to say this message
        //m_MyText.text = "NOT HIT";
    }
    public void HitAuto(HitTestResult result)
    {
        //m_MyText.text = "HIT !!!!";
    }
}
