using UnityEngine;
using UnityEngine.Serialization;

namespace _Project14_15.Scripts
{
    public class HealthBoost : Item
    {
        [Range(1f, 100f)]
        [SerializeField] private float _health;
        
        public override void Use(GameObject character)
        {
           //character.AddHealth(_health);
            StartEffect(character.transform.position);
            Desroy();
        }
    }
}