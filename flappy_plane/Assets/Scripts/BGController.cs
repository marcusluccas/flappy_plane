using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour
{
    private Renderer meuFundo;
    private Vector2 meuOffset;
    private float meuXoffset = 0;
    private float velocidade;

    // Start is called before the first frame update
    void Start()
    {;
        meuFundo = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        velocidade = 0.1f;

        meuXoffset += velocidade * Time.deltaTime;

        meuOffset.x = meuXoffset;

        meuFundo.material.mainTextureOffset = meuOffset;
    }
}
