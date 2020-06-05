﻿using System;
using System.IO;
using UnityEngine;
using Object = UnityEngine.Object;


namespace Snake_box
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
    public sealed class Data : ScriptableObject
    {
        #region Fields
        
        [SerializeField] private string _shakeDataPath;
        [SerializeField] private string _characterDataPath;
        [SerializeField] private string _enemySpawnDataPath;
        [SerializeField] private string _levelSpawnDataPath;
        [SerializeField] private string _simpleEnemyDataPath;
        [SerializeField] private string _slowEnemyDataPath;
        [SerializeField] private string _fastEnemyDataPath;
        [SerializeField] private string _flyingEnemyDataPath;
        [SerializeField] private string _acceleratingEnemyDataPath;
        [SerializeField] private string _invisibleEnemyDataPath;
        [SerializeField] private string _spawnedEnemyDataPath;
        [SerializeField] private string _spawningEnemyDataPath;
        [SerializeField] private string _spikedEnemyDataPath;
        [SerializeField] private string _LevelDataPath;
        [SerializeField] private string _turretDataPath;
        [SerializeField] private string _shellDataPath;
        [SerializeField] private string _blockSnakeDataPath;
        [SerializeField] private string _bordersDataPath;
        [SerializeField] private string _allSpawnListsDataPath;
        [SerializeField] private string _levelPrefabsDataPath;
        [SerializeField] private string _batteringRamTalentDataPath;
        [SerializeField] private string _costReductionTalentDataPath;
        [SerializeField] private string _maxHpTalentDataPath;
        [SerializeField] private string _maxShieldTalentDataPath;
        [SerializeField] private string _maxSizeTalentDataPath;
        [SerializeField] private string _maxSpeedTalentDataPath;
        [SerializeField] private string _repairKitTalentDataPath;
        [SerializeField] private string _shieldRegenTalentDataPath;
        [SerializeField] private string _endLevelBonusTalentDataPath;
        [SerializeField] private string _killBonusTalentDataPath;
        [SerializeField] private string _startingMoneyTalentDataPath;
        [SerializeField] private string _waveBonusTalentDataPath;

        private static ShakesData _shake;
        private static CharacterData _characterData;
        private static SimpleEnemyData _simpleEnemyData;
        private static SlowEnemyData _slowEnemyData;
        private static FastEnemyData _fastEnemyData;
        private static FlyingEnemyData _flyingEnemyData;
        private static AcceleratingEnemyData _acceleratingEnemyData;
        private static InvisibleEnemyData _invisibleEnemyData;
        private static SpawnedEnemyData _spawnedEnemyData;
        private static SpawningEnemyData _spawningEnemyData;
        private static SpikedEnemyData _spikedEnemyData;
        private static LevelData _levelData;
        private static BlockSnakeData _blockSnake;
        private static TurretData _turretData;
        private static BordersData _bordersData;
        private static AllSpawnListsData _allSpawnListsData;
        private static ShellData _shellData;
        private static LevelPrefabs _levelPrefabs;
        private static BatteringRamDamageTalentData _batteringRamDamageTalentData;
        private static CostReductionTalentData _costReductionTalentData;
        private static MaxHpTalentData _maxHpTalentData;
        private static MaxShieldTalentData _maxShieldTalentData;
        private static MaxSizeTalentData _maxSizeTalentData;
        private static MaxSpeedTalentData _maxSpeedTalentData;
        private static RepairKitTalentData _repairKitTalentData;
        private static ShieldRegenTalentData _shieldRegenTalentData;
        private static EndLevelBonusTalentData _endLevelBonusTalentData;
        private static KillBonusTalentData _killBonusTalentData;
        private static StartingMoneyTalentData _startingMoneyTalentData;
        private static WaveBonusTalentData _waveBonusTalentData;
        private static readonly Lazy<Data> _instance = new Lazy<Data>(() => Load<Data>("Data/" + typeof(Data).Name));
        
        #endregion
        

        #region Properties

        public static Data Instance => _instance.Value;

        public BlockSnakeData BlockSnake
        {
            get
            {
                if (_blockSnake == null)
                {
                    _blockSnake = Load<BlockSnakeData>("Data/" + Instance._blockSnakeDataPath);
                }

                return _blockSnake;
            }
        }

        public ShakesData Shakes
        {
            get
            {
                if (_shake == null)
                {
                    _shake = Load<ShakesData>("Data/" + Instance._shakeDataPath);
                }

                return _shake;
            }
        }

        public CharacterData Character
        {
            get
            {
                if (_characterData == null)
                {
                    _characterData = Load<CharacterData>("Data/" + Instance._characterDataPath);
                }

                return _characterData;
            }
        }

        public SimpleEnemyData SimpleEnemy
        {
            get
            {
                if (_simpleEnemyData == null)
                {
                    _simpleEnemyData = Load<SimpleEnemyData>("Data/" + Instance._simpleEnemyDataPath);
                }

                return _simpleEnemyData;
            }
        }
        
        public SlowEnemyData SlowEnemy
        {
            get
            {
                if (_slowEnemyData == null)
                {
                    _slowEnemyData = Load<SlowEnemyData>("Data/" + Instance._slowEnemyDataPath);
                }

                return _slowEnemyData;
            }
        }
        
        public FastEnemyData FastEnemy
        {
            get
            {
                if (_fastEnemyData == null)
                {
                    _fastEnemyData = Load<FastEnemyData>("Data/" + Instance._fastEnemyDataPath);
                }

                return _fastEnemyData;
            }
        }

        public FlyingEnemyData FlyingEnemy
        {
            get
            {
                if (_flyingEnemyData == null)
                {
                    _flyingEnemyData = Load<FlyingEnemyData>("Data/" + Instance._flyingEnemyDataPath);
                }

                return _flyingEnemyData;
            }
        }
        
        public AcceleratingEnemyData AcceleratingEnemy
        {
            get
            {
                if (_acceleratingEnemyData == null)
                {
                    _acceleratingEnemyData = Load<AcceleratingEnemyData>("Data/" + Instance._acceleratingEnemyDataPath);
                }

                return _acceleratingEnemyData;
            }
        }
        
        public InvisibleEnemyData InvisibleEnemy
        {
            get
            {
                if (_invisibleEnemyData == null)
                {
                    _invisibleEnemyData = Load<InvisibleEnemyData>("Data/" + Instance._invisibleEnemyDataPath);
                }

                return _invisibleEnemyData;
            }
        }
        
        public SpawnedEnemyData SpawnedEnemy
        {
            get
            {
                if (_spawnedEnemyData == null)
                {
                    _spawnedEnemyData = Load<SpawnedEnemyData>("Data/" + Instance._spawnedEnemyDataPath);
                }

                return _spawnedEnemyData;
            }
        }
        
        public SpawningEnemyData SpawningEnemy
        {
            get
            {
                if (_spawningEnemyData == null)
                {
                    _spawningEnemyData = Load<SpawningEnemyData>("Data/" + Instance._spawningEnemyDataPath);
                }

                return _spawningEnemyData;
            }
        }
        
        public SpikedEnemyData SpikedEnemy
        {
            get
            {
                if (_spikedEnemyData == null)
                {
                    _spikedEnemyData = Load<SpikedEnemyData>("Data/" + Instance._spikedEnemyDataPath);
                }

                return _spikedEnemyData;
            }
        }

        public LevelData LevelData
        {
            get
            {
                if (_levelData == null)
                {
                    _levelData = Load<LevelData>("Data/" + Instance._LevelDataPath);
                }

                return _levelData;
            }
        }

        public TurretData TurretData
        {
            get
            {
                if (_turretData == null)
                {
                    _turretData = Load<TurretData>("Data/" + Instance._turretDataPath);
                }

                return _turretData;
            }
        }

        public BordersData BordersData
        {
            get
            { 
                if(_bordersData == null)
                    _bordersData = Load<BordersData>("Data/" + Instance._bordersDataPath);
                return _bordersData;
            }
        }

        public ShellData ShellData
        {
            get
            {
                if (_shellData == null)
                {
                    _shellData = Load<ShellData>("Data/" + Instance._shellDataPath);
                }

                return _shellData;
            }
        }

        public AllSpawnListsData AllSpawnListsData
        {
            get
            {
                if (_allSpawnListsData == null)
                    _allSpawnListsData = Load<AllSpawnListsData>("Data/" + Instance._allSpawnListsDataPath);
                return _allSpawnListsData;
            }
        }

        public LevelPrefabs LevelPrefabs
        {
            get
            {
                if (_levelPrefabs == null)
                    _levelPrefabs = Load<LevelPrefabs>("Data/" + Instance._levelPrefabsDataPath);
                return _levelPrefabs;
            }
        }

        public BatteringRamDamageTalentData BatteringRamDamageTalentData
        {
            get
            {
                if (_batteringRamDamageTalentData==null)
                {
                    _batteringRamDamageTalentData =
                        Load<BatteringRamDamageTalentData>("Data/" + Instance._batteringRamTalentDataPath);
                }

                return _batteringRamDamageTalentData;
            }
        }
        public CostReductionTalentData CostReductionTalentData
        {
            get
            {
                if (_costReductionTalentData==null)
                {
                    _costReductionTalentData =
                        Load<CostReductionTalentData>("Data/" + Instance._costReductionTalentDataPath);
                }

                return _costReductionTalentData;
            }
        }
        public MaxHpTalentData MaxHpTalentData
        {
            get
            {
                if (_maxHpTalentData==null)
                {
                    _maxHpTalentData =
                        Load<MaxHpTalentData>("Data/" + Instance._maxHpTalentDataPath);
                }

                return _maxHpTalentData;
            }
        }
        public MaxShieldTalentData MaxShieldTalentData
        {
            get
            {
                if (_maxShieldTalentData==null)
                {
                    _maxShieldTalentData =
                        Load<MaxShieldTalentData>("Data/" + Instance._maxShieldTalentDataPath);
                }

                return _maxShieldTalentData;
            }
        }
        public MaxSizeTalentData MaxSizeTalentData
        {
            get
            {
                if (_maxSizeTalentData==null)
                {
                    _maxSizeTalentData =
                        Load<MaxSizeTalentData>("Data/" + Instance._maxSizeTalentDataPath);
                }

                return _maxSizeTalentData;
            }
        }
        public MaxSpeedTalentData MaxSpeedTalentData
        {
            get
            {
                if (_maxSpeedTalentData==null)
                {
                    _maxSpeedTalentData =
                        Load<MaxSpeedTalentData>("Data/" + Instance._maxSpeedTalentDataPath);
                }

                return _maxSpeedTalentData;
            }
        }
        public RepairKitTalentData RepairKitTalentData
        {
            get
            {
                if (_repairKitTalentData==null)
                {
                    _repairKitTalentData =
                        Load<RepairKitTalentData>("Data/" + Instance._repairKitTalentDataPath);
                }

                return _repairKitTalentData;
            }
        }

        public ShieldRegenTalentData ShieldRegenTalentData
        {
            get
            {
                if (_shieldRegenTalentData == null)
                {
                    _shieldRegenTalentData = Load<ShieldRegenTalentData>("Data/+" + Instance._shieldRegenTalentDataPath);
                }

                return _shieldRegenTalentData;
            }
        }

        public EndLevelBonusTalentData EndLevelBonusTalentData
        {
            get
            {
                if (_endLevelBonusTalentData == null)
                {
                    _endLevelBonusTalentData = Load<EndLevelBonusTalentData>("Data/+" + Instance._endLevelBonusTalentDataPath);
                }

                return _endLevelBonusTalentData;
            }
        }

        public KillBonusTalentData KillBonusTalentData
        {
            get
            {
                if (_killBonusTalentData == null)
                {
                    _killBonusTalentData = Load<KillBonusTalentData>("Data/+" + Instance._killBonusTalentDataPath);
                }

                return _killBonusTalentData;
            }
        }

        public StartingMoneyTalentData StartingMoneyTalentData
        {
            get
            {
                if (_startingMoneyTalentData == null)
                {
                    _startingMoneyTalentData = Load<StartingMoneyTalentData>("Data/+" + Instance._startingMoneyTalentDataPath);
                }

                return _startingMoneyTalentData;
            }
        }

        public WaveBonusTalentData WaveBonusTalentData
        {
            get
            {
                if (_waveBonusTalentData == null)
                {
                    _waveBonusTalentData = Load<WaveBonusTalentData>("Data/+" + Instance._waveBonusTalentDataPath);
                }

                return _waveBonusTalentData;
            }
        }




        #endregion


        #region Methods

        private static T Load<T>(string resourcesPath) where T : Object =>
            CustomResources.Load<T>(Path.ChangeExtension(resourcesPath, null));
    
        #endregion
    }
}
