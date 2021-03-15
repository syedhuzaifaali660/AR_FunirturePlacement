
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource source;


    public void SofaHoverAudioPlay()
    {
        source.Play();
    }
    public void SofaHoverAudioStop()
    {
        source.Stop();
    }



}
