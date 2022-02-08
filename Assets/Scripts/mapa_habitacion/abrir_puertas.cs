using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrir_puertas : MonoBehaviour
{

    public GameObject puerta;
    private Animator abrir ;
    private Quaternion q1, q2;

    // Start is called before the first frame update
    void Start()
    {
        abrir = GetComponent<Animator>();
        puerta = gameObject;
        q1 = Quaternion.Euler(puerta.transform.localRotation.x, puerta.transform.localRotation.y, puerta.transform.localRotation.z);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (puerta.transform.localRotation == q1)
        {
            abrir.SetBool("abierta", true);
            q2= Quaternion.Euler(puerta.transform.localRotation.x, puerta.transform.localRotation.y, puerta.transform.localRotation.z);
        }
        else if (q2==q1)
        {
            abrir.SetBool("abierta", false);
            q2 = Quaternion.Euler(puerta.transform.localRotation.x, puerta.transform.localRotation.y, puerta.transform.localRotation.z);
        }
    }
}
