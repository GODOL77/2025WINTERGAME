using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    int level;
    public float gaemTime;
    public float maxGameTime = 2 * 10f;

    public PoolManager pool;
    public Player plyaer;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        gaemTime += Time.deltaTime;

        if (gaemTime > maxGameTime)
        {
            gaemTime = maxGameTime;
        }
    }
}
