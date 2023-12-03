using AutoMapper;

public class CreateUserMapper : Profile
{
    public CreateUserMapper()
    {
        CreateMap<CreateSupplierRequest, Supplier>();
        CreateMap<Supplier, CreateSupplierResponse>();
    }
}
