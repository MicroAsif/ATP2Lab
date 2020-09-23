using System;
using DoctorConsult.Core.Entity.Model;
using DoctorConsult.Core.Service.Interfaces;
using DoctorConsult.Infrustracture.Service;
using Unity;

namespace DoctorConsult.Web
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();


            container.RegisterType<IMedicineService, MedicineService>();
            container.RegisterType<ILocationService, LocationService>();
            container.RegisterType<ISpecialityService, SpecialityService>();

            container.RegisterType<IAdminProfileService,AdminService>();
            container.RegisterType<ICampaignService, CampaignService>();
            container.RegisterType<IDoctorProfileService, DoctorService>();

            container.RegisterType<IMedicineForPrescriptionService, MedicineForPrescriptionService>();
            container.RegisterType<IMedicineService, MedicineService>();
            container.RegisterType<IMedicalTestService, MedicalTestService>();

            container.RegisterType<IPatientsConsultService, PatientsConsultService>();
            container.RegisterType<IPatientProfileService, PatientService>();
            container.RegisterType<IPrescriptionService, PrescriptionService>();

            container.RegisterType<IPatientConsultSingleService, PatientConsultSingleService>();
            container.RegisterType<IPatientsProblemPageForDoctorService, PatientsProblemService>();

            container.RegisterType<IUserService, UserService>();


        }
    }
}