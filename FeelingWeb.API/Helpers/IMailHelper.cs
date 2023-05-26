
using FeelingWeb.Shared.Responses;

namespace FeelingWeb.API.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string toName, string toEmail, string subject, string body);
    }

}
