using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using ViewModel;

namespace Service
{
    public sealed class ResourcesService
    {
        public List<Material> Materials { get; }
        public VoxelViewModel VoxelViewModelPrefab { get; }
        
        public ResourcesService()
        {
            Materials = Resources.LoadAll<Material>("Materials/").ToList();
            VoxelViewModelPrefab = Resources.Load<VoxelViewModel>("Prefabs/VoxelViewModel");
        }
    }
}
