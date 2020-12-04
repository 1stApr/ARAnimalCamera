using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimationScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;
    public GameObject canvas2;
    void Start()
    {
        if (canvas != null)
        {
            canvas.SetActive(false);
            canvas2.SetActive(true);
        }
    }
    public void OpenCanvas()
    {
        if (canvas != null)
        {
            bool isActive = canvas.activeSelf;
            canvas.SetActive(!isActive);
            canvas2.SetActive(isActive);
        }
    }


}
