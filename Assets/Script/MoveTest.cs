using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{

    public GameObject cube1;

    private Rigidbody rb;
    private bool checkClick = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = cube1.GetComponent<Rigidbody>();
    }

    /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    private void OnMouseDrag()
    {
        if(this.name == "Cube2"){
            rb.velocity = Vector3.MoveTowards(-cube1.transform.position, this.transform.position, 10f);
        }  
    }

    // Update is called once per frame
    void Update()
    {

    }
}
