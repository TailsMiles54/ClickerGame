using Leopotam.Ecs;
using UI;

namespace Systems
{
    public class AttackSystem : IEcsRunSystem
    {
        private EcsWorld _world;
        private EcsFilter<ClickRequest> _clickRequestsFilter;
    
        public void Run()
        {
            foreach (var i in _clickRequestsFilter)
            {
                var clickType = _clickRequestsFilter.Get1(i).ClickType;
            
                if (clickType == ClickTypeEvent.AttackClick)
                {
                    _world.NewEntity().Replace(new AttackComponent() {Attacking = Attacking.Player});
                }
            }
        }
    }
}
