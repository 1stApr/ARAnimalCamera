using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenUrlImageTarget()
    {
        Application.OpenURL("https://sites.google.com/view/imagetarget/home");
    }
}
