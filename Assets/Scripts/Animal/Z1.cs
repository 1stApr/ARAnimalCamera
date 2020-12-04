using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z1 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 1;
        AnimalStatus.z1();
    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }

}
