using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace UnityStandardAssets.Characters.FirstPerson
{

    public class PlayerS : MonoBehaviour
    {

        public bool isDetected, isHidden;
        public int livesLeft = 3;
        bool tempDetect;
        FirstPersonController fps;
        public GameObject counter;
        int detectionCounter;
        public void Start()
        {
            fps = GetComponent<FirstPersonController>();
            isDetected = false;
            tempDetect = false;
        }

        private void Update()
        {
            //if detected
            if (isDetected && fps.m_WalkSpeed > 0 && fps.m_RunSpeed > 0 && !tempDetect)
            {
                tempDetect = true;
                //calling stun coroutine
                StartCoroutine("Stun");
            }
        }

        IEnumerator Stun()
        {

            //set counter
            counter.SetActive(true);
            //player cant move
            fps.m_WalkSpeed = 0;
            fps.m_RunSpeed = 0;
            //3 sec delay
            yield return new WaitForSeconds(3f);
            //turning counter off
            counter.SetActive(false);
            //player can move now
            fps.m_WalkSpeed = 5;
            fps.m_RunSpeed = 10;
            detectionCounter++;
            isDetected = false;
            tempDetect = false;
        }


    }
}