using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OndaDeAsteroides : MonoBehaviour
{
    public ComportamentoAsteroide comportamentoAsteroide;
    public int quantidadeAsteroides = 3;

    void Start()
    {
        GerarAsteroides();
    }

    public void GerarAsteroides()
    {
        for(int i=0; i < quantidadeAsteroides; i++)
        {
            float x = Random.Range(-7.0f, 7.0f);
            float y = Random.Range(-4.0f, 4.0f);

            Vector3 posicao = new Vector3(x, y, 0.0f);
            Instantiate(comportamentoAsteroide, posicao, Quaternion.identity);
        }
    }
}
