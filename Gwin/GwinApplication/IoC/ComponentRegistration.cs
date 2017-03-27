﻿using App.Gwin.Application.BAL;
using App.Gwin.DataModel.ModelInfo;
using App.Gwin.Entities;
using App.Gwin.Entities.ContactInformations;
using App.Gwin.Logging;
using App.Gwin.ModelData;
using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using System;

namespace App.Gwin.GwinApplication.IoC
{
    public class ComponentRegistration : IRegistration
    {
        public void Register(IKernelInternal kernel)
        {
           

            kernel.Register(
                Component.For<SecurityInterceptor>()
                    .ImplementedBy<SecurityInterceptor>());

            // Registrer All BLO Objects
            foreach (Type EntityType in new GwinEntitiesManager().GetAll_Entities_Type())
            {

                Type BLOEntity_Type = GwinBaseBLO<BaseEntity>.Detemine_Type_EntityBLO(EntityType, GwinApp.Instance.TypeBaseBLO);


                kernel.Register(
             Component.For(BLOEntity_Type).ImplementedBy(BLOEntity_Type)
                      .Interceptors(InterceptorReference.ForType<SecurityInterceptor>()).Anywhere);
            }

        }
    }
}
