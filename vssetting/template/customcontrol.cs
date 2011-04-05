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
using System.Data;
using System.Drawing;
$if$ ($targetframeworkversion$ == 3.5)using System.Linq;
$endif$using System.Text;
using System.Windows.Forms;

namespace $rootnamespace$
{
	public partial class $safeitemrootname$: Control
	{
		public $safeitemrootname$()
		{
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}
	}
}
