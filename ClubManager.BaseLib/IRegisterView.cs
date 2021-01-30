namespace ClubManager.BaseLib
{
    public interface IRegisterView
    {
        void ShowViewModaless(IMainController inController);
        void HideForm();
        void HideAgeOption();
        void ShowAgeOption();
        string Email { get; }
        string Password { get; }
        string FirstName { get; }
        string LastName { get; }
        string Role { get; }
        string Age { get; }
    }
}