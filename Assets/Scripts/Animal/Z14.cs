using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z14 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 14;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
