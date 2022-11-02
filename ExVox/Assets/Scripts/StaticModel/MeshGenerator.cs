using System.Linq;
using UnityEngine;

namespace StaticModel
{
    public static class MeshGenerator
    {
        public static Mesh GetMesh()
        {
            return new Mesh
            {
                vertices = Voxel.vertices.ToArray(),
                triangles = Voxel.triangles.ToArray()
            };
        }
    }
}
