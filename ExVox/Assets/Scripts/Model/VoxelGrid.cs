using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public sealed class VoxelGrid
    {
        public List<Vector3> Positions { get; set; } = new List<Vector3>()
        {
            new Vector3(0, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(2, 0, 0),
            new Vector3(3, 0, 0),
        };
    }
}
