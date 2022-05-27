using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    private float runSpeed = 10;
  
      void Update()
    {             

        
        if (Input.GetKey(KeyCode.W))
        {

            transform.Translate(Vector3.forward * runSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {

            transform.Translate(Vector3.back * runSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(Vector3.left * runSpeed * Time.deltaTime);
           
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate(Vector3.right * runSpeed * Time.deltaTime);
              
        }

        if (Input.GetKey(KeyCode.E))
        {

            transform.Rotate(-Vector3.down * 100 * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.C))
        {

            transform.Rotate(-Vector3.up * 100 * Time.deltaTime);

        }

 


  

    }


}
