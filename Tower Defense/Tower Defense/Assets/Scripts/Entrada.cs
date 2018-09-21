using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrada : MonoBehaviour {

    [SerializeField] GameObject[] enemies;
    int enemyIndex = 0;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, 1f);
    }

    void SpawnEnemy()
    {
        Instantiate(enemies[enemyIndex], transform.position, transform.rotation);
        enemyIndex++;
        if (enemyIndex > enemies.Length - 1)
            enemyIndex = 0;
    }
}
