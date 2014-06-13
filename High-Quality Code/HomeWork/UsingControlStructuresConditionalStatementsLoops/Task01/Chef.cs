namespace Eatery
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            this.Peel(potato);
			this.Cut(potato);
									
			Carrot carrot = this.GetCarrot();
			this.Peel(carrot);
			this.Cut(carrot);
			            
			Bowl bowl = this.GetBowl();
			bowl.Add(potato);
			bowl.Add(carrot);
        }

        private Bowl GetBowl()
        {
            // Code
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            // Code
            return new Carrot();
        }
        
        private Potato GetPotato()
        {
            // Code
            return new Potato();
        }
        
        private void Cut(Vegetable vegetableToCut)
        {
            // Code
            vegetableToCut.Cut();
        }

        private void Peel(Vegetable vegetableToPeel)
        {
            // Code
            vegetableToPeel.Peel();
        }
    }
}