using UnityEngine;

namespace Snake_box
{
    [CreateAssetMenu(fileName = "RepairKitTalentData", menuName = "Data/Talent/RepairKitTalentData")]
    public class RepairKitTalentData : BaseTalentData
    {
        [Tooltip("Фиксированное влияние в %")]
        public float FixedRepairKitModifier;
        [Tooltip("Влияние за уровень в %")]
        public float RepairKitModifier;
    }
}
