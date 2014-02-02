﻿#region Copyright

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserbarView.xaml.cs">
//    Copyright (c) 2013, Justin Kadrovach, All rights reserved.
//   
//    This source is subject to the Simplified BSD License.
//    Please see the License.txt file for more information.
//    All other rights reserved.
//    
//    THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY 
//    KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//    IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//    PARTICULAR PURPOSE.
// </copyright>
//  --------------------------------------------------------------------------------------------------------------------

#endregion

namespace slimCat.Views
{
    #region Usings

    using ViewModels;

    #endregion

    /// <summary>
    ///     Interaction logic for Userbar.xaml
    /// </summary>
    public partial class UserbarView
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="UserbarView" /> class.
        /// </summary>
        /// <param name="vm">
        ///     The vm.
        /// </param>
        public UserbarView(UserbarViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }

        #endregion
    }
}