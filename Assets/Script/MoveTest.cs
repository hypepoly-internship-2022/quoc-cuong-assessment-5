using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{

    public GameObject cube2;
    public GameObject cube3;
    public float maxSpeed = 10f;


    private Rigidbody rb;
    private Vector3 curPos;
    private bool isClick = false;

    // Start is called before the first frame update
    void Start()
    {
        curPos = this.transform.position;
        rb = this.GetComponent<Rigidbody>();
    }

    // void MoveCube()
    // {
    //     if(this.name == "Cube3"){
    //         rb.velocity = this.transform.position - cube1.transform.position;
    //         Debug.Log(this.name);
    //     }

    //     if(this.name == "Cube2"){
    //         rb.velocity = this.transform.position - cube1.transform.position;
    //         Debug.Log(this.name);
    //     }
    // }

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
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit)){
                Debug.Log(hit.collider.name);
                if(hit.collider.name == "Cube2"){
                    rb.velocity = cube2.transform.position - curPos;
                }
                if(hit.collider.name == "Cube3"){
                    rb.velocity = cube3.transform.position - curPos;
                }
            }
        }else{
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
