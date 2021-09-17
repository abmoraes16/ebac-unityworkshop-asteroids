using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoAsteroide : MonoBehaviour
{
    public static System.Action EventoAsteroideDestruido = null;
    public Rigidbody2D myRigidBody;
    public ComportamentoAsteroide prefabFragmento;
    public float velocidadeMaxima = 1.0f;
    public float altura = 1.0f;
    public float largura = 1.0f; 
    public int QuantidadeFragmentos = 3;

    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle; //para asteroides irem para direcao aleatoria
        direcao *= velocidadeMaxima;
        myRigidBody.velocity = direcao;
        this.transform.localScale = new Vector3(altura, largura, largura);
    }
    
    void OnTriggerEnter2D(Collider2D outro)
    {
        Destroy(gameObject);
        Destroy(outro.gameObject);
        
        for(int i=0; i < QuantidadeFragmentos; i++)
        {
            float diametro = Random.Range(0.2f, 0.6f);
            Instantiate(prefabFragmento, myRigidBody.position, Quaternion.identity);
            prefabFragmento.altura = diametro;
            prefabFragmento.largura = diametro;
        }

        if(EventoAsteroideDestruido != null)
        {
            EventoAsteroideDestruido();
        }    
    }
}