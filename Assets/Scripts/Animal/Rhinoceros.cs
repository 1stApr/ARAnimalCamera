using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhinoceros : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Rhinoceros_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Rhinoceros_Animator = GetComponent<Animator>();
    }
    void setRhinoceros()
    {
        Debug.Log("Animal African Rhinoceros Start");
        
    }
    public void setAttack()
    {
        Rhinoceros_Animator.SetInteger("CheckRhinoceros", 1);
    }
    public void setWalk()
    {
        Rhinoceros_Animator.SetInteger("CheckRhinoceros", 2);
    }
    public void setRun()
    {
        Rhinoceros_Animator.SetInteger("CheckRhinoceros", 3);
    }
    public void setEat()
    {
        Rhinoceros_Animator.SetInteger("CheckRhinoceros", 4);
    }
}
