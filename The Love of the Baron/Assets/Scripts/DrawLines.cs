using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{
   [Header("Lines")]
   [SerializeField] Transform lineParent;
   [SerializeField] private GameObject linePrefab;
    private LineRenderer currentLine;

    void Update()
    {
    if (currentLine == null)
    {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity, lineParent).GetComponent<LineRenderer>();
    }        
    }
}
