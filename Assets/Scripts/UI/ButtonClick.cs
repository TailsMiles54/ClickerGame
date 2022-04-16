using System;
using System.Collections;
using System.Collections.Generic;
using Leopotam.Ecs;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UI
{
    public class ButtonClick : MonoBehaviour
    {
        private EcsWorld _world;
        public ClickEvent ClickEvent = new ClickEvent();
        public ClickTypeEvent ClickTypeEvent = ClickTypeEvent.AttackClick;

        public void OnClick()
        {
            ClickEvent?.Invoke(ClickTypeEvent);
        }
    }

    public class ClickEvent : UnityEvent<ClickTypeEvent>
    {
    
    }

    public struct ClickRequest
    {
        public ClickTypeEvent ClickType;
    }
}