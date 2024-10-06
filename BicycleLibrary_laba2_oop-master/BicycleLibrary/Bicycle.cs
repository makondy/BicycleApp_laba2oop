namespace BicycleLibrary
{
    public class Bicycle
    {
        public string Brand { get; set; }          
        public string Model { get; set; }           
        public int Year { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }                     
        public string FrameMaterial { get; set; }   
        public int GearCount { get; set; }          

        
        public double Mileage { get; set; }         

       
        public double GetAverageSpeed(double distance, double time)
        {
            return time > 0 ? distance / time : 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Марка: {Brand}, Модель: {Model}, Рік: {Year}, Вага: {Weight} кг, Кількість швидкостей: {GearCount}, Пробіг: {Mileage} км");
        }
    }
}
