using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime,
            transform.position.y, transform.position.z); //pozycja to wektor3?
        //Time.deltaTime - czas pomi�dzy ostatni� a obecn� klatk�
    }
}
