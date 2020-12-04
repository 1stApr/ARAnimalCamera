using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salmon : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Salmon_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Salmon_Animator = GetComponent<Animator>();
    }
    void setSalmon()
    {
        Debug.Log("Animal African Salmon Start");
        
    }
    public void setAttack()
    {
        Salmon_Animator.SetInteger("CheckSalmon", 1);
    }
    public void setWalk()
    {
        Salmon_Animator.SetInteger("CheckSalmon", 2);
    }
    public void setRun()
    {
        Salmon_Animator.SetInteger("CheckSalmon", 3);
    }
    public void setEat()
    {
        Salmon_Animator.SetInteger("CheckSalmon", 4);
    }
}
