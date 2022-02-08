using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{

    public float sensitivity = 10;
    public Light linterna;
    private Vector2 mirando;

    // Start is called before the first frame update
    void Start()
    {
        linterna.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (linterna.enabled == false)
            {
                linterna.enabled = true;
            }
            else if (linterna.enabled == true)
            {
                linterna.enabled = false;
            }
        }
    }
}