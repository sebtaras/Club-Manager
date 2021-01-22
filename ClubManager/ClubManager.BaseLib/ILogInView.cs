namespace ClubManager.BaseLib
{
    public interface ILogInView
    {
        void ShowViewModaless(IMainController inController);
        void HideForm();
        string Email { get; }
        string Password { get; }

    }
}