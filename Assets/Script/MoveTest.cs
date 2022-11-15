using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{

    public GameObject cube1;
    public float speedCube2 = 1f;
    private Rigidbody rb;
    private bool checkCLick = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = cube1.GetComponent<Rigidbody>();
    }

    void CubeMove()
    {
        if(this.name == "Cube2"){
            rb.velocity = this.transform.position - cube1.transform.position;
        }
        if(this.name == "Cube3"){
            rb.velocity = this.transform.position - cube1.transform.position;
        }
    }

    void OnMouseDown() {
        checkCLick = true;
    }

    void OnMouseUp() {
        checkCLick = false;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(checkCLick == true){
            CubeMove();
        }
    }
}
