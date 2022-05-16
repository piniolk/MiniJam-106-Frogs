using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    float speed = 3f;
    bool isMoving;
    GameObject followPoint;

    // Start is called before the first frame update
    void Start() {
        isMoving = false;
        followPoint = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update() {
        if (GetComponent<Rigidbody2D>().velocity == new Vector2(0,0)) {
            isMoving = false;
        }

        if (CheckIfClose()) {
            TrackFrog();
        } else {
            Patrol();
        }
        
    }

    public void ChangeMove() {
        Patrol();
    }

    void Patrol() {
        if (isMoving == false) {
            int num = Random.Range(0, 2);
            if (num == 0) {
                PatrolX();
            } else {
                PatrolY();
            }
        }
    }

    void PatrolX() {
        isMoving = true;
        Vector3 move = this.transform.position;
        float x = Random.Range(-3f, 3f);
        move.x += x;
        move.Normalize();
        this.transform.Translate(move * speed * Time.deltaTime);
    }

    void PatrolY() {
        isMoving = true;
        Vector3 move = this.transform.position;
        float y = Random.Range(-3f, 3f);
        move.y += y;
        move.Normalize();
        this.transform.Translate(move * speed * Time.deltaTime);
    }

    bool CheckIfClose() {
        float x = Mathf.Abs(this.transform.position.x - followPoint.transform.position.x);
        float y = Mathf.Abs(this.transform.position.y - followPoint.transform.position.y);
        if (x < 5 && y < 5) {
            return true;
        } else {
            return false;
        }
    }

    void TrackFrog() {
        isMoving = true;
        Vector3 followPos = followPoint.transform.position;
        Vector3 move = followPos - this.transform.position;
        move.Normalize();
        this.transform.Translate(move * speed * Time.deltaTime);
    }
}
