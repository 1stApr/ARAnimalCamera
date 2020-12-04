using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Turtle_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Turtle_Animator = GetComponent<Animator>();
    }
    void setTurtle()
    {
        Debug.Log("Animal African Turtle Start");
        
    }
    public void setAttack()
    {
        Turtle_Animator.SetInteger("CheckTurtle", 1);
    }
    public void setWalk()
    {
        Turtle_Animator.SetInteger("CheckTurtle", 2);
    }
    public void setRun()
    {
        Turtle_Animator.SetInteger("CheckTurtle", 3);
    }
    public void setEat()
    {
        Turtle_Animator.SetInteger("CheckTurtle", 4);
    }
}
