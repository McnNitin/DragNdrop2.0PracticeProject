namespace DragNdrop2._0.Models
{
    public class JobModel
    {
        public int Id { get; set; }
        public JobStatuses Status { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
    }

    public enum JobStatuses
    {
        //Todo,
        //Started,
        //InProgress,
        //Completed
        //Done
        
        TODO,
        INPROGRESS,
        COMPLETED,
        DONE


    }
}
