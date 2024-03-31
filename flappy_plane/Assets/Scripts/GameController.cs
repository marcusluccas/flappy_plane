using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    [SerializeField] private float pontos = 0f;

    [SerializeField] private Text meuMostradorPontos;

    private int level = 1;

    [SerializeField] private float proximoLevel = 10f;

    [SerializeField] private Text levelText;

    [SerializeField] private AudioClip levelSound;

    private Camera minhaCamera;

    // Start is called before the first frame update
    void Start()
    {
        minhaCamera = FindObjectOfType<Camera>();
        posicao.x = 12;
    }

    // Update is called once per frame
    void Update()
    {
        Ponto();

        CriaObstaculo();

        GanhaLevel();
    }

    //Criando metodos dos pontos
    void Ponto()
    {
        pontos += Time.deltaTime;

        meuMostradorPontos.text = "Pontos : " + Mathf.Round(pontos).ToString();
    }

    //Criando o metodo de ganhar levels
    void GanhaLevel()
    {
        levelText.text = level.ToString();

        if (pontos >= proximoLevel)
        {
            AudioSource.PlayClipAtPoint(levelSound, minhaCamera.transform.position);

            level++;
            proximoLevel *= 2;
        }
    }

    //Criando um metodo de renornar o level
    public int RetornaLevel()
    {
        return level;
    }

    //Criando o metodo de criar os obstaculos
    void CriaObstaculo()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            posicao.y = Random.Range(minY, maxY);

            Instantiate(obstaculo, posicao, Quaternion.identity);

            timer = Random.Range(minT / level, maxT / level);
        }
    }
}
