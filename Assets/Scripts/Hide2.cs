using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hide2 : MonoBehaviour
{
    // Start is called before the first frame update
    //GameObject.FindWithTag("UIScan").transform.localScale = new Vector3(0, 0, 0);
    //GameObject.FindWithTag("UIScan").transform.localScale = new Vector3(1f, 1f, 1f);
    public GameObject canvas1;
   

    // Update is called once per frame
    void Start()
    {
        canvas1.transform.localScale = new Vector3(1f, 1f, 1f);

    }
    public void hideUI1()
    {

        canvas1.transform.localScale = new Vector3(0, 0, 0); ;

    }
    public void unHideUI1()
    {

        canvas1.transform.localScale = new Vector3(1f, 1f, 1f);

    }

}
