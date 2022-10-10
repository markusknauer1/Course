namespace Course.Entities
{
    public class Department
    {
        public string Name { get; set; } // nome do departamento
        
        public Department()
        {
        }
        public Department(string name)
        {
            Name = name;
        }
    }
}