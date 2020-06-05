using UnityEngine;

namespace Snake_box
{
    [CreateAssetMenu(fileName = "KillBonusTalentData", menuName = "Data/Talent/KillBonusTalentData")]
    public class KillBonusTalentData : BaseTalentData
    {
        [Tooltip("Влияние за уровень в %")]
        public float KillBonusModifier;
    }
}
