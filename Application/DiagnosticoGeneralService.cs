using System.Collections.Generic;
using Domain;

namespace Application
{
    public class DiagnosticoGeneralService
    {
        double[] sintomasGripe = new double[9];
        double[] sintomasResfriadoComun = new double[7];
        double[] sintomasRinitis = new double[5];
        double[] sintomasRinosinositis = new double[7];
        double[] sintomasFaringitis = new double[8];
        double[] sintomasAmigdalitis = new double[9];
        double[] sintomasBronquitis = new double[7];
        double[] sintomasEnfisemaPulmonar = new double[6];
        double[] sintomasAsma = new double[5];
        double[] sintomasNeumonia = new double[7];
        double[] sintomasCancerDePulmon = new double[8];
        double[] sintomasSinusitis = new double[9];
        double[] sintomasLaringitis = new double[8];
        double[] sintomasEPOC = new double[10];
        double[] sintomasCovid19 = new double[11];
        
        public DiagnosticoGeneralResponse Ejecute(DiagnosticoGeneralRequest request)
        {
            MapearSintomas(request.Sintomas);
            var enfermedades = InicializarEnfermedades();
            return enfermedades;
        }

        private void MapearSintomas(int[] Sintomas)
        {
            for (var sintoma = 0; sintoma < Sintomas.Length; sintoma++)
            {
                if (Sintomas[sintoma] == 1)
                {
                    switch (sintoma)
                    {
                        case 0:
                            sintomasEnfisemaPulmonar[5] = 1;
                            sintomasEPOC[8] = 1;
                            break;
                        case 1:
                            sintomasAmigdalitis[8] = 1;
                            break;
                        case 2:
                            sintomasGripe[2] = 1;
                            sintomasResfriadoComun[0] = 1;
                            sintomasRinitis[0] = 1;
                            sintomasBronquitis[1] = 1;
                            sintomasEnfisemaPulmonar[2] = 1;
                            sintomasSinusitis[6] = 1;
                            sintomasRinosinositis[1] = 1;
                            break;
                        case 3:
                            sintomasCovid19[6] = 1;
                            break;
                        case 4:
                            sintomasLaringitis[3] = 1;
                            break;
                        case 5:
                            sintomasCovid19[5] = 1;
                            break;
                        case 6:
                            sintomasAmigdalitis[3] = 1;
                            sintomasFaringitis[6] = 1;
                            break;
                        case 7:
                            sintomasBronquitis[3] = 1;
                            sintomasEnfisemaPulmonar[0] = 1;
                            sintomasAsma[4] = 1;
                            sintomasNeumonia[6] = 1;
                            sintomasEPOC[0] = 1;
                            sintomasCovid19[10] = 1;
                            break;
                        case 8:
                            sintomasFaringitis[3] = 1;
                            break;
                        case 9:
                            sintomasGripe[6] = 1;
                            sintomasResfriadoComun[2] = 1;
                            sintomasRinosinositis[4] = 1;
                            sintomasAmigdalitis[6] = 1;
                            sintomasCancerDePulmon[7] = 1;
                            sintomasSinusitis[4] = 1;
                            break;
                        case 10:
                            sintomasResfriadoComun[6] = 1;
                            sintomasRinosinositis[6] = 1;
                            sintomasSinusitis[8] = 1;
                            sintomasLaringitis[6] = 1;
                            sintomasCovid19[4] = 1;
                            break;
                        case 11:
                            sintomasFaringitis[5] = 1;
                            break;
                        case 12:
                            sintomasNeumonia[0] = 1;
                            sintomasCancerDePulmon[4] = 1;
                            sintomasCovid19[8] = 1;
                            break;
                        case 13:
                            sintomasCancerDePulmon[6] = 1;
                            break;
                        case 14:
                            sintomasAmigdalitis[4] = 1;
                            break;
                        case 15:
                            sintomasSinusitis[5] = 1;
                            break;
                        case 16:
                            sintomasGripe[1] = 1;
                            sintomasFaringitis[4] = 1;
                            sintomasLaringitis[7] = 1;
                            break;
                        case 17:
                            sintomasRinosinositis[0] = 1;
                            break;
                        case 18:
                            sintomasGripe[5] = 1;
                            sintomasBronquitis[5] = 1;
                            sintomasNeumonia[3] = 1;
                            break;
                        case 19:
                            sintomasGripe[7] = 1;
                            sintomasResfriadoComun[5] = 1;
                            sintomasRinitis[2] = 1;
                            break;
                        case 20:
                            sintomasEPOC[3] = 1;
                            break;
                        case 21:
                            sintomasAsma[0] = 1;
                            sintomasCancerDePulmon[2] = 1;
                            break;
                        case 22:
                            sintomasGripe[8] = 1;
                            sintomasRinosinositis[3] = 1;
                            sintomasEnfisemaPulmonar[3] = 1;
                            sintomasBronquitis[2] = 1;
                            sintomasNeumonia[1] = 1;
                            sintomasSinusitis[3] = 1;
                            sintomasEPOC[5] = 1;
                            sintomasCovid19[2] = 1;
                            break;
                        case 23:
                            sintomasGripe[0] = 1;
                            sintomasResfriadoComun[1] = 1;
                            sintomasRinosinositis[5] = 1;
                            sintomasAmigdalitis[1] = 1;
                            sintomasBronquitis[4] = 1;
                            sintomasNeumonia[2] = 1;
                            sintomasSinusitis[1] = 1;
                            sintomasCovid19[0] = 1;
                            break;
                        case 24:
                            sintomasAmigdalitis[0] = 1;
                            break;
                        case 25:
                            sintomasEPOC[7] = 1;
                            break;
                        case 26:
                            sintomasCovid19[9] = 1;
                            break;
                        case 27:
                            sintomasEPOC[4] = 1;
                            break;
                        case 28:
                            sintomasAmigdalitis[2] = 1;
                            sintomasSinusitis[2] = 1;
                            sintomasLaringitis[5] = 1;
                            break;
                        case 29:
                            sintomasResfriadoComun[4] = 1;
                            sintomasRinosinositis[4] = 1;
                            sintomasCovid19[3] = 1;
                            break;
                        case 30:
                            sintomasBronquitis[6] = 1;
                            sintomasAsma[1] = 1;
                            sintomasNeumonia[4] = 1;
                            sintomasEPOC[2] = 1;
                            break;
                        case 31:
                            break;
                        case 32:
                            sintomasRinitis[4] = 1;
                            break;
                        case 33:
                            sintomasEnfisemaPulmonar[4] = 1;
                            break;
                        case 34:
                            sintomasLaringitis[1] = 1;
                            break;
                        case 35:
                            sintomasSinusitis[0] = 1;
                            break;
                        case 36:
                            sintomasCancerDePulmon[5] = 1;
                            sintomasEPOC[6] = 1;
                            sintomasCovid19[7] = 1;
                            break;
                        case 37:
                            sintomasFaringitis[1] = 1;
                            break;
                        case 38:
                            sintomasRinitis[1] = 1;
                            break;
                        case 39:
                            sintomasAmigdalitis[7] = 1;
                            break;
                        case 40:
                            sintomasCancerDePulmon[3] = 1;
                            sintomasLaringitis[0] = 1;
                            break;
                        case 41:
                            sintomasFaringitis[6] = 1;
                            sintomasLaringitis[4] = 1;
                            break;
                        case 42:
                            sintomasAsma[2] = 1;
                            sintomasEPOC[1] = 1;
                            break;
                        case 43:
                            sintomasGripe[4] = 1;
                            break;
                        case 44:
                            sintomasGripe[3] = 1;
                            sintomasResfriadoComun[3] = 1;
                            sintomasRinitis[3] = 1;
                            sintomasBronquitis[0] = 1;
                            sintomasEnfisemaPulmonar[1] = 1;
                            sintomasCancerDePulmon[0] = 1;
                            sintomasSinusitis[7] = 1;
                            break;
                        case 45:
                            sintomasFaringitis[2] = 1;
                            sintomasEPOC[9] = 1;
                            break;
                        case 46:
                            sintomasCancerDePulmon[1] = 1;
                            break;
                        case 47:
                            sintomasAsma[3] = 1;
                            sintomasLaringitis[2] = 1;
                            sintomasCovid19[1] = 1;
                            break;
                        case 48:
                            sintomasNeumonia[5] = 1;
                            break;
                        case 49:
                            sintomasFaringitis[7] = 1;
                            sintomasAmigdalitis[5] = 1;
                            break;
                        
                    }
                }
                
            }
        }

