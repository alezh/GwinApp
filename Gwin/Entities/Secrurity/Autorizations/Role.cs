﻿using GApp.GwinApp.Attributes;
using GApp.GwinApp.Entities.Application;
using GApp.GwinApp.Entities.MultiLanguage;
using GApp.GwinApp.Entities.Secrurity.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GApp.GwinApp.Entities.Secrurity.Autorizations
{
    /// <summary>
    /// This Eity is Used by Test Project to Teste : 
    /// BaseBAO
    /// </summary>
    [GwinEntity(DisplayMember = "Name",Localizable =true)]
    [Menu(Group = nameof(MenuItemApplication.ParentsMenuItem.Root))]
    public class Role : BaseEntity
    {

        public enum Roles
        {
            Guest,
            User,
            Admin,
            Root
        }

        public Role()
        {
            this.Name = new LocalizedString();
            this.Description = new LocalizedString();
        }

        [EntryForm(Ordre = 1)]
        [DataGrid]
        public string Reference { get; set; }



        [EntryForm(Ordre = 1)]
        [Filter]
        [DataGrid]
        [Required]
        public LocalizedString Name { set; get; }

        [EntryForm(Ordre = 2,MultiLine = true)]
        [Filter]
        [DataGrid]
        public LocalizedString Description { set; get; }

        /// <summary>
        /// indicate that the role is hidden
        /// </summary>
        public bool Hidden { set; get; }

        [DataGrid]
        [EntryForm]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToMany_Selection)]
        public virtual List<Authorization> Authorizations { set; get; }

        public  List<MenuItemApplication> MenuItemApplications { set; get; }
        public List<User> Users { set; get; }

    }
}
