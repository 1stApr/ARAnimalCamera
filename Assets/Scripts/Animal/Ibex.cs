using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ibex : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Ibex_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Ibex_Animator = GetComponent<Animator>();
    }
    void setIbex()
    {
        Debug.Log("Animal African Ibex Start");
        
    }
    public void setAttack()
    {
        Ibex_Animator.SetInteger("CheckIbex", 1);
    }
    public void setWalk()
    {
        Ibex_Animator.SetInteger("CheckIbex", 2);
    }
    public void setRun()
    {
        Ibex_Animator.SetInteger("CheckIbex", 3);
    }
    public void setEat()
    {
        Ibex_Animator.SetInteger("CheckIbex", 4);
    }
}
