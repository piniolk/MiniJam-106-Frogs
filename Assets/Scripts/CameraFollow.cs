using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    GameObject player;

    // Start is called before the first frame update
    void Start() {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update() {
        Vector3 move = player.transform.position;
        move.z = -20f;
        this.transform.position = move;
    }
}
