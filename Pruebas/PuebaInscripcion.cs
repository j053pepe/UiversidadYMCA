﻿using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Globalization;
using BLL;
using Utilities;

namespace Pruebas
{
    /// <summary>
    /// Descripción resumida de PuebaInscripcion
    /// </summary>
    [TestClass]
    public class PuebaInscripcion
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (UniversidadEntities db = new UniversidadEntities())
            {
                DTOAlumnoInscrito objAlumno = new DTOAlumnoInscrito();

                objAlumno.AlumnoId = 7942;
                objAlumno.OfertaEducativaId = 29;
                objAlumno.Anio = 2017;
                objAlumno.PeriodoId = 2;
                objAlumno.FechaInscripcion = DateTime.Parse("13/01/2017");
                objAlumno.HoraInscripcion = TimeSpan.Parse("12:40:36");
                objAlumno.UsuarioId = 6070;
                objAlumno.Cuatrimestre = 1;

                var alumno = db.AlumnoInscrito.Where(a => a.AlumnoId == objAlumno.AlumnoId
                                                     && a.OfertaEducativaId == objAlumno.OfertaEducativaId).FirstOrDefault();



                db.AlumnoInscritoBitacora.Add(new AlumnoInscritoBitacora
                {
                    AlumnoId = alumno.AlumnoId,
                    OfertaEducativaId = alumno.OfertaEducativaId,
                    Anio = alumno.Anio,
                    PeriodoId = alumno.PeriodoId,
                    FechaInscripcion = alumno.FechaInscripcion,
                    HoraInscripcion = alumno.HoraInscripcion,
                    PagoPlanId = alumno.PagoPlanId,
                    TurnoId = alumno.TurnoId,
                    EsEmpresa = alumno.EsEmpresa,
                    UsuarioId = alumno.UsuarioId
                });

                db.AlumnoInscrito.Add(new AlumnoInscrito
                {
                    AlumnoId = objAlumno.AlumnoId,
                    OfertaEducativaId = objAlumno.OfertaEducativaId,
                    Anio = objAlumno.Anio,
                    PeriodoId = objAlumno.PeriodoId,
                    FechaInscripcion = DateTime.Now,
                    HoraInscripcion = DateTime.Now.TimeOfDay,
                    PagoPlanId = alumno.PagoPlanId,
                    TurnoId = alumno.TurnoId,
                    EsEmpresa = alumno.EsEmpresa,
                    UsuarioId = objAlumno.UsuarioId,
                    EstatusId = 1
                });

                db.AlumnoCuatrimestre.Add(new AlumnoCuatrimestre
                {
                    AlumnoId = objAlumno.AlumnoId,
                    OfertaEducativaId = objAlumno.OfertaEducativaId,
                    Cuatrimestre = objAlumno.Cuatrimestre,
                    Anio = objAlumno.Anio,
                    PeriodoId = objAlumno.PeriodoId,
                    FechaAsignacion = objAlumno.FechaInscripcion,
                    HoraAsignacion = objAlumno.HoraInscripcion,
                    UsuarioId = objAlumno.UsuarioId
                });

                db.AlumnoInscrito.Remove(alumno);

                db.SaveChanges();
            }

        }


        [TestMethod]
        public void EnviarCorreo()
        {
            int AlumnoId = 8000;
            string EmailAlumno = "hbk_antonio619@hotmail.com";
            string Fallidos = "";
            DTOCuentaMail objCuenta = BLLCuentaMail.ConsultarCuentaMail();
           

            try
            {
                var refere = new Utilities.ProcessResult();
                string body = "";
                DTOAlumno opjAl = BLLAlumnoPortal.ObtenerAlumno(AlumnoId);
                

                #region "HTML"
                body = "<html lang='en' xmlns='http://www.w3.org/1999/xhtml'>" +
                            "<head>" +
                            "<meta charset='utf-8' />" +
                            "<title>Bienvenida Alumnos</title>" +
                            "<meta http-equiv='X-UA-Compatible' content='IE=edge' />" +
                            "<meta content='width=device-width, initial-scale=1.0' name='viewport' />" +
                            "<meta http-equiv='Content-type' content='text/html; charset=utf-8' />" +
                            "<meta content='' name='description' />" +
                            "<meta content='' name='author' />" +
                           "<style>" +
                                "body {" +
                                    "color: #333333;" +
                                    "font-family: 'Open Sans', sans-serif;" +
                                    "padding: 0px !important;" +
                                    "margin: 0px !important;" +
                                    "font-size: 13px;" +
                                    "direction: ltr;" +
                                "}" +
                                "body {" +
                                    "font-family: 'Helvetica Neue',Helvetica,Arial,sans-serif;" +
                                    "font-size: 14px;" +
                                    "line-height: 1.42857143;" +
                                    "color: #333;" +
                                    "background-color: #fff;" +
                                "}" +
                                "Inherited from html html {" +
                                    "font-size: 10px;" +
                                    "-webkit-tap-highlight-color: rgba(0,0,0,0);" +
                                "}" +
                                "html {" +
                                    "font-family: sans-serif;" +
                                    "-webkit-text-size-adjust: 100%;" +
                                    "-ms-text-size-adjust: 100%;" +
                                "}" +
                                "div, input, select, textarea, span, img, table, label, td, th, p, a, button, ul, code, pre, li {" +
                                    "-webkit-border-radius: 0 !important;" +
                                    "-moz-border-radius: 0 !important;" +
                                    "border-radius: 0 !important;" +
                                "}" +
                                "* {" +
                                    "-webkit-box-sizing: border-box;" +
                                    "-moz-box-sizing: border-box;" +
                                    "box-sizing: border-box;" +
                                "}" +
                                "@media (min-width: 1200px) {" +
                                    ".container {" +
                                        "width: 1170px;" +
                                    "}" +
                                "}" +
                                "@media (min-width: 992px) {" +
                                    ".container {" +
                                        "width: 970px;" +
                                    "}" +
                                "}" +
                                "@media (min-width: 768px) {" +
                                    ".container {" +
                                        "width: 750px;" +
                                    "}" +
                                "}" +
                                ".container {" +
                                    "padding-right: 15px;" +
                                    "padding-left: 15px;" +
                                    "margin-right: auto;" +
                                    "margin-left: auto;" +
                                "}" +
                                        ".row {" +
                                            "margin-right: -15px;" +
                                            "margin-left: -15px;" +
                                        "}" +
                                        ".col-md-1, .col-md-10, .col-md-11, .col-md-12, .col-md-2, .col-md-3, .col-md-4, .col-md-5, .col-md-6, .col-md-7, .col-md-8, .col-md-9 {" +
                                    "float: left;" +
                                "}" +
                                ".col-lg-1, .col-lg-10, .col-lg-11, .col-lg-12, .col-lg-2, .col-lg-3, .col-lg-4, .col-lg-5, .col-lg-6, .col-lg-7, .col-lg-8, .col-lg-9, .col-md-1, .col-md-10, .col-md-11, .col-md-12, .col-md-2, .col-md-3, .col-md-4, .col-md-5, .col-md-6, .col-md-7, .col-md-8, .col-md-9, .col-sm-1, .col-sm-10, .col-sm-11, .col-sm-12, .col-sm-2, .col-sm-3, .col-sm-4, .col-sm-5, .col-sm-6, .col-sm-7, .col-sm-8, .col-sm-9, .col-xs-1, .col-xs-10, .col-xs-11, .col-xs-12, .col-xs-2, .col-xs-3, .col-xs-4, .col-xs-5, .col-xs-6, .col-xs-7, .col-xs-8, .col-xs-9 {" +
                                    "position: relative;" +
                                    "min-height: 1px;" +
                                    "padding-right: 15px;" +
                                    "padding-left: 15px;" +
                                "}" +
                                ".portlet.light {" +
                                    "padding: 12px 20px 15px 20px;" +
                                    "background-color: #fff;" +
                                "}" +
                                ".portlet {" +
                                    "margin-top: 0px;" +
                                    "margin-bottom: 25px;" +
                                    "padding: 0px;" +
                                    "-webkit-border-radius: 4px;" +
                                    "-moz-border-radius: 4px;" +
                                    "-ms-border-radius: 4px;" +
                                    "-o-border-radius: 4px;" +
                                    "border-radius: 4px;" +
                                "}" +
                                ".portlet.light > .portlet-title {" +
                                    "padding: 0;" +
                                    "min-height: 48px;" +
                                "}" +
                                ".portlet > .portlet-title {" +
                                    "border-bottom: 1px solid #eee;" +
                                    "padding: 0;" +
                                    "margin-bottom: 10px;" +
                                    "min-height: 41px;" +
                                    "-webkit-border-radius: 4px 4px 0 0;" +
                                    "-moz-border-radius: 4px 4px 0 0;" +
                                    "-ms-border-radius: 4px 4px 0 0;" +
                                    "-o-border-radius: 4px 4px 0 0;" +
                                    "border-radius: 4px 4px 0 0;" +
                                "}" +
                                ".portlet.light > .portlet-title > .caption {" +
                                    "color: #666;" +
                                    "padding: 10px 0;" +
                                "}" +
                                ".portlet > .portlet-title > .caption {" +
                                    "float: left;" +
                                    "display: inline-block;" +
                                    "font-size: 18px;" +
                                    "line-height: 18px;" +
                                    "padding: 10px 0;" +
                                "}" +
                                ".uppercase {" +
                                    "text-transform: uppercase !important;" +
                                "}" +
                                ".bold {" +
                                    "font-weight: 700 !important;" +
                                "}" +
                                "h2 {" +
                                    "font-size: 27px;" +
                                "}" +
                                "h3 {" +
                                    "font-size: 23px;" +
                                "}" +
                                "h4 {" +
                                    "font-size: 17px;" +
                                "}" +
                                ".h4, h4 {" +
                                    "font-size: 18px;" +
                                "}" +
                                "h1, h2, h3, h4, h5, h6 {" +
                                    "font-family: 'Open Sans', sans-serif;" +
                                    "font-weight: 300;" +
                                "}" +
                                ".h2, h2 {" +
                                    "font-size: 30px;" +
                                "}" +
                                ".h1, .h2, .h3, h1, h2, h3 {" +
                                    "margin-top: 20px;" +
                                    "margin-bottom: 10px;" +
                                "}" +
                                ".h1, .h2, .h3, .h4, .h5, .h6, h1, h2, h3, h4, h5, h6 {" +
                                    "font-family: inherit;" +
                                    "font-weight: 500;" +
                                    "line-height: 1.1;" +
                                    "color: inherit;" +
                                "}" +
                                "* {" +
                                    "-webkit-box-sizing: border-box;" +
                                    "-moz-box-sizing: border-box;" +
                                    "box-sizing: border-box;" +
                                "}" +
                                "user agent stylesheeth2 {" +
                                    "display: block;" +
                                    "font-size: 1.5em;" +
                                    "-webkit-margin-before: 0.83em;" +
                                    "-webkit-margin-after: 0.83em;" +
                                    "-webkit-margin-start: 0px;" +
                                    "-webkit-margin-end: 0px;" +
                                    "font-weight: bold;" +
                                "}" +
                                ".table {" +
                                    "width: 100%;" +
                                    "max-width: 100%;" +
                                    "margin-bottom: 20px;" +
                                "}" +
                                ".font-green-sharp {" +
                                    "color: #4DB3A2 !important;" +
                                "}" +
                                ".uppercase {" +
                                    "text-transform: uppercase !important;" +
                                "}" +
                                ".bold {" +
                                    "font-weight: 700 !important;" +
                                "}" +
                                ".font-blue {" +
                                    "color: #3598dc !important;" +
                                "}" +
                                "hr {" +
                                    "margin: 20px 0;" +
                                    "border: 0;" +
                                    "border-top: 1px solid #eee;" +
                                    "border-bottom: 0;" +
                                "}" +
                                "hr {" +
                                    "margin-top: 20px;" +
                                    "margin-bottom: 20px;" +
                                    "border: 0;" +
                                    "border-top: 1px solid #eee;" +
                                "}" +
                                "hr {" +
                                    "height: 0;" +
                                    "-webkit-box-sizing: content-box;" +
                                    "-moz-box-sizing: content-box;" +
                                    "box-sizing: content-box;" +
                                "}" +
                                "* {" +
                                    "-webkit-box-sizing: border-box;" +
                                    "-moz-box-sizing: border-box;" +
                                    "box-sizing: border-box;" +
                                "}" +
                                "user agent stylesheethr {" +
                                    "display: block;" +
                                    "-webkit-margin-before: 0.5em;" +
                                    "-webkit-margin-after: 0.5em;" +
                                    "-webkit-margin-start: auto;" +
                                    "-webkit-margin-end: auto;" +
                                    "border-style: inset;" +
                                    "border-width: 1px;" +
                                "}" +
                            "</style>" +
                            "</head>" +
                            "<body>" +

                            "<div class='page-head'>" +
    "<div class='container'>" +
        "<div class='table'>" +
            "<div class='row'>" +
                "<div class='col-md-12'>" +
                    "<div class='col-md-3'>" +
                    "</div>" +
                "</div>" +
                "<div class='col-md-12'>" +
                    "<table cellpadding='0' cellspacing='0' border='0' height='100%' width='100%' bgcolor='#f0f1f1' style='border-collapse:collapse'>" +
                        "<tbody>" +
                            "<tr>" +
                                "<td>" +
                                    "<center style='width:100%'>" +
                                        "<div style='max-width:2000px; margin-left:auto; margin-right:auto'>" +
                                            "<table cellspacing='0' cellpadding='0' border='0' align='center' bgcolor='#ffffff' width='680' style='max-width:680px; border:solid 1px #cfd1d2'>" +
                                                "<tbody>" +
                                                    "<tr><td> &nbsp;</td></tr>" +
                                                    "<tr style='padding:3%'>" +
                                                        "<td dir='ltr' bgcolor='#ffffff' ; align='center' height='100%' valign='top' width='100%' style='padding:0 3% 3% 3%; line-height:25px'>" +
                                                            "<div class='col-md-12'>" +
                                                                "<table border='0' cellspacing='0' cellpadding='0' align='center' width='100%' class='x_body-content' style='background-color:#CCCCCC; padding:3%'>" +
                                                                    "<tbody>" +
                                                                        "<tr>" +
                                                                            "<td align='center' valign='top'>" +
                                                                                "<div class='col-md-12' style='font-size:16pt; font-weight:bolder; color:#FFFFFF;  text-transform:uppercase; text-align:center'>" +
                                                                                    "<img height='113px' width='80px' src='http://108.163.172.122/portalAdministrativo/Imagenes/UYMCA-500px.png' />" +
                                                                                "</div>" +
                                                                            "</td>" +
                                                                            "<td align='center' valign='top'>" +
                                                                                "<div class='col-md-12' style='font-size:17pt; font-weight:bolder; color:#CC0000;  text-transform:uppercase; text-align:center'>" +
                                                                                    "<br>" +
                                                                                    " Aviso importante universidad YMCA " +
                                                                                    "<br>" +
                                                                                "</div>" +
                                                                            "</td>" +
                                                                        "</tr>" +
                                                                    "</tbody>" +
                                                                "</table>" +
                                                            "</div>" +
                                                        "</td>" +
                                                    "</tr>" +
                                                    "<tr style='padding:3%'>" +
                                                        "<td dir='ltr' bgcolor='#ffffff' align='center' height='100%' valign='top' width='100%' style='padding:0 3% 3% 3%; line-height:25px'>" +
                                                            "<div class='col-md-12'>" +
                                                                "<table border='0' cellspacing='0' cellpadding='0' align='center' width='100%' class='x_body-content' style='background-color:#f3f3f3; padding:3%'>" +
                                                                    "<tbody>" +
                                                                        "<tr>" +
                                                                            "<td align='center' valign='top'>" +
                                                                                "<div style='color:#009966; font-size:30px; text-align:center; padding:10px'>Estimado,&nbsp; "+opjAl.Nombre+ " " + opjAl.Paterno + " " + opjAl.Materno + " </div>" +
                                                                                "<div>" +
                                                                                    "<h3 class='caption font-blue'>" +
                                                                                        "No has concluido tu proceso de inscripción, para finalizarlo es necesario que te presentes inmediatamente con tu coordinador." +
                                                                                    "</h3>" +
                                                                                    "<br />" +
                                                                                    "<h4 class='caption font-blue-dark'> Universidad YMCA México. </h4>" +
                                                                                "</div>" +
                                                                            "</td>" +
                                                                        "</tr>" +
                                                                    "</tbody>" +
                                                                "</table>" +
                                                            "</div>" +
                                                        "</td>" +
                                                    "</tr>" +
                                                "</tbody>" +
                                            "</table>" +
                                        "</div>" +
                                    "</center>" +
                                "</td>" +
                            "</tr>" +
                        "</tbody>" +
                    "</table>" +
                "</div>" +
            "</div>" +
        "</div>" +
    "</div>" +
"</div>" +

                            "</body>" +
                            "</html>";
                #endregion

                Email.Enviar(objCuenta.Email, objCuenta.Password, objCuenta.DisplayName, EmailAlumno, ',', "antoniogalvan@ymcacdmex.org.mx", ';', "Aviso Portal Universidad YMCA", body, "", ',', objCuenta.Smtp, objCuenta.Puerto, objCuenta.SSL, true, ref refere);
            }
            catch (Exception e)
            {
                Fallidos = AlumnoId + " " + e.Message;
            }

        }
    }
}
