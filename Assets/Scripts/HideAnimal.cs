using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAnimal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject canvas4;
    public GameObject canvas5;
    public GameObject canvas6;
    public GameObject canvas7;
    public GameObject canvas8;
    public GameObject canvas9;
    public GameObject canvas10;
    public GameObject canvas11;
    public GameObject canvas12;
    public GameObject canvas13;
    public GameObject canvas14;
    public GameObject canvas15;
    public GameObject canvas16;
    public GameObject canvas17;
    public GameObject canvas18;
    public GameObject canvas19;
    public GameObject canvas20;

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
