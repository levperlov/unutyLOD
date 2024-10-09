using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go : MonoBehaviour
{
    public int spead;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * spead);
        }
        if (Input.GetKey(KeyCode.S))
        {
             transform.Translate(Vector3.back * Time.deltaTime * spead);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * spead);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * spead);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, spead, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -spead, 0);
        }
    }
}
