using ProyecContable.Estados.Alerta;
using ProyecContable.Properties;
using System.Collections.Generic;

namespace ProyecContable.Estados
{
    public class ClassToast
    {
        
        public ClassToast(string Estado, string Titulo, string Mensaje)
        {
            // VALIDAR
            if (Estado == ClassColorAlerta.Alerta.Validado.ToString())
            {
                List<int> ColorClaro = new List<int>
                {
                    255,
                    250,
                    230
                };
                List<int> ColorOscuro = new List<int>
                {
                    255,
                    171,
                    0
                };
                FrmMensaje FrmEstado = new FrmMensaje(Resources.Warning_32px, Titulo, Mensaje, ColorClaro, ColorOscuro);               
                FrmEstado.ShowDialog();
            }
            // GUARDADO
            if (Estado == ClassColorAlerta.Alerta.Guardado.ToString())
            {
                List<int> ColorClaro = new List<int>
                {
                    212,
                    237,
                    218
                };
                List<int> ColorOscuro = new List<int>
                {
                    2,
                    96,
                    76
                };
                FrmMensaje FrmEstado = new FrmMensaje(Resources.ok_32px, Titulo, Mensaje, ColorClaro, ColorOscuro);
                FrmEstado.ShowDialog();
            }
            // ERROR
            if (Estado == ClassColorAlerta.Alerta.Error.ToString())
            {
                List<int> ColorClaro = new List<int>
                {
                    248,
                    215,
                    218
                };
                List<int> ColorOscuro = new List<int>
                {
                    114,
                    28,
                    36
                };
                FrmMensaje FrmEstado = new FrmMensaje(Resources.close_window_32px, Titulo, Mensaje, ColorClaro, ColorOscuro);
                FrmEstado.ShowDialog();
            }
            // ACTUALIZADO
            if (Estado == ClassColorAlerta.Alerta.Actualizado.ToString())
            {
                List<int> ColorClaro = new List<int>
                {
                    212,
                    237,
                    218
                };
                List<int> ColorOscuro = new List<int>
                {
                    2,
                    96,
                    76
                };
                FrmMensaje FrmEstado = new FrmMensaje(Resources.ok_32px, Titulo, Mensaje, ColorClaro, ColorOscuro);
                FrmEstado.ShowDialog();
            }
        }

    }
}
