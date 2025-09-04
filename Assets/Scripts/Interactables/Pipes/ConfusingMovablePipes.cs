using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ConfusingMovablePipes : MonoBehaviour
{
    private float[] rotations = { 0, 90, 180, 270 };


    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
    }
}
