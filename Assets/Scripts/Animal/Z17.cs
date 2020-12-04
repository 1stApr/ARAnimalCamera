using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z17 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 17;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
