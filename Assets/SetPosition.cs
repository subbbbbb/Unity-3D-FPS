using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{

    private float _speed;

    void Start()
    {
        _speed = 10;
        
    }



    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput,0,0) * _speed * Time.deltaTime); // the time.deltaTime makes it so it goes 1m per sec not 1m per frame

        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, verticalInput) * _speed * Time.deltaTime);

        float jumpInput = Input.GetAxis("Jump");
        transform.Translate(new Vector3(0, jumpInput, 0) * _speed * Time.deltaTime);

        
    }
    
}
