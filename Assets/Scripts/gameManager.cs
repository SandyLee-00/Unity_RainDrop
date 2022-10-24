using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject rain;

    void Start()
    {
        InvokeRepeating("makeRain", 0, 0.5f);
    }

    void Update()
    {
        
    }

    void makeRain()
    {
        Instantiate(rain);
    }
}
