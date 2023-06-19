using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTwo : MonoBehaviour
{
    #region Variables
    public float horizontalInput;
    private static string horinontalInputString = "Horizontal";
    public float speed = 10.0f;
    private float xRange = 10f;

    [SerializeField] GameObject projectilePrefab;
    [SerializeField] KeyCode launchKeyCode;

    #endregion


    #region UnityMethods
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Bound the player to maximum limit
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Getting Horizontal Input
        horizontalInput = Input.GetAxis(horinontalInputString);
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        if (Input.GetKeyDown(launchKeyCode))
        {
            //print("Launch KeyCode has been pressed");
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }

    #endregion
}
