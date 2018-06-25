using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace CMCVirtual.IoC
{
    public static class CastleWindsorInjector
    {
        private static IWindsorContainer Container = new WindsorContainer();

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        public static void Register()
        {
            Container.Register(Classes.FromAssemblyInThisApplication()
                                      .IncludeNonPublicTypes()
                                      .BasedOn<Core.Contracts.IController>()
                                      .WithService.FromInterface());

            Container.Register(Classes.FromAssemblyInThisApplication()
                                      .IncludeNonPublicTypes()
                                      .BasedOn<Core.Contracts.IControllerAsync>()
                                      .WithService.FromInterface());

            Container.Register(Classes.FromAssemblyInThisApplication()
                                      .IncludeNonPublicTypes()
                                      .BasedOn<BO.Contracts.IHostBO>()
                                      .WithService.FromInterface());

            Container.Register(Classes.FromAssemblyInThisApplication()
                                      .IncludeNonPublicTypes()
                                      .BasedOn<BO.Contracts.IStationBO>()
                                      .WithService.FromInterface());

            Container.Register(Classes.FromAssemblyInThisApplication()
                                      .IncludeNonPublicTypes()
                                      .BasedOn<BO.Contracts.IStepBO>()
                                      .WithService.FromInterface());

            Container.Register(Classes.FromAssemblyInThisApplication()
                                      .IncludeNonPublicTypes()
                                      .BasedOn<BO.Contracts.IProfileBO>()
                                      .WithService.FromInterface());

            Container.Register(Classes.FromAssemblyInThisApplication()
                                      .IncludeNonPublicTypes()
                                      .BasedOn<DAO.Contracts.IHostDAO>()
                                      .WithService.FromInterface());

            Container.Register(Classes.FromAssemblyInThisApplication()
                                      .IncludeNonPublicTypes()
                                      .BasedOn<DAO.Contracts.IStationDAO>()
                                      .WithService.FromInterface());

            Container.Register(Classes.FromAssemblyInThisApplication()
                                      .IncludeNonPublicTypes()
                                      .BasedOn<DAO.Contracts.IStepDAO>()
                                      .WithService.FromInterface());

            Container.Register(Classes.FromAssemblyInThisApplication()
                                      .IncludeNonPublicTypes()
                                      .BasedOn<DAO.Contracts.IProcedureDAO>()
                                      .WithService.FromInterface());

            Container.Register(Classes.FromAssemblyInThisApplication()
                                      .IncludeNonPublicTypes()
                                      .BasedOn<DAO.Contracts.IProfileDAO>()
                                      .WithService.FromInterface());

            Container.Register(Classes.FromAssemblyInThisApplication()
                                      .IncludeNonPublicTypes()
                                      .BasedOn<DAO.Contracts.IProfileDatabaseDAO>()
                                      .WithService.FromInterface());

            Container.Register(Classes.FromAssemblyInThisApplication()
                          .IncludeNonPublicTypes()
                          .BasedOn<DAO.Contracts.IProfileFileDAO>()
                          .WithService.FromInterface());
        }
    }
}