using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z4 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 4;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
