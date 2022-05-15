using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Boundary")) {
            Debug.Log("Touch");
            GetComponent<EnemyMovement>().ChangeMove();
        }
    }
}