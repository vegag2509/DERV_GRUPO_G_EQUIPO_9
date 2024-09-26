using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2_movimiento : MonoBehaviour
{

    [SerializeField] float velocidad = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * velocidad * -1 * Time.deltaTime);
        }
    }
}
