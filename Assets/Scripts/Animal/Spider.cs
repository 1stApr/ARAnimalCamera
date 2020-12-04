using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Spider_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Spider_Animator = GetComponent<Animator>();
    }
    void setSpider()
    {
        Debug.Log("Animal African Spider Start");
        
    }
    public void setAttack()
    {
        Spider_Animator.SetInteger("CheckSpider", 1);
    }
    public void setWalk()
    {
        Spider_Animator.SetInteger("CheckSpider", 2);
    }
    public void setRun()
    {
        Spider_Animator.SetInteger("CheckSpider", 3);
    }
    public void setEat()
    {
        Spider_Animator.SetInteger("CheckSpider", 4);
    }
}
