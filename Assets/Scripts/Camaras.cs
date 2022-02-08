using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaras : MonoBehaviour
{

    public float velocidad;
    Transform currentview;
    public Transform vista;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentview = vista;
        }
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, currentview.position, Time.deltaTime * velocidad);
    }
}
