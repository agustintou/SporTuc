using System.Threading.Tasks;

namespace SporTucMobile.Interfaces
{
    public interface IMessage
    {
        Task MessageShowAsync(string title, string message);

        Task<bool> QuestionShowAsync(string title, string message);
    }
}
