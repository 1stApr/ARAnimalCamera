using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Bat_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Bat_Animator = GetComponent<Animator>();
    }
    void setBat()
    {
        Debug.Log("Animal African Bat Start");
        
    }
    public void setAttack()
    {
        Bat_Animator.SetInteger("CheckBat", 1);
    }
    public void setWalk()
    {
        Bat_Animator.SetInteger("CheckBat", 2);
    }
    public void setRun()
    {
        Bat_Animator.SetInteger("CheckBat", 3);
    }
    public void setEat()
    {
        Bat_Animator.SetInteger("CheckBat", 4);
    }
}
