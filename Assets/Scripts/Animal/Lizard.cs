using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Lizard_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Lizard_Animator = GetComponent<Animator>();
    }
    void setLizard()
    {
        Debug.Log("Animal African Lizard Start");
        
    }
    public void setAttack()
    {
        Lizard_Animator.SetInteger("CheckLizard", 1);
    }
    public void setWalk()
    {
        Lizard_Animator.SetInteger("CheckLizard", 2);
    }
    public void setRun()
    {
        Lizard_Animator.SetInteger("CheckLizard", 3);
    }
    public void setEat()
    {
        Lizard_Animator.SetInteger("CheckLizard", 4);
    }
}
