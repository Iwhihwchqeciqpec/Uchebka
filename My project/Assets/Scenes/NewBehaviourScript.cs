using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject obj1;

public void Deactive()
    {
        obj1.SetActive(!obj1.activeSelf);
    }
}
