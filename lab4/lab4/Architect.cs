namespace lab4
{
    abstract class Bouquet
        {
            public Bouquet(string n)
            {
                this.Name = n;
            }
            public string Name {get; protected set;}
            public abstract int GetCost();
        }
 
        class RoseBouquet : Bouquet
        {
            public RoseBouquet() : base("Rose bouqet")
            { }
            public override int GetCost()
            {
                return 100;
            }
        }
        class TulipBouquet : Bouquet
        {
            public TulipBouquet()
                : base("Tulip bouquet")
            { }
            public override int GetCost()
            {
                return 80;
            }
        }
        
        class LilyBouquet : Bouquet
        {
            public LilyBouquet()
                : base("Lily Bouquet")
            { }
            public override int GetCost()
            {
                return 90;
            }
        }
 
        abstract class BouquetDecorator : Bouquet
        {
            protected Bouquet bouquet;
            public BouquetDecorator(string n, Bouquet bouquet) : base(n)
            {
                this.bouquet = bouquet;
            }
        }
 
        class RibbonBouquet : BouquetDecorator
        {
            public RibbonBouquet(Bouquet b) 
                : base(b.Name + ", with ribbon", b)
            { }
 
            public override int GetCost()
            {
                return bouquet.GetCost() + 10;
            }
        }

        class PackageBouquet : BouquetDecorator
        {
            public PackageBouquet(Bouquet b)
                : base(b.Name + ", with package", b)
            {
            }

            public override int GetCost()
            {
                return bouquet.GetCost() + 5;
            }
        }
    }