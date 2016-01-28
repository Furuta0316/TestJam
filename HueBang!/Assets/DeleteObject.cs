using UnityEngine;
using System.Collections;

public class DeleteObject : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
    }
}
