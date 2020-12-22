using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using NUnit.Framework;

namespace NetTopologySuite.Tests.Various
{
    [TestFixture]
    public class Issue26Tests
    {
        private const double distance = 0.01;
        private const int segments = 1; // Using 8 segments all works

        private WKTReader reader;

        [OneTimeSetUp]
        public void FixtureSetup()
        {
            reader = new WKTReader();
        }

        [Test, Category("Issue26")]
        public void TestBufferInvalid1()
        {
            var geom = reader.Read(
@"POLYGON((2697924.8808711283
227546.82352091197,2697924.8808709416 227546.82352097417,2697914.0812493595
227550.42337448979,2697914.0803210619 227550.42373623489,2697914.0785510424
227550.42452969193,2697914.0767414356 227550.42558087394,2697914.0751545215
227550.42674054191,2697914.07398362 227550.42774338531,2697914.0725798113
227550.42914719391,2697914.0709506571 227550.431288136,2697914.0699130595
227550.43311919068,2697914.0691634207 227550.43477821077,2697914.0686141043
227550.43636512483,2697914.0682816235 227550.43756118839,2697914.0678543774
227550.43957534854,2697914.067636719 227550.44165039063,2697914.067636719
227550.44360351563,2697914.0681498856 227550.44676579328,2697914.0687440257
227550.4485482137,2697919.7005032194 227567.93952725796,2697919.7008968792
227567.94055296137,2697919.7016903362 227567.9423229809,2697919.7024457334
227567.9437049155,2697919.703483331 227567.94529182956,2697919.7047819598
227567.94689040375,2697919.7061857684 227567.94829421234,2697919.7081996407
227567.94985012422,2697919.7099696603 227567.95088772188,2697919.711050781
227567.95143629843,2697919.7128818356 227567.95222975547,2697919.7159245033
227567.95301054147,2697919.7178776283 227567.95319364694,2697919.7188110352
227567.9532373047,2697919.7208251953 227567.9532373047,2697919.7230974915
227567.95297571679,2697919.7249285462 227567.9525484707,2697919.7258758727
227567.95227758357,2697929.7641934697 227564.53854526003,2697929.7951254398
227564.52855934843,2697929.795120893 227564.5285452648,2697929.7955873748
227564.52846477786,2697938.4046342866 227561.46649266753,2697939.0928287324
227561.60842668827,2697939.0940181781 227561.60859827008,2697939.0962154437
227561.60878137554,2697939.09856647 227561.60869963493,2697939.1009468413
227561.608333424,2697939.1020521689 227561.60809878219,2697953.9362806845
227557.5711114775,2697953.9376629735 227557.57062397568,2697953.9396160985
227557.5697694835,2697953.9413628443 227557.56878597435,2697953.9430107935
227557.56762630638,2697953.9438815983 227557.56693820781,2697953.9454685124
227557.56553439921,2697953.9473593566 227557.56328540784,2697953.9483359191
227557.56169849378,2697953.94912342 227557.56012276473,2697953.9499168769
227557.55810860457,2697953.9503951343 227557.55651840146,2697953.9508223804
227557.5545042413,2697953.9510400388 227557.55242919922,2697953.9510400388
227557.55041503906,2697953.9509612732 227557.54916239705,2697951.4805633239
227537.98300028767,2697951.4804244312 227537.98217788761,2697951.4799971851
227537.98016372745,2697951.4793904 227537.97826269516,2697951.478596943
227537.97643164048,2697951.4774952978 227537.97450754896,2697951.47633563
227537.9729206349,2697951.4753327863 227537.97174973297,2697951.4739289777
227537.97034592438,2697951.4719559341 227537.96881407686,2697951.4703079849
227537.96783751436,2697951.468192711 227537.96689562991,2697951.466239586
227537.96628527835,2697951.4652179973 227537.96602427136,2697951.4633869426
227537.96565806042,2697951.4614257812 227537.96546386718,2697951.4594116211
227537.96546386718,2697951.4575687358 227537.96563514532,2697951.4556156108
227537.96600135625,2697951.4542964213 227537.9663431776,2697924.8808711283
227546.82352091197))");
            Assert.IsTrue(geom.IsValid, "It is valid before buffering.");
            geom = geom.Buffer(-distance, segments);
            // This assert fails.
            Assert.IsTrue(geom.IsValid, "Buffer shouldn't produce invalid polygons.");
        }

