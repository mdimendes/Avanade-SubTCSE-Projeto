namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public class EmployeeRole
    {
        public string id { get; set; }

        public string RoleName { get; set; }

        public EmployeeRole(string id, string roleName)
        {
            this.id = id;
            RoleName = roleName;
        }

        public EmployeeRole(string roleName)
        {
            RoleName = roleName;
        }
    }
}
