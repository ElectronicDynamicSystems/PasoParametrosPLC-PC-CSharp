using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasoParametrosPLC_PC_CSharp;

namespace PasoParametrosPLC_PC_CSharp
{
    class ConexionPLC
    {
        /*Metodos de la clase ConexionPLC
         * 
         * Conexion(ip, rack slot);
         * Desconexion()
         * Passw(Contraseña string)
         * 
         * FormLeerEntradas(num db, pos inicial , bit leer)
         * FormLeerAnalogica(num db, pos inicial , tamaño db)
         * LeerByte(num db, pos inicial)
         * LeerTodo****
         * Escribir(num db, pos inicial,valor)
         * 
         * */
        S7Client client = new S7Client();
        int result;
        string consola;

        public bool conectar(string ip, int rack, int slot)
        {
            try {
                result = client.ConnectTo(ip, rack, slot);

                if (result == 0)//  if (ConnectResult.State == client.PLCClientConnectState.Connected)
                {
                    consola = ("\r\n Conectado");
                    return true;
                }
                else
                {
                    consola = ("\r\n Error al conectar+ :");
                    consola += (client.ErrorText(result));
                    return false;
                }
            } catch {
                consola = ("\r\n Error al conectar+ :");
                consola += (client.ErrorText(result));
                return false;
            }
            
        }

        public bool Desconexion()
        {
            try { client.Disconnect(); consola = " Cliente Desconectado \n"; return true; } // Disconnect the clien
            catch { consola = " Error al Desconectar \n "; return false; }
        }
        public string consolaMsg()
        {
            return consola;
        }



        // Funciones DB PLC

        public struct StructDB0 // Estructura de datos del DB del PLC 
        {
            public String SerialNumber;
            public short TestResult;
            public Single RealDetector;
            public byte byte20;
        }
        public struct StructDB2// Estructura de datos del DB del PLC 
        {
            public Int16 intword;
            public Int32 word;
        }

        public StructDB0 Lectura(int DbNumber,int offSetStart)
        {
            StructDB0 Result = new StructDB0();
            byte[] readBuffer = new byte[21];
            
            client.DBRead(DbNumber, offSetStart, readBuffer.Length, readBuffer);//Lectura de buffer
            //Extraer datos y meterlos en Struct
            Result.SerialNumber = S7.GetCharsAt(readBuffer, 0, 12);
            Result.TestResult = S7.GetIntAt(readBuffer, 12);
            Result.RealDetector = S7.GetRealAt(readBuffer, 14);
            Result.byte20 = S7.GetByteAt(readBuffer, 20);

            return Result;// Devuelve un objeto del tipo StructDB0 
        }
        public StructDB0 Lectura2(int DbNumber, int offSetStart)
        {
            StructDB0 Result = new StructDB0();
            byte[] readBuffer = new byte[4];

            client.DBRead(DbNumber, offSetStart, readBuffer.Length, readBuffer);//Lectura de buffer
            //Extraer datos y meterlos en Struct
            Result.SerialNumber = S7.GetIntAt(readBuffer,0).ToString();
            Result.TestResult = (short)S7.GetWordAt(readBuffer, 2);

            return Result;// Devuelve un objeto del tipo StructDB0 
        }

        public StructDB0 Escritura(int DbNumber, int offSetStart, StructDB0 estructura)
        {
            StructDB0 estructuraw = new StructDB0();
            estructuraw = estructura;
            ;
            byte[] writeBuffer = new byte[21];
            S7.SetCharsAt(writeBuffer, 0, estructuraw.SerialNumber);
            S7.SetIntAt(writeBuffer, 12, estructuraw.TestResult);
            S7.SetRealAt(writeBuffer, 14, estructuraw.RealDetector);
            S7.SetByteAt(writeBuffer, 20, estructuraw.byte20);
            result = client.DBWrite(DbNumber, offSetStart, writeBuffer.Length, writeBuffer);
            if (result != 0)
            {
                Console.WriteLine("Error: " + client.ErrorText(result));
            }
            return estructuraw;// Devuelve un objeto del tipo StructDB0 

        }
            public StructDB2 Escritura2(int DbNumber, int offSetStart, StructDB2 estructura)
        {
            StructDB2 estructuraw = new StructDB2();
            estructuraw = estructura;
            
            byte[] writeBuffer = new byte[4];
            S7.SetIntAt(writeBuffer, 0, estructuraw.intword);
            S7.SetWordAt(writeBuffer, 2, Convert.ToUInt16(estructuraw.word));
            result = client.DBWrite(DbNumber, offSetStart, writeBuffer.Length, writeBuffer);
            if (result != 0)
            {
                Console.WriteLine("Error: " + client.ErrorText(result));
            }
            return estructuraw;// Devuelve un objeto del tipo StructDB0 

        }

    }
}
