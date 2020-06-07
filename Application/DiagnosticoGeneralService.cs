using System.Collections.Generic;
using Domain;

namespace Application
{
    public class DiagnosticoGeneralService
    {
        double[,] sintomasGripe = new double[1,9];
        double[,] sintomasResfriadoComun = new double[1,7];
        double[,] sintomasRinitis = new double[1,5];
        double[,] sintomasRinosinositis = new double[1,7];
        double[,] sintomasFaringitis = new double[1,8];
        double[,] sintomasAmigdalitis = new double[1,9];
        double[,] sintomasBronquitis = new double[1,7];
        double[,] sintomasEnfisemaPulmonar = new double[1,6];
        double[,] sintomasAsma = new double[1,5];
        double[,] sintomasNeumonia = new double[1,7];
        double[,] sintomasCancerDePulmon = new double[1,8];
        double[,] sintomasSinusitis = new double[1,9];
        double[,] sintomasLaringitis = new double[1,8];
        double[,] sintomasEPOC = new double[1,10];
        double[,] sintomasCovid19 = new double[1,11];
        
        public DiagnosticoGeneralResponse Ejecute(DiagnosticoGeneralRequest request)
        {
            MapearSintomas(request.Sintomas);
            return InicializarEnfermedades();
        }

        private void MapearSintomas(int[] Sintomas)
        {
            for (var sintoma = 0; sintoma < Sintomas.Length; sintoma++)
            {
                switch (sintoma)
                {
                    case 0:
                        sintomasEnfisemaPulmonar[0,5] = 1;
                        sintomasEPOC[0,8] = 1;
                        break;
                    case 1:
                        sintomasAmigdalitis[0,8] = 1;
                        break;
                    case 2:
                        sintomasGripe[0,2] = 1;
                        sintomasResfriadoComun[0,0] = 1;
                        sintomasRinitis[0,0] = 1;
                        sintomasBronquitis[0,1] = 1;
                        sintomasEnfisemaPulmonar[0,2] = 1;
                        sintomasSinusitis[0,6] = 1;
                        sintomasRinosinositis[0,1] = 1;
                        break;
                    case 3:
                        sintomasCovid19[0,6] = 1;
                        break;
                    case 4:
                        sintomasLaringitis[0,3] = 1;
                        break;
                    case 5:
                        sintomasCovid19[0,5] = 1;
                        break;
                    case 6:
                        sintomasFaringitis[0,0] = 1;
                        sintomasAmigdalitis[0,3] = 1;
                        sintomasFaringitis[0,6] = 1;
                        break;
                    case 7:
                        sintomasBronquitis[0,3] = 1;
                        sintomasEnfisemaPulmonar[0,0] = 1;
                        sintomasAsma[0,4] = 1;
                        sintomasNeumonia[0,6] = 1;
                        sintomasEPOC[0,0] = 1;
                        sintomasCovid19[0,10] = 1;
                        break;
                    case 8:
                        sintomasFaringitis[0,3] = 1;
                        break;
                    case 9:
                        sintomasGripe[0,6] = 1;
                        sintomasResfriadoComun[0,2] = 1;
                        sintomasRinosinositis[0,4] = 1;
                        sintomasFaringitis[0,6] = 1;
                        sintomasCancerDePulmon[0,7] = 1;
                        sintomasSinusitis[0,4] = 1;
                        break;
                    case 10:
                        sintomasResfriadoComun[0,6] = 1;
                        sintomasRinosinositis[0,6] = 1;
                        sintomasSinusitis[0,8] = 1;
                        sintomasLaringitis[0,6] = 1;
                        sintomasCovid19[0,4] = 1;
                        break;
                    case 11:
                        sintomasFaringitis[0,5] = 1;
                        break;
                    case 12:
                        sintomasNeumonia[0,0] = 1;
                        sintomasCancerDePulmon[0,4] = 1;
                        sintomasCovid19[0,8] = 1;
                        break;
                    case 13:
                        sintomasCancerDePulmon[0,6] = 1;
                        break;
                    case 14:
                        sintomasFaringitis[0,4] = 1;
                        break;
                    case 15:
                        sintomasSinusitis[0,5] = 1;
                        break;
                    case 16:
                        sintomasGripe[0,1] = 1;
                        sintomasFaringitis[0,4] = 1;
                        sintomasLaringitis[0,7] = 1;
                        break;
                    case 17:
                        sintomasRinosinositis[0,0] = 1;
                        break;
                    case 18:
                        sintomasGripe[0,5] = 1;
                        sintomasBronquitis[0,5] = 1;
                        sintomasNeumonia[0,3] = 1;
                        break;
                    case 19:
                        sintomasGripe[0,7] = 1;
                        sintomasResfriadoComun[0,5] = 1;
                        sintomasRinitis[0,2] = 1;
                        break;
                    case 20:
                        sintomasEPOC[0,3] = 1;
                        break;
                    case 21:
                        sintomasAsma[0,0] = 1;
                        sintomasCancerDePulmon[0,2] = 1;
                        break;
                    case 22:
                        sintomasGripe[0,8] = 1;
                        sintomasRinosinositis[0,3] = 1;
                        sintomasEnfisemaPulmonar[0,3] = 1;
                        sintomasBronquitis[0,2] = 1;
                        sintomasNeumonia[0,1] = 1;
                        sintomasSinusitis[0,3] = 1;
                        sintomasEPOC[0,5] = 1;
                        sintomasCovid19[0,2] = 1;
                        break;
                    case 23:
                        sintomasGripe[0,0] = 1;
                        sintomasResfriadoComun[0,1] = 1;
                        sintomasRinosinositis[0,5] = 1;
                        sintomasFaringitis[0,1] = 1;
                        sintomasBronquitis[0,4] = 1;
                        sintomasNeumonia[0,2] = 1;
                        sintomasSinusitis[0,1] = 1;
                        sintomasCovid19[0,0] = 1;
                        break;
                    case 24:
                        sintomasAmigdalitis[0,0] = 1;
                        break;
                    case 25:
                        sintomasEPOC[0,7] = 1;
                        break;
                    case 26:
                        sintomasCovid19[0,9] = 1;
                        break;
                    case 27:
                        sintomasEPOC[0,4] = 1;
                        break;
                    case 28:
                        sintomasFaringitis[0,2] = 1;
                        sintomasSinusitis[0,2] = 1;
                        sintomasLaringitis[0,5] = 1;
                        break;
                    case 29:
                        sintomasResfriadoComun[0,4] = 1;
                        sintomasRinosinositis[0,4] = 1;
                        sintomasCovid19[0,3] = 1;
                        break;
                    case 30:
                        sintomasBronquitis[0,6] = 1;
                        sintomasAsma[0,1] = 1;
                        sintomasNeumonia[0,4] = 1;
                        sintomasEPOC[0,2] = 1;
                        break;
                    case 31:
                        break;
                    case 32:
                        sintomasRinitis[0,4] = 1;
                        break;
                    case 33:
                        sintomasEnfisemaPulmonar[0,4] = 1;
                        break;
                    case 34:
                        sintomasLaringitis[0,1] = 1;
                        break;
                    case 35:
                        sintomasSinusitis[0,0] = 1;
                        break;
                    case 36:
                        sintomasCancerDePulmon[0,5] = 1;
                        sintomasEPOC[0,6] = 1;
                        sintomasCovid19[0,7] = 1;
                        break;
                    case 37:
                        sintomasFaringitis[0,1] = 1;
                        break;
                    case 38:
                        sintomasRinitis[0,1] = 1;
                        break;
                    case 39:
                        sintomasFaringitis[0,7] = 1;
                        break;
                    case 40:
                        sintomasCancerDePulmon[0,3] = 1;
                        sintomasLaringitis[0,0] = 1;
                        break;
                    case 41:
                        sintomasFaringitis[0,6] = 1;
                        sintomasLaringitis[0,4] = 1;
                        break;
                    case 42:
                        sintomasAsma[0,2] = 1;
                        sintomasEPOC[0,1] = 1;
                        break;
                    case 43:
                        sintomasGripe[0,4] = 1;
                        break;
                    case 44:
                        sintomasGripe[0,3] = 1;
                        sintomasResfriadoComun[0,3] = 1;
                        sintomasRinitis[0,3] = 1;
                        sintomasBronquitis[0,0] = 1;
                        sintomasEnfisemaPulmonar[0,1] = 1;
                        sintomasCancerDePulmon[0,0] = 1;
                        sintomasSinusitis[0,7] = 1;
                        break;
                    case 45:
                        sintomasFaringitis[0,2] = 1;
                        sintomasEPOC[0,9] = 1;
                        break;
                    case 46:
                        sintomasCancerDePulmon[0,1] = 1;
                        break;
                    case 47:
                        sintomasAsma[0,3] = 1;
                        sintomasLaringitis[0,2] = 1;
                        sintomasCovid19[0,1] = 1;
                        break;
                    case 48:
                        sintomasNeumonia[0,5] = 1;
                        break;
                    case 49:
                        sintomasFaringitis[0,7] = 1;
                        sintomasFaringitis[0,5] = 1;
                        break;
                        
                }
            }
        }

