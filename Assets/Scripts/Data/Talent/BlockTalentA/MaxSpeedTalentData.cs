using UnityEngine;

namespace Snake_box
{
    [CreateAssetMenu(fileName = "MaxSpeedTalentData", menuName = "Data/Talent/MaxSpeedTalentData")]
    public class MaxSpeedTalentData : BaseTalentData
    {
        [Tooltip("Влияние за уровень в %")]
        public float SpeedModifier;
    }
}
