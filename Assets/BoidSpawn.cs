using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidSpawn : MonoBehaviour
{
    public GameObject prefab; // Boidプレハブ
    public int numBoids; // 生成するボイドの数
    void Start()
    {
        for (int i = 0; i < numBoids; ++i)
        {
            Instantiate(prefab);
        }
    }
}
