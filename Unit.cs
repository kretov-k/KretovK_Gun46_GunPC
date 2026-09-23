using System;
using System.Collections.Generic;
using System.Text;

namespace KretovK_Gun42_GunPC
{
    public class Unit
    {
        private float _health;
        private string Name { get; }
        public float  Health => _health;
        public int Damage { get; }
        public float Armor { get; }
        public Unit() : this("Unknown Unit")
        {
        }
        public Unit(string name)
        {
            Name = name;
            Damage = 5;
            Armor = 0.6f;
        }
        public float GetRealHealth()
        {
            return _health * (1f + Armor);
        }
        public bool SetDamage(float value)
        {
            _health = Health - value * Armor;
            return Health <= 0f;
        }
    }
}
