using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    #region Variables
    [SerializeField] private float carSpeed = 5f;

    #endregion

    #region UnityMethods
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * carSpeed * Time.deltaTime);
    }

    #endregion
}
