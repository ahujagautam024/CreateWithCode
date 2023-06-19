using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables
    // Private Variables
    private float speed = 12f;
    private float turnSpeed = 25f;
    private float horizontalInput;
    private float forwardInput;
    #endregion

    #region UnityMethods
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Taking Input of the Axis Arrow Keys/WASD
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        // Move the vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
    
        // Rotate the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

    #endregion
}
