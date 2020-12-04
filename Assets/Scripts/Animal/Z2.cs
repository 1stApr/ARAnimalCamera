using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z2 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 2;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
