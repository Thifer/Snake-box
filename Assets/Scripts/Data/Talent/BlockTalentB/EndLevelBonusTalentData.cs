using UnityEngine;

namespace Snake_box
{
    [CreateAssetMenu(fileName = "EndLevelBonusTalentData", menuName = "Data/Talent/EndLevelBonusTalentData")]
    public class EndLevelBonusTalentData : BaseTalentData
    {
        [Tooltip("Влияние за уровень в %")]
        public float EndLevelBonusModifier;
    }
}
