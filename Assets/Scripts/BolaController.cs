using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BolaController : MonoBehaviour
{
    public Rigidbody2D meuRB;
    private Vector2 minhaVelocidade;
    public float velocidade = 5f;
    public float limiteHorizontal = 12f;

    private Vector2 DirecaoInicial(float vel1, float vel2) {
        return new Vector2 (vel1, vel2);
    }

    // Start is called before the first frame update
    void Start()
    {

        int direcao = Random.Range(0, 4);

        // escolhe a direção inicial da bola
        if (direcao == 0) { // superior direita
            minhaVelocidade = DirecaoInicial(velocidade, velocidade);
        }else if (direcao == 1) { // superior esquerda
            minhaVelocidade = DirecaoInicial(-velocidade, velocidade);
        }else if (direcao == 2) { // inferior esquerda
            minhaVelocidade = DirecaoInicial(-velocidade, -velocidade);
        } else { // inferior direita
            minhaVelocidade = DirecaoInicial(velocidade, -velocidade);
        }

        //adicionando velocidade para a esquerda
        meuRB.velocity = minhaVelocidade;
    }

    // Update is called once per frame
    void Update()
    {
        //checa se a bola saiu da cena
        if (transform.position.x <= -limiteHorizontal || transform.position.x >= limiteHorizontal) {
            //recarrega a cena
            SceneManager.LoadScene("Jogo");
        }
    }
}
