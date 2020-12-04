using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deer : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Deer_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Deer_Animator = GetComponent<Animator>();
    }
    void setDeer()
    {
        Debug.Log("Animal African Deer Start");
        
    }
    public void setAttack()
    {
        Deer_Animator.SetInteger("CheckDeer", 1);
    }
    public void setWalk()
    {
        Deer_Animator.SetInteger("CheckDeer", 2);
    }
    public void setRun()
    {
        Deer_Animator.SetInteger("CheckDeer", 3);
    }
    public void setEat()
    {
        Deer_Animator.SetInteger("CheckDeer", 4);
    }
}
