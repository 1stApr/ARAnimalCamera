using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z20 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 20;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
