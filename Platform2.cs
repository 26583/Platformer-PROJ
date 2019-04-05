using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2 : MonoBehaviour
{
    PlayerCollision playerCollision;
    BoxTeleport boxTeleport;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerCollision = GameObject.Find("player").GetComponent<PlayerCollision>();
        boxTeleport = GameObject.Find("box").GetComponent<BoxTeleport>();
        if (playerCollision.getBool()) {
            Vector3 position = transform.position;
            if (position.y >= 5.6) {
                position.y -= 0.1f;
                transform.position = position;
            }
        }
        if (boxTeleport.getBool()) {
            Vector3 position = transform.position;
            if (position.y >= 25.7f) {
                position.y -= 0.1f;
                transform.position = position;
            }
        }
        if (playerCollision.getBool2()) {
            Vector3 position = transform.position;
            if (position.x >= -46) {
                position.x -= 0.5f;
                transform.position = position;
            }
        }

    }
}
