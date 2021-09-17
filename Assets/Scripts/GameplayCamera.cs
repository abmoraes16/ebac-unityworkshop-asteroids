using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayCamera : MonoBehaviour
{
    public static GameplayCamera instance;
    public Camera myCamera;

    void Awake()
    {
        instance = this;
    }
}
