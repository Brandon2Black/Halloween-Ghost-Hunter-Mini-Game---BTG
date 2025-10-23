using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
     public float forwardInput;
    public float Speed = 10.0f;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Speed * Time.deltaTime);
         forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * forwardInput * Speed * Time.deltaTime);
    }
}
