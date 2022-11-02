using Attributes;
using Service;
using StaticModel;
using UnityEngine;
using Zenject;

namespace ViewModel
{
    [RequireComponent(typeof(MeshFilter))]
    [RequireComponent(typeof(MeshRenderer))]
    public class VoxelViewModel : ObjectBase
    {
        #region Components

        [GetComponent] private MeshFilter _meshFilter;
        [GetComponent] private MeshRenderer _meshRenderer;

        #endregion

        #region DI

        [Inject] private ResourcesService _resourcesService;

        #endregion

        #region API

        private void Start()
        {
            _meshFilter.mesh = MeshGenerator.GetMesh();
            _meshRenderer.material = _resourcesService.Materials[0];
        }

        #endregion
    }
}
