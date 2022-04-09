namespace RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(String Name, int Level, String HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType; 
        }

        public override string Attack()
        {
            return this.Name + " Atacou com o Rasengan";
        }
    }
}