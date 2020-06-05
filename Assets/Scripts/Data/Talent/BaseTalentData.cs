using UnityEngine;

namespace Snake_box
{
    public class BaseTalentData : ScriptableObject
    {
        [Tooltip("Имя таланта(необходимо для загрузки)")]
        public string Name;
        [Tooltip("Фиксированная цена")]
        public int Cost;
        [Tooltip("Цена за уровень")]
        public int CostModifier;
        [Tooltip("Максимальный уровень таланта")]
        public int MaxLevel;
    }
}
