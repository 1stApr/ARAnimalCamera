using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Rabbit_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Rabbit_Animator = GetComponent<Animator>();
    }
    void setRabbit()
    {
        Debug.Log("Animal African Rabbit Start");
        
    }
    public void setAttack()
    {
        Rabbit_Animator.SetInteger("CheckRabbit", 1);
    }
    public void setWalk()
    {
        Rabbit_Animator.SetInteger("CheckRabbit", 2);
    }
    public void setRun()
    {
        Rabbit_Animator.SetInteger("CheckRabbit", 3);
    }
    public void setEat()
    {
        Rabbit_Animator.SetInteger("CheckRabbit", 4);
    }
}
