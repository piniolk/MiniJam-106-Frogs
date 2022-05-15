using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour {
    //SpriteRenderer spriteRenderer;
    float speed = 6f;
    // Start is called before the first frame update
    void Start() {
        //this.spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, y, 0);

        //spriteRenderer.Move(movement * speed * Time.deltaTime);
        transform.Translate(movement * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Escape)) {
            
        }
    }
}
