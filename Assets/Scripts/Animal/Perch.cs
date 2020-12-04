using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perch : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Perch_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Perch_Animator = GetComponent<Animator>();
    }
    void setPerch()
    {
        Debug.Log("Animal African Perch Start");
        
    }
    public void setAttack()
    {
        Perch_Animator.SetInteger("CheckPerch", 1);
    }
    public void setWalk()
    {
        Perch_Animator.SetInteger("CheckPerch", 2);
    }
    public void setRun()
    {
        Perch_Animator.SetInteger("CheckPerch", 3);
    }
    public void setEat()
    {
        Perch_Animator.SetInteger("CheckPerch", 4);
    }
}
