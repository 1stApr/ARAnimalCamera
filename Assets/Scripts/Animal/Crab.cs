using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Crab_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Crab_Animator = GetComponent<Animator>();
    }
    void setCrab()
    {
        Debug.Log("Animal African Crab Start");
        
    }
    public void setAttack()
    {
        Crab_Animator.SetInteger("CheckCrab", 1);
    }
    public void setWalk()
    {
        Crab_Animator.SetInteger("CheckCrab", 2);
    }
    public void setRun()
    {
        Crab_Animator.SetInteger("CheckCrab", 3);
    }
    public void setEat()
    {
        Crab_Animator.SetInteger("CheckCrab", 4);
    }
}