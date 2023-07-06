﻿// using Npgsql;

using Multicad.Runtime;
using Multicad.DatabaseServices;
using Multicad.Geometry;
using Multicad.DatabaseServices.StandardObjects;

namespace library
{
    public class pepe
    {
        private void drawLine(List<Point3d> points)
        {
            DbPolyline line = new DbPolyline();
            line.Polyline = new Polyline3d(points);
            line.Polyline.SetClosed(false);
            line.DbEntity.Transform(McDocumentsManager.GetActiveDoc().UCS);
            line.Polyline.SetThickness(300);
            line.DbEntity.AddToCurrentDocument();
        }

        [CommandMethod("pepe", CommandFlags.NoCheck | CommandFlags.NoPrefix)]
        public void drawPepe()
        {
            List<List<Point3d>> lines = new List<List<Point3d>> { new List<Point3d> { new Point3d(3221.5962, 51567.2816, 0), new Point3d(3516.9502, 51567.2816, 0), new Point3d(3963.7677, 51181.0495, 0), new Point3d(4861.1895, 50923.5614, 0), new Point3d(5792.6905, 50650.927, 0), new Point3d(8016.3652, 50434.1447, 0), new Point3d(9831.0882, 50280.7878, 0), new Point3d(11705.45, 50451.1844, 0), new Point3d(13034.5429, 51678.0394, 0), new Point3d(13128.261, 52146.6298, 0), new Point3d(12693.1188, 52652.4551, 0), new Point3d(12627.4845, 52049.1251, 0), new Point3d(11562.8218, 51001.8176, 0), new Point3d(9875.8962, 50899.5797, 0), new Point3d(7439.2258, 50993.2978, 0), new Point3d(6184.6025, 51205.6623, 0), new Point3d(5909.4436, 51352.0771, 0), new Point3d(4793.6619, 51496.5986, 0), new Point3d(3629.2857, 51968.029, 0), new Point3d(3049.9375, 52030.5078, 0), new Point3d(2589.8668, 51837.3917, 0), new Point3d(2669.3852, 51502.2785, 0), new Point3d(3203.2943, 51070.6073, 0), new Point3d(3708.804, 50809.3326, 0), new Point3d(4017.7851, 50617.9229, 0), new Point3d(4254.891, 50546.1179, 0), new Point3d(4983.4121, 50094.906, 0), new Point3d(5343.1382, 49852.5643, 0), new Point3d(5619.5592, 49780.6191, 0), new Point3d(6145.8951, 49542.064, 0), new Point3d(6960.0119, 49432.2529, 0), new Point3d(7731.8845, 49234.2852, 0), new Point3d(9986.7985, 49234.2852, 0), new Point3d(11349.9708, 49336.5232, 0), new Point3d(12446.1884, 50069.2282, 0), new Point3d(12610.9051, 50370.2621, 0), new Point3d(12673.3838, 50745.1345, 0) }, new List<Point3d> { new Point3d(4002.4838, 54487.842, 0), new Point3d(4857.1136, 53787.6634, 0), new Point3d(6427.3671, 53535.3931, 0), new Point3d(8074.8462, 53339.755, 0), new Point3d(8517.6062, 53571.4317, 0), new Point3d(8785.3215, 53967.8564, 0), new Point3d(8517.6062, 54225.275, 0), new Point3d(8265.8126, 54927.0267, 0), new Point3d(7902.8524, 55521.6637, 0), new Point3d(7161.4868, 55691.56, 0), new Point3d(6489.6242, 56178.0812, 0), new Point3d(4898.7772, 56178.0812, 0), new Point3d(3887.1221, 55892.3465, 0), new Point3d(3400.6009, 55205.0388, 0), new Point3d(2921.8023, 55305.4321, 0), new Point3d(2921.8023, 55428.993, 0), new Point3d(3570.4972, 56448.3707, 0), new Point3d(6010.8256, 56726.3828, 0), new Point3d(7061.0935, 56479.2609, 0), new Point3d(7956.9103, 55892.3465, 0), new Point3d(8698.2759, 55042.8651, 0) }, new List<Point3d> { new Point3d(11442.9482, 53502.322, 0), new Point3d(11617.9928, 53450.8383, 0), new Point3d(12163.7203, 53574.3992, 0), new Point3d(12688.8542, 54123.5589, 0), new Point3d(12688.8542, 54708.0898, 0), new Point3d(12564.8166, 55356.7847, 0), new Point3d(12093.7406, 55843.3059, 0), new Point3d(10811.7959, 55843.3059, 0), new Point3d(10093.598, 55495.7908, 0), new Point3d(9491.2384, 54947.4891, 0), new Point3d(9220.9489, 54175.2333, 0), new Point3d(9885.0889, 53966.7242, 0), new Point3d(11614.9419, 53966.7242, 0), new Point3d(12194.1338, 54221.5687, 0), new Point3d(12688.8542, 54708.0898, 0), new Point3d(11475.9359, 55403.1201, 0) }, new List<Point3d> { new Point3d(7902.8524, 55521.6637, 0), new Point3d(5807.5781, 55521.6637, 0), new Point3d(3676.1521, 55225.0186, 0), new Point3d(4772.7553, 54638.1041, 0), new Point3d(5421.4502, 54228.8085, 0), new Point3d(6911.904, 53889.016, 0), new Point3d(7745.9403, 53889.016, 0) }, new List<Point3d> { new Point3d(6538.9688, 56713.3808, 0), new Point3d(7759.133, 56631.0068, 0), new Point3d(8469.6083, 56203.6919, 0), new Point3d(8894.9926, 55562.7196, 0) }, new List<Point3d> { new Point3d(8469.6083, 56203.6919, 0), new Point3d(8052.5902, 57408.411, 0), new Point3d(7025.4899, 58265.615, 0), new Point3d(6114.2281, 58559.0722, 0), new Point3d(4561.9938, 58559.0722, 0) }, new List<Point3d> { new Point3d(12693.3918, 55283.7958, 0), new Point3d(12762.0368, 55918.7617, 0), new Point3d(12597.2889, 56303.1735, 0), new Point3d(11941.7295, 56526.2696, 0), new Point3d(10698.8267, 57802.6369, 0), new Point3d(8984.4187, 58188.7648, 0) }, new List<Point3d> { new Point3d(9506.9785, 55587.228, 0), new Point3d(10268.9376, 56148.4006, 0), new Point3d(11041.1934, 56246.2196, 0), new Point3d(12148.0934, 56143.2522, 0) }, new List<Point3d> { new Point3d(10093.8929, 56364.6322, 0), new Point3d(10886.7422, 56549.9736, 0) }, new List<Point3d> { new Point3d(10698.8267, 57802.6369, 0), new Point3d(10241.3958, 58951.4177, 0), new Point3d(9465.2787, 59785.454, 0), new Point3d(8017.299, 60028.7146, 0), new Point3d(7067.4244, 59762.2863, 0), new Point3d(6546.1517, 59345.2682, 0), new Point3d(6719.9092, 58928.25, 0) }, new List<Point3d> { new Point3d(6546.1517, 59345.2682, 0), new Point3d(5878.1504, 59959.2116, 0), new Point3d(4256.4132, 60059.6048, 0), new Point3d(2750.5143, 59603.9739, 0), new Point3d(1870.1427, 58252.5262, 0), new Point3d(906.6463, 57519.8485, 0), new Point3d(580.5827, 57159.4624, 0) }, new List<Point3d> { new Point3d(14218.2351, 43316.7449, 0), new Point3d(14532.2858, 44387.6063, 0), new Point3d(14177.0481, 45641.235, 0), new Point3d(12508.9755, 47656.8227, 0), new Point3d(10910.406, 48757.2872, 0), new Point3d(10238.5434, 48618.2812, 0), new Point3d(8941.1536, 47540.9843, 0), new Point3d(8663.1415, 47181.8853, 0), new Point3d(8663.1415, 46845.954, 0), new Point3d(9392.9233, 46845.954, 0), new Point3d(9893.6025, 46960.5053, 0), new Point3d(10557.7425, 47398.117, 0), new Point3d(11093.1732, 47398.117, 0), new Point3d(11093.1732, 46759.7188, 0), new Point3d(11669.7909, 47140.6983, 0), new Point3d(10606.652, 46270.6234, 0), new Point3d(10220.5241, 46162.5076, 0), new Point3d(9911.6218, 45714.5993, 0), new Point3d(10475.3685, 45181.7427, 0), new Point3d(11054.5604, 44934.6209, 0), new Point3d(11270.792, 45498.3676, 0), new Point3d(11927.2095, 46139.34, 0), new Point3d(11270.792, 45498.3676, 0), new Point3d(11054.5604, 44934.6209, 0), new Point3d(11263.0695, 44540.7704, 0), new Point3d(12228.3893, 44170.0876, 0), new Point3d(12073.9381, 44563.9381, 0), new Point3d(12853.9165, 45529.2579, 0), new Point3d(12073.9381, 44563.9381, 0), new Point3d(12228.3893, 44170.0876, 0), new Point3d(12761.2458, 44015.6364, 0), new Point3d(13070.1481, 44015.6364, 0), new Point3d(13070.1481, 44370.8741, 0), new Point3d(13649.34, 45065.9044, 0), new Point3d(13070.1481, 44370.8741, 0), new Point3d(13070.1481, 44015.6364, 0), new Point3d(13402.2181, 43830.295, 0), new Point3d(13718.843, 43830.295, 0) }, new List<Point3d> { new Point3d(9324.7074, 47019.7116, 0), new Point3d(9479.1585, 47297.7237, 0) }, new List<Point3d> { new Point3d(8663.1415, 47181.8853, 0), new Point3d(8258.9943, 47467.62, 0), new Point3d(7919.2017, 47467.62, 0), new Point3d(7633.4671, 47050.6018, 0), new Point3d(7849.6987, 46664.4739, 0), new Point3d(8421.168, 46000.3339, 0), new Point3d(8544.729, 45467.4774, 0), new Point3d(8544.729, 44988.6788, 0), new Point3d(8997.4639, 44130.8313, 0), new Point3d(9268.6115, 43808.1999, 0) }, new List<Point3d> { new Point3d(7464.5898, 43420.9995, 0) }, new List<Point3d> { new Point3d(9392.9233, 46845.954, 0), new Point3d(9539.3837, 46104.8745, 0), new Point3d(9911.6218, 45714.5993, 0), new Point3d(9539.3837, 46104.8745, 0), new Point3d(9991.2964, 46499.583, 0) }, new List<Point3d> { new Point3d(11764.9106, 48358.1454, 0), new Point3d(12274.5995, 49230.7944, 0) }, new List<Point3d> { new Point3d(2182.637, 51999.2109, 0), new Point3d(2857.0738, 52405.9323, 0) }, new List<Point3d> { new Point3d(2594.5068, 52848.6923, 0) }, new List<Point3d> { new Point3d(5899.7617, 52060.9914, 0), new Point3d(6939.7329, 52411.0807, 0) }, new List<Point3d> { new Point3d(10944.2011, 53399.2464, 0), new Point3d(10434.5123, 53221.6275, 0), new Point3d(9307.0188, 53538.2524, 0), new Point3d(10009.7716, 53159.8471, 0) }, new List<Point3d> { new Point3d(11199.0455, 53067.1764, 0), new Point3d(11724.1795, 53067.1764, 0) }, new List<Point3d> { new Point3d(6764.3933, 55395.0182, 0), new Point3d(5140.9399, 55395.0182, 0), new Point3d(4842.3343, 54983.1484, 0), new Point3d(4801.1474, 54519.7949, 0), new Point3d(5398.3585, 54241.7828, 0), new Point3d(6757.5288, 53943.1772, 0), new Point3d(6984.0571, 54502.6337, 0), new Point3d(6984.0571, 54976.2839, 0), new Point3d(6795.2835, 55316.0765, 0), new Point3d(5642.0481, 55316.0765, 0), new Point3d(5158.1012, 55316.0765, 0), new Point3d(4900.6825, 54873.3165, 0), new Point3d(4900.6825, 54622.7624, 0), new Point3d(5271.3653, 54355.047, 0), new Point3d(5789.6348, 54265.8086, 0), new Point3d(6551.5939, 54049.5769, 0), new Point3d(6784.9868, 54310.4278, 0), new Point3d(6908.5477, 54832.1295, 0), new Point3d(6747.232, 55243.9993, 0), new Point3d(5909.7635, 55243.9993, 0), new Point3d(5731.2866, 55202.8123, 0), new Point3d(5731.2866, 54983.1484, 0), new Point3d(5456.7067, 54808.1038, 0), new Point3d(5274.7976, 54863.0197, 0), new Point3d(5199.2881, 55051.7934, 0), new Point3d(5257.6363, 55230.2703, 0), new Point3d(5161.5334, 55230.2703, 0), new Point3d(5065.4305, 54965.9872, 0), new Point3d(4996.7855, 54763.4845, 0), new Point3d(5182.1269, 54554.1174, 0), new Point3d(5288.5266, 54433.9887, 0), new Point3d(5731.2866, 54344.7503, 0), new Point3d(6366.2525, 54197.1636, 0), new Point3d(6609.9421, 54293.2665, 0), new Point3d(6757.5288, 54540.3884, 0), new Point3d(6908.5477, 54832.1295, 0), new Point3d(6695.7483, 55127.3028, 0), new Point3d(6747.232, 55243.9993, 0), new Point3d(6191.2078, 55243.9993, 0), new Point3d(5906.3312, 55117.0061, 0), new Point3d(5786.2026, 54825.265, 0), new Point3d(5535.6484, 54825.265, 0), new Point3d(5274.7976, 54742.8911, 0), new Point3d(5137.5077, 54880.181, 0), new Point3d(5096.3207, 54838.994, 0), new Point3d(5237.0429, 54639.9236, 0), new Point3d(5309.1201, 54488.9047, 0), new Point3d(5271.3653, 54355.047, 0), new Point3d(5762.1768, 54406.5307, 0), new Point3d(6366.2525, 54197.1636, 0), new Point3d(6366.2525, 54262.3763, 0), new Point3d(6609.9421, 54293.2665, 0), new Point3d(6764.3933, 54739.4588, 0), new Point3d(6716.3418, 54996.8774, 0), new Point3d(6589.3486, 55106.7094, 0), new Point3d(6335.3623, 55199.3801, 0), new Point3d(6074.5114, 55130.7351, 0), new Point3d(5923.4925, 54948.8259, 0), new Point3d(5817.0928, 54705.1363, 0), new Point3d(5817.0928, 54554.1174, 0), new Point3d(5933.7892, 54423.692, 0), new Point3d(6191.2078, 54334.4535, 0), new Point3d(6421.1685, 54334.4535, 0), new Point3d(6609.9421, 54293.2665, 0), new Point3d(6764.3933, 54739.4588, 0), new Point3d(6621.0934, 55040.1076, 0), new Point3d(6589.3486, 55106.7094, 0), new Point3d(6215.2336, 55068.9546, 0), new Point3d(6057.3502, 54986.5807, 0), new Point3d(5981.8407, 54856.1552, 0), new Point3d(5981.8407, 54650.2204, 0), new Point3d(6026.4599, 54454.5822, 0), new Point3d(6225.5303, 54389.3695, 0), new Point3d(6572.1874, 54437.421, 0), new Point3d(6757.5288, 54540.3884, 0) }, new List<Point3d> { new Point3d(11155.5257, 55357.9785, 0), new Point3d(10578.908, 55430.0557, 0), new Point3d(10074.3675, 55296.198, 0), new Point3d(9837.5424, 54946.1087, 0), new Point3d(9708.8331, 54472.4585, 0), new Point3d(9708.8331, 54091.479, 0), new Point3d(9899.3229, 53962.7697, 0), new Point3d(10501.6824, 53962.7697, 0), new Point3d(11150.3773, 53962.7697, 0), new Point3d(11418.0927, 54137.8143, 0), new Point3d(11493.6021, 54621.7613, 0), new Point3d(11424.9572, 55026.7666, 0), new Point3d(11140.0806, 55294.4819, 0), new Point3d(10769.3978, 55335.6689, 0), new Point3d(10415.8762, 55335.6689, 0), new Point3d(10148.1609, 55242.9982, 0), new Point3d(9921.6325, 54951.2571, 0), new Point3d(9852.9875, 54676.6773, 0), new Point3d(9777.4781, 54299.13, 0), new Point3d(9870.1488, 54117.2208, 0), new Point3d(10257.9928, 54048.5759, 0), new Point3d(11013.0874, 54048.5759, 0), new Point3d(11342.5832, 54240.7818, 0), new Point3d(11411.2282, 54676.6773, 0), new Point3d(11294.5317, 55033.6311, 0), new Point3d(11040.5454, 55222.4047, 0), new Point3d(10384.986, 55222.4047, 0), new Point3d(10206.5091, 55177.7855, 0), new Point3d(10436.4697, 55109.1405, 0), new Point3d(10484.5212, 54882.6122, 0), new Point3d(10405.5795, 54707.5675, 0), new Point3d(10079.5159, 54707.5675, 0), new Point3d(9966.2517, 54848.2897, 0), new Point3d(9921.6325, 54553.1163, 0), new Point3d(9921.6325, 54326.588, 0), new Point3d(10028.0322, 54189.298, 0), new Point3d(10264.8573, 54141.2466, 0), new Point3d(10638.9724, 54141.2466, 0), new Point3d(10944.4424, 54141.2466, 0), new Point3d(11157.2418, 54216.756, 0), new Point3d(11297.964, 54323.1557, 0), new Point3d(11342.5832, 54707.5675, 0), new Point3d(11229.319, 54958.1216, 0), new Point3d(11013.0874, 55143.463, 0), new Point3d(10539.4372, 55143.463, 0), new Point3d(10580.6241, 54916.9346, 0), new Point3d(10498.2502, 54697.2708, 0), new Point3d(10395.2827, 54584.0066, 0), new Point3d(10172.1866, 54584.0066, 0), new Point3d(10004.0065, 54645.787, 0), new Point3d(10055.4902, 54563.4131, 0), new Point3d(9990.2775, 54405.5297, 0), new Point3d(9935.3615, 54179.0013, 0), new Point3d(10474.2244, 54179.0013, 0), new Point3d(10937.5779, 54223.6205, 0), new Point3d(11177.8353, 54330.0202, 0), new Point3d(10941.0102, 54330.0202, 0), new Point3d(10642.4046, 54281.9687, 0), new Point3d(10474.2244, 54179.0013, 0), new Point3d(10474.2244, 54309.4267, 0), new Point3d(10673.2948, 54360.9104, 0), new Point3d(10779.6945, 54360.9104, 0), new Point3d(10779.6945, 54481.0391, 0), new Point3d(10505.1147, 54481.0391, 0), new Point3d(10422.7407, 54419.2587, 0), new Point3d(10422.7407, 54529.0906, 0), new Point3d(10662.1506, 54549.8536, 0), new Point3d(10639.0995, 54726.1271, 0), new Point3d(10693.3375, 54948.7571, 0), new Point3d(10693.3375, 55076.8943, 0), new Point3d(10894.696, 55076.8943, 0), new Point3d(10999.9516, 55076.8943, 0), new Point3d(11180.7167, 54946.4689, 0), new Point3d(10956.4765, 54980.7914, 0), new Point3d(10773.4233, 54980.7914, 0) } };

            lines.ForEach(line => drawLine(line));
        }
    }
}