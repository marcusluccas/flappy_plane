using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //criando um timer
    [SerializeField] private float timer = 1f;

    [SerializeField] private GameObject obstaculo;

    [SerializeField] private Vector3 posicao;

    [SerializeField] private float minY = -1.5f;
    [SerializeField] private float maxY = 2.2f;
    
    [SerializeField] private float minT = 1f;
    [SerializeField] private float maxT = 3f;

    // Start is called before the first frame update
    void Start()
    {
        posicao.x = 12;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            posicao.y = Random.Range(minY, maxY);

            Instantiate(obstaculo, posicao, Quaternion.identity);

            timer = Random.Range(minT, maxT);
        }
    }
}
