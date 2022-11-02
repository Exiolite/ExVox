using UnityEngine;

namespace StaticModel
{
    public static class Voxel
    {
        public static readonly Vector3[] vertices =
        {
            new Vector3(0, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(1, 1, 0),
            new Vector3(0, 1, 0),
            new Vector3(0, 0, 1),
            new Vector3(1, 0, 1),
            new Vector3(1, 1, 1),
            new Vector3(0, 1, 1),
        };

        public static readonly int[] triangles =
        {
            5, 6, 4, 4, 6, 7, // Front face
            0, 3, 1, 1, 3, 2, // Back face
            1, 2, 5, 5, 2, 6, // Right face
            4, 7, 0, 0, 7, 3, // Left face
            3, 7, 2, 2, 7, 6, // Top face
            1, 5, 0, 0, 5, 4, // Bottom face
        };
    }
}
