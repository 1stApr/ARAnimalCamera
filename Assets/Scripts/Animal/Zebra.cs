using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zebra : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Zebra_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Zebra_Animator = GetComponent<Animator>();
    }
    void setZebra()
    {
        Debug.Log("Animal African Zebra Start");
        
    }
    public void setAttack()
    {
        Zebra_Animator.SetInteger("CheckZebra", 1);
    }
    public void setWalk()
    {
        Zebra_Animator.SetInteger("CheckZebra", 2);
    }
    public void setRun()
    {
        Zebra_Animator.SetInteger("CheckZebra", 3);
    }
    public void setEat()
    {
        Zebra_Animator.SetInteger("CheckZebra", 4);
    }
}
