using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlindDatingjk.Models;

namespace BlindDatingjk.ViewModels
{
    public class InboxViewModel
    {

        public IEnumerable<MailMessage> mailMessages;
        public IEnumerable<DatingProfile> fromProfiles;
    }
}
