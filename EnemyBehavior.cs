using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public int speed;
    private Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 WorldCheck = camera.WorldToViewportPoint(transform.position);
        if(WorldCheck.x > 1.2f) {
            Destroy(gameObject);
        }
        Vector3 position = transform.position;
        position.x += 0.1f;
        transform.position = position;
    }
}
