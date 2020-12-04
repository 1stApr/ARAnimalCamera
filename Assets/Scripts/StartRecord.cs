using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRecord : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas1;
    public GameObject canvas2;
    public void InvisibleUI()
    {
        
        canvas1.transform.localScale = new Vector3(0, 0, 0); ;
        canvas2.transform.localScale = new Vector3(0, 0, 0); ;
    }


}
