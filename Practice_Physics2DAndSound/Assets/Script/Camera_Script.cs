using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Script : MonoBehaviour
{

    public GameObject MaskDude;

    void Update()
    {
        Vector3 position = transform.position;
        position.x = MaskDude.transform.position.x;
        transform.position = position;
    }
}
