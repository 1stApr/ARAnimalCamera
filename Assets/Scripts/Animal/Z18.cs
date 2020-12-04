using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z18 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 18;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
