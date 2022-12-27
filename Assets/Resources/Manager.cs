using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager INST;

    public List<GameObject> Interactables = new List<GameObject>();

    // Start is called before the first frame update
    void Awake()
    {
        INST = this;
    }
}
