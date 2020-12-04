using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z15 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 15;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
