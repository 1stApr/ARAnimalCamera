using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z9 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 9;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
