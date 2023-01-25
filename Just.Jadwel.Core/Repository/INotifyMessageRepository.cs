using Just.Jadwel.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Just.Jadwel.Core.Repository
{
    public interface INotifyMessageRepository
    {
        public bool InsertNotifyMessage(NotifyMessage notifyMessage);
        public List<NotifyMessage> GetNotifyMessage();
        public bool UpdateNotifyMessage(NotifyMessage notifyMessage);
        public bool DeleteNotifyMessage(int id);
        public NotifyMessage GetNotifyMessage(int id);
    }
}
