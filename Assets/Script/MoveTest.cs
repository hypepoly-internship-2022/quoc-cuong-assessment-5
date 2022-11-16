using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{

    public GameObject cube2;
    public GameObject cube3;
    public float speed = 10;


    private Rigidbody rb;
    private bool isClick = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void MoveCube()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            if(hit.collider.name == "Cube2"){
                rb.velocity = cube2.transform.position - this.transform.position;
            }
            if(hit.collider.name == "Cube3"){
                rb.velocity = cube3.transform.position - this.transform.position;
            }
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetMouseButton(0)){
            isClick = true;
        } else{
            isClick = false;
        }
    }

    private void FixedUpdate()
    {
        if(isClick == true){
            MoveCube();
        }else{
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
