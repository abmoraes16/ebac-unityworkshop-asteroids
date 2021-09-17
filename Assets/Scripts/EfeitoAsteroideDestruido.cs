using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeitoAsteroideDestruido : MonoBehaviour
{
    public ParticleSystem myParticleSystem;
    public AudioSource myAudioSource;
    public float delayAutoDestruir = 1.0f;
    void Start()
    {
        myParticleSystem.Play(false);
        myAudioSource.Play();
        Destroy(gameObject, delayAutoDestruir);
    }
}
