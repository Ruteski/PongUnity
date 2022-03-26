using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    private Vector3 minhaPosicao;
    private float meuY;
    public float velocidade = 7f;
    public float meuLimite = 3.5f;

    // Start is called before the first frame update
    void Start() 
    {
        //pegando a posicao inicial da raquete e aplicando a minha posicao
        minhaPosicao = transform.position;
    }

    // Update is called once per frame
    void Update() {

        if (gameObject.tag == "Player1") {
            if (Input.GetKey(KeyCode.UpArrow)) {
                //meuY += 0.005f;

                //verifica o limite da tela
                if (meuY < meuLimite) {
                    //deltaTime retorna o tempo que leva para ir de um frame ate o proximo frame
                    meuY += velocidade * Time.deltaTime; // usando o deltaTime pra manter a msm velocidade em diferentes FPS
                }
            }

            if (Input.GetKey(KeyCode.DownArrow) && (meuY > -meuLimite)) {
                //meuY -= 0.005f;

                //deltaTime retorna o tempo que leva para ir de um frame ate o proximo frame
                meuY -= velocidade * Time.deltaTime; // usando o deltaTime pra manter a msm velocidade em diferentes FPS
            }
        } else {
            if (Input.GetKey(KeyCode.W)) {
                if (meuY < meuLimite) {
                    meuY += velocidade * Time.deltaTime;
                }
            }

            if (Input.GetKey(KeyCode.S) && (meuY > -meuLimite)) {
                meuY -= velocidade * Time.deltaTime;
            }
        }

        minhaPosicao.y = meuY;
        transform.position = minhaPosicao;
    }

}
