namespace İsteğe_Bağlı_Parametreler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Optional Parameters
            /*
             Parametreli bir metot kullanırken parametrelerinin
            türlerine uygun verilmesi zorunludur.

            Eğer ki bir metodun parametrelerini zorunlu kılmak istemiyorsak
            bu özelliğe opsiyonel parametre denir.

            Bir parametrenin opsiyonel olması demek o parametrenin default değeri

            Metot parametrelerine = (assaign) operatörü ile değer atanırsa o parametre
            opsiyonel olur.

            Tüm parametreler opsiyonel olabilir.

            Birden fazla parametre durumunda 
            opsiyonel olanlar sağ tarafta tanımlanmalıdır.
            opsiyonel olmayanlar sol tarafta tanımlanmalıdır.

             */
            X();
            X(7);
            X(27, 3);



            #endregion
        }

        static public void X(int a = 1 , int b = 1)
        {

        }


    }
}
