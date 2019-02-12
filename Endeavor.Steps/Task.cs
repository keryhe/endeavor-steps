using System;
using System.Collections.Generic;
using System.Text;

namespace Endeavor.Steps
{
    public class TaskRequest
    {
        public long TaskId;
        public long StepTaskId;
        public StatusType Status;
    }

    public class TaskResponse
    {
        public StatusType Status;
        public string Output;
    }

    public enum StatusType
    {
        Ready = 1,
        Processing,
        Waiting,
        Complete,
        Error
    }
}
