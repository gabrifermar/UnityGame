using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Encender : MonoBehaviour
{

    public Light luzpc;
    public AudioSource ventilador;
    public RawImage escritorio;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (luzpc.intensity == 0)
        {
            luzpc.intensity = 1;
            Invoke("Sonidoventilador", 1.5f);
            escritorio.enabled = true;
        }
        else
        {
            luzpc.intensity = 0;
            ventilador.Stop();
            escritorio.enabled = false;
        }
    }

    void Sonidoventilador()
    {
        ventilador.Play();
        ventilador.volume = 0.1f;
    }

}
