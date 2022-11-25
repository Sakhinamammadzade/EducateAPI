using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.Mongo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load (ContainerBuilder builder)
        {
            builder.RegisterType<AuthManager>().As<IAuthManager>();
            builder.RegisterType<UserManager>().As<IUserManager>();
            builder.RegisterType<UserDal>().As<IUserDal>();
            builder.RegisterType<CourseManager>().As<ICourseServices>();
            builder.RegisterType<CourseDal>().As<ICourseDal>();
            builder.RegisterType<BlogDal>().As<IBlogDal>();
            builder.RegisterType<BlogManager>().As<IBlogManager>();
            builder.RegisterType<ChooseDal>().As<IChooseDal>();
            builder.RegisterType<ChooseManager>().As<IChooseManager>();
            builder.RegisterType<CourseCategoyDal>().As<ICourseCategoryDal>();
            builder.RegisterType<CourseCategoryManager>().As<ICourseCategoryManager>();
            builder.RegisterType<AboutDal>().As<IAboutDal>();
            builder.RegisterType<AboutManager>().As<IAboutManager>();


        }

    }
}
