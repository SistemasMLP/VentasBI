using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MLP.CASA.Interface;
using System.Configuration;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using Ventas.Dll;
using Ventas.Captura; 

namespace Ventas
{
    public partial class Login : Form
    {
        
        private Image img;
        private Image result;
        private Rectangle rectangle;
        public InfUsuario_SIA SessionUser
        {
            get;
            set;
        }
        public Login()
        {
            InitializeComponent();
            txtUsuario.Focus();
           
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SetVisibleControls(false);
            Application.DoEvents();
            ExecuteLogin();
            SetVisibleControls(true);
        }
 
         
        private void SetVisibleControls(bool bVisible)
        {
            this.txtUsuario.Enabled = bVisible;
            this.txtPass.Enabled = bVisible;
            this.btnEntrar.Enabled = bVisible;
        
        }
        private void ExecuteLogin()
        {
            if (this.txtUsuario.Text == string.Empty || this.txtPass.Text == string.Empty)
            {
                this.lblError.Text = "Favor de Introducir Usuario y/o Contraseña.";
                this.lblError.Visible = true;
            }
            else
            {
                this.lblError.Visible = false;
                string  user, pass;
                user = txtUsuario.Text;
                pass = txtPass.Text;
                BLL_SIA ObjSia = new BLL_SIA(ConfigurationSettings.AppSettings["LDAP"].ToString(), "DBConnection", ConfigurationSettings.AppSettings["AppKey"].ToString(), user, pass, ConfigurationSettings.AppSettings["Dominio"].ToString());

                InfUsuario_SIA infUsr = ObjSia.Autentica();
                SessionUser = infUsr;
                if (infUsr.Valido)
                {
                    Thread th1 = default(Thread);
                    th1 = new Thread(new ThreadStart(run));
                    th1.Start();
                    this.Close();
                }
                else
                {
                    this.lblError.Text = infUsr.Mensaje;
                    this.lblError.Visible = true;
                }
            }

        }
        private void run()
        {
            Application.Run(new frmPrincipal(SessionUser));
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            img = this.BackgroundImage;
            result = new System.Drawing.Bitmap(img.Width, img.Height);
            rectangle = new System.Drawing.Rectangle(0, 0, img.Width, img.Height);
            MuestraImagen(false);
        }
        private void MuestraImagen(Boolean mueveForma)
        {
            System.Drawing.Graphics
                graphics = System.Drawing.Graphics.FromImage(result);

            if (mueveForma)
            {
                graphics.Clear(Color.White);
            }
            else
            {
                CapturaForm.Control(this);
                graphics.DrawImage(this.BackgroundImage,
                    rectangle,
                    0, 0, img.Width, img.Height,
                    System.Drawing.GraphicsUnit.Pixel);
            }
            graphics.DrawImage(img,
                rectangle,
                0, 0, img.Width, img.Height,
                System.Drawing.GraphicsUnit.Pixel);

            graphics.Dispose();

            this.BackgroundImage = result;
            this.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



    }
    # region "NameSpace Captura"
    namespace Captura
    {
        //  Capture Module		Capture Utilities
        //  Copyright ©2003-2004 Excellence Foundation		Don@xfnd.org
        //
        //  This product is free software. You can redistribute it and/or modify it under the
        //  terms of the Public Source Distribution License Agreement (PSDLA) as published by
        //  Excellence Foundation.
        //
        //  This product is distributed in the hope it will be instructional and useful, but
        //  WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
        //  FITNESS FOR A PARTICULAR PURPOSE. See the PSDLA for more details. You should have
        //  received a copy of the PSDLA with this product. If not, browse
        //  http://www.xfnd.org/licenses/PSDLA.doc.
        public class CapturaForm
        {
            /// <summary>
            /// Captures the specified window or part thereof to a bitmap image.
            /// </summary>
            /// <param name="handle">window handle</param>
            /// <param name="r">capture rectangle</param>
            /// <returns>bitmap image of the window</returns>
            public static Bitmap Window(IntPtr handle, Rectangle r)
            {
                return Window(handle, r.X, r.Y, r.Width, r.Height);
            }


