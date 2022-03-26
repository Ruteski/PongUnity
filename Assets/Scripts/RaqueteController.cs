using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    private Vector3 minhaPosicao;
    public float meuY;
    public float velocidade = 5f;

    // Start is called before the first frame update
    void Start() 
    {
        //pegando a posicao inicial da raquete e aplicando a minha posicao
        minhaPosicao = transform.position;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            //meuY += 0.005f;

            //deltaTime retorna o tempo que leva para ir de um frame ate o proximo frame
            meuY += velocidade * Time.deltaTime; // usando o deltaTime pra manter a msm velocidade em diferentes FPS
            
        } 
        
        if (Input.GetKey(KeyCode.DownArrow)) {
            //meuY -= 0.005f;

            //deltaTime retorna o tempo que leva para ir de um frame ate o proximo frame
            meuY -= velocidade * Time.deltaTime; // usando o deltaTime pra manter a msm velocidade em diferentes FPS
        }

        minhaPosicao.y = meuY;
        transform.position = minhaPosicao;
    }

}
