﻿/************************************************************************

   Extended WPF Toolkit

   Copyright (C) 2010-2012 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   This program can be provided to you by Xceed Software Inc. under a
   proprietary commercial license agreement for use in non-Open Source
   projects. The commercial version of Extended WPF Toolkit also includes
   priority technical support, commercial updates, and many additional 
   useful WPF controls if you license Xceed Business Suite for WPF.

   Visit http://xceed.com and follow @datagrid on Twitter.

  **********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Xceed.Wpf.DataGrid
{
  public abstract class ForeignKeyConverter
  {
    #region Constructors

    public ForeignKeyConverter()
    {
    }

    #endregion

    #region Public Virtual Methods

    public virtual object GetValueFromKey( object key, ForeignKeyConfiguration configuration )
    {
      return key;
    }

    public virtual object GetKeyFromValue( object value, ForeignKeyConfiguration configuration )
    {
      return value;
    }

    #endregion
  }
}