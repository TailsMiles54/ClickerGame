using Leopotam.Ecs;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Events
{
    public class EventCatcher : IEcsInitSystem, IEcsDestroySystem
    {
        private GameObject ButtonTest;
        private EcsWorld _world;
        
        private void CatchClickEvent(ClickTypeEvent clickTypeEvent)
        {
            _world.NewEntity().Replace(new ClickRequest() {ClickType = clickTypeEvent});
        }
        
        public void Init()
        {
            ButtonTest.GetComponent<ButtonClick>().ClickEvent.AddListener(CatchClickEvent);
        }

        public void Destroy()
        {
            ButtonTest.GetComponent<ButtonClick>().ClickEvent.RemoveListener(CatchClickEvent);
        }
    }
}
