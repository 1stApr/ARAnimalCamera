using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z23 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 23;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
