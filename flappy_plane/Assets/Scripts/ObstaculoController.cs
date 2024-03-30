using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField] private float velocidade = 4f;

    [SerializeField] private GameObject eu;

    private GameController game;

    private int levelVel;
    // Start is called before the first frame update
    void Start()
    {
        game = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        levelVel = game.RetornaLevel();

        transform.position += Vector3.left * (velocidade + levelVel) * Time.deltaTime;

        if (transform.position.x < -12f)
        {
            Destroy(eu);
        }
    }
}
