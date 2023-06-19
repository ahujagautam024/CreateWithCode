using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardTwo : MonoBehaviour
{
    #region Variables

    public float speed = 40f;

    #endregion

    #region UnityMethods
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    #endregion
}
