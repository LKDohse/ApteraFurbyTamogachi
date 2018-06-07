namespace ApteraFurbyTamogachi
{
    public class Tamogachi
    {
        public int Health { get; set; }

        public string Feed() {
            Health++;
            return $"Furby Love Food! \nFurby's Health is now at {Health}";
        }

        public void Ignore() {
            Health--; 
        }

        public string GetHealth()
        {
            return $"Furby's health is: {Health}"; 
        }

        public string GetStatus() {
            if (Health > 10)
            {
                return "Furby is doing amazing!";
            }
            else if (Health <= 10 && Health >= 8)
            {
                return "Furby is feeling pre-tty good.";
            }
            else if (Health <= 7 && Health >= 5)
            {
                return "Furby is OK.";
            }
            else if (Health <= 4 && Health >= 2)
            {
                return "Furby has seen better days. ";
            }
            else if (Health == 1) {
                return "Please take care of Furby."; 
            }
            else {
                return "..."; 
            }
        }

        public void Kill()
        {
            Health = 0; 
        }
    }
}
