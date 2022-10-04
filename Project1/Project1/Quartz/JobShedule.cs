namespace Project1.Quartz
{
    public class JobShedule
    {
        public JobShedule(Type sheduteType, string expression)
        {
            SheduteType = sheduteType;
            Expression = expression;
        }

        public Type SheduteType { get; set; }
        public string Expression { get; set; }
    }
}