        private DiagnosticoGeneralResponse InicializarEnfermedades()
        {
            var amigdalitis = new Enfermedad(){Nombre = "Amigdalitis", Estado = new DiagnosticoService().Ejecute(new DiagnosticoRequest(){NombreDelArchivo = "AmigdalitisWeights", InputsValues = sintomasAmigdalitis}).Diagnostico};
            var asma = new Enfermedad(){Nombre = "Asma", Estado = new DiagnosticoService().Ejecute(new DiagnosticoRequest(){NombreDelArchivo = "AsmaWeights", InputsValues = sintomasAsma}).Diagnostico};
            var bronquitis = new Enfermedad(){Nombre = "Bronquitis", Estado = new DiagnosticoService().Ejecute(new DiagnosticoRequest(){NombreDelArchivo = "BronquitisWeights", InputsValues = sintomasBronquitis}).Diagnostico};
            var cancerDePulmon = new Enfermedad(){Nombre = "Cancer De Pulmon", Estado = new DiagnosticoService().Ejecute(new DiagnosticoRequest(){NombreDelArchivo = "CancerDePulmonWeights", InputsValues = sintomasCancerDePulmon}).Diagnostico};
            var covid19 = new Enfermedad(){Nombre = "Covid-19", Estado = new DiagnosticoService().Ejecute(new DiagnosticoRequest(){NombreDelArchivo = "Covid19Weights", InputsValues = sintomasCovid19}).Diagnostico};
            var enfisemaPulmonar = new Enfermedad(){Nombre = "Enfisema Pulmonar", Estado = new DiagnosticoService().Ejecute(new DiagnosticoRequest(){NombreDelArchivo = "EnfisemaPulmonarWeights", InputsValues = sintomasEnfisemaPulmonar}).Diagnostico};
            var epoc = new Enfermedad(){Nombre = "EPOC", Estado = new DiagnosticoService().Ejecute(new DiagnosticoRequest(){NombreDelArchivo = "EPOCWeights", InputsValues = sintomasEPOC}).Diagnostico};
            var faringitis = new Enfermedad(){Nombre = "Faringitis", Estado = new DiagnosticoService().Ejecute(new DiagnosticoRequest(){NombreDelArchivo = "FaringitisWeights", InputsValues = sintomasFaringitis}).Diagnostico};
            var gripe = new Enfermedad(){Nombre = "Gripe", Estado = new DiagnosticoService().Ejecute(new DiagnosticoRequest(){NombreDelArchivo = "GripeWeights", InputsValues = sintomasGripe}).Diagnostico};
            var laringitis = new Enfermedad(){Nombre = "Laringitis", Estado = new DiagnosticoService().Ejecute(new DiagnosticoRequest(){NombreDelArchivo = "LaringitisWeights", InputsValues = sintomasLaringitis}).Diagnostico};
            var neumonia = new Enfermedad(){Nombre = "Neumonia", Estado = new DiagnosticoService().Ejecute(new DiagnosticoRequest(){NombreDelArchivo = "NeumoniaWeights", InputsValues = sintomasNeumonia}).Diagnostico};
            var resfriadoComun = new Enfermedad(){Nombre = "Resfriado Comun", Estado = new DiagnosticoService().Ejecute(new DiagnosticoRequest(){NombreDelArchivo = "ResfriadoComunWeights", InputsValues = sintomasResfriadoComun}).Diagnostico};
            var rinitis = new Enfermedad(){Nombre = "Rinitis", Estado = new DiagnosticoService().Ejecute(new DiagnosticoRequest(){NombreDelArchivo = "RinitisWeights", InputsValues = sintomasRinitis}).Diagnostico};
            var rinosinositis = new Enfermedad(){Nombre = "Rinosinositis", Estado = new DiagnosticoService().Ejecute(new DiagnosticoRequest(){NombreDelArchivo = "RinosinositisWeights", InputsValues = sintomasRinosinositis}).Diagnostico};
            var sinusitis = new Enfermedad(){Nombre = "Sinusitis", Estado = new DiagnosticoService().Ejecute(new DiagnosticoRequest(){NombreDelArchivo = "SinusitisWeights", InputsValues = sintomasSinusitis}).Diagnostico};
            var listaDiagnostico = new List<Enfermedad>();
            listaDiagnostico.Add(amigdalitis);
            listaDiagnostico.Add(asma);
            listaDiagnostico.Add(bronquitis);
            listaDiagnostico.Add(cancerDePulmon);
            listaDiagnostico.Add(covid19);
            listaDiagnostico.Add(enfisemaPulmonar);
            listaDiagnostico.Add(epoc);
            listaDiagnostico.Add(faringitis);
            listaDiagnostico.Add(gripe);
            listaDiagnostico.Add(laringitis);
            listaDiagnostico.Add(neumonia);
            listaDiagnostico.Add(resfriadoComun);
            listaDiagnostico.Add(rinitis);
            listaDiagnostico.Add(rinosinositis);
            listaDiagnostico.Add(sinusitis);
            return new DiagnosticoGeneralResponse(){Diagnostico = listaDiagnostico};
        }
    }
    
    public class DiagnosticoGeneralRequest
    {
        public int[] Sintomas { get; set; }
    }

    public class DiagnosticoGeneralResponse
    {
        public List<Enfermedad> Diagnostico { get; set; }
    }
}