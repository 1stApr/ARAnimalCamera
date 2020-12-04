using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Penguin_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Penguin_Animator = GetComponent<Animator>();
    }
    void setPenguin()
    {
        Debug.Log("Animal African Penguin Start");
        
    }
    public void setAttack()
    {
        Penguin_Animator.SetInteger("CheckPenguin", 1);
    }
    public void setWalk()
    {
        Penguin_Animator.SetInteger("CheckPenguin", 2);
    }
    public void setRun()
    {
        Penguin_Animator.SetInteger("CheckPenguin", 3);
    }
    public void setEat()
    {
        Penguin_Animator.SetInteger("CheckPenguin", 4);
    }
}
