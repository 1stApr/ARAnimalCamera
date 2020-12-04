using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffalo : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Buffalo_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Buffalo_Animator = GetComponent<Animator>();
    }
    void setBuffalo()
    {
        Debug.Log("Animal African Buffalo Start");
        
    }
    public void setAttack()
    {
        Buffalo_Animator.SetInteger("CheckBuffalo", 1);
    }
    public void setWalk()
    {
        Buffalo_Animator.SetInteger("CheckBuffalo", 2);
    }
    public void setRun()
    {
        Buffalo_Animator.SetInteger("CheckBuffalo", 3);
    }
    public void setEat()
    {
        Buffalo_Animator.SetInteger("CheckBuffalo", 4);
    }
}
