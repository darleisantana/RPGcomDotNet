namespace RPG.src.Entities
{
    public abstract class Hero
    {
        public Hero(String Name, int Level, String HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;  
        }

        public Hero()
        {
            
        }

        public String Name = "";

        public int Level;

        public string HeroType = "";

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada";
        }
    }
}