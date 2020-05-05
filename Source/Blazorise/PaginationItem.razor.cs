﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise
{
    public partial class PaginationItem : BaseComponent
    {
        #region Members

        private bool active;

        private bool disabled;

        #endregion

        #region Methods

        protected override void BuildClasses( ClassBuilder builder )
        {
            builder.Append( ClassProvider.PaginationItem() );
            builder.Append( ClassProvider.PaginationItemActive(), Active );
            builder.Append( ClassProvider.PaginationItemDisabled(), Disabled );

            base.BuildClasses( builder );
        }

        #endregion

        #region Properties

        /// <summary>
        /// Indicate the currently active page.
        /// </summary>
        [Parameter]
        public bool Active
        {
            get => active;
            set
            {
                active = value;

                DirtyClasses();
            }
        }

        /// <summary>
        /// Used for links that appear un-clickable.
        /// </summary>
        [Parameter]
        public bool Disabled
        {
            get => disabled;
            set
            {
                disabled = value;

                DirtyClasses();
            }
        }

        [Parameter] public RenderFragment ChildContent { get; set; }

        #endregion
    }
}
