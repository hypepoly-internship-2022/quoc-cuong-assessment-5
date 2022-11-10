using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{

    public GameObject cube1;
    public float speedCube2 = 1f;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = cube1.GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        if(this.name == "Cube2"){
            rb.MovePosition(this.transform.position);
        }
    }

    private void OnMouseDrag()
    {
        if(this.name == "Cube3"){
            cube1.transform.position = Vector3.MoveTowards(cube1.transform.position, this.transform.position, speedCube2);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
