using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTeleport : MonoBehaviour
{
    private bool put3 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R)) {
            Application.LoadLevel("level3");
        }
    }
    public bool getBool()
    {
        return put3;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Vector3 temp = new Vector3(20, 50,0);
        if (other.gameObject.name == "portal1") {
            transform.position += temp;
            Debug.Log("thoep");
       }
        if (other.gameObject.name == "puttun3") {
            put3 = true;
        }
    }
}
