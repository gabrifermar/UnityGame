using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class encender_luz : MonoBehaviour
{

    public Light luz1;
    public Light luz2;
    private GameObject interruptor;
    public AudioSource sonido;

    // Start is called before the first frame update
    void Start()
    {
        interruptor = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void OnMouseDown()
    {
        sonido.Play();
        if (interruptor.transform.localRotation == Quaternion.Euler(-8.972f, 0, 0))
        {
            interruptor.transform.localRotation = Quaternion.Euler(7.404f, 0, 0);
            luz1.enabled = false;
            luz2.enabled = false;
        }
        else if(interruptor.transform.localRotation == Quaternion.Euler(7.404f, 0, 0))
        {
            interruptor.transform.localRotation = Quaternion.Euler(-8.972f, 0, 0);
            luz1.enabled = true;
            luz2.enabled = true;
        }
    }
}
