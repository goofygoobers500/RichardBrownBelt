using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        Vector3 destination = new Vector3(horizontal, 0, 1);
        GetComponent<Rigidbody>().velocity = destination * speed;




    }
}
