using UnityEngine;

namespace Snake_box
{
    [CreateAssetMenu(fileName = "ShieldRegenTalentData", menuName = "Data/Talent/ShieldRegenTalentData")]
    public class ShieldRegenTalentData : BaseTalentData
    {
        [Tooltip("Фиксированное влияние в %")]
        public float FixedShieldRegenModifier;
        [Tooltip("Влияние за уровень в %")]
        public float ShieldRegenModifier;
    }
}
