using UnityEngine;

namespace Snake_box
{
    [CreateAssetMenu(fileName = "MaxShieldTalentData", menuName = "Data/Talent/MaxShieldTalentData")]
    public class MaxShieldTalentData : BaseTalentData
    {
        [Tooltip("Влияние за уровень в %")]
        public float ShieldModifier;
    }
}
