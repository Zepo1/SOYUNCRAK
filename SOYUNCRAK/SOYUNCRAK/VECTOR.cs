using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SOYUNCRAK
{
    internal class VECTOR
    {
        const int MAXE = 100;
        int[] vector;
        int dimencion;
        public VECTOR()
        {
            vector = new int[MAXE];
            this.dimencion = 0;
        }
        public void  DIMENCIONAR (int DIM)
        {
            this.dimencion = DIM;
        }
        public void CARGARANDOM(int A , int B)
        {
            Random VR = new Random();
            for (int i =1; i<= dimencion; i++)
            {
                vector[i] = VR.Next(A, B );
            }

        }
        public String DESCARGAR()
        {
            String vec = " ";
            for ( int i =1; i <= dimencion; i ++ )
            {
                vec= vec + vector[i] + "|";
            }
            return vec;
        }
        public void eliminar (int pos)
        {
            if ( pos >= 1  && pos <= dimencion)
            {
                for ( int i = pos; i <= dimencion -1; i++)
                {
                    vector[i] = vector[i + 1];
                }
            }
            dimencion--;
        }
        public void EJ1 (int VI)
        {
            for ( int i =1;  i <= dimencion; i++)
            {
                vector[i] = VI;
                VI = VI * 3 ;
               
            }
        }
        public float EJ2 ()
        {
            float acumulador = 0;
            int Denominador = 2;
            float a = -1;float  b = 1;float c = 0 ; bool bandera = true;
            for ( int i =1;i<= dimencion; i++)
            {
                c = a + b;
                a = b;b = c;
                if (bandera == true)
                {
                    acumulador = acumulador + (c / Denominador);
                    bandera = false;
                }
                else
                {
                    acumulador=acumulador - (c /Denominador) ;
                    bandera = true;
                }
                Denominador = Denominador+2;
            }
            return acumulador;
        }
        public float EJ3(int multiplo)
        {
            float acumulador = 0; int denominador = 0;
            for ( int i =1;i<=dimencion; i++)
            {
                if ( i % multiplo == 0)
                {
                    acumulador = acumulador + vector[i];
                    denominador++;

                }

            }
            acumulador = acumulador/denominador;
            return acumulador;
        }
        public float EJ4(int A , int B )
        {
            float acumulador = 0; float denominador = 0;
            for ( int i =A; i<=B; i++)
            {
                acumulador = acumulador + vector[i];
                denominador++;
            }
            acumulador = acumulador / denominador;
            return acumulador;
        }
        public void EJ5 ( VECTOR V2 , VECTOR V3,int MULTIPLO)
        {
            int n1 =0; int n2 =0;
            for (int i = 1 ; i<=dimencion; i++)
            {
                if ( vector [i] % MULTIPLO == 0)
                {
                    n1++;
                    V2.vector[n1] = vector[i];
                }
                else
                {
                    n2++;
                    V3.vector[n2] = vector[i];
                }
            }
            V2.dimencion = n1;
            V3.dimencion = n2;
        }
        public void ORDENARACEN ( int A , int B )
        {
            for ( int i = A; i <= B-1; i++)
            {
               for ( int aux = i +1 ; aux <= B; aux++)
                {
                    if (vector[aux] < vector[i])
                    {
                        intercambio(aux, i);
                    }
                }
            }
        }
       public void intercambio ( int p1 , int p2)
        {
            int aux = vector [p1];
            vector [p1] = vector [p2];
            vector [p2] = aux;
        }
        public void ahorasi( int A , int B,VECTOR V2)
        {
            int i = 1;
            V2.dimencion= dimencion; int i2 = 1 ;int B2 = B; bool bandera = true; V2.dimencion = dimencion;
            ORDENARACEN(A,B);
            while (i <= dimencion)
            {
                if ( i == A)
                {
                    for (int aux = A; aux <= B; aux++)
                    {
                        if (bandera == true)
                        {
                            V2.vector[i2] = vector[aux];                           
                            bandera = false;
                        }
                        else
                        {
                            V2.vector[B2] = vector[aux];
                            B2--;
                            
                            bandera= true;
                        }
                        i2++;
                        i++;
                    }
                }

                V2.vector[i2]= vector[i];
                i2++;
                i++;
               
            }
        }
        public double UNOFIB ( int mult)
        {
            int a=-1; int b=1;   int c =0;
            for ( int i = 1 ; i <= dimencion ; i++)
            {
                c = a + b;
                a = b; b = c;
                vector[i] = c;
            }
            double denominador = 1; double acumulador = 0; double count =1;bool bandera = true;
            for ( int j = 1 ;j <= dimencion ; j++)
            {
                if (j % mult == 0 )
                {
                    if  ( bandera == true)
                    {
                        for (int k = 1; k <= vector[j]; k++)
                        {
                            denominador = denominador * vector[j];
                        }
                        acumulador = acumulador + (count / denominador);
                        count++;
                        bandera = false;
                    }
                    else
                    {
                        for (int k = 1; k <= vector[j]; k++)
                        {
                            denominador = denominador * vector[j];
                        }
                        acumulador = acumulador - (count / denominador);
                        count++;
                        bandera = true ;
                    }

                   
                }
            }
            return acumulador;
        }
        public void DELREPETRANGO(int A , int B)
        {
            for ( int i = A ; i <= B ; i++)
            {
                for( int j = i+1 ; j <= B ; j++)
                {
                    if( vector[j] ==  vector[i])
                    {
                        eliminar(j);
                        B--;
                    }
                }
            }
        }
        public void ORDENARDECEN(int A, int B)
        {
            for (int i = A; i <= B - 1; i++)
            {
                for (int aux = i + 1; aux <= B; aux++)
                {
                    if (vector[aux] > vector[i])
                    {
                        intercambio(aux, i);
                    }
                }
            }
        }
        public void FRECRANGO( int A , int B)
        {
            int count = 0;
            for (int i = A; i <= B; i++)
            {
                for (int j = i; j <= B; j++)
                {
                    if (vector[i] == vector[j])
                    {
                        count++;
                    }
                }
                vector[i] = count;
                count = 0;
            }
        }
        public int FRECRANGODig(int dig ,int A, int B)
        {
            int count = 0;
            for (int i = A; i <= B; i++)
            {
                if (vector[i] == dig)
                {
                    count++;
                }
            }
            return count;
        }
        public void PARCI2(int A, int B, VECTOR V2 , VECTOR V3)
        {
            int A1 = 1;int A2=1;
            ORDENARDECEN(A,B);
            
            DELREPETRANGO(A,B);
            for ( int i = A;i <= B ; i++)
            {
                V2.vector[A1] = vector[i];
                A1++;
            }
            for (int i = A; i <= B; i++)
            {

                V3.vector[A2] = FRECRANGODig(vector[i], A, B); ;
                A2++;

            }
            V2.dimencion = A1;
            V3.dimencion = A2;
        }
    }
}
