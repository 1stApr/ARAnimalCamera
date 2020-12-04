using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z19 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 19;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
