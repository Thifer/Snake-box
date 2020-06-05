using UnityEngine;

namespace Snake_box
{
    [CreateAssetMenu(fileName = "MaxHpTalentData", menuName = "Data/Talent/MaxHpTalentData")]
    public class MaxHpTalentData : BaseTalentData
    {
        [Tooltip("Влияние за уровень в %")]
        public float HpModifier;
    }
}
