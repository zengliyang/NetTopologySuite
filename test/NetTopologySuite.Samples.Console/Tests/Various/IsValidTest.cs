using System;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using NetTopologySuite.Operation.Polygonize;
using NetTopologySuite.Samples.SimpleTests;
using NUnit.Framework;

namespace NetTopologySuite.Samples.Tests.Various
{
    [TestFixture]
    public class IsValidTest : BaseSamples
    {
        public IsValidTest() : base(new NtsGeometryServices(new PrecisionModel(PrecisionModels.Fixed)))
        { }

        [Test]
        public void IsCCWBugTest()
        {
            var g = Reader.Read("POLYGON ((60.0 40.0, 60.0 240.0, 460.0 240.0, 460.0 40.0, 60.0 40.0), (260.0 200.0, 340.0 60.0, 400.0 120.0, 260.0 200.0), (260.0 200.0, 120.0 100.0, 200.0 60.0, 260.0 200.0))");
            Assert.IsNotNull(g);
            bool result = g.IsValid;
            Assert.IsTrue(result);
        }

        [Test]
        public void SimpleContainerTest()
        {
            const string wktPoint = @"POINT(-93.4224469 41.873883)";
            const string wktPolygon = @"POLYGON((-93.4252049042723
        41.8704201522236,-93.4252045886767 41.8704218292759,-93.4251944663897
        41.8704537436275,-93.4251912197049 41.8704751660195,-93.4251948772194
        41.8704965513943,-93.4252023698805 41.8705187509512,-93.4252031837553
        41.8705225189422,-93.4252013741425 41.8705260880256,-93.4251919984311
        41.8705406212441,-93.4251846877274 41.870554964673,-93.4251807415669
        41.8705700276367,-93.4251610235833 41.8707058897986,-93.4251612742548
        41.8707269111328,-93.4252067472159 41.8709954862244,-93.4251863485251
        41.8708750062709,-93.4251848466664 41.8708762908204,-93.4251814703271
        41.8708798411836,-93.4251813748423 41.8708841964667,-93.425184280435
        41.8709100287988,-93.4251831539811 41.8709319742527,-93.4251749552422
        41.8709530635708,-93.4251616935005 41.870976184821,-93.4251599358149
        41.8709804064762,-93.4251628997049 41.8709842327966,-93.4251895738534
        41.8710116852033,-93.425193635959 41.8710150578611,-93.4251995752811
        41.8710159992246,-93.4252074274666 41.8710166126567,-93.4252210606089
        41.8720660100162,-93.4252205912993 41.8720720702808,-93.4251880495579
        41.872265100336,-93.4251838686256 41.8722768053143,-93.4251045552961
        41.8724184221462,-93.425098662675 41.8724265021885,-93.4248948199516
        41.8726483991353,-93.4248890453106 41.8726537556485,-93.4247108452105
        41.872795354139,-93.4247025228298 41.8728008485359,-93.4242909335975
        41.873025633358,-93.4242856074445 41.873028716465,-93.4237160047944
        41.8733779010074,-93.4237102611061 41.8733810175834,-93.4234195707745
        41.8735199614456,-93.423415606449 41.87352170068,-93.4226517008991
        41.8738281659771,-93.4226384031757 41.8738320598293,-93.422467020796
        41.8738653386381,-93.4224582647299 41.8738665305927,-93.4224133086026
        41.8738701102812,-93.4224097033486 41.8738619707344,-93.4224076078678
        41.8738583702397,-93.4224028451526 41.8738567133354,-93.4218775515979
        41.8737156048709,-93.4218731370963 41.8737146973482,-93.4218685889793
        41.8737143041044,-93.42183119329 41.8737132261088,-93.4218256665677
        41.8737134589251,-93.4218211788643 41.8737158810341,-93.4218001007567
        41.8737297059474,-93.4217960676661 41.8737329518983,-93.4217952651938
        41.8737373408247,-93.4217942243631 41.8737604067779,-93.4217918066286
        41.8737755718807,-93.421785995501 41.8737902136688,-93.4217769580596
        41.873803911162,-93.4217615185511 41.8738230308915,-93.4217591091977
        41.873826795763,-93.4217609126713 41.8738307454565,-93.4217657528559
        41.8738387225474,-93.4215861414162 41.8738038429246,-93.4215668071151
        41.8738013223973,-93.4215471818151 41.8738011808854,-93.4209719837377
        41.8738321311546,-93.4209688555411 41.8738322384827,-93.4204562370128
        41.8738398552622,-93.420438200035 41.873841141465,-93.4203366269377
        41.8738542016968,-93.4203154869866 41.8738584265833,-93.4200173195471
        41.8739403294419,-93.4200126606169 41.8739412976035,-93.4200078537452
        41.8739416914026,-93.4195734083426 41.8739508396298,-93.4195612437284
        41.8739501702688,-93.4194534359162 41.8739359118352,-93.4194997454025
        41.8738684456478,-93.4195017766702 41.8738646324802,-93.4194997296961
        41.8738608240073,-93.4194796156393 41.8738317416152,-93.4194761174718
        41.8738277865413,-93.4194754592426 41.8738273069659,-93.4194600947936
        41.8738136428908,-93.4194487590572 41.8737981493136,-93.4194356266997
        41.8738029920358,-93.4194135707879 41.8738075232658,-93.4193907666262
        41.8738088580361,-93.4193680358109 41.8738069482571,-93.4193461972958
        41.8738018627352,-93.4193370867838 41.8737990071934,-93.4193321892472
        41.8738001860736,-93.4193124446989 41.8738064279494,-93.4193080470773
        41.8738081560318,-93.4193046561677 41.8738108701041,-93.4192738907502
        41.8738400565964,-93.4192574522145 41.8738528330795,-93.4192426928691
        41.8738605075661,-93.4190969793893 41.8737751277868,-93.419091849215
        41.873771753445,-93.4189266353222 41.8736499730052,-93.4189196964212
        41.8736438527437,-93.4188370138157 41.8735561095034,-93.418832050838
        41.873549810764,-93.4187558563283 41.8734321706269,-93.4187527629448
        41.8734264123099,-93.4186918565983 41.873285647926,-93.418689179961
        41.8732758226561,-93.4186756233146 41.8731622213312,-93.4186756502494
        41.8731580506233,-93.4186767172506 41.8731539568197,-93.4188163739183
        41.8727992253419,-93.4188172671282 41.8727971444236,-93.4190677627168
        41.8722588330373,-93.4190695724474 41.8722557258512,-93.4190719897785
        41.8722528588262,-93.4191626522209 41.8721615012424,-93.4191715324621
        41.8721543360235,-93.4192813541089 41.8720831167264,-93.4192904398438
        41.8720782525092,-93.4194208195845 41.8720213524179,-93.4194283335857
        41.8720185782358,-93.4197783107842 41.8719113217688,-93.4197950399571
        41.8719050183585,-93.419810259779 41.8718968530794,-93.4201961375966
        41.8716537384591,-93.4202008601772 41.8716513135205,-93.4202065894559
        41.8716512650148,-93.4202531112403 41.8716543016209,-93.4202588643003
        41.8716551254288,-93.4202619959158 41.8716588254083,-93.4202759424096
        41.8716797661855,-93.4202865742242 41.8716928203978,-93.4203000058353
        41.8717043432108,-93.4203158505396 41.8717140028756,-93.4203453805483
        41.8717290793642,-93.4203671305076 41.8717378857342,-93.4203908280343
        41.8717431872122,-93.4204154746004 41.8717447604132,-93.4204400316884
        41.871742539048,-93.4204634645511 41.8717366167172,-93.4204847858127
        41.8717272429661,-93.4213430869941 41.8712550393925,-93.4213484257599
        41.8712524167342,-93.4217696326327 41.8710686413585,-93.4217819675583
        41.8710624681806,-93.4225011721807 41.8706524108576,-93.422504609009
        41.8706505898104,-93.4228038745353 41.8705034953921,-93.4228114819352
        41.8705003205078,-93.422918397479 41.8704630131536,-93.4229322313883
        41.8704596406827,-93.4230372029452 41.8704442436142,-93.4230429813516
        41.8704438272402,-93.4230487579878 41.8704442571176,-93.4232717005119
        41.8704774993309,-93.4232990833298 41.870479194736,-93.423326268146
        41.8704762096956,-93.4236253751133 41.8704167071638,-93.4236335610087
        41.870415525385,-93.4238145318733 41.870399012684,-93.4238210224332
        41.8703986850827,-93.4250122305449 41.8703867692288,-93.425015148263
        41.8703867928497,-93.4251551243301 41.8703904614261,-93.4251614184953
        41.8703911423719,-93.4251667433205 41.8703937415644,-93.4252015466182
        41.8704150901537,-93.425205330148 41.8704178891504,-93.4252048259347
        41.8704175161412,-93.4252049042723 41.8704201522236),(-93.4208870841416
        41.8724356341242,-93.4204504898438 41.8724299995943,-93.4197024469119
        41.8724199642879,-93.4196972546475 41.8724187961132,-93.4196353408064
        41.8724000931151,-93.4196198291984 41.8723939248574,-93.4195982913747
        41.8723872683468,-93.4195754419732 41.8723838351084,-93.419552135681
        41.8723837535633,-93.4195292442755 41.8723870267617,-93.4195076240148
        41.8723935322689,-93.4194880836107 41.8724030267448,-93.4194713539778
        41.8724151550461,-93.4194580608944 41.8724294635104,-93.4194487015946
        41.8724454169255,-93.4193439049526 41.8726846688587,-93.419395200573
        41.8725675603701,-93.4193877396226 41.8725704665946,-93.4193659535056
        41.8725753507093,-93.4193433275646 41.8725770881644,-93.4192665269722
        41.8725775398523,-93.4192603524051 41.8725780679252,-93.4192550160649
        41.8725804488741,-93.4192190574867 41.8726006370315,-93.4192151170512
        41.8726033114076,-93.4192156301849 41.872607271081,-93.4192232672457
        41.8726370206333,-93.4192253880039 41.8726562540265,-93.4192219780526
        41.8726753835933,-93.4192108643559 41.8727093579771,-93.4192100703796
        41.872713699906,-93.4192146768558 41.8727164111226,-93.4192461426288
        41.8727312573426,-93.419265721321 41.8727427710309,-93.4192817140852
        41.8727570476324,-93.419293437433 41.8727734770053,-93.4192988775902
        41.8727874668423,-93.4191329059232 41.8731663820577,-93.4191276849472
        41.8731843040893,-93.4191274300223 41.8732026450275,-93.4191321517247
        41.8732206442571,-93.4191702773132 41.8733142152074,-93.4191837698745
        41.8733361900205,-93.4192304374412 41.8733912269825,-93.419229433288
        41.8733927666126,-93.4192166441372 41.8734057897667,-93.4191916566367
        41.8734269561956,-93.4191884410569 41.8734302646578,-93.4191891480306
        41.8734343196234,-93.419195806784 41.8734561337928,-93.419198813257
        41.8734774597635,-93.4191949894282 41.8734987124909,-93.4191846527334
        41.8735285946617,-93.4191838107888 41.8735324447607,-93.419187360553
        41.8735353048818,-93.4192203304999 41.8735574436094,-93.4192256701439
        41.8735602904165,-93.4192321341885 41.8735611213189,-93.4193540307386
        41.8735664108143,-93.4193778314199 41.873569247953,-93.4194004007161
        41.873575568208,-93.4194208358789 41.8735851187759,-93.4194383195221
        41.8735975176438,-93.419452152316 41.8736122688698,-93.4194617809601
        41.8736287824197,-93.4194668203147 41.8736463977674,-93.419466919936
        41.8736470689857,-93.4194760195824 41.8736540390248,-93.4194759071328
        41.8736541210325,-93.4194854774525 41.8736612293223,-93.4194983633347
        41.8736753544259,-93.4195031993325 41.8736837086428,-93.4195144314412
        41.8736793033788,-93.4195373507007 41.8736742891635,-93.4195611428728
        41.873672751279,-93.4201248312579 41.8736782174628,-93.420130993152
        41.8736777829684,-93.4201355791947 41.8736746765217,-93.4201613321703
        41.873653059001,-93.4201648599462 41.8736494023375,-93.4201663231686
        41.8736443629005,-93.4201675701888 41.8736361010465,-93.4201754671183
        41.8736183283238,-93.4201881107788 41.8736021603025,-93.4202049545688
        41.8735882959423,-93.4202147937897 41.8735829872061,-93.4202246929138
        41.8735767894139,-93.4202477515228 41.8735595553436,-93.4202539726685
        41.8735538890089,-93.4202705697844 41.873541468662,-93.4202900750461
        41.8735316903226,-93.42031174756 41.8735249254134,-93.4203347641126
        41.8735214308941,-93.4203582504382 41.8735213395012,-93.4203813144277
        41.8735246547062,-93.4204030800139 41.8735312505837,-93.4204227204476
        41.8735408765945,-93.4204394897012 41.8735531671021,-93.4204416745214
        41.8735551153495,-93.4204463790795 41.87355790629,-93.4204902294489
        41.8735789021067,-93.4204952204885 41.8735808182804,-93.4205008069311
        41.8735812102933,-93.42301128543 41.8735781524808,-93.4230164520042
        41.8735778092075,-93.4230214609996 41.8735768024597,-93.4230551245979
        41.8735676262439,-93.4230602764925 41.8735657762103,-93.4230631849409
        41.8735620987199,-93.4230755586795 41.8735422320505,-93.4230773564861
        41.8735384904594,-93.4230762964724 41.8735345946511,-93.4230702913923
        41.8735196377041,-93.4230659424137 41.8735036880736,-93.4230655053245
        41.873487413881,-93.4230689943974 41.8734713466553,-93.4230779166186
        41.873445380668,-93.4230787729028 41.8734411693134,-93.4230744727682
        41.8734383736541,-93.4230327699652 41.873416340546,-93.4230275102874
        41.8734141286126,-93.4230215060696 41.8734136726635,-93.4227615124581
        41.8734139733128,-93.4228815784502 41.8733676687166,-93.4227806811426
        41.8734065807266,-93.4230760445901 41.8734054630616,-93.4230813975882
        41.8734050735237,-93.4230856826632 41.8734026442473,-93.4231152202784
        41.8733824496982,-93.4231191123381 41.8733791851228,-93.4231185956998
        41.8733748296328,-93.4231122312659 41.8733501568882,-93.4231100526547
        41.8733328490405,-93.4231123633808 41.8733155507669,-93.4231190773581
        41.8732989064876,-93.4231299444646 41.8732835362591,-93.4231445598611
        41.8732700126745,-93.4231623790725 41.8732588395328,-93.4231827382722
        41.8732504330711,-93.4232048790112 41.8732451064581,-93.4232279764732
        41.8732430581278,-93.4234417042937 41.8732396317651,-93.4234476086901
        41.8732390818086,-93.4234520058442 41.8732360858048,-93.4234780167991
        41.87321432125,-93.4234813137245 41.873210957771,-93.4234805245035
        41.8732068301756,-93.4234745982371 41.8731886299726,-93.4234713231299
        41.8731717108147,-93.423472384232 41.873154633905,-93.4234777433134
        41.8731380144445,-93.4234872073084 41.8731224511541,-93.4235004352714
        41.8731085047051,-93.4235169506596 41.8730966775217,-93.4235361585012
        41.8730873956807,-93.4235573668289 41.8730809935621,-93.4235798116086
        41.8730777018034,-93.4236962916709 41.8730690794396,-93.4237020396927
        41.8730682038061,-93.4237051107155 41.8730644681774,-93.4237182387602
        41.8730440840845,-93.4237201066225 41.8730403450043,-93.4237190962689
        41.8730364258915,-93.4237171113154 41.8730312981414,-93.4237127302435
        41.8730132856517,-93.4237133129601 41.8729949831347,-93.4237188353853
        41.872977146782,-93.4237290693494 41.8729605135243,-93.4237435920205
        41.8729457705846,-93.4237618033748 41.8729335270843,-93.4237829509878
        41.8729242888778,-93.4238061611212 41.8729184376519,-93.4238304748222
        41.8729162151563,-93.4239589016107 41.8729143057101,-93.4239644127474
        41.8729138378755,-93.4239697124109 41.8729126147705,-93.4240024065487
        41.8729024930713,-93.4240082450175 41.872900067987,-93.4240120463081
        41.8728959629666,-93.4240189960191 41.8728862451295,-93.4240210522714
        41.8728826189639,-93.4240203216228 41.872878718604,-93.4240159142763
        41.8728645928883,-93.4240128403466 41.8728473129274,-93.4240142776292
        41.8728299140335,-93.4240201722822 41.8728130479413,-93.4240303034983
        41.8727973464269,-93.424044291776 41.8727833976428,-93.4240616131358
        41.8727717240869,-93.4240816187478 41.8727627630304,-93.4241035592354
        41.8727568501392,-93.424126612746 41.8727542068996,-93.424194150818
        41.8727514127599,-93.4241993529452 41.8727508479525,-93.4242039659304
        41.8727489640076,-93.4242313352164 41.8727352956486,-93.4242364284873
        41.8727320658399,-93.4242390852299 41.8727274854207,-93.4242434953501
        41.8727166193551,-93.4242446584849 41.8727120682403,-93.4242423383631
        41.872704805503,-93.4242378296534 41.8726913540726,-93.4242365521323
        41.8726743495037,-93.4242395802857 41.8726574692006,-93.4242449117233
        41.8726455509592,-93.4243511207047 41.8725880867061,-93.4243548976868
        41.8725877695432,-93.4245533622779 41.8725852186763,-93.4245593705201
        41.8725846696181,-93.424563805743 41.8725815909068,-93.4246012545241
        41.8725495400984,-93.4246047050754 41.8725458729739,-93.4246033573454
        41.872541504414,-93.4245965561398 41.8725267390515,-93.4245913478126
        41.8725108892297,-93.4245900518579 41.8724945971345,-93.4245927108255
        41.8724783977205,-93.4246003684798 41.8724519086947,-93.4246010066206
        41.8724476550214,-93.4245965217194 41.8724449933004,-93.4245527485082
        41.8724240244069,-93.4245477255838 41.8724220978964,-93.4245421031349
        41.8724217155676,-93.4208870841416 41.8724356341242),(-93.4192557005874
        41.8728860404338,-93.4192517738604 41.8728885030989,-93.4192316535636
        41.8728968530734,-93.4192097763753 41.8729021920072,-93.4191869401851
        41.8729043251824,-93.4191253031 41.8729056478384,-93.4191199570662
        41.8729061329136,-93.4191157475125 41.872908643248,-93.4190819616882
        41.8729329121701,-93.4190780625782 41.8729363783874,-93.4190789683006
        41.8729408560156,-93.4190869620863 41.8729636645257,-93.4190908651678
        41.8729844768383,-93.4190882090529 41.8730053986299,-93.4190785265384
        41.8730390976159,-93.4190778951598 41.8730432567085,-93.419082185042
        41.873045947512,-93.4191187757531 41.8730646433075,-93.4191372239398
        41.8730762543055,-93.4191522091692 41.8730903784457,-93.4191607147421
        41.8731028942059,-93.4192557005874 41.8728860404338),(-93.4242521428096
        41.8709201736071,-93.4242514694803 41.8709158991529,-93.4242419330463
        41.8708836377243,-93.4242391177842 41.8708624687927,-93.4242430236301
        41.8708413968033,-93.4242502682079 41.8708207122768,-93.4242511455668
        41.8708166935025,-93.4242481030991 41.8708133157374,-93.4242231384712
        41.8707905606972,-93.4242187997491 41.8707873609043,-93.4242127703634
        41.8707866931061,-93.4241346175012 41.8707842471854,-93.4241292922226
        41.8707844435167,-93.4241248799971 41.8707866808148,-93.4240901075826
        41.8708080103253,-93.424086375367 41.8708107626315,-93.4240870153
        41.8708146521309,-93.4240958922729 41.8708452100554,-93.424098597497
        41.8708666023168,-93.4240944464083 41.8708878647417,-93.4240867278873
        41.8709091675878,-93.4240858021456 41.8709132154711,-93.4240888683084
        41.8709166231094,-93.4241143452632 41.8709398262683,-93.4241184670278
        41.870942895316,-93.4241241878441 41.8709436868213,-93.4241735344762
        41.8709467536389,-93.4241854172703 41.8709466109134,-93.4242151203326
        41.870944044338,-93.4242214818433 41.8709429467027,-93.4242265830706
        41.8709399011627,-93.4242485006204 41.8709235072776,-93.4242521428096
        41.8709201736071))";