            /// <summary>
            /// Captures the window or part thereof to a bitmap image.
            /// </summary>
            /// <param name="wndHWND">window handle</param>
            /// <param name="x">x location in window</param>
            /// <param name="y">y location in window</param>
            /// <param name="width">width of capture area</param>
            /// <param name="height">height of capture area</param>
            /// <returns>window bitmap</returns>
            public static Bitmap Window(IntPtr wndHWND, int x, int y, int width, int height)
            {
                IntPtr wndHDC = USER32.GetDC(wndHWND);		// get context for window 

                //	create compatibile capture context and bitmap
                IntPtr capHDC = GDI32.CreateCompatibleDC(wndHDC);
                IntPtr capBMP = GDI32.CreateCompatibleBitmap(wndHDC, width, height);

                //	make sure bitmap non-zero
                if (capBMP == IntPtr.Zero)					// if no compatible bitmap
                {
                    USER32.ReleaseDC(wndHWND, wndHDC);		//   release window context
                    GDI32.DeleteDC(capHDC);					//   delete capture context
                    return null;							//   return null bitmap
                }

                //	select compatible bitmap in compatible context
                //	copy window context to compatible context
                //  select previous bitmap back into compatible context
                IntPtr prvHDC = (IntPtr)GDI32.SelectObject(capHDC, capBMP);
                GDI32.BitBlt(capHDC, 0, 0, width, height, wndHDC, x, y, GDI32.SRCCOPY);
                GDI32.SelectObject(capHDC, prvHDC);

                //	create GDI+ bitmap for window
                Bitmap bmp = System.Drawing.Image.FromHbitmap(capBMP);

                //	release window and capture resources
                USER32.ReleaseDC(wndHWND, wndHDC);			// release window context
                GDI32.DeleteDC(capHDC);						// delete capture context
                GDI32.DeleteObject(capBMP);					// delete capture bitmap

                //	return bitmap image to user
                return bmp;									// return bitmap
            }


            /// <summary>
            /// Captures the specified area of the control or whats underneath
            /// </summary>
            /// <param name="ctl">Control to capture</param>
            /// <param name="client">If true capture only client area else entire control.</param>
            /// <param name="under">If true capture specified area underneath the control else whats on the control.</param>
            /// <returns>bitmap image of the control or whats underneath the control</returns>
            public static void Control(System.Windows.Forms.Form ctl)
            {
                Bitmap bmp;									// capture bitmap
                Rectangle ctlR;									// capture area rectangle in control coordinates
                Rectangle scrR;									// capture area rectangle in screen coordinates
                int m_hDelay = 0;

                scrR = ctl.Bounds;									// get rectangle in parent coordinates
                if (ctl.Parent != null)								// if parent exists
                    scrR = ctl.Parent.RectangleToScreen(scrR);		// map to screen coordinates
                ctlR = ctl.RectangleToClient(scrR);					// get rectangle in control coordinates

                //	capture an area under the control

                ctl.Opacity = 0;
                System.Threading.Thread.Sleep(m_hDelay);

                Single oprvV = (float)ctl.Opacity;					// save control visibility
                if (oprvV > 0)										// if control visible
                {
                    ctl.Opacity = 0;
                    ctl.Refresh();
                }

                IntPtr desktopHWND = USER32.GetDesktopWindow();	// get window handle for desktop
                bmp = Window(desktopHWND, scrR);					// get bitmap for capture area under control
                if (ctl.Opacity < 1)
                {
                    ctl.BackgroundImage = bmp;
                    ctl.Refresh();
                    System.Threading.Thread.Sleep(m_hDelay);
                    ctl.Opacity = 1;
                }
                System.GC.Collect();
            }

        }
    }
    #endregion

    #region "NameSpace DLL"
    namespace Dll
    {
        //  Dll Module		Interop Entry Points in various Dlls
        //  Copyright ©2003-2004 Excellence Foundation		Don@xfnd.org
        //
        //  This product is free software. You can redistribute it and/or modify it under the
        //  terms of the Public Source Distribution License Agreement (PSDLA) as published by
        //  Excellence Foundation.
        //
        //  This product is distributed in the hope it will be instructional and useful, but
        //  WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
        //  FITNESS FOR A PARTICULAR PURPOSE. See the PSDLA for more details. You should have
        //  received a copy of the PSDLA with this product. If not, browse
        //  http://www.xfnd.org/licenses/PSDLA.doc.

        /// <summary>
        /// GDI32 dll access
        /// </summary>
        public class GDI32
        {
            public const int SRCCOPY = 13369376;

            [DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
            public static extern IntPtr DeleteDC(IntPtr hDc);

            [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
            public static extern IntPtr DeleteObject(IntPtr hDc);

            [DllImport("gdi32.dll", EntryPoint = "BitBlt")]
            public static extern bool BitBlt(IntPtr hdcDest, int xDest,
                int yDest, int wDest, int hDest, IntPtr hdcSource,
                int xSrc, int ySrc, int RasterOp);

            [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]
            public static extern IntPtr CreateCompatibleBitmap(IntPtr hdc,
                int nWidth, int nHeight);

            [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC")]
            public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

            [DllImport("gdi32.dll", EntryPoint = "SelectObject")]
            public static extern IntPtr SelectObject(IntPtr hdc, IntPtr bmp);
        }													// end class GDI32

        /// <summary>
        /// USER32 dll access
        /// </summary>
        public class USER32
        {
            public const int SM_CXSCREEN = 0;
            public const int SM_CYSCREEN = 1;

            [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
            public static extern IntPtr GetDesktopWindow();

            [DllImport("user32.dll", EntryPoint = "GetDC")]
            public static extern IntPtr GetDC(IntPtr ptr);

            [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
            public static extern int GetSystemMetrics(int abc);

            [DllImport("user32.dll", EntryPoint = "GetWindowDC")]
            public static extern IntPtr GetWindowDC(Int32 ptr);

            [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
            public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);
        }													// end class USER32
    }														// end namespace Dll
    #endregion
}
