using UnityEngine;
using UnityEngine.Serialization;

namespace _Project14_15.Scripts
{
    public class HealthBoost : Item
    {
        [SerializeField] private float _health;
        
        public override void Use(Character character)
        {
            character.AddHealth(_health);
            StartEffect(character.transform.position);
            DesroyItem();
        }
    }
}