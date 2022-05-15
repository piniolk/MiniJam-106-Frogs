using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TadpoleManager : MonoBehaviour {
    public GameObject tadpoleNumUI;
    void Start() {
        tadpoleNumUI = GameObject.FindWithTag("UITadpoleNum");
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Enemy")) {
            tadpoleNumUI.GetComponent<UIHandler>().SubtractText();
            Destroy(this.gameObject);
        }
    }
}
