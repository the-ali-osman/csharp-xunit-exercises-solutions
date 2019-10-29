﻿using CSharpUnitTestExercises;
using Xunit;
using System.Numerics;

namespace Tests
{
    public class NumbersTest
    {
        Numbers exercise = new Numbers();

        public static BigInteger bigFibonaci = BigInteger.Parse("2531162323732361242240155003520607291766356485802485278951929841991312781760541315230153423463758831637443488219211037689033673531462742885329724071555187618026931630449193158922771331642302030331971098689235780843478258502779200293635651897483309686042860996364443514558772156043691404155819572984971754278513112487985892718229593329483578531419148805380281624260900362993556916638613939977074685016188258584312329139526393558096840812970422952418558991855772306882442574855589237165219912238201311184749075137322987656049866305366913734924425822681338966507463855180236283582409861199212323835947891143765414913345008456022009455704210891637791911265475167769704477334859109822590053774932978465651023851447920601310106288957894301592502061560528131203072778677491443420921822590709910448617329156135355464620891788459566081572824889514296350670950824208245170667601726417091127999999941149913010424532046881958285409468463211897582215075436515584016297874572183907949257286261608612401379639484713101138120404671732190451327881433201025184027541696124114463488665359385870910331476156665889459832092710304159637019707297988417848767011085425271875588008671422491434005115288334343837778792282383576736341414410248994081564830202363820504190074504566612515965134665683289356188727549463732830075811851574961558669278847363279870595320099844676879457196432535973357128305390290471349480258751812890314779723508104229525161740643984423978659638233074463100366500571977234508464710078102581304823235436518145074482824812996511614161933313389889630935320139507075992100561077534028207257574257706278201308302642634678112591091843082665721697117838726431766741158743554298864560993255547608496686850185804659790217122426535133253371422250684486113457341827911625517128815447325958547912113242367201990672230681308819195941016156001961954700241576553750737681552256845421159386858399433450045903975167084252876848848085910156941603293424067793097271128806817514906531652407763118308162377033463203514657531210413149191213595455280387631030665594589183601575340027172997222489081631144728873621805528648768511368948639522975539046995395707688938978847084621586473529546678958226255042389998718141303055036060772003887773038422366913820397748550793178167220193346017430024134496141145991896227741842515718997898627269918236920453493946658273870473264523119133765447653295022886429174942653014656521909469613184983671431465934965489425515981067546087342348350724207583544436107294087637975025147846254526938442435644928231027868701394819091132912397475713787593612758364812687556725146456646878912169274219209708166678668152184941578590201953144030519381922273252666652671717526318606676754556170379350956342095455612780202199922615392785572481747913435560866995432578680971243966868110016581395696310922519803685837460795358384618017215468122880442252343684547233668502313239328352671318130604247460452134121833305284398726438573787798499612760939462427922917659263046333084007208056631996856315539698234022953452211505675629153637867252695056925345220084020071611220575700841268302638995272842160994219632684575364180160991884885091858259996299627148614456696661412745040519981575543804847463997422326563897043803732970397488471644906183310144691243649149542394691524972023935190633672827306116525712882959108434211652465621144702015336657459532134026915214509960877430595844287585350290234547564574848753110281101545931547225811763441710217452979668178025286460158324658852904105792472468108996135476637212057508192176910900422826969523438985332067597093454021924077101784215936539638808624420121459718286059401823614213214326004270471752802725625810953787713898846144256909835116371235019527013180204030167601567064268573820697948868982630904164685161783088076506964317303709708574052747204405282785965604677674192569851918643651835755242670293612851920696732320545562286110332140065912751551110134916256237884844001366366654055079721985816714803952429301558096968202261698837096090377863017797020488044826628817462866854321356787305635653577619877987998113667928954840972022833505708587561902023411398915823487627297968947621416912816367516125096563705174220460639857683971213093125");

        [Theory(DisplayName = "Calculate the VAT for {value}")]
        [
            InlineData(100, 20),
            InlineData(150.00, 30.00),
            InlineData(0.00, 0.00),
            InlineData(123.49, 24.70)
        ]
        public void calculateVAT(decimal value, decimal expected)
        {
            Assert.Equal(expected, exercise.calculateVAT(value));
        }

