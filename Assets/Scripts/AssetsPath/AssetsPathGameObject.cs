﻿using System.Collections.Generic;


namespace ExampleTemplate
{
    public sealed class AssetsPathGameObject
    {
        #region Fields

        public static readonly Dictionary<GameObjectType, string> GameObjects = new Dictionary<GameObjectType, string>
        {
            {
                GameObjectType.Canvas, "GUI/GUI_Canvas"
            },
            {                
                GameObjectType.Character, "Prefabs/Character/Prefabs_Character_SphereCharacter"
            }
        };

        public static readonly Dictionary<EnemyType, string> EnemyObjects = new Dictionary<EnemyType, string>
        {
            {
                EnemyType.Simple, "Prefabs/Enemies/SimpleEnemy"
            }
        };

        #endregion
    }
}
