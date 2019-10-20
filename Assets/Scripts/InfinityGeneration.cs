using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityGeneration : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        print(other);
        if (other.name == "Check")
        {
            print("HERE");
            var obj1 = GameObject.Find("ramp1");
            transform.position = new Vector3(obj1.transform.position.x, obj1.transform.position.y + 16f, obj1.transform.position.z);

        }
    }


}
