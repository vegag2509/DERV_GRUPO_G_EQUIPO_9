using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S3_rotación : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angulo = 5f * speed * Time.deltaTime;
        transform.Rotate(0, angulo, 0);
    }
}
