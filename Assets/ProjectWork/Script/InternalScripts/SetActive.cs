using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetActive : MonoBehaviour
{
    public GameObject Gameobj1;
    //int count = 0;
    //Output the new state of the Toggle into Text when the user uses the Toggle
    public void Disappear()
    {
        Gameobj1.SetActive(false);
    }

    public void Appear()
    {
        Gameobj1.SetActive(true);
    }


}
