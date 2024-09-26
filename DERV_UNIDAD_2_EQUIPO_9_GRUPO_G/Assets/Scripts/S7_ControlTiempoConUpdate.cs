using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S7_ControlTiempoConUpdate : MonoBehaviour
{

    float contador_tiempo;
    [SerializeField] TextMeshProUGUI Textotiempo;
    float contador_segundos;

    // Start is called before the first frame update
    void Start()
    {
        contador_tiempo = 0;
        contador_segundos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        contador_tiempo += Time.deltaTime;
        if(contador_tiempo > 1.0)
        {
            Textotiempo.text = contador_segundos++.ToString();
            contador_tiempo = 0;
        }

    }
}
