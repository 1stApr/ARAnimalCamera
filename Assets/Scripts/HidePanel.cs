using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HidePanel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas1;
    public GameObject canvas2;

    // Update is called once per frame
    void Start()
    {
        
        canvas2.transform.localScale = new Vector3(0, 0, 0);
        canvas1.transform.localScale = new Vector3(1f, 1f, 1f);

        /*
        GameObject.FindWithTag("UI1").SetActive(false);
        GameObject.FindWithTag("UI2").SetActive(true);
        */
    }
    public void hideUI1()
    {
        
        canvas1.transform.localScale = new Vector3(0, 0, 0); ;
        canvas2.transform.localScale = new Vector3(1f, 1f, 1f);


    }
    public void hideUI2()
    {
        canvas2.transform.localScale = new Vector3(0, 0, 0); ;
        canvas1.transform.localScale = new Vector3(1f, 1f, 1f);



    }
    public void changeUI()
    {

        canvas1.SetActive(true);
        canvas2.SetActive(false);
    }

}
