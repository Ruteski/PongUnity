using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    private Vector3 minhaPosicao;
    private float meuY;
    public float velocidade = 7f;
    public float meuLimite = 3.5f;

    //variavel para checar se ele deve ser controlado pela ia
    public bool automatico = false;

    //pegando a posicao da bola
    public Transform transformBola;

    // Start is called before the first frame update
    void Start() 
    {
        //pegando a posicao inicial da raquete e aplicando a minha posicao
        minhaPosicao = transform.position;
    }

    // Update is called once per frame
    void Update() {

        //velocidade final
        float deltaVelocidade = velocidade * Time.deltaTime;

        minhaPosicao.y = meuY;
        transform.position = minhaPosicao;

        if (!automatico) {
            if (gameObject.tag == "Player1") {
                if (Input.GetKey(KeyCode.W)) {
                    //meuY += 0.005f;

                    //verifica o limite da tela
                    //deltaTime retorna o tempo que leva para ir de um frame ate o proximo frame
                    meuY += deltaVelocidade; // usando o deltaTime pra manter a msm velocidade em diferentes FPS
                }

                if (Input.GetKey(KeyCode.S)) {
                    //meuY -= 0.005f;

                    //deltaTime retorna o tempo que leva para ir de um frame ate o proximo frame
                    meuY -= deltaVelocidade; // usando o deltaTime pra manter a msm velocidade em diferentes FPS
                }
            } else {
                if (Input.GetKey(KeyCode.UpArrow)) {
                    meuY += deltaVelocidade;
                }

                if (Input.GetKey(KeyCode.DownArrow)) {
                    meuY -= deltaVelocidade;
                }
            }
        } else {
            //funcao matematica
            //linear interpolation
            //ir de um lugar para outro de forma suave
            //transformar um valor em outro de forma suave
            meuY = Mathf.Lerp(meuY, transformBola.position.y, 0.01f);


            //se meu valor � de 0 e o da bola � 10 a diferen�a entre eles � de 10, 10% de 10 � 1
        }

        if (meuY < -meuLimite) {
            meuY = -meuLimite;
        }

        if (meuY > meuLimite) {
            meuY = meuLimite;
        }
    }
}
