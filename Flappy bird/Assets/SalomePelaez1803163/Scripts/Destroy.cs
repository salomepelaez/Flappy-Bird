using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject birdSound;
    public float time;

    void Start()
    {
        Destroy(birdSound, time);
    }
}
