using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    public Rigidbody2D meuRB;
    private Vector2 minhaVelocidade;
    public float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //passando a velocidade para a minha velocidade
        minhaVelocidade.x = -velocidade;

        //adicionando velocidade para a esquerda
        meuRB.velocity = minhaVelocidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
