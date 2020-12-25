namespace Interfaces
{
    public interface IHq
    {
        void Attach(ICar car);
        void Detach(ICar car);
        void NotifySoftwareUpdate();
    }
}
