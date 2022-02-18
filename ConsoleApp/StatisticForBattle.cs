using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    [Serializable]
    class StatisticForBattle
    {
        public double chanceCritc { get; set; }
        public double chanceBlock { get; set; }

        //Chance de critico: Vai comparar a DESTREZA+(AGILIDADE/2) dos dois oponentes,
        //    e vai comparar quem tem o maior atributo, depois vai pegar
        //     a diferença e ver qual a aporcentagem dela pelo total do
        //    atributo de quem ganhou.
        //    player1 x player2  
        //      150       70

        //    player1 tem 80 a mais que o player2;
        //    (80*100)/150 = 53,333% Esta vai ser a chance de critico do player1
        //    player2 vai ter metade da chance de critico do player1

        //Chance de bloqueio: Vai ser igual a chance de critico com diferença
        //    que no final o resultado dos ganhador sera metade, e o perdedor
        //    não terá chance de bloqueio; E os atributos serão (AGILIDADE+(FORÇA/2))

        //    Usando o exemplo anterior; Player1=26,666% de chance de bloqueio;
        //    Player2=0% chance de bloqueio.

    }
}
