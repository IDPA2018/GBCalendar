﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GBCalendar.Forms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditAppointment : ContentPage
	{
		public EditAppointment ()
		{
			InitializeComponent ();

		}

        private void OnToggled(object sender, ToggledEventArgs e)
        {
            
        }

        private void OnCreateAppointmentClicked()
        {

        }

    }
}