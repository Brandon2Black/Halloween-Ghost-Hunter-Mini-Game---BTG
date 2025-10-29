using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjctileSpinner : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        transform.rotation = Quaternion.Euler(0, 0, 90);
    }

}
