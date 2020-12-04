using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swan : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Swan_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Swan_Animator = GetComponent<Animator>();
    }
    void setSwan()
    {
        Debug.Log("Animal African Swan Start");
        
    }
    public void setAttack()
    {
        Swan_Animator.SetInteger("CheckSwan", 1);
    }
    public void setWalk()
    {
        Swan_Animator.SetInteger("CheckSwan", 2);
    }
    public void setRun()
    {
        Swan_Animator.SetInteger("CheckSwan", 3);
    }
    public void setEat()
    {
        Swan_Animator.SetInteger("CheckSwan", 4);
    }
}
