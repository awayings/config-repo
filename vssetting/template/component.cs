/* $safeitemrootname$.cs - <Brief Description>                                */
/* Copyright 1986-$year$ QAD Inc., Santa Barbara, CA, USA.                      */
/* All rights reserved worldwide. This is an unpublished work.                */
/* $Id::                                                                   $: */
/*                                                                            */
/* <Detailed Description>                                                     */
/*                                                                            */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
$if$ ($targetframeworkversion$ == 3.5)using System.Linq;
$endif$using System.Text;

namespace $rootnamespace$
{
	public partial class $safeitemrootname$: Component
	{	
		public $safeitemrootname$()
		{
			InitializeComponent();
		}

		public $safeitemrootname$(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
	}
}
