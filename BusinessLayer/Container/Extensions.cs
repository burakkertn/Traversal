using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.enti;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFrameWork;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)

        { 
        //---------------------------------------Program.cs tarafında düzenleme (5.0 da StarUp.cs tarafında-------------------------------------------------------------------
             

                services.AddScoped<IAbout2Service, About2Manager>();
                services.AddScoped<IAbout2Dal, EnAbout2Dal>();
//-------------------------------------------------------------------------------------------------------------------------------------------
                services.AddScoped<ITeamService, TeamManager>();
                services.AddScoped<ITeamDal, EnTeamDal>();
            //-------------------------------------------------------------------------------------------------------------------------------------------
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAboutDal, EnAboutDal>();
            //-------------------------------------------------------------------------------------------------------------------------------------------
            services.AddScoped<IDesService, DesManager>();
                services.AddScoped<IDesDal, EnDesDal>();
//-------------------------------------------------------------------------------------------------------------------------------------------
                services.AddScoped<IFeature2Service, Feature2Manager>();
                services.AddScoped<IFeature2Dal, EnFeature2Dal>();
            //-------------------------------------------------------------------------------------------------------------------------------------------
                 services.AddScoped<IFeatureService, FeatureManager>();
                services.AddScoped<IFeatureDal, EnFeatureDal>();
            //-------------------------------------------------------------------------------------------------------------------------------------------
                services.AddScoped<IContactService, ContactManager>();
                services.AddScoped<IContactDal, EnContactDal>();
//-------------------------------------------------------------------------------------------------------------------------------------------
                services.AddScoped<INewsLetterService, NewsLetterManager>();
                services.AddScoped<INewsLetterDal, EnNewsLetterDal>();
//-------------------------------------------------------------------------------------------------------------------------------------------
                services.AddScoped<IAboutService, AboutManager>();
                services.AddScoped<IAboutDal, EnAboutDal>();
//-------------------------------------------------------------------------------------------------------------------------------------------
                services.AddScoped<ISubAboutService, SubAboutManager>();
                services.AddScoped<ISubAboutDal, EnSubAboutDal>();
            //-------------------------------------------------------------------------------------------------------------------------------------------
        
            services.AddScoped<ITestimonialService, TestimonialManager>();
                services.AddScoped<ITestimonialDal, EnTestimonialDal>();
            //-------------------------------------------------------------------------------------------------------------------------------------------
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EnCommentDal>();
            //-------------------------------------------------------------------------------------------------------------------------------------------
            services.AddScoped<IRezervasyonService, RezervasyonManager>();
            services.AddScoped<IRezervasyonDal, EnRezervasyonDal>();
            //-------------------------------------------------------------------------------------------------------------------------------------------
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EnAppUserDal>();
            //-------------------------------------------------------------------------------------------------------------------------------------------
            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDal, EnContactUsDal>();
            //-------------------------------------------------------------------------------------------------------------------------------------------
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EnAnnouncementDal>();

            services.AddScoped<IExcelService, ExcelManager>();

            services.AddScoped<IPdfService, PdfManager>();
        }
        public static void CustomerValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementValidator>();
        }
    }
}