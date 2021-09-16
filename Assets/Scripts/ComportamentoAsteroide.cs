using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoAsteroide : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float velocidadeMaxima = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle; //para asteroides irem para direcao aleatoria
        direcao *= velocidadeMaxima;
        myRigidBody.velocity = direcao;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D outro)
    {
        Destroy(gameObject);
        Destroy(outro.gameObject);
    }
}
