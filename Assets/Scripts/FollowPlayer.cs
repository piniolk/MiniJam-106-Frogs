using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    GameObject followPoint;
    float speed = 4f;
    float offsetX;
    float offsetY;

    void Start() {
        offsetX = Random.Range(-2f, 2f);
        offsetY = Random.Range(-2f, 2f);
    }

    // Update is called once per frame
    void Update() {
        if (CheckIfClose()) {
            Movement();
        }
    }

    public void SetFollowPoint(GameObject objFollow) {
        followPoint = objFollow;
    }

    void Movement() {
        Vector3 followPos = followPoint.transform.position;
        followPos.x += offsetX;
        followPos.y += offsetY;
        Vector3 move = followPos - this.transform.position;
        move.Normalize();
        this.transform.Translate(move * speed * Time.deltaTime);
    }

    bool CheckIfClose() {
        float x = Mathf.Abs(this.transform.position.x - followPoint.transform.position.x);
        float y = Mathf.Abs(this.transform.position.y - followPoint.transform.position.y);
        if (x < 1 && y < 1) {
            return false;
        } else {
            return true;
        }
    }
}
