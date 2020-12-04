using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salamander : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Salamander_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Salamander_Animator = GetComponent<Animator>();
    }
    void setSalamander()
    {
        Debug.Log("Animal African Salamander Start");
        
    }
    public void setAttack()
    {
        Salamander_Animator.SetInteger("CheckSalamander", 1);
    }
    public void setWalk()
    {
        Salamander_Animator.SetInteger("CheckSalamander", 2);
    }
    public void setRun()
    {
        Salamander_Animator.SetInteger("CheckSalamander", 3);
    }
    public void setEat()
    {
        Salamander_Animator.SetInteger("CheckSalamander", 4);
    }
}
