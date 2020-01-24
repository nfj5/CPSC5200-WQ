namespace restapi.Models
{
    public class InvalidStateError
    {
        public int ErrorCode { get => 100; }

        public string Message { get => "Transition not valid for current state"; }
    }

    public class EmptyTimecardError
    {
        public int ErrorCode { get => 101; }

        public string Message { get => "Unable to submit timecard with no lines"; }
    }

    public class MissingTransitionError
    {
        public int ErrorCode { get => 102; }

        public string Message { get => "No state transition of requested type present in timecard"; }
    }
    
    public class IllegalApprovalError
    {
    		public int ErrorCode { get => 103; }
    		
    		public string Message { get => "Timecard approval cannot be completed by the Employee listed on the timecard."; }
    }
    
    public class InconsistentTimecardError
    {
    		public int ErrorCode { get => 104; }
    		
    		public string Message { get => "Timecard Employee is not consistent."; }
    }
    
    public class InvalidLineUpdateError
    {
    		public int ErrorCode { get => 105; }
    		
    		public string Message { get => "Timecard DocumentLine does not exist to update."; }
    }
}