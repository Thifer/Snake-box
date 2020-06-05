using UnityEngine;

namespace Snake_box
{
    [CreateAssetMenu(fileName = "WaveBonusTalentData", menuName = "Data/Talent/WaveBonusTalentData")]
    public class WaveBonusTalentData : BaseTalentData
    {
        [Tooltip("Влияние за уровень в %")]
        public float WaveBonusModifier;
    }
}