        private DiagnosticoGeneralResponse InicializarEnfermedades()
        {
            var amigdalitis = new Enfermedad(){Nombre = "Amigdalitis", Estado = new DiagnosticoAmigdalitisService().Ejecute(new DiagnosticoAmigdalitisRequest(){InputsValues = sintomasAmigdalitis}).Diagnostico};
            var asma = new Enfermedad(){Nombre = "Asma", Estado = new DiagnosticoAsmaService().Ejecute(new DiagnosticoAsmaRequest(){InputsValues = sintomasAsma}).Diagnostico};
            var bronquitis = new Enfermedad(){Nombre = "Bronquitis", Estado = new DiagnosticoBronquitisService().Ejecute(new DiagnosticoBronquitisRequest(){InputsValues = sintomasBronquitis}).Diagnostico};
            var cancerDePulmon = new Enfermedad(){Nombre = "Cancer De Pulmon", Estado = new DiagnosticoCancerDePulmonService().Ejecute(new DiagnosticoCancerDePulmonRequest(){InputsValues = sintomasCancerDePulmon}).Diagnostico};
            var covid19 = new Enfermedad(){Nombre = "Covid-19", Estado = new DiagnosticoCovid19Service().Ejecute(new DiagnosticoCovid19Request(){InputsValues = sintomasCovid19}).Diagnostico};
            var enfisemaPulmonar = new Enfermedad(){Nombre = "Enfisema Pulmonar", Estado = new DiagnosticoEnfisemaPulmonarService().Ejecute(new DiagnosticoEnfisemaPulmonarRequest(){InputsValues = sintomasEnfisemaPulmonar}).Diagnostico};
            var epoc = new Enfermedad(){Nombre = "EPOC", Estado = new DiagnosticoEPOCService().Ejecute(new DiagnosticoEPOCRequest(){InputsValues = sintomasEPOC}).Diagnostico};
            var faringitis = new Enfermedad(){Nombre = "Faringitis", Estado = new DiagnosticoFaringitisService().Ejecute(new DiagnosticoFaringitisRequest(){InputsValues = sintomasFaringitis}).Diagnostico};
            var gripe = new Enfermedad(){Nombre = "Gripe", Estado = new DiagnosticoGripeService().Ejecute(new DiagnosticoGripeRequest(){InputsValues = sintomasGripe}).Diagnostico};
            var laringitis = new Enfermedad(){Nombre = "Laringitis", Estado = new DiagnosticoLaringitisService().Ejecute(new DiagnosticoLaringitisRequest(){InputsValues = sintomasLaringitis}).Diagnostico};
            var neumonia = new Enfermedad(){Nombre = "Neumonia", Estado = new DiagnosticoNeumoniaService().Ejecute(new DiagnosticoNeumoniaRequest(){InputsValues = sintomasNeumonia}).Diagnostico};
            var resfriadoComun = new Enfermedad(){Nombre = "Resfriado Comun", Estado = new DiagnosticoResfriadoComunService().Ejecute(new DiagnosticoResfriadoComunRequest(){InputsValues = sintomasResfriadoComun}).Diagnostico};
            var rinitis = new Enfermedad(){Nombre = "Rinitis", Estado = new DiagnosticoRinitisService().Ejecute(new DiagnosticoRinitisRequest(){InputsValues = sintomasRinitis}).Diagnostico};
            var rinosinositis = new Enfermedad(){Nombre = "Rinosinositis", Estado = new DiagnosticoRinosinositisService().Ejecute(new DiagnosticoRinosinositisRequest(){InputsValues = sintomasRinosinositis}).Diagnostico};
            var sinusitis = new Enfermedad(){Nombre = "Sinusitis", Estado = new DiagnosticoSinusitisService().Ejecute(new DiagnosticoSinusitisRequest(){InputsValues = sintomasSinusitis}).Diagnostico};
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