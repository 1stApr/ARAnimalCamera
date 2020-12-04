using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class African_elephant : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator elephant_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        elephant_Animator = GetComponent<Animator>();
    }
    void setElephant()
    {
        Debug.Log("Animal African Elephant Start");
        
    }
    public void setAttack()
    {
        elephant_Animator.SetInteger("CheckElephant", 1);
    }
    public void setWalk()
    {
        elephant_Animator.SetInteger("CheckElephant", 2);
    }
    public void setRun()
    {
        elephant_Animator.SetInteger("CheckElephant", 3);
    }
    public void setEat()
    {
        elephant_Animator.SetInteger("CheckElephant", 4);
    }
}
