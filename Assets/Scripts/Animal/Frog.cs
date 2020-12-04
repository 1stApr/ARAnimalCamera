using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Frog_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Frog_Animator = GetComponent<Animator>();
    }
    void setFrog()
    {
        Debug.Log("Animal African Frog Start");
        
    }
    public void setAttack()
    {
        Frog_Animator.SetInteger("CheckFrog", 1);
    }
    public void setWalk()
    {
        Frog_Animator.SetInteger("CheckFrog", 2);
    }
    public void setRun()
    {
        Frog_Animator.SetInteger("CheckFrog", 3);
    }
    public void setEat()
    {
        Frog_Animator.SetInteger("CheckFrog", 4);
    }
}
