using Leopotam.Ecs;

namespace Systems
{
    public class DamageSystem : AttackSystem, IEcsRunSystem
    {
        private EcsFilter<AttackComponent> _attacksFilter;

        public void Run()
        {
            foreach (var i in _attacksFilter)
            {
                var attack = _attacksFilter.Get1(i).Attacking;

                switch (attack)
                {
                    case Attacking.Player:
                        
                        break;
                    case Attacking.Enemy:

                        break;
                }
            }
        }
    }
}
