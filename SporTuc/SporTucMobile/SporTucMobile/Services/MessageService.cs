using System.Threading.Tasks;
using SporTucMobile.Interfaces;

namespace SporTucMobile.Services
{
    public class MessageService : IMessage
    {
        public async Task MessageShowAsync(string title, string message)
        {
            await App.Current.MainPage.DisplayAlert(title, message, "Ok");
        }

        public async Task<bool> QuestionShowAsync(string title, string message)
        {
            return await App.Current.MainPage.DisplayAlert(title, message, "Aceptar", "Cancelar");
        }

        public MessageService()
        {

        }
    }
}
