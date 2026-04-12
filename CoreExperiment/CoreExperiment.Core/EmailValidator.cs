using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CoreExperiment.Core
{
    internal class EmailValidator
    {
        private readonly ICustomLogger _logger;

        public EmailValidator(ICustomLogger logger)
        {
            _logger = logger;
        }

        public bool IsEmail(string text)
        {
            _logger.LogInfo("IsEmail");

            try
            {
                MailAddress m = new MailAddress(text);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
