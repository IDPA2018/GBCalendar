﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace GBCalendar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewAppointment : ContentPage
	{
        public NewAppointment ()
		{
            InitializeComponent();
            


            try
            {
                //Fill up Classes for Appointment
                DatabaseReader readerclasses = new DatabaseReader();

                //"8" ist id des Techeachers. Muss später noch durch Person.idPers ersetzt werden
                List<Class> classes = readerclasses.ReadClass(8);

                foreach (Class c in classes)
                {
                    Classpicker.Items.Add(c.ClassName);
                }

            }
            catch (Exception)
            {
                throw;

            }


            try
            {
                //Fill up Rooms for Appointment
                DatabaseReader readerrooms = new DatabaseReader();

                List<Room> rooms = readerrooms.ReadRoom();

                foreach (Room r in rooms)
                {
                    Roompicker.Items.Add(r.RoomName);
                }

            }
            catch (Exception)
            {

                throw;
            }

           
        }

       

        void OnToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == true)
            {
                LabelBegin.IsVisible = false;
                TimePickerStart_Time.IsVisible = false;
                LabelEnd.IsVisible = false;
                TimePickerEnd_Time.IsVisible = false;

            }

            if (e.Value == false)
            {
                LabelBegin.IsVisible = true;
                TimePickerStart_Time.IsVisible = true;
                LabelEnd.IsVisible = true;
                TimePickerEnd_Time.IsVisible = true;
            }
        }

        void OnEreignisErstellenClicked(object sender, EventArgs args)
        {
            //Class c = new Class(Classpicker.SelectedItem.ToString());

            //Console.WriteLine(DatePicker.Date.ToString("dd-MM-yyyy"));


            DateTime starttime = DateTime.Parse(DatePicker.Date.ToString("dd-MM-yyyy") + " " + TimePickerStart_Time.Time.ToString());

            Console.WriteLine(starttime);
            
            //c.AddAppointment(AppointmentTitel.ToString(),xy,)
        }
    }
}