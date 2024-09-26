using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S2_Practica5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        int escenaActiva = SceneManager.GetActiveScene().buildIndex;
        if (escenaActiva == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                cambioDeEscena(1);
            }
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        
        int escenaActiva = SceneManager.GetActiveScene().buildIndex;
        if (escenaActiva == 1)
        {
            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene(2);
            }
        }
    }

    public void cambioDeEscena(int index)
    {
        SceneManager.LoadScene(index);
    }

}