using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Cat_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Cat_Animator = GetComponent<Animator>();
    }
    void setCat()
    {
        Debug.Log("Animal African Cat Start");
        
    }
    public void setAttack()
    {
        Cat_Animator.SetInteger("CheckCat", 1);
    }
    public void setWalk()
    {
        Cat_Animator.SetInteger("CheckCat", 2);
    }
    public void setRun()
    {
        Cat_Animator.SetInteger("CheckCat", 3);
    }
    public void setEat()
    {
        Cat_Animator.SetInteger("CheckCat", 4);
    }
}
