using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDetect : MonoBehaviour
{
    public int speed;

    private void Update() {
        gameObject.transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }

}
