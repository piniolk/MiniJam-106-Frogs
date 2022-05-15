using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInteract : MonoBehaviour {
    public GameObject tadpole;
    public GameObject tadpoleNumUI;
    GameObject spawnTad;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("FoodPellet")){
            spawnTadpole();
            Destroy(collision.collider.gameObject);
            spawnTad.GetComponent<FollowPlayer>().SetFollowPoint(this.gameObject);
        }
    }

    void spawnTadpole() {
        Vector3 spawnPoint = this.transform.position;
        spawnPoint.x -= 1f;
        spawnPoint.y -= 1f;
        spawnTad = Instantiate(tadpole, spawnPoint, Quaternion.identity) as GameObject;
        tadpoleNumUI = GameObject.FindWithTag("UITadpoleNum");
        tadpoleNumUI.GetComponent<UIHandler>().UpdateText();
    }

}
