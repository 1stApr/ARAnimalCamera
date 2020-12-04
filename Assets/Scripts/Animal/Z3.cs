using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z3 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 3;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
