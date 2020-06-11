using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Characters.FirstPerson {
    public class Coin : MonoBehaviour {
        
        private void Update() {
            //spining the coin
            gameObject.transform.Rotate(Vector3.up * Time.deltaTime * 50);
        }

        private void OnTriggerEnter(Collider other) {
            if (other.tag == "Player") {
                //increasing score when colide with coin
                GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().score++;
                //spawning next coin
                GameObject.FindGameObjectWithTag("SpawnCoin").GetComponent<SpawnCoin>().CoinSpawn();
                //destroying the current coin
                Destroy(gameObject);
            }
        }
    }
}