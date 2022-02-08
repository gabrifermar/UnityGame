using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoluna : MonoBehaviour
{

    private Rigidbody luna;

    // Start is called before the first frame update
    void Start()
    {
        luna = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (luna.position.x > -8f)
        {
            luna.velocity = new Vector3(-5f, 0, 0);
        }
        else if (luna.position.x < -8f)
        {
            luna.velocity = new Vector3(0, 0, 0);
        }
    }
}
