using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float Speed = 1;

    void FixedUpdate() {
        transform.Translate(
            Input.GetAxis("Horizontal") * Speed,
            0,
            0
        );
	}
}
