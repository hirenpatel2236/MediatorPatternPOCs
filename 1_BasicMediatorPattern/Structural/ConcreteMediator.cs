﻿namespace BasicMediatorPattern.Structural
{
    public class ConcreteMediator : Mediator
    {
        public Colleague1 colleague1 { get; set; }
        public Colleague2 colleague2 { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == this.colleague1)
            {
                this.colleague2.HandleNotification(message);
            }
            else
            {
                this.colleague1.HandleNotification(message);
            }
        }
    }
}
