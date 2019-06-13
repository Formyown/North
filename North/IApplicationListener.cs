using System;
namespace North
{
    public interface IApplicationListener<ET>
    {
        bool OnEvent(ET eventData);
    }
}
