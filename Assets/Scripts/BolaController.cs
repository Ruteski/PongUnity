using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    public Rigidbody2D meuRB;
    public Vector2 minhaVelocidade;

    // Start is called before the first frame update
    void Start()
    {
        //adicionando velocidade para a esquerda
        meuRB.velocity = minhaVelocidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
