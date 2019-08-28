using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    [SerializeField]
    float speed;

    void Update () {
        if (Input.GetKey(KeyCode.UpArrow)) {
            RotateGun(speed);
        }else if (Input.GetKey(KeyCode.DownArrow)) {
            RotateGun(-speed);
        }
    }

    void RotateGun (float _speed) {
        transform.Rotate(0, 0, _speed, Space.Self);
    }
}
