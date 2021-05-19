using System;
using UnityEngine;

public class EnemyFactory : MonoBehaviour, IFactory
{
    [SerializeField]
    public GameObject[] enemyPrefabs;

    public GameObject FactoryMethod(string tag)
    {
        GameObject enemy = Instantiate(enemyPrefabs[int.Parse(tag)]);
        return enemy;
    }
}
