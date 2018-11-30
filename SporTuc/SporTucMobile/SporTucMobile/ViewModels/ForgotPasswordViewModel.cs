using GalaSoft.MvvmLight.Command;
using SporTucMobile.Interfaces;
using SporTucMobile.Models;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace SporTucMobile.ViewModels
{
    public class ForgotPasswordViewModel : BaseViewModel
    {
        #region Attributes
        public string _email { get; set; }
        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                if (value != _email)
                {
                    _email = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Properties
        public ICommand CommandClose { get { return new RelayCommand(Close); } }

        public ICommand CommandForgotPassword { get { return new RelayCommand(ForgotPassword); } }

        private readonly IMessage _message;
        #endregion

        #region Builders
        public ForgotPasswordViewModel()
        {
            _message = DependencyService.Get<IMessage>();
            InitialData();
        }
        #endregion

        #region Commands
        void Close()
        {
            Rg.Plugins.Popup.Services.PopupNavigation.Instance.PopAsync();
        }

        async void ForgotPassword()
        {
            try
            {
                if(!string.IsNullOrWhiteSpace(_email))
                {
                    var person = await App.SqlConnection.GetAsync<Person>(x => x.Email == _email);

                    if (person == null)
                    {
                        _email = string.Empty;
                        throw new Exception("No existe ninguna cuenta con ese E-Mail. Intente de nuevo");
                    }

                    await this._message.MessageShowAsync("Felicidades!", "Se envio la contraseña al E-Mail seleccionado.");
                    Close();
                }
                else
                {
                    throw new Exception("Por favor ingrese un E-Mail.");
                }

            }
            catch (Exception ex)
            {
                await this._message.MessageShowAsync("Mensaje", ex.Message);
            }
        }
        #endregion

        #region Methods
        void InitialData()
        {
            _email = string.Empty;
        }
        #endregion
    }
}
