using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Pig_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Pig_Animator = GetComponent<Animator>();
    }
    void setPig()
    {
        Debug.Log("Animal African Pig Start");
        
    }
    public void setAttack()
    {
        Pig_Animator.SetInteger("CheckPig", 1);
    }
    public void setWalk()
    {
        Pig_Animator.SetInteger("CheckPig", 2);
    }
    public void setRun()
    {
        Pig_Animator.SetInteger("CheckPig", 3);
    }
    public void setEat()
    {
        Pig_Animator.SetInteger("CheckPig", 4);
    }
}
