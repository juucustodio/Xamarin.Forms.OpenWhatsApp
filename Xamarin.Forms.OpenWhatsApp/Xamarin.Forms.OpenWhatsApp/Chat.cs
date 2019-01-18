using System;

namespace Xamarin.Forms.OpenWhatsApp
{
    public class Chat
    {
        public static void Open(string phoneNumber, string message = null)
        {
            try
            {
                var uriString = "whatsapp://send?phone=" + phoneNumber;

                if (!string.IsNullOrWhiteSpace(message))
                    uriString += "&text=" + message;

                Device.OpenUri(new Uri(uriString));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
