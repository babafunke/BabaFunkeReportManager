using System.Collections.Generic;

namespace BabaFunkeReportManager.Data
{
    public static class MockData
    {

        /// <summary>
        /// A mock of email recipients.
        /// In my real world application, these are contributors to my app I send reports to. It also includes myself
        /// </summary>
        /// <returns></returns>
        public static List<string> GetEmailRecipients()
        {
            return new List<string>
            {
                "recipient1@example.com",
                "recipient2@example.com",
                "recipient3@example.com"
            };
        }
    }
}
