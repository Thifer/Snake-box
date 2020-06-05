using UnityEngine;

namespace Snake_box
{
    [CreateAssetMenu(fileName = "BatteringRamDamageTalentData", menuName = "Data/Talent/BatteringRamDamageTalentData")]
    public class BatteringRamDamageTalentData : BaseTalentData
    {
        [Tooltip("Влияние за уровень в %")]
        public float DamageModifier;
    }
}
