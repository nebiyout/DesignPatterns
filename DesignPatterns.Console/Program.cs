using DesignPatterns.Behavioural.Iterator;
using DesignPatterns.Behavioural.Observer;
using DesignPatterns.Behavioural.Strategy;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter.ObjectAdapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Proxy;
using System;

namespace DesignPatterns.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("== Singleton ==");
            //singlton
            var obj = Singleton.GetSingleton();

            System.Console.WriteLine("== Factory ==");
            //factory 
            IShape shape = Factory.getShape("circle");

            if (shape != null)
                shape.Draw();

            System.Console.WriteLine("== Abstract Factory ==");
            //abstract factory
            IAbstractFactory abstractFactory = AbstractFactory.GetShapeFactory(true);
            IAbstractShape abstractShape = abstractFactory.getShape("square");
            if (abstractShape != null)
                abstractShape.Draw();



            //Composite
            System.Console.WriteLine("== Adapter ==");
            Client client = new Client(new Adapter(new Adaptee()));
            client.MakeRequest();

            //Composite
            System.Console.WriteLine("== Composite ==");
            //Creating Leaf Objects
            IComponent hardDisk = new Leaf("Hard Disk", 2000);
            IComponent ram = new Leaf("RAM", 3000);
            IComponent cpu = new Leaf("CPU", 2000);
            IComponent mouse = new Leaf("Mouse", 2000);
            IComponent keyboard = new Leaf("Keyboard", 2000);

            //Creating composite objects
            Composite motherBoard = new Composite("Peripherals");
            Composite cabinet = new Composite("Cabinet");
            Composite peripherals = new Composite("Peripherals");
            Composite computer = new Composite("Computer");

            //Creating tree structure
            //Ading CPU and RAM in Mother board
            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);

            //Ading mother board and hard disk in Cabinet
            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);

            //Ading mouse and keyborad in peripherals
            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);

            //Ading cabinet and peripherals in computer
            computer.AddComponent(cabinet);
            computer.AddComponent(peripherals);

            //To display the Price of Computer
            computer.DisplayPrice();
            System.Console.WriteLine();

            //To display the Price of Keyboard
            keyboard.DisplayPrice();
            System.Console.WriteLine();

            //To display the Price of Cabinet
            cabinet.DisplayPrice();


            System.Console.WriteLine("== Facade ==");
            Order order = new Order();
            order.PlaceOrder();

            System.Console.WriteLine("== Proxy ==");
            try
            {
                var secureNestProxy = new SecureNestProxy(new RealNest());
                secureNestProxy.Access("Stegosaurus");
                secureNestProxy.Access("TRex");
            }
            catch (Exception e)
            {
                System.Console.Write(e);
            }

            System.Console.WriteLine("== Bridge ==");
            var tv = new Tv();
            var remote = new RemoteControl(tv);
            remote.togglePower();

            var radio = new Radio();
            remote = new AdvancedRemoteControl(radio);
            remote.volumeUp();


            System.Console.WriteLine("== Strategy ==");
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.
            var context = new Context();

            System.Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            System.Console.WriteLine();

            System.Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();

            System.Console.WriteLine("== Observer ==");
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();




            System.Console.WriteLine("== Iterator ==");
            // The client code may or may not know about the Concrete Iterator
            // or Collection classes, depending on the level of indirection you
            // want to keep in your program.
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            System.Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
            {
                System.Console.WriteLine(element);
            }

            System.Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                System.Console.WriteLine(element);
            }



            System.Console.ReadKey();
        }
    }
}
