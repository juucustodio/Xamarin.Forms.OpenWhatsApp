using System;

namespace Xamarin.Forms.OpenWhatsApp
{
    public class Chat
    {
        string PhoneNumber;
        string Message;

        public Chat(string _phoneNumber, string _message = null)
        {
            PhoneNumber = _phoneNumber;
            Message = _message;
        }

        public void Open()
        {
            try
            {
                var uriString = "whatsapp://send?phone=" + PhoneNumber;

                if (!String.IsNullOrWhiteSpace(Message))
                    uriString += "&text=" + Message;

                Device.OpenUri(new Uri(uriString));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
