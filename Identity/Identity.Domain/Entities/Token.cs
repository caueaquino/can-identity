using System;

namespace Identity.Domain.Entities
{
    public class Token
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }

        public Token()
        {
            this.AccessToken = "CAN_ACCESS_TOKEN";
            this.RefreshToken = "CAN_REFRESH_TOKEN";
            this.ExpirationDate = new DateTimeOffset();
        }

    }
}
