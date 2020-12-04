using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Horse_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Horse_Animator = GetComponent<Animator>();
    }
    void setHorse()
    {
        Debug.Log("Animal African Horse Start");
        
    }
    public void setAttack()
    {
        Horse_Animator.SetInteger("CheckHorse", 1);
    }
    public void setWalk()
    {
        Horse_Animator.SetInteger("CheckHorse", 2);
    }
    public void setRun()
    {
        Horse_Animator.SetInteger("CheckHorse", 3);
    }
    public void setEat()
    {
        Horse_Animator.SetInteger("CheckHorse", 4);
    }
}
