using UnityEngine;

namespace Snake_box
{
    [CreateAssetMenu(fileName = "StartingMoneyTalent", menuName = "Data/Talent/StartingMoneyTalent")]
    public class StartingMoneyTalent : BaseTalentData
    {
        [Tooltip("Влияние за уровень в %")]
        public float StartingMoneyModifier;
    }
}
