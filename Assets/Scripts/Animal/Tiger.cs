using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiger : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Tiger_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Tiger_Animator = GetComponent<Animator>();
    }
    void setTiger()
    {
        Debug.Log("Animal African Tiger Start");
       
    }
    public void setAttack()
    {
        Tiger_Animator.SetInteger("CheckTiger", 1);
    }
    public void setWalk()
    {
        Tiger_Animator.SetInteger("CheckTiger", 2);
    }
    public void setRun()
    {
        Tiger_Animator.SetInteger("CheckTiger", 3);
    }
    public void setEat()
    {
        Tiger_Animator.SetInteger("CheckTiger", 4);
    }
}
