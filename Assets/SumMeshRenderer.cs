using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumMeshRenderer : MonoBehaviour
{
    public Bounds bounds;

    void OnDrawGizmosSelected()
    {
        Bounds totalBounds = new Bounds();
        foreach (MeshRenderer meshRenderer in GetComponentsInChildren<MeshRenderer>())
        {
            totalBounds.Encapsulate(meshRenderer.bounds);
        }
        Color temp = Color.red;
        temp.a = 0.3f;
        Gizmos.color = temp;
        Gizmos.DrawCube(totalBounds.center, totalBounds.size);
    }
    void resizing()
    {
        Bounds totalBounds = new Bounds();
        foreach (MeshRenderer meshRenderer in GetComponentsInChildren<MeshRenderer>())
        {
            totalBounds.Encapsulate(meshRenderer.bounds);
        }
        Debug.Log(totalBounds.size);

        Vector3 boundVec = totalBounds.size;

        transform.localScale = new Vector3(1 / boundVec.x, 1 / boundVec.x, 1 / boundVec.x);
        // transform.localScale = new Vector3(1 / (boundVec.x*2), 1 / (boundVec.x * 2), 1 / (boundVec.x * 2));
    }
    // Start is called before the first frame update
    void Start()
    {
        resizing();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
