using System.Windows.Input;

namespace SporTucMobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region attributes
        private string _nameUser { get; set; }
        public string NameUser
        {
            get
            {
                return this._nameUser;
            }
            set
            {
                if(value != _nameUser)
                {
                    _nameUser = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _password { get; set; }
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                if (value != _password)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Properties

        #endregion

        #region Builder
        public LoginViewModel()
        {
            InitialData();
        }
        #endregion

        #region Command

        #endregion

        #region Methods
        private void InitialData()
        {
            _nameUser = string.Empty;
            _password = string.Empty;
        }
        #endregion
    }
}
