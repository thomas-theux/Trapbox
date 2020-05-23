using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour {

    public Vector3 StartPos;

    private void Awake() {
        StartPos = this.transform.position;
    }

}
