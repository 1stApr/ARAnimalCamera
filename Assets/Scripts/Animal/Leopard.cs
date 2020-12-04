using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leopard : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Leopard_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Leopard_Animator = GetComponent<Animator>();
    }
    void setLeopard()
    {
        Debug.Log("Animal African Leopard Start");
        
    }
    public void setAttack()
    {
        Leopard_Animator.SetInteger("CheckLeopard", 1);
    }
    public void setWalk()
    {
        Leopard_Animator.SetInteger("CheckLeopard", 2);
    }
    public void setRun()
    {
        Leopard_Animator.SetInteger("CheckLeopard", 3);
    }
    public void setEat()
    {
        Leopard_Animator.SetInteger("CheckLeopard", 4);
    }
}
