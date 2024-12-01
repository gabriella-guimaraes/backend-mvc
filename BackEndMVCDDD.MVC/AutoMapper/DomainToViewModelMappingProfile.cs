using AutoMapper;
using BackEndMVCDDD.Domain.Entities;
using BackEndMVCDDD.MVC.ViewModels;

namespace BackEndMVCDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Client, ClientViewModel>();
            CreateMap<Product, ProductViewModel>();
        }
        //public override string ProfileName
        //{
        //    get { return "ViewModelToDomainMappings"; }
        //}

        //protected override void Configure()
        //{
        //    var configure = new MapperConfiguration(config =>
        //    {
        //        config.CreateMap<ClientViewModel, Client>();
        //        config.CreateMap<ProductViewModel, Product>();
        //    });
        //}
    }
}

//O AutoMapper mudou sua API nas versões mais recentes, e o método Configure foi removido. 
//Agora, o mapeamento é configurado diretamente no construtor da classe Profile.