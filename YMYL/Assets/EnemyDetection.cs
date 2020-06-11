using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
namespace UnityStandardAssets.Characters.FirstPerson
{

    public class EnemyDetection : MonoBehaviour
    {

        PlayerS temp;

        bool detected = false;

        private void Start()
        {
            temp = FindObjectOfType<PlayerS>().GetComponent<PlayerS>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                //PlayerS temp = other.gameObject.GetComponent<PlayerS>();
                //if (temp.GetComponent<Rigidbody>().velocity.x != 0 || temp.GetComponent<Rigidbody>().velocity.z != 0)
                if (detected) return;

                if (CrossPlatformInputManager.GetAxis("Horizontal") != 0 || CrossPlatformInputManager.GetAxis("Vertical") != 0)
                {
                    if (!temp.isDetected) ;
                    temp.livesLeft--;

                    temp.isDetected = true;
                }

                else temp.isHidden = true;

            }

            detected = true;
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.tag == "Player")
            {
                if (!temp.isDetected)
                {
                    temp.isHidden = false;
                }
            }

            detected = false;
        }
    }
}