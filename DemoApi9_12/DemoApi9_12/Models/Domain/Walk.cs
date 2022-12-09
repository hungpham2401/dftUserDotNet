namespace DemoApi9_12.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Guid GegionID { get; set; }
        public Guid WalkDiffcultyId { get; set; }

        //Navigation Properties
        public Region Region { get; set; }

        public Walkdiffculty Walkdiffculty { get; set; }
    }
}