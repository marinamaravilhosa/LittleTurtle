using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float velocidade = 2.0f;
    public float reposicao = 18.0f;

    public Vector3 posicaoInicial ;


    // Start is called before the first frame update
    void Start()
    {
        posicaoInicial = transform.position ;
    }

    // Update is called once per frame
    void Update()
    {
        float novaPosicao = Mathf.Repeat(Time.time * velocidade ,reposicao);
        transform.position = posicaoInicial + Vector3.left * novaPosicao;
    }
}
