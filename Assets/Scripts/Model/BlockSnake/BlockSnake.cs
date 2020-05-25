﻿using System.Collections.Generic;
using UnityEngine;


namespace Snake_box
{
    public sealed class BlockSnake : MonoBehaviour
    {
        #region Fields

        public Transform _spawnPoint;
        private TurretController _turretController;
        private BlockSnakeData _blockSnakeData;
        private bool _turret;


        #endregion


        #region Unity Method

        private void Awake() 
        {             
            _blockSnakeData = Data.Instance.BlockSnake;           
        }

        #endregion


        #region Method

        public void AddTurret()
        {
            if (!_turret)
            {
                Data.Instance.TurretData.AddNewWithParent(_spawnPoint);
                _turret = true;
            }
        }

        public bool GetHasTurrel()
        {
            return _turret;
        }

        #endregion
    }
}
