namespace RPG.src.Entities
{
    public class DarkWizard : Hero
    {
        public DarkWizard(String Name, int Level, String HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType; 
        }

         public override string Attack()
        {
            return this.Name + " Lançou Magia Necrofila";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia efetiva com Bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou Magia pouco efetiva com Bonus de " + Bonus;
            }
        }
    }
}