using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Chicken_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Chicken_Animator = GetComponent<Animator>();
    }
    void setChicken()
    {
        Debug.Log("Animal African Chicken Start");
        
    }
    public void setAttack()
    {
        Chicken_Animator.SetInteger("CheckChicken", 1);
    }
    public void setWalk()
    {
        Chicken_Animator.SetInteger("CheckChicken", 2);
    }
    public void setRun()
    {
        Chicken_Animator.SetInteger("CheckChicken", 3);
    }
    public void setEat()
    {
        Chicken_Animator.SetInteger("CheckChicken", 4);
    }
}
