namespace Models.DTOs;

public class CompanyDto
{
    public int Id { get; set; } //The DTO also has an Id, because the Ids in the databases should be the same
    public string Name { get; set; } = null!;
    public AddressDto Address { get; set; } = null!; 
    //Main reason, why we need this DTO --> the address ids diverge in the databases but that is ok
}