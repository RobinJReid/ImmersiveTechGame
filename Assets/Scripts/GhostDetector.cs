using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostDetector : MonoBehaviour
{
    public float Value;

    private void Update()
    {

        Value = new float(Random.Range(5.0f, 10.0f));
    }
}