        [Test, Category("Issue26")]
        public void TestBufferInvalid2()
        {
            var geom = reader.Read(
@"POLYGON((2721559.0259026354
260211.64013205285,2721570.3580681849 260195.99818543479,2721529.8251821264
260166.280999564,2721494.7831037422 260214.45285920257,2721434.0979183083
260298.89776810241,2721474.4687860529 260328.31201413152,2721559.0259026354
260211.64013205285))");
            Assert.IsTrue(geom.IsValid, "It is valid before buffering.");
            geom = geom.Buffer(distance, segments);
            // This assert fails.
            Assert.IsTrue(geom.IsValid, "Buffer shouldn't produce invalid polygons.");
        }

        [Test, Category("Issue26")]
        public void TestBufferInvalid3()
        {
            var geom = reader.Read(
@"POLYGON((2707378.1449053376
249440.33464680318,2707371.3136157258 249452.75099747762,2707420.9671040061
249479.61906280182,2707428.9462343147 249468.77519405185,2707378.1449053376
249440.33464680318))");
            geom = geom.Buffer(distance, segments);
            // This assert fails.
            Assert.IsTrue(geom.IsValid, "Buffer shouldn't produce invalid polygons.");
        }

        [Test, Category("Issue26")]
        public void TestBufferInvalid4()
        {
            var geom = reader.Read(
@"POLYGON((2690548.06499161
222745.6326164779,2690515.5544364145 222805.58220019616,2690521.3511186
222808.92183193445,2690522.4918925939 222809.30208994733,2690525.9173166361
222809.49294642056,2690528.8670960059 222808.92137669481,2690531.1503555393
222807.97010183227,2690535.4748482225 222805.21433685036,2690537.1546661635
222800.84541121754,2690537.1551116593 222800.84441772403,2690561.7856095368
222753.06815055074,2690552.158261566 222747.88780608302,2690552.158174423
222747.88775863362,2690548.06499161 222745.6326164779))");
            geom = geom.Buffer(distance, segments);
            // This assert fails.
            Assert.IsTrue(geom.IsValid, "Buffer shouldn't produce invalid polygons.");
        }

        [Test, Category("Issue26")]
        public void TestBufferInvalid5()
        {
            var geom = reader.Read(
@"POLYGON((2707210.6005991572
250668.02735701349,2707239.1481549842 250621.1425099186,2707215.3975130767
250607.31261745846,2707188.7325845929 250651.94412882419,2707188.7325117975
250651.94424874967,2707187.3078625104 250654.25457160824,2707202.6920840386
250663.33738880945,2707202.6921007996 250663.33739872716,2707210.6005991572
250668.02735701349))");
            geom = geom.Buffer(distance * 5, segments);
            // This assert fails.
            Assert.IsTrue(geom.IsValid, "Buffer shouldn't produce invalid polygons.");
        }

        [Test, Category("Issue26")]
        public void TestBufferInvalid6()
        {
            var geom = reader.Read(
@"POLYGON((2713556.8088996187
249866.18363983184,2713584.6975274645 249819.24009874952,2713579.4434981244
249815.77835040639,2713579.4428831846 249815.7779110361,2713574.4509958546
249811.91818375568,2713542.1451193155 249855.94666113809,2713556.8088996187
249866.18363983184))");
            geom = geom.Buffer(distance, segments);
            // This assert fails.
            Assert.IsTrue(geom.IsValid, "Buffer shouldn't produce invalid polygons.");
        }

        [Test, Category("Issue26")]
        public void TestBufferInvalid7()
        {
            var geom = reader.Read(
@"POLYGON((2703248.7982676448
249414.17508187954,2703240.5008770656 249425.8647261351,2703277.41985302
249452.70889176268,2703295.3997307951 249465.5940710248,2703303.4900849606
249454.40417855361,2703248.7982676448 249414.17508187954))");
            geom = geom.Buffer(distance, segments);
            // This assert fails.
            Assert.IsTrue(geom.IsValid, "Buffer shouldn't produce invalid polygons.");
        }

        [Test, Category("Issue26")]
        public void TestBufferInvalid8()
        {
            var geom = reader.Read(
@"POLYGON((2703544.1100440542
246173.33303338153,2703544.0851861257 246173.31495488089,2703536.1439364534
246184.17887997779,2703577.6534592919 246214.93367189405,2703584.795495607
246204.08332817027,2703547.2129705944 246175.6779778651,2703544.1100440542
246173.33303338153))");
            geom = geom.Buffer(distance, segments);
            // This assert fails.
            Assert.IsTrue(geom.IsValid, "Buffer shouldn't produce invalid polygons.");
        }

        [Test, Category("Issue26")]
        public void TestBufferInvalid9()
        {
            var geom = reader.Read(
@"POLYGON((2703813.9575800826
242486.32942833903,2703788.6725914241 242528.261484131,2703814.1149073248
242553.86470716231,2703830.4593556 242525.76097263311,2703830.4594283327
242525.76084960389,2703844.0930999196 242503.0707175273,2703813.9575800826
242486.32942833903))");
            geom = geom.Buffer(distance, segments);
            // This assert fails.
            Assert.IsTrue(geom.IsValid, "Buffer shouldn't produce invalid polygons.");
        }

        [Test, Category("Issue26")]
        public void TestBufferInvalid10()
        {
            var geom = reader.Read(
@"POLYGON((2672281.4909100723
219605.10482511416,2672288.7362600574 219588.28761828531,2672177.2569024358
219557.8872474494,2672169.759691271 219584.14248095002,2672169.2618649495
219586.33689937004,2672276.2446570531 219615.84715272515,2672281.4909100723
219605.10482511416))");
            geom = geom.Buffer(distance, segments);
            // This assert fails.
            Assert.IsTrue(geom.IsValid, "Buffer shouldn't produce invalid polygons.");
        }

        [Test, Category("Issue26")]
        public void TestBufferInvalid11()
        {
            var geom = reader.Read(
@"POLYGON((2679619.8984976411
262131.15473598641,2679619.8984990148 262131.15473376829,2679646.5243171602
262088.17409856233,2679630.7451750087 262078.04292233213,2679604.0905169365
262121.36324039931,2679604.0905167605 262121.36324068488,2679603.0686676935
262123.02386979931,2679618.7318387181 262133.03910914197,2679619.8984976411
262131.15473598641))");
            geom = geom.Buffer(distance, segments);
            // This assert fails.
            Assert.IsTrue(geom.IsValid, "Buffer shouldn't produce invalid polygons.");
        }
    }
}
