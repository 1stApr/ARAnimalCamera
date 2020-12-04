using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cattle : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Cattle_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Cattle_Animator = GetComponent<Animator>();
    }
    void setCattle()
    {
        Debug.Log("Animal African Cattle Start");
        
    }
    public void setAttack()
    {
        Cattle_Animator.SetInteger("CheckCattle", 1);
    }
    public void setWalk()
    {
        Cattle_Animator.SetInteger("CheckCattle", 2);
    }
    public void setRun()
    {
        Cattle_Animator.SetInteger("CheckCattle", 3);
    }
    public void setEat()
    {
        Cattle_Animator.SetInteger("CheckCattle", 4);
    }
}
