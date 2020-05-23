using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minefield : MonoBehaviour {

    public GameObject[] MinesArr;


    private void Awake() {
        for (int i = 0; i < MinesArr.Length; i++) {
            int rndPosX = Random.Range(0, 5);
            int rndPosZ = Random.Range(0, 15);
            MinesArr[i].transform.position = new Vector3(rndPosX + 0.5f, 1.5f, rndPosZ + 0.5f);
        }
    }

}
