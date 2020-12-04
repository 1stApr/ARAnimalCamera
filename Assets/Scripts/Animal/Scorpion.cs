using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorpion : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Scorpion_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Scorpion_Animator = GetComponent<Animator>();
    }
    void setScorpion()
    {
        Debug.Log("Animal African Scorpion Start");
        
    }
    public void setAttack()
    {
        Scorpion_Animator.SetInteger("CheckScorpion", 1);
    }
    public void setWalk()
    {
        Scorpion_Animator.SetInteger("CheckScorpion", 2);
    }
    public void setRun()
    {
        Scorpion_Animator.SetInteger("CheckScorpion", 3);
    }
    public void setEat()
    {
        Scorpion_Animator.SetInteger("CheckScorpion", 4);
    }
}
