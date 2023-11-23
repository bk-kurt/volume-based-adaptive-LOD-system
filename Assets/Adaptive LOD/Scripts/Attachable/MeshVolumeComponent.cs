using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshVolumeComponent : MonoBehaviour
{
    public float Volume { get; private set; }

    private void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Volume = MeshVolumeCalculator.VolumeOfMesh(mesh);
    }
}