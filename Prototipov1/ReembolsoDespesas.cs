using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace Prototipov1
{
    internal class ReembolsoDespesas
    {
        public string Nome, Ong, Descr_Gasto1, Descr_Gasto2, Descr_Gasto3, Descr_Gasto4,
                      Descr_Gasto5, Descr_Gasto6, Descr_Gasto7, Descr_Gasto8, Data;
        public double Valor_Gasto1, Valor_Gasto2, Valor_Gasto3, Valor_Gasto4, 
                      Valor_Gasto5, Valor_Gasto6, Valor_Gasto7, Valor_Gasto8, Valor_total;

        public void New()
        {

        }
        public void New (string _Nome, string _Ong, string _Descr_Gasto1, string _Descr_Gasto2, string _Descr_Gasto3, string _Descr_Gasto4,
                          string _Descr_Gasto5, string _Descr_Gasto6, string _Descr_Gasto7, string _Descr_Gasto8, string _Data, double _Valor_Gasto1,
                          double _Valor_Gasto2, double _Valor_Gasto3, double _Valor_Gasto4, double _Valor_Gasto5, double _Valor_Gasto6, double _Valor_Gasto7,
                          double _Valor_Gasto8, double _Valor_total)
        {

                Nome = _Nome;
                Ong = _Ong;
                Descr_Gasto1 = _Descr_Gasto1;
                Descr_Gasto2 = _Descr_Gasto2;
                Descr_Gasto3 = _Descr_Gasto3;
                Descr_Gasto4 = _Descr_Gasto4;
                Descr_Gasto5 = _Descr_Gasto5;
                Descr_Gasto6 = _Descr_Gasto6;
                Descr_Gasto7 = _Descr_Gasto7;
                Descr_Gasto8 = _Descr_Gasto8;
                Data = _Data;
                Valor_Gasto1 = _Valor_Gasto1;
                Valor_Gasto2 = _Valor_Gasto2;
                Valor_Gasto3 = _Valor_Gasto3;
                Valor_Gasto4 = _Valor_Gasto4;
                Valor_Gasto5 = _Valor_Gasto5;
                Valor_Gasto6 = _Valor_Gasto6;
                Valor_Gasto7 = _Valor_Gasto7;
                Valor_Gasto8 = _Valor_Gasto8;
                Valor_total = _Valor_total;
        }

        
    
    
    
    
    
    
    
    
    }




    
}
