using BasicMediatorPattern.Structural;

var mediator = new ConcreteMediator();
var c1 = new Colleague1(mediator);
var c2 = new Colleague2(mediator);
mediator.colleague1 = c1;
mediator.colleague2 = c2;

c1.Send("Hello, Message from c1");
c2.Send("Hello, Message from c2");