using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Formas : MonoBehaviour
{
    private Rigidbody formasRB;

    // Start is called before the first frame update
    void Start()
    {
        formasRB = GetComponent<Rigidbody>();
        StartCoroutine(WaitForJump());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Move()
    {
        formasRB.AddForce(Vector3.up *5, ForceMode.Impulse);
    }

    IEnumerator WaitForJump()
    {
        while (true)
        {
        yield return new WaitForSeconds(1);
        Move();
        }
        
    }
}
