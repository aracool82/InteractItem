using UnityEngine;

namespace _Project14_15.Scripts
{
    public class SpeedBoost : Item
    {
        [SerializeField] private float _speed;
        
        public override void Use(Character character)
        {
            character.AddSpeed(_speed);
            StartEffect(character.transform.position);
            DesroyItem();
        }
    }
}