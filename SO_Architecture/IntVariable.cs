using UnityEngine;

namespace FeTo.SOArchitecture
{
    [CreateAssetMenu(fileName = "IntVariable", menuName = "FeTo/SO_Architecture/IntVariable")]
    public class IntVariable : ScriptableVariable<int>
    {
        public override void ApplyChange(int amount) {
            value += amount;
        }

        public override void ApplyChange(ScriptableVariable<int> amount) {
            value += amount.GetValue();
        }
    }
}
