using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z12 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 12;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
