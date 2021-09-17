using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoJogador : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float aceleracao = 1.0f;
    public float velocidadeAngular = 180.0f;
    public float velocidadeMaxima = 5.0f;
    public int tempoSegundosProtejil = 1;

    public Rigidbody2D prefabProjetil;
    public float velocidadeProjetil = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D projetil = Instantiate(prefabProjetil, myRigidbody2D.position, Quaternion.identity);
            projetil.velocity = transform.up * velocidadeProjetil;
            Destroy(projetil.gameObject, tempoSegundosProtejil);
        }
    }

    // execucao de codigo de fisica FixedUpdate - 
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            Vector3 direcao = transform.up * aceleracao;
            myRigidbody2D.AddForce(direcao, ForceMode2D.Force);
        }

        if(Input.GetKey(KeyCode.LeftArrow)){
            myRigidbody2D.rotation += velocidadeAngular * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            myRigidbody2D.rotation -= velocidadeAngular * Time.deltaTime;
        }

        if(myRigidbody2D.velocity.magnitude > velocidadeMaxima){
            myRigidbody2D.velocity = Vector2.ClampMagnitude(myRigidbody2D.velocity, velocidadeMaxima);
        }
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        Destroy(gameObject);
    }
}
