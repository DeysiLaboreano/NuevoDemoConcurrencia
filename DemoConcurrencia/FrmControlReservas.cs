using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcurrencia
{
    public partial class FrmControlReservas : Form
    {
        private int contador = 0; // Contador de recursos o reservas.
        private object bloqueo = new object(); // Objeto para bloqueo.
        private SemaphoreSlim semaforo = new SemaphoreSlim(2);
        private const int MAX_RECURSOS = 6;
        public FrmControlReservas()
        {
            InitializeComponent();
            
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                semaforo.Wait(); 

                lock (bloqueo) 
                {
                    if (contador < MAX_RECURSOS) 
                    {
                        contador++; 
                        Thread.Sleep(1000); 

                        
                        this.Invoke((MethodInvoker)delegate
                        {
                            lblRecursosActivos.Text = $"Contador: {contador}";
                        });

                        Monitor.Pulse(bloqueo); // Notificar a cualquier hilo en espera.
                    }
                    else
                    {
                        ActualizarResultado("No se pueden agregar más recursos. Límite alcanzado.");
                    }
                }
                semaforo.Release(); // Liberar el semáforo.
            });
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (bloqueo) 
                {
                    while (contador <= 0) 
                    {
                        ActualizarResultado("Esperando recursos...");
                        Monitor.Wait(bloqueo); 
                    }

                    if (contador > 0)
                    {
                        contador--; 
                        Thread.Sleep(1000); 

                      
                        this.Invoke((MethodInvoker)delegate
                        {
                            lblRecursosActivos.Text = $"Contador: {contador}";
                        });
                    }
                    ActualizarResultado("Procesando...");
                }
            });

        }
        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            TxtResultado.AppendText($"{DateTime.Now:HH:mm:ss.fff}: {mensaje}{Environment.NewLine}");
        }
    }
}
