using Autofac;
using RestApiModelDDD.Application.Entitys;
using RestApiModelDDD.Application.Interface;
using RestApiModelDDD.Application.Mapper;
using RestApiModelDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModelDDD.Domain.Core.Interfaces.Services.Interface;
using RestApiModelDDD.Domain.Services.Service;
using RestApiModelDDD.Infrastruture.Data.Repositorys;

namespace RestApiModelDDD.Infrastruture.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<AplicationServiceCliente>().As<IAplicationServiceCliente>();
            builder.RegisterType<AplicationServiceProduto>().As<IAplicationServiceProduto>();
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion IOC
        }
    }
}