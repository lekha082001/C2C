namespace FirstApi.Models
{
    public class Accessories
    {
        private IAccessories _accessories;
        public Accessories(IAccessories a)
        {
            _accessories = a;
        }
    }
    public interface IAccessories { }
    public class Speakers : IAccessories { }
    public class Screen : IAccessories { }
   public class Car {
        private IEngine _engine;
        public Car(IEngine e)
        {
            _engine = e; 
        }
    }
    public interface IEngine { }
    public class SuzukiEngine : IEngine { }
    public class ToyotaEngine : IEngine { }
}
