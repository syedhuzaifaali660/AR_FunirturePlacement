using UnityEngine;

public class LookAt : MonoBehaviour
{
    private void Start()
    {
        transform.LookAt(Camera.main.transform);
    }
    
}
