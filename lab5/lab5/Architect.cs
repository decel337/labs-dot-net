using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace lab5
{
    abstract class Mediator
    {
        public abstract void ToLand(Colleague colleague);
        public abstract void ToTerminal(Colleague colleague);
        public abstract void ToSky(Colleague colleague);
        public abstract void Send(string msg, Colleague colleague);
    }
    abstract class Colleague
    {
        protected Mediator mediator;
 
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
 
        public virtual void ToLand()
        {
            mediator.ToLand(this);
        }
        
        public virtual void ToTerminal()
        {
            mediator.ToTerminal(this);
        }
        
        public virtual void ToSky()
        {
            mediator.ToSky(this);
        }
        
        public virtual void Send(string message)
        {
            mediator.Send(message, this);
        }
        public abstract void Notify(string message);
    }
    class Plain : Colleague
    {
        public string Name { get; set; }
        public Airport Airport { get; set; }
        public Landd? land { get; set; }
        public bool isTerminal { get; set; }

        public Plain(Mediator mediator, string name)
            : base(mediator)
        {
            Name = name;
        }
 
        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение самолету: " + message);
        }
    }
    class Airport : Colleague
    {
        
        public Terminal Terminal { get; set; }
        public List<Landd> Lands { get; set; }
        public string Name { get; set; }

        public Airport(Mediator mediator, Terminal terminal, List<Landd> lands, string name)
            : base(mediator)
        {
            Terminal = terminal;
            Lands = lands;
            Name = name;
        }
 
        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение аеропорту: " + message);
        }

        public Landd CheckLands()
        {
            Landd land = Lands.FirstOrDefault(l => l.Free);
            if (land != null)
            {
                land.Free = false;
            }
            return land;
        }
        
        public bool CheckTerminal()
        {
            if (Terminal.Free)
            {
                Terminal.Free = false;
                return true;
            }
            return false;
        }

        public void Free(Plain plain)
        {
            if (this == plain.Airport)
            {
                if (plain.land != null)
                {
                    Lands[plain.land.Number - 1].Free = true;
                    plain.land = null;
                }

                plain.isTerminal = false;
                Terminal.Free = true;
            }
        }
    }
    

    class Terminal
    {
        public bool Free { get; set; }

        public Terminal()
        {
            Free = true;
        }
    }
    
    class Landd
    {
        public bool Free { get; set; }
        public int Number { get; set; }

        public Landd(int number)
        {
            Free = true;
            Number = number;
        }
    }
 
    class Dispetcher : Mediator
    {
        public Colleague Plain { get; set; }

        public Colleague Airport { get; set; }
        public override void ToLand(Colleague colleague)
        {
            if (Plain == colleague)
            {
                Airport.Notify($"Хочу приземлиться в аеропорту {((Airport)Airport).Name}, на какую платформу?");
                Landd? land = ((Airport) Airport).CheckLands();
                if (land != null)
                {
                    ((Plain) Plain).land = land;
                    ((Plain) Plain).Airport = (Airport)Airport;
                    Plain.Notify($"Отправляйтесь на платформу {land.Number}");
                }
                else
                {
                    Plain.Notify("Все платформы заняты. Дождитесь или следуйте в другой аеропорт");
                }
            }
        }
        
        
        public override void ToTerminal(Colleague colleague)
        {
            if (Plain == colleague)
            {
                Airport.Notify($"Хочу подъехать к терминалу в {((Airport)Airport).Name}, забрать людей. Он свободен?");
                bool flag = ((Airport) Airport).CheckTerminal();
                ((Plain) Plain).isTerminal = flag;
                
                if (flag)
                {
                    Plain.Notify("Отправляйтесь на терминал");
                }
                else
                {
                    Plain.Notify("Терминал занят, ожидайте на платформе");
                }
            }
        }
        
        public override void ToSky(Colleague colleague)
        {
            Airport.Notify($"Улетаю из аеропорта {((Airport)Airport).Name}");
            ((Airport)Airport).Free((Plain)Plain);
        }

        public override void Send(string msg, Colleague colleague)
        {
            if (colleague == Airport)
            {
                Plain.Notify(msg);
            }
            else
            {
                Airport.Notify(msg);
            }
        }
    }
}