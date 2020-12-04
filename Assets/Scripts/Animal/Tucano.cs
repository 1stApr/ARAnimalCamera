using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tucano : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    Animator Tucano_Animator;
    void Start()
    {
        //Fetch the Animator from the GameObject you attached the script to
        Tucano_Animator = GetComponent<Animator>();
    }
    void setTucano()
    {
        Debug.Log("Animal African Tucano Start");
       
    }
    public void setAttack()
    {
        Tucano_Animator.SetInteger("CheckTucano", 1);
    }
    public void setWalk()
    {
        Tucano_Animator.SetInteger("CheckTucano", 2);
    }
    public void setRun()
    {
        Tucano_Animator.SetInteger("CheckTucano", 3);
    }
    public void setEat()
    {
        Tucano_Animator.SetInteger("CheckTucano", 4);
    }
}
