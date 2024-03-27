using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //criando a minha variavel do meu rigidbody2d
    private Rigidbody2D meuRB;
    [SerializeField] private float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {
        meuRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            meuRB.velocity = Vector2.up * velocidade;
        }
    }
}
