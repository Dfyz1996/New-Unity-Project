using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float speed = 0.5f;

    private void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(transform.right * speed);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(-transform.right * speed);

        }

        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(transform.forward * speed);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(-transform.forward * speed);

        }
    }
}
