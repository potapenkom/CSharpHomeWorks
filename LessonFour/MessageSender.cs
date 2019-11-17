using System;
using System.Collections.Generic;
using System.Text;

namespace LessonFour
{
    public delegate void WolfMessage();
    public class MessageSender
    {
        public event WolfMessage EventMessage;

        public void InvokeEvent()
        {
            EventMessage?.Invoke();
        }
    }
}
