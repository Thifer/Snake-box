using UnityEngine;

namespace Snake_box
{
    [CreateAssetMenu(fileName = "CostReductionTalentData", menuName = "Data/Talent/CostReductionTalentData")]
    public class CostReductionTalentData : BaseTalentData
    {
        [Tooltip("Влияние за уровень в %")]
        public float CostReductionModifier;
    }
}
