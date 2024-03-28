using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        Subir();

        LimitandoY();
    }

    //Criando metodo de subir o avião
    void Subir()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            meuRB.velocity = Vector2.up * velocidade;
        }
    }

    //Criando um metodo de limitar o y
    void LimitandoY()
    {
        if (meuRB.velocity.y < -velocidade)
        {
            meuRB.velocity = Vector2.down * velocidade;
        }
    }

    //Metodo de colisao de player com os obstaculos
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //reiniciar o jogo se o player colidir o obstaculo
        SceneManager.LoadScene("Jogo");
    }
}
