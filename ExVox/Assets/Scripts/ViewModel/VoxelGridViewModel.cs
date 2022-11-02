using Model;
using Service;
using UnityEngine;
using Zenject;

namespace ViewModel
{
    public sealed class VoxelGridViewModel : ObjectBase
    {
        #region Fields

        private VoxelGrid _voxelGrid = new VoxelGrid();

        #endregion

        #region DI

        [Inject] private ResourcesService _resourcesService;
        [Inject] private DiContainer _diContainer;

        #endregion
        
        #region API

        private void Awake()
        {
            Load();
        }

        private void Load()
        {
            foreach (Vector3 position in _voxelGrid.Positions)
            {
                GameObject voxel = _diContainer.InstantiatePrefab(_resourcesService.VoxelViewModelPrefab);
                voxel.transform.position = position;
            }
        }

        #endregion
    }
}
