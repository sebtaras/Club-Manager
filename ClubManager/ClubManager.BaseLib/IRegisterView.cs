namespace ClubManager.BaseLib
{
    public interface IRegisterView
    {
        void ShowViewModaless(IMainController inController);
        void HideForm();
        string Email { get; }
        string Password { get; }
        string FirstName { get; }
        string LastName { get; }
        string Role { get; }
    }
}