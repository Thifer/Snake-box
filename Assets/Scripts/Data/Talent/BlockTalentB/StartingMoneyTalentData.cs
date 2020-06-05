using UnityEngine;

namespace Snake_box
{
    [CreateAssetMenu(fileName = "StartingMoneyTalentData", menuName = "Data/Talent/StartingMoneyTalentData")]
    public class StartingMoneyTalentData : BaseTalentData
    {
        [Tooltip("Влияние за уровень в %")]
        public float StartingMoneyModifier;
    }
}
