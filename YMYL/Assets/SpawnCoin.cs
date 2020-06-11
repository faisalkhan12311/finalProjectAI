using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject coin;

    private void Start() {
        CoinSpawn();
    }

    public void CoinSpawn() {
        //choosing random spawn point from array
        Transform temp = spawnPoint[Random.Range(0, spawnPoint.Length)];
        //spawning coin object
        Instantiate(coin, temp.position, temp.rotation);
    }
}
