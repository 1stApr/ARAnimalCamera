using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octopus : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Octopus_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Octopus_Animator = GetComponent<Animator>();
    }
    void setOctopus()
    {
        Debug.Log("Animal African Octopus Start");
        
    }
    public void setAttack()
    {
        Octopus_Animator.SetInteger("CheckOctopus", 1);
    }
    public void setWalk()
    {
        Octopus_Animator.SetInteger("CheckOctopus", 2);
    }
    public void setRun()
    {
        Octopus_Animator.SetInteger("CheckOctopus", 3);
    }
    public void setEat()
    {
        Octopus_Animator.SetInteger("CheckOctopus", 4);
    }
}
