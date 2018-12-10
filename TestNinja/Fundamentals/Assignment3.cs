using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment3
    {
        /// <summary>
        /// Клиент отправляет деньги , либо снимает их.
        /// Если сумма достаточная в кошелке и в терминале, 
        /// операция выполняется успешно
        /// </summary>
        /// <param name="myMoney">Моя доступная сумма денег</param>
        /// <param name="sendMoney">Деньги которые хочу снять или перевести</param>
        /// <param name="terMoney">Имеющиеся деньги в терминале</param>
        /// <returns></returns>
        public SampleFunc SendMoney(int myMoney, int sendMoney,int terMoney)
        {
            if( myMoney>= sendMoney && terMoney>= sendMoney)
            {
                return new Complete();
            }
            return new Error();
        }
        public class Error: SampleFunc
        {
        }
        public class Complete: SampleFunc
        {
        }
        public class SampleFunc
        {
        }
    }
}