            var reader = new WKTReader();

            var point = reader.Read(wktPoint);
            Assert.IsTrue(point.IsValid);

            var polygon = reader.Read(wktPolygon);
            Assert.IsFalse(polygon.IsValid);

            var fixedPol = polygon.Buffer(0);
            Assert.IsTrue(fixedPol.IsValid);

            bool result = fixedPol.Contains(point);
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPointInRingTest()
        {
            const string wkt1 =
                @"LINESTRING(159084.138183715 215384.465334836,159085.255551952
215382.299118879,159084.287081382 215380.125720536,159081.909029527
215380.063184668,159080.685184241 215382.030015885,159081.870080819
215384.260803017,159084.138183715 215384.465334836)";
            const string wkt2 =
                @"LINESTRING(159081.417 215432.901,159081.484 215412.286,159069.343
215411.729,159063.929 215411.79,159063.765 215441.011,159055.84
215440.909,159055.756 215439.794,159050.254 215439.759,159050.231
215426.571,159029.91 215426.438,159029.894 215420.862,159028.749
215420.841,159028.787 215412.904,159050.376 215412.995,159050.394
215404.475,159051.839 215404.512,159051.721 215397.907,159050.448
215397.876,159050.48 215385.756,159037.29 215385.669,159037.274
215380.139,159036.129 215380.118,159036.18 215372.161,159050.58
215372.256,159050.641 215357.846,159061.806 215357.884,159061.764
215355.578,159063.703 215355.583,159063.834 215344.331,159062.797
215344.264,159062.878 215338.481,159063.885 215338.48,159063.94
215333.569,159062.002 215333.52,159062.061 215329.565,159063.973
215329.565,159064.019 215324.529,159063.008 215324.569,159062.948
215318.85,159064.078 215318.847,159064.229 215304.453,159074.999
215304.543,159074.895 215315.988,159082.789 215316.117,159082.751291265
215325.067329746,159076.257853729 215325.010585012,159076.145672787
215330.246673065,159077.726943351 215330.292687136,159077.64265916
215336.096838446,159075.46670601 215336.028874838,159075.17015073
215349.460814847,159091.770139291 215349.583804507,159091.835913025
215356.268745225,159114.649 215356.642,159114.529 215396.632,159109.671
215396.625,159109.501 215398.902,159112.021 215398.92,159111.982
215404.407,159112.999 215404.421,159113.001 215412.415,159095.019
215412.366,159094.928 215434.091,159086.987 215433.984,159086.928
215432.972,159081.417 215432.901)";
            const string wkt3 = @"LINESTRING(159063.929280482 215399.247659686,159103.333615111
215398.947801304,159103.342074891 215397.380179598,159101.054815857
215397.403687265,159101.283398228 215370.145108237,159064.458615271
215370.009119945,159063.929280482 215399.247659686)";

            var reader = new WKTReader(new NtsGeometryServices(new PrecisionModel(PrecisionModels.Fixed)));
            string[] wkts = new[] { wkt1, wkt2, wkt3,};
            var polygonizer = new Polygonizer();
            foreach (string wkt in wkts)
            {
                var geom = (LineString) reader.Read(wkt);
                Assert.IsNotNull(geom);
                Assert.IsTrue(geom.IsValid);
                Assert.AreEqual(geom.Factory.PrecisionModel, GeometryFactory.Fixed.PrecisionModel);
                polygonizer.Add(geom);
            }

            var polys = polygonizer.GetPolygons();
            Console.WriteLine("Polygons formed (" + polys.Count + "):");
            foreach (var obj in polys)
            {
                Assert.IsNotNull(obj);
                Console.WriteLine(obj);
            }
        }
    }
}
