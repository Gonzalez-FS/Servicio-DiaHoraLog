using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;

namespace WindowsService7
{
    public partial class Service7 : ServiceBase
    {
        public System.Timers.Timer TimerServicio = new System.Timers.Timer();
        public Service7()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Día-Hora.txt");
            string dia = lines[0];
            string hora = lines[1];

            DayOfWeek wk = DateTime.Today.DayOfWeek;
            String horaAct = DateTime.Now.ToString("HH:mm");

            string dir = @"C:\Log";
            string dirlog = @"C:\Log\Log.txt";
            DateTime fecha = DateTime.Today;

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            TimerServicio = new System.Timers.Timer();
            TimerServicio.Elapsed += (_, __) => EjecutaUnaAccion();

            switch (dia)
            {
                case "Lunes":
                    try
                    {
                        if (wk == DayOfWeek.Monday)
                        {
                            do
                            {
                                horaAct = DateTime.Now.ToString("HH:mm");
                                TimerServicio.Interval = 5000;
                            } while (horaAct != hora);
                            File.AppendAllText(dirlog, "Servicio Iniciado Correctamente - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                            TimerServicio.Start();
                        }
                        else
                        {
                            File.AppendAllText(dirlog, "Error al iniciar servicio - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine); 
                            TimerServicio.Close();
                        }
                    }
                    catch
                    {
                        File.AppendAllText(dirlog, "Error al iniciar servicio - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                        TimerServicio.Close();
                    }
                    break;
                case "Martes":
                    try
                    {
                        if (wk == DayOfWeek.Tuesday)
                        {
                            do
                            {
                                horaAct = DateTime.Now.ToString("HH:mm");
                                TimerServicio.Interval = 5000;
                            } while (horaAct != hora);
                            File.AppendAllText(dirlog, "Servicio Iniciado Correctamente - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                            TimerServicio.Start();
                        }
                        else
                        {
                            File.AppendAllText(dirlog, "Error al iniciar servicio - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                            TimerServicio.Close();
                        }
                    }
                    catch
                    {
                        File.AppendAllText(dirlog, "Error al iniciar servicio - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                        TimerServicio.Close();
                    }
                    break;
                case "Miércoles":
                    try
                    {

                        if (wk == DayOfWeek.Wednesday)
                        {
                            do
                            {
                                horaAct = DateTime.Now.ToString("HH:mm");
                                TimerServicio.Interval = 5000;
                            } while (horaAct != hora);
                            File.AppendAllText(dirlog, "Servicio Iniciado Correctamente - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                            TimerServicio.Start();
                        }
                        else
                        {
                            File.AppendAllText(dirlog, "Error al iniciar servicio - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                            TimerServicio.Close();
                        }
                    }
                    catch
                    {
                        File.AppendAllText(dirlog, "Error al iniciar servicio - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                        TimerServicio.Close();
                    }
                    break;
                case "Jueves":
                    try
                    {
                        if (wk == DayOfWeek.Thursday)
                        {
                            do
                            {
                                horaAct = DateTime.Now.ToString("HH:mm");
                                TimerServicio.Interval = 5000;
                            } while (horaAct != hora);
                            File.AppendAllText(dirlog, "Servicio Iniciado Correctamente - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                            TimerServicio.Start();
                        }
                        else
                        {
                            File.AppendAllText(dirlog, "Error al iniciar servicio - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                            TimerServicio.Close();
                        }
                    }
                    catch
                    {
                        File.AppendAllText(dirlog, "Error al iniciar servicio - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                        TimerServicio.Close();
                    }
                    break;
                case "Viernes":
                    try
                    {
                        if (wk == DayOfWeek.Friday)
                        {
                            do
                            {
                                horaAct = DateTime.Now.ToString("HH:mm");
                                TimerServicio.Interval = 5000;
                            } while (horaAct != hora);
                            File.AppendAllText(dirlog, "Servicio Iniciado Correctamente - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                            TimerServicio.Start();
                        }
                        else
                        {
                            File.AppendAllText(dirlog, "Error al iniciar servicio - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                            TimerServicio.Close();
                        }
                    }
                    catch
                    {
                        File.AppendAllText(dirlog, "Error al iniciar servicio - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                        TimerServicio.Close();
                    }
                    break;
                case "Sábado":
                    try
                    {
                        if (wk == DayOfWeek.Saturday)
                        {
                            do
                            {
                                horaAct = DateTime.Now.ToString("HH:mm");
                                TimerServicio.Interval = 5000;
                            } while (horaAct != hora);
                            File.AppendAllText(dirlog, "Servicio Iniciado Correctamente - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                            TimerServicio.Start();
                        }
                        else
                        {
                            File.AppendAllText(dirlog, "Error al iniciar servicio - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                            TimerServicio.Close();
                        }
                    }
                    catch
                    {
                        File.AppendAllText(dirlog, "Error al iniciar servicio - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                        TimerServicio.Close();
                    }
                    break;
                case "Domingo":
                    try
                    {


                        if (wk == DayOfWeek.Sunday)
                        {
                            do
                            {
                                horaAct = DateTime.Now.ToString("HH:mm");
                                TimerServicio.Interval = 5000;
                            } while (horaAct != hora);
                            File.AppendAllText(dirlog, "Servicio Iniciado Correctamente - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                            TimerServicio.Start();
                        }
                        else
                        {
                            File.AppendAllText(dirlog, "Error al iniciar servicio - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                            TimerServicio.Close();
                        }
                    }
                    catch
                    {
                        File.AppendAllText(dirlog, "Error al iniciar servicio - " + "Fecha: " + fecha + " - Hora: " + horaAct + System.Environment.NewLine);
                        TimerServicio.Close();
                    }
                    break;
            }
        }
        public void EjecutaUnaAccion()
        {

            int i;
            for (i = 1; i <= 15; i++)
            {
                File.AppendAllText(@"C:\WindowsService7\bin\Debug\InformeC#.TXT", "Línea C# N° " + i + System.Environment.NewLine);
            }
            TimerServicio.Close();
        }
        protected override void OnStop()
        {
            TimerServicio.Close();
        }
        protected override void OnPause()
        {
            TimerServicio.Stop();
        }
        protected override void OnContinue()
        {
            TimerServicio.Start();
        }
    }
}
