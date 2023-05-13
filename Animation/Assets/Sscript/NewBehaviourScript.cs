using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Vector3 direction = new Vector3(1,1,1);

    // Start is called before the first frame update
    void Start()
    {
        print(transform.position);
        Move(transform);
        print(transform.position);
    }

    public void Move(Transform dir)
    {
        dir.position = new Vector3(5, 5, 5);
    }
}
