using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class VuforiaObjectPlacementStuck : MonoBehaviour
{
    int count = 1;
    //public Text m_MyTextCount;

    public void OnInteractiveHitTest(HitTestResult result)
    {
        var listenerBehaviour = GetComponent<AnchorInputListenerBehaviour>();
        if (count == 1)
        {
            //m_MyTextCount.text = "Count"+count;
            if (listenerBehaviour != null)
            {
                //m_MyTextCount.text = "ListCBe1-" + count;
                listenerBehaviour.enabled = false;
                count = 2;
                listenerBehaviour = null;
            }
        }
    }
    public void TurnOnSofaPlacer()
    {
        var listenerBehaviour = GetComponent<AnchorInputListenerBehaviour>();
        //m_MyTextCount.text = "outsideCount" + count;

        if (count == 2)        {
            //m_MyTextCount.text = "CountBe2-" + count;
            listenerBehaviour.enabled = true;
            count = 1;
            
        }        else        {
            return;
        }
    }

    void myTextChanger(Text Textcounter)
    {
        Debug.Log(Textcounter);
    }


}
