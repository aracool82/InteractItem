using UnityEngine;

namespace _Project14_15.Scripts
{
    public class SpeedBoost : Item
    {
        [Range(1f,4f)]
        [SerializeField] private float _speed;
        
        public override void Use(GameObject character)
        {
            //character.AddSpeed(_speed);
            StartEffect(character.transform.position);
            Desroy();
        }
    }
}