﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

namespace GBCalendar.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowAppointmentForStudent : ContentPage
    {
        public ShowAppointmentForStudent(Appointment appointment)
        {
            try
            {
                InitializeComponent();
                this.Title = appointment.Title;
                this.AppointmentTitel.Text = appointment.Title;
                this.AppointmentDescription.Text = appointment.Description;
                this.RoomEntry.Text = appointment.Room.RoomName;
                this.Entry_Date.Text = appointment.StartTime.Substring(0, 10);
                
                if (appointment.AllDayEvent == "Y")
                {
                    this.AllDayEventEntry.Text = "Ja";
                    this.LabelBegin.IsVisible = false;
                    this.EntryStart_Time.IsVisible = false;
                    this.EntryEnd_Time.IsVisible = false;
                    this.LabelEnd.IsVisible = false;
                }
                else
                {
                    this.Label_AllDayEvent.IsVisible = false;
                    this.AllDayEventEntry.IsVisible = false;
                    this.EntryStart_Time.Text = appointment.StartTime.Substring(12,7);
                    this.EntryEnd_Time.Text = appointment.EndTime.Substring(12, 7);
                }
            }

            catch (Exception e)
            {
                throw;
            }
        }
    }
}
