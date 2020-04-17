using UnityEngine;

public class Example : MonoBehaviour
{
    [System.Obsolete]
    void Start()
    {
        Mesh mesh = gameObject.GetComponent<MeshFilter>().mesh;
        mesh.Optimize();
    }
}