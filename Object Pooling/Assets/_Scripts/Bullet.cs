using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    [SerializeField]
    float speed;
    

    // Private
    Vector3 posTemp;
    Transform myParent;

    void Start () {
        myParent = transform.parent;
        posTemp = transform.localPosition;
    }

    void Update () {
        if (gameObject.active) {
            transform.position += transform.up * Time.deltaTime * speed;
        }
    }

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable () {
        transform.parent = null;
        Invoke("StopBullet", 2f);
    }

    /// <summary>
    /// Stops the bullet by turning it off
    /// </summary>
    void StopBullet () {
        transform.parent = myParent;
        Debug.Log("Stopping bullet");
        gameObject.SetActive(false);
    }
}
