using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField] private float velocidade = 5f;

    [SerializeField] private GameObject eu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velocidade * Time.deltaTime;

        if (transform.position.x < -12f)
        {
            Destroy(eu);
        }
    }
}
