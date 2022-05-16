using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpawn : MonoBehaviour {
    public GameObject[] objectsList;
    public GameObject foodObj;
    public GameObject enemyObj;
    int minObj = 5;
    int minFood = 20;
    int minEnemy = 15;
    float xMin = -40f;
    float xMax = 15f;
    float yMin = -85f;
    float yFoodMin = 0f;
    float yFoodMax = 80f;
    float xEnemyMin = -30f;
    float xEnemyMax = 15f;
    float yEnemyMin = 0f;
    float yEnemyMax = 80f;
    // Start is called before the first frame update
    void Start() {
        SpawnObj();
        FoodSpawn();
        EnemySpawn();
    }

    void SpawnObj() {

        for(int i = 0; i < 4; i++) {
            for(int j = 0; j < minObj; j++) {
                Vector3 newVec = new Vector3(xMin + (j * 10), yMin + (i * 15), 0);
                float xOffset = Random.Range(-5f, 5f);
                float yOffset = Random.Range(-5f, 5f);
                newVec.x += xOffset;
                newVec.y += xOffset;
                int objNum = objectsList.Length;
                GameObject newObj = Instantiate(objectsList[Random.Range(0, objNum++)], newVec, Quaternion.identity) as GameObject;
            }
        }
    }

    void FoodSpawn() {
        for(int i = 0; i <= minFood; i++) {
            Vector3 newVec = new Vector3(Random.Range(xMin, xMax), Random.Range(yFoodMin, yFoodMax), 0);
            GameObject newObj = Instantiate(foodObj, newVec, Quaternion.identity) as GameObject;
        }
    }

    void EnemySpawn() {
        for (int i = 0; i <= minEnemy; i++) {
            Vector3 newVec = new Vector3(Random.Range(xEnemyMin, xEnemyMax), Random.Range(yEnemyMin, yEnemyMax), 0);
            GameObject newObj = Instantiate(enemyObj, newVec, Quaternion.identity) as GameObject;
        }
    }
}
