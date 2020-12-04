using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z10 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 10;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