        [Theory(DisplayName = "Calculate the hypotenuse for sides {sideA} and {sideB}")]
        [
            InlineData(3, 4, 5),
            InlineData(4, 2, 4.472),
            InlineData(1.23, 2.67, 2.94),
            InlineData(0, 6, 6)
        ]
        public void hypotenuseLength(double sideA, double sideB, double expected)
        {
            Assert.Equal(expected, exercise.hypotenuseLength(sideA, sideB), 2);

        }

        /// <summary>
        /// </summary>
        /// <param name="n"></param>
        /// <param name="expectedString">Note this is a string, due to not being able to pass a BigInteger in to the InlineData</param>
        [Theory(DisplayName = "Calculate the Fibonacci number at position {n}")]
        [
            InlineData(1, "1"),
            InlineData(2, "1"),
            InlineData(5, "5"),
            InlineData(10, "55"),
            InlineData(17, "1597"),
            //InlineData(20000, "2531162323732361242240155003520607291766356485802485278951929841991312781760541315230153423463758831637443488219211037689033673531462742885329724071555187618026931630449193158922771331642302030331971098689235780843478258502779200293635651897483309686042860996364443514558772156043691404155819572984971754278513112487985892718229593329483578531419148805380281624260900362993556916638613939977074685016188258584312329139526393558096840812970422952418558991855772306882442574855589237165219912238201311184749075137322987656049866305366913734924425822681338966507463855180236283582409861199212323835947891143765414913345008456022009455704210891637791911265475167769704477334859109822590053774932978465651023851447920601310106288957894301592502061560528131203072778677491443420921822590709910448617329156135355464620891788459566081572824889514296350670950824208245170667601726417091127999999941149913010424532046881958285409468463211897582215075436515584016297874572183907949257286261608612401379639484713101138120404671732190451327881433201025184027541696124114463488665359385870910331476156665889459832092710304159637019707297988417848767011085425271875588008671422491434005115288334343837778792282383576736341414410248994081564830202363820504190074504566612515965134665683289356188727549463732830075811851574961558669278847363279870595320099844676879457196432535973357128305390290471349480258751812890314779723508104229525161740643984423978659638233074463100366500571977234508464710078102581304823235436518145074482824812996511614161933313389889630935320139507075992100561077534028207257574257706278201308302642634678112591091843082665721697117838726431766741158743554298864560993255547608496686850185804659790217122426535133253371422250684486113457341827911625517128815447325958547912113242367201990672230681308819195941016156001961954700241576553750737681552256845421159386858399433450045903975167084252876848848085910156941603293424067793097271128806817514906531652407763118308162377033463203514657531210413149191213595455280387631030665594589183601575340027172997222489081631144728873621805528648768511368948639522975539046995395707688938978847084621586473529546678958226255042389998718141303055036060772003887773038422366913820397748550793178167220193346017430024134496141145991896227741842515718997898627269918236920453493946658273870473264523119133765447653295022886429174942653014656521909469613184983671431465934965489425515981067546087342348350724207583544436107294087637975025147846254526938442435644928231027868701394819091132912397475713787593612758364812687556725146456646878912169274219209708166678668152184941578590201953144030519381922273252666652671717526318606676754556170379350956342095455612780202199922615392785572481747913435560866995432578680971243966868110016581395696310922519803685837460795358384618017215468122880442252343684547233668502313239328352671318130604247460452134121833305284398726438573787798499612760939462427922917659263046333084007208056631996856315539698234022953452211505675629153637867252695056925345220084020071611220575700841268302638995272842160994219632684575364180160991884885091858259996299627148614456696661412745040519981575543804847463997422326563897043803732970397488471644906183310144691243649149542394691524972023935190633672827306116525712882959108434211652465621144702015336657459532134026915214509960877430595844287585350290234547564574848753110281101545931547225811763441710217452979668178025286460158324658852904105792472468108996135476637212057508192176910900422826969523438985332067597093454021924077101784215936539638808624420121459718286059401823614213214326004270471752802725625810953787713898846144256909835116371235019527013180204030167601567064268573820697948868982630904164685161783088076506964317303709708574052747204405282785965604677674192569851918643651835755242670293612851920696732320545562286110332140065912751551110134916256237884844001366366654055079721985816714803952429301558096968202261698837096090377863017797020488044826628817462866854321356787305635653577619877987998113667928954840972022833505708587561902023411398915823487627297968947621416912816367516125096563705174220460639857683971213093125")
        ]
        public void fibonaci(int n, string expectedString)
        {
            BigInteger expected = BigInteger.Parse(expectedString);
            Assert.Equal(expected, exercise.fibonacci(n));
        }
    }
}