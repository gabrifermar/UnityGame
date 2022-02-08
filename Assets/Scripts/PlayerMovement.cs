using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    
    public float sensitivity;
    public float speed;
    public float maxYAngle = 80f;
    private Vector2 currentRotation;
    Rigidbody Rigidbody;
    private void Start() 
    {
        Rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
         currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
         currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity;
         currentRotation.x = Mathf.Repeat(currentRotation.x, 360);
         currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle);
         Camera.main.transform.rotation = Quaternion.Euler(currentRotation.y,currentRotation.x,0);
        //  if (Input.GetMouseButtonDown(0))
        //      Cursor.lockState = CursorLockMode.Locked;

        // Movement
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Camera.main.transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= Camera.main.transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Camera.main.transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= Camera.main.transform.forward * speed * Time.deltaTime;
        }

        
    }
}
