namespace TorTee.BLL.Helpers
{
    public class EmailHelper
    {
        public static string CreateEmailBody(string content, string title = "Default Title")
        {
            var emailBody = $@"
            <!DOCTYPE html>
            <html>
            <head>
                <meta charset='UTF-8'>
                <title>{title}</title>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        margin: 0;
                        padding: 0;
                        background-color: #f4f4f4;
                    }}
                    .container {{
                        width: 80%;
                        margin: auto;
                        background-color: #fff;
                        padding: 20px;
                        border-radius: 10px;
                        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                    }}
                    .header {{
                        background-color: #4CAF50;
                        color: white;
                        padding: 10px 0;
                        text-align: center;
                        border-radius: 10px 10px 0 0;
                    }}
                    .footer {{
                        background-color: #4CAF50;
                        color: white;
                        padding: 10px 0;
                        text-align: center;
                        border-radius: 0 0 10px 10px;
                    }}
                    .content {{
                        padding: 20px;
                    }}
                </style>
            </head>
            <body>
                <div class='container'>
                    <div class='header'>
                        <h1>{title}</h1>
                    </div>
                    <div class='content'>
                        {content}
                    </div>
                    <div class='footer'>
                        <p>&copy; {DateTime.Now.Year} Tortee. All rights reserved.</p>
                    </div>
                </div>
            </body>
            </html>";

            return emailBody;
        }

        public static string GetRejectedEmailBody(string userName, string companyName)
        {
            return $@"Subject: Rejection of Job Application for [Position Title]

                        Dear {userName},

                        Thank you for your interest in the Mentor position at {companyName}. We appreciate the time and effort you invested in applying for this role.

                        After careful consideration, we regret to inform you that we have decided not to move forward with your application. 

                        While your qualifications are impressive, we have selected another candidate whose skills and experience align more closely with our current needs.

                        We sincerely appreciate your interest in joining our team and wish you the best in your job search. Please feel free to apply for other positions with us in the future.

                        Thank you once again for considering {companyName}. We value your interest and hope you find success in your career endeavors.

                        Best regards,

                        {companyName}";
        }
        public static string GetAcceptedEmailBody(string platformEmail, string account, string password)
        {
            return $@"Congratulations! 🎉 Your application has been accepted! We are thrilled to welcome you to become a mentor in our platform. 🤝

                    We provide you account to become a mentor in our platform:                    
                    Account: {account}
                    Password: {password}                    

                    After log in, please change your password. Make sure to choose a strong and secure password!

                    If you have any questions or need additional information, feel free to reach out to support team at {platformEmail}.

                    Once again, welcome aboard, and we look forward to working with you! 🌟

                    Best regards,";
        }

        public static string GetConfirmEmailBody(string link, string userName, string platformEmail)
        {
            return $@"Dear {userName},

                        Thank you for registering with our platform! We’re excited to have you join our community. To complete your account setup, please follow the steps below:

                        Verify Your Email Address: Click on the following link to verify your email address and activate your account: <a href='{link}'>here</a>
            
                        Explore Our Features: Once your account is activated, you can start exploring our platform. Discover exciting content, connect with other users, and enjoy our services.            If you did not register for an account, please ignore this email. Your privacy and security are important to us, and we will never share your information with third parties.

                        If you encounter any issues or need assistance, feel free to reach out to our support team at {platformEmail}.";
        }
    }

}
