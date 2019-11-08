using System;
using System.Collections.Generic;

namespace Timesheets
{
    //commentsgit 
    public interface ITimeEntryDataGateway
    {
        TimeEntryRecord Create(long projectId, long userId, DateTime date, int hours);

        List<TimeEntryRecord> FindBy(long userId);    }
}