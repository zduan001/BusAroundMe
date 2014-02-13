﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeCSharp;
using Infra;
using System.Collections.Generic;

namespace LeetCodeCsharpTest
{
    [TestClass]
    public class UnitTest_All
    {
        [TestMethod]
        public void Test_001MinCutPalindrome()
        {
            _001_smallestcutPalindrom target = new _001_smallestcutPalindrom();
            string input = "aab";
            int actual = target.FindSmallestCutForAllPalindrome(input);
            Assert.AreEqual(1, actual);

            input = "abacdc";
            actual = target.FindSmallestCutForAllPalindrome(input);
            Assert.AreEqual(1, actual);


            input = "abacdcefe";
            actual = target.FindSmallestCutForAllPalindrome(input);
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void Test_001AllPalindrome()
        {
            _001_smallestcutPalindrom target = new _001_smallestcutPalindrom();
            string input = "aab";
            List<List<string>> actual = target.FindAllPossiblePalindromeCut(input);

            Assert.AreEqual(2, actual.Count);
        }

        [TestMethod]
        public void TestFloodArea()
        {
            _002_FloodSurroundArea target = new _002_FloodSurroundArea();

            /*["OOOOOO","OXXXXO","OXOOXO","OXOOXO","OXXXXO","OOOOOO"]*/
            List<List<FloodNode>> input = new List<List<FloodNode>>();

            for (int j = 0; j < 6; j++)
            {
                List<FloodNode> row1 = new List<FloodNode>();
                for (int i = 0; i < 6; i++)
                {
                    row1.Add(new FloodNode() { value = 'o' });
                }
                input.Add(row1);
            }

            input[1][1].value = 'x';
            input[1][2].value = 'x';
            input[1][3].value = 'x';
            input[1][4].value = 'x';

            input[2][1].value = 'x';
            input[2][4].value = 'x';

            input[3][1].value = 'x';
            input[3][4].value = 'x';

            input[4][1].value = 'x';
            input[4][2].value = 'x';
            input[4][3].value = 'x';
            input[4][4].value = 'x';

            List<List<FloodNode>> actual = target.FloodBitMap(input);
        }

        [TestMethod]
        public void TestMethod_003_LongestConsectiveSequence()
        {
            _003_LongestConsectiveSequence target = new _003_LongestConsectiveSequence();
            int[] input = new int[] { 100, 4, 200, 1, 3, 2 };
            int actual = target.FindLongestConsectiveSequence(input);
            Assert.AreEqual(4, actual);

            input = new int[] { 10, 21, 45, 22, 7, 2, 67, 19, 13, 45, 12, 11, 18, 16, 17, 100, 201, 20, 101 };
            actual = target.FindLongestConsectiveSequence(input);
            Assert.AreEqual(7, actual);

            input = new int[] { 1, 3, 5, 7 };
            actual = target.FindLongestConsectiveSequence(input);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void Test_004SumtoLeafNumbers()
        {
            _004_SumRoottoLeafNumbers target = new _004_SumRoottoLeafNumbers();
            //string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            string inputstring = "1,2,#,#,3,#,#";
            char t = ',';
            TreeNode node = TreeNode.DeserializeTree(inputstring, t);
            int actual = target.CalCulateSum(node);
            Assert.AreEqual(25, actual);
        }

        [TestMethod]
        public void TestWordLadder()
        {
            _005_WordLadder target = new _005_WordLadder();
            string[] dict = new string[] { "hot", "dot", "dog", "lot", "log" };
            string start = "hit";
            string end = "cog";
            int actual = target.FindWordLadderLength(dict, start, end);
            Assert.AreEqual(5, actual);

            dict = new string[] { "gasket", "hearer", "linker", "bitter", "dissed", "filled", "donner", "fences", "cronus", "spaced", "halsey", "tracey", "earwax", "glider", "shoved", "rather", "tender", "copter", "swoons", "croons", "hazing", "crying", "wanted", "basket", "feller", "posses", "snails", "spaces", "series", "socked", "singly", "douses", "pivots", "brooms", "atoned", "barred", "weirds", "wildly", "quited", "culled", "hoofed", "thorax", "penned", "backed", "smalls", "dorset", "stores", "massey", "soaked", "gutted", "slings", "corvus", "lewder", "soared", "meagan", "bathes", "debase", "killed", "passel", "rutted", "leaves", "caller", "sayers", "balled", "fluent", "quaver", "belong", "lifted", "stints", "callow", "pummel", "fluked", "ribald", "tanker", "blocks", "braver", "licked", "pupped", "upjohn", "seller", "warmed", "skited", "jotted", "tushes", "sacked", "darker", "lassos", "sporty", "hushed", "gender", "gashed", "insole", "nasser", "yankee", "barked", "bastes", "header", "photon", "fluxes", "harped", "wasted", "tarter", "crusoe", "gaping", "netted", "hatred", "cursed", "dauber", "tanner", "sicken", "peered", "leaven", "ranter", "dicier", "chiles", "nearer", "pucked", "hinged", "basked", "loaner", "staler", "brayed", "scaled" };
            start = "soared";
            end = "gasket";
            actual = target.FindWordLadderLength(dict, start, end);
            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        public void TestWordLadderII()
        {
            _005_WordLadder target = new _005_WordLadder();
            string[] dict = new string[] { "hot", "dot", "dog", "lot", "log" };
            string start = "hit";
            string end = "cog";
            List<List<string>> actual = target.FindWordLadderII(dict, start, end);
            Assert.AreEqual(2, actual.Count);

            Assert.AreEqual("hit", actual[0][0]);
            Assert.AreEqual("hot", actual[0][1]);
            Assert.AreEqual("dot", actual[0][2]);
            Assert.AreEqual("dog", actual[0][3]);
            Assert.AreEqual("cog", actual[0][4]);

            Assert.AreEqual("hit", actual[1][0]);
            Assert.AreEqual("hot", actual[1][1]);
            Assert.AreEqual("lot", actual[1][2]);
            Assert.AreEqual("log", actual[1][3]);
            Assert.AreEqual("cog", actual[1][4]);

        }

        [TestMethod]
        public void TestMethod_006VliadPalindromw()
        {
            _006_ValidPalindrome target = new _006_ValidPalindrome();
            string input = "A man, a plan, a canal: Panama";
            bool actual = target.IsValidPalindrome(input.ToLower());
            Assert.IsTrue(actual);

            input = "race a car";
            actual = target.IsValidPalindrome(input.ToLower());
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestMethod_007MaxPathSum()
        {
            /*{5,4,8,11,#,13,4,7,2,#,#,#,1}*/
            _007_BinaryTreeMaxPathSum target = new _007_BinaryTreeMaxPathSum();
            string treeStr = "5,4,8,11,#,13,4,7,2,#,#,#,1";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(treeStr, t);
        }

        [TestMethod]
        public void TestMethod_08_BuyStockIII()
        {
            _008_BuyStockIII target = new _008_BuyStockIII();
            int[] input = new int[] { 2, 1, 4, 5, 2, 9, 7 };
            int actual = target.BuyStock(input);
            Assert.AreEqual(11, actual);

            input = new int[] { 2, 6, 8, 7, 8, 7, 9, 4, 1, 2, 4, 5, 8 };
            actual = target.BuyStock(input);
            Assert.AreEqual(14, actual);

            input = new int[] { 397, 6621, 4997, 7506, 8918, 1662, 9187, 3278, 3890, 514, 18, 9305, 93, 5508, 3031, 2692, 6019, 1134, 1691, 4949, 5071, 799, 8953, 7882, 4273, 302, 6753, 4657, 8368, 3942, 1982, 5117, 563, 3332, 2623, 9482, 4994, 8163, 9112, 5236, 5029, 5483, 4542, 1474, 991, 3925, 4166, 3362, 5059, 5857, 4663, 6482, 3008, 3616, 4365, 3634, 270, 1118, 8291, 4990, 1413, 273, 107, 1976, 9957, 9083, 7810, 4952, 7246, 3275, 6540, 2275, 8758, 7434, 3750, 6101, 1359, 4268, 5815, 2771, 126, 478, 9253, 9486, 446, 3618, 3120, 7068, 1089, 1411, 2058, 2502, 8037, 2165, 830, 7994, 1248, 4993, 9298, 4846, 8268, 2191, 3474, 3378, 9625, 7224, 9479, 985, 1492, 1646, 3756, 7970, 8476, 3009, 7457, 8922, 2980, 577, 2342, 4069, 8341, 4400, 2923, 2730, 2917, 105, 724, 518, 5098, 6375, 5364, 3366, 8566, 8838, 3096, 8191, 2414, 2575, 5528, 259, 573, 5636, 4581, 9049, 4998, 2038, 4323, 7978, 8968, 6665, 8399, 7309, 7417, 1322, 6391, 335, 1427, 7115, 853, 2878, 9842, 2569, 2596, 4760, 7760, 5693, 9304, 6526, 8268, 4832, 6785, 5194, 6821, 1367, 4243, 1819, 9757, 4919, 6149, 8725, 7936, 4548, 2386, 5354, 2222, 8777, 2041, 1, 2245, 9246, 2879, 8439, 1815, 5476, 3200, 5927, 7521, 2504, 2454, 5789, 3688, 9239, 7335, 6861, 6958, 7931, 8680, 3068, 2850, 1181, 1793, 7138, 2081, 532, 2492, 4303, 5661, 885, 657, 4258, 131, 9888, 9050, 1947, 1716, 2250, 4226, 9237, 1106, 6680, 1379, 1146, 2272, 8714, 8008, 9230, 6645, 3040, 2298, 5847, 4222, 444, 2986, 2655, 7328, 1830, 6959, 9341, 2716, 3968, 9952, 2847, 3856, 9002, 1146, 5573, 1252, 5373, 1162, 8710, 2053, 2541, 9856, 677, 1256, 4216, 9908, 4253, 3609, 8558, 6453, 4183, 5354, 9439, 6838, 2682, 7621, 149, 8376, 337, 4117, 8328, 9537, 4326, 7330, 683, 9899, 4934, 2408, 7413, 9996, 814, 9955, 9852, 1491, 7563, 421, 7751, 1816, 4030, 2662, 8269, 8213, 8016, 4060, 5051, 7051, 1682, 5201, 5427, 8371, 5670, 3755, 7908, 9996, 7437, 4944, 9895, 2371, 7352, 3661, 2367, 4518, 3616, 8571, 6010, 1179, 5344, 113, 9347, 9374, 2775, 3969, 3939, 792, 4381, 8991, 7843, 2415, 544, 3270, 787, 6214, 3377, 8695, 6211, 814, 9991, 2458, 9537, 7344, 6119, 1904, 8214, 6087, 6827, 4224, 7266, 2172, 690, 2966, 7898, 3465, 3287, 1838, 609, 7668, 829, 8452, 84, 7725, 8074, 871, 3939, 7803, 5918, 6502, 4969, 5910, 5313, 4506, 9606, 1432, 2762, 7820, 3872, 9590, 8397, 1138, 8114, 9087, 456, 6012, 8904, 3743, 7850, 9514, 7764, 5031, 4318, 7848, 9108, 8745, 5071, 9400, 2900, 7341, 5902, 7870, 3251, 7567, 2376, 9209, 9000, 1491, 7030, 2872, 7433, 1779, 362, 5547, 7218, 7171, 7911, 2474, 914, 2114, 8340, 8678, 3497, 2659, 2878, 2606, 7756, 7949, 2006, 656, 5291, 4260, 8526, 4894, 1828, 7255, 456, 7180, 8746, 3838, 6404, 6179, 5617, 3118, 8078, 9187, 289, 5989, 1661, 1204, 8103, 2, 6234, 7953, 9013, 5465, 559, 6769, 9766, 2565, 7425, 1409, 3177, 2304, 6304, 5005, 9559, 6760, 2185, 4657, 598, 8589, 836, 2567, 1708, 5266, 1754, 8349, 1255, 9767, 5905, 5711, 9769, 8492, 3664, 5134, 3957, 575, 1903, 3723, 3140, 5681, 5133, 6317, 4337, 7789, 7675, 3896, 4549, 6212, 8553, 1499, 1154, 5741, 418, 9214, 1007, 2172, 7563, 8614, 8291, 3469, 677, 4413, 1961, 4341, 9547, 5918, 4916, 7803, 9641, 4408, 3484, 1126, 7078, 7821, 8915, 1105, 8069, 9816, 7317, 2974, 1315, 8471, 8715, 1733, 7685, 6074, 257, 5249, 4688, 8549, 5070, 5366, 2962, 7031, 6059, 8861, 9301, 7328, 6664, 5294, 8088, 6500, 6421, 1518, 4321, 5336, 2623, 8742, 1505, 9941, 1716, 2820, 4764, 6783, 906, 2450, 2857, 7515, 4051, 7546, 2416, 9121, 9264, 1730, 6152, 1675, 592, 1805, 9003, 7256, 7099, 3444, 3757, 9872, 4962, 4430, 1561, 7586, 3173, 3066, 3879, 1241, 2238, 8643, 8025, 3144, 7445, 882, 7012, 1496, 4780, 9428, 617, 396, 1159, 3121, 2072, 1751, 4926, 7427, 5359, 8378, 871, 5468, 8250, 5834, 9899, 9811, 9772, 9424, 2877, 3651, 7017, 5116, 8646, 5042, 4612, 6092, 2277, 1624, 7588, 3409, 1053, 8206, 3806, 8564, 7679, 2230, 6667, 8958, 6009, 2026, 7336, 6881, 3847, 5586, 9067, 98, 1750, 8839, 9522, 4627, 8842, 2891, 6095, 7488, 7934, 708, 3580, 6563, 8684, 7521, 9972, 6089, 2079, 130, 4653, 9758, 2360, 1320, 8716, 8370, 9699, 6052, 1603, 3546, 7991, 670, 3644, 6093, 9509, 9518, 7072, 4703, 2409, 3168, 2191, 6695, 228, 2124, 3258, 5264, 9645, 9583, 1354, 1724, 9713, 2359, 1482, 8426, 3680, 6551, 3148, 9731, 8955, 4751, 9629, 6946, 5421, 9625, 9391, 1282, 5495, 6464, 5985, 4256, 5984, 4528, 952, 6212, 6652, 562, 1476, 6297, 145, 9182, 8021, 6211, 1542, 5856, 4637, 1574, 2407, 7785, 1305, 1362, 2536, 934, 4661, 4309, 559, 4052, 1943, 2406, 516, 4280, 6662, 2852, 8808, 7614, 9064, 1813, 4529, 6893, 8110, 4674, 2427, 2484, 7237, 3969, 8340, 1874, 5543, 7099, 6011, 3200, 8461, 8547, 486, 9474, 9208, 7397, 9879, 7503, 9803, 6747, 1783, 6466, 9600, 6944, 432, 8664, 8757, 4961, 1909, 6867, 5988, 4337, 5703, 3225, 4658, 4043, 1452, 6554, 1142, 7463, 9754, 5956, 2363, 241, 1782, 7923, 7638, 1661, 5427, 3794, 8409, 7210, 260, 8009, 4154, 692, 3025, 9263, 2006, 4935, 2483, 7994, 5624, 8186, 7571, 282, 8582, 9023, 6836, 6076, 6487, 6591, 2032, 8850, 3184, 3815, 3125, 7174, 5476, 8552, 968, 3885, 2115, 7580, 8246, 2621, 4625, 1272, 1885, 6631, 6207, 4368, 4625, 8183, 2554, 8548, 8465, 1136, 7572, 1654, 7213, 411, 4597, 5597, 5613, 7781, 5764, 8738, 1307, 7593, 7291, 8628, 7830, 9406, 6208, 6077, 2027, 833, 7349, 3912, 7464, 9908, 4632, 8441, 8091, 7187, 6990, 2908, 4675, 914, 4562, 8240, 1325, 9159, 190, 6938, 3292, 5954, 2028, 4600, 9899, 9319, 3228, 7730, 5077, 9436, 159, 7105, 6622, 7508, 7369, 4086, 3768, 2002, 8880, 8211, 5541, 2222, 1119, 216, 3136, 5682, 4809, 813, 1193, 4999, 4103, 4486, 7305, 6131, 9086, 7205, 5451, 2314, 1287, 528, 8102, 1446, 3985, 4724, 5306, 1355, 5163, 9074, 9709, 4043, 7285, 5250, 2617, 4756, 1818, 2105, 6790, 6627, 2918, 7984, 7978, 7021, 2470, 1636, 3152, 7908, 8841, 4955, 222, 6480, 5484, 4676, 7926, 5821, 9401, 3232, 7176, 916, 8658, 3237, 1311, 5943, 8487, 3928, 7051, 306, 6033, 3842, 3285, 8951, 1826, 7616, 2324, 648, 9252, 5476, 8556, 4445, 6784 };
            actual = target.BuyStock(input);
            Assert.AreEqual(19965, actual);
        }

        [TestMethod]
        public void TestMethod_009_Triangle()
        {
            _009_Triangle target = new _009_Triangle();
            List<List<int>> input = new List<List<int>>();
            input.Add(new List<int>() { 2 });
            input.Add(new List<int>() { 3, 4 });
            input.Add(new List<int>() { 6, 5, 7 });
            input.Add(new List<int>() { 4, 1, 8, 3 });
            int actual = target.FindMinPath(input);
            Assert.AreEqual(11, actual);
        }

        [TestMethod]
        public void TestMethod_010_PascalTriangle()
        {
            _010_PascalTriangle target = new _010_PascalTriangle();
            List<int> actual = target.GetPsacalTriangle(3);
            Assert.AreEqual(4, actual.Count);

            actual = target.GetPsacalTriangle(4);
            Assert.AreEqual(5, actual.Count);
        }

        [TestMethod]
        public void TestMethod_011_PopuldateNextRight()
        {
            _011_PopuldateNextRight target = new _011_PopuldateNextRight();
            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);

            target.PopuldateNextRight(root, null);

            Assert.AreEqual(root.LeftChild.Next, root.RightChild);
            Assert.AreEqual(root.RightChild.LeftChild.Next, root.RightChild.RightChild);
            Assert.AreEqual(root.LeftChild.LeftChild.Next, root.RightChild.LeftChild);

        }

        [TestMethod]
        public void TestMethod_012_InterleaveSortString()
        {
            _012_InterleaveSortString target = new _012_InterleaveSortString();
            int[] input = new int[] { 1, 3, 5, 7, 2, 4, 6, 8 };
            target.solve(input, 0, input.Length - 1);

            Assert.AreEqual(4, input[3]);

            input = new[] { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };
            target.solve(input, 0, input.Length - 1);

            input = new[] { 1, 3, 5, 2, 4, 6 };
            target.solve(input, 0, input.Length - 1);
        }

        [TestMethod]
        public void TestMethod_013_distinctSequence()
        {
            _013_distinctSequence target = new _013_distinctSequence();
            string s = "rabbbit";
            string p = "rabbit";
            int actual = target.FindMaxDistinctSequence(s, p);
            Assert.AreEqual(3, actual);

            s = "babgbag";
            p = "bag";
            actual = target.FindMaxDistinctSequence(s, p);
            Assert.AreEqual(5, actual);

            s = "aabdbaabeeadcbbdedacbbeecbabebaeeecaeabaedadcbdbcdaabebdadbbaeabdadeaabbabbecebbebcaddaacccebeaeedababedeacdeaaaeeaecbe";
            p = "bddabdcae";
            actual = target.FindMaxDistinctSequence(s, p);
            Assert.AreEqual(10582116, actual);
        }

        [TestMethod]
        public void TestMethod_014_FlattenBinaryTree()
        {
            _014_FlattenBinaryTree target = new _014_FlattenBinaryTree();
            string inputstring = "30,10,50,#,#,#,20,45,#,#,35,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            TreeNode left = null;
            TreeNode right = null;

            target.FlattenBinaryTree(root, ref left, ref right);

            Assert.AreEqual(30, root.Value);
            Assert.AreEqual(10, root.RightChild.Value);
            Assert.AreEqual(50, root.RightChild.RightChild.Value);
            Assert.AreEqual(20, root.RightChild.RightChild.RightChild.Value);
            Assert.AreEqual(45, root.RightChild.RightChild.RightChild.RightChild.Value);
            Assert.AreEqual(35, root.RightChild.RightChild.RightChild.RightChild.RightChild.Value);
            Assert.IsNull(root.RightChild.RightChild.RightChild.RightChild.RightChild.RightChild);
        }

        [TestMethod]
        public void TestMethod_015_MinDepth()
        {
            _015_MinDepth target = new _015_MinDepth();
            string inputstring = "5,4,11,7,#,#,2,#,#,#,8,13,#,#,4,5,#,#,1,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            int actual = target.FindMinDepth(root);
            Assert.AreEqual(actual, 3);
        }

        [TestMethod]
        public void TestMethod_016_PathSum()
        {
            _016_PathSum target = new _016_PathSum();
            string inputstring = "5,4,11,7,#,#,2,#,#,#,8,13,#,#,4,5,#,#,1,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            List<List<int>> actual = target.FindAllPathSum(root, 22);

            Assert.AreEqual(2, actual.Count);
        }

        [TestMethod]
        public void Test_017_ConvertSortedListToBST()
        {
            _017_ConvertSortedListToBST target = new _017_ConvertSortedListToBST();
            LinkListNode input = LinkListNode.CreateLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            TreeNode actual = target.Convert(input);
            Assert.AreEqual(5, actual.Value);
            Assert.AreEqual(3, actual.LeftChild.Value);
            Assert.AreEqual(8, actual.RightChild.Value);
        }

        [TestMethod]
        public void Test_019_IsBalanceTree()
        {
            _019_IsBalanceTree target = new _019_IsBalanceTree();
            string inputstring = "5,4,11,7,#,#,2,#,#,#,8,13,#,#,4,5,#,#,1,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            int depth = 0;
            bool actual = target.IsBalanceTree(root, ref depth);
            Assert.IsFalse(actual);

            inputstring = "5,4,11,#,#,2,#,#,8,13,#,#,4,5,#,#,1,#,#";
            t = ',';
            root = TreeNode.DeserializeTree(inputstring, t);
            depth = 0;

            actual = target.IsBalanceTree(root, ref depth);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_020_ConvertPreOrderInOrderToTree()
        {
            _020_ConvertPreOrderInOrderToTree target = new _020_ConvertPreOrderInOrderToTree();
            int[] preOrder = new int[] { 7, 10, 4, 3, 1, 2, 8, 11 };
            int[] inOrder = new int[] { 4, 10, 3, 1, 7, 11, 8, 2 };

            TreeNode actual = target.CreateTree(preOrder, 0, 7, inOrder, 0, 7);
        }

        [TestMethod]
        public void Test_022_IsASymmetricTree()
        {
            _022_IsASymmetricTree target = new _022_IsASymmetricTree();
            string inputstring = "5,4,11,#,#,2,#,#,4,2,#,#,11,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            bool actual = target.IsSymmetricTree(root);
            Assert.IsTrue(actual);

            inputstring = "5,4,11,6,#,#,5,#,#,2,4,#,#,3,#,#,4,2,3,#,#,4,#,#,11,5,#,#,6,#,#";
            t = ',';
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.IsSymmetricTree(root);
            Assert.IsTrue(actual);

            inputstring = "5,4,11,6,#,#,5,#,#,2,3,#,#,4,#,#,4,2,3,#,#,4,#,#,11,5,#,#,6,#,#";
            t = ',';
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.IsSymmetricTree(root);
            Assert.IsFalse(actual);

            inputstring = "5,4,11,6,#,#,5,#,#,2,#,4,#,#,4,2,3,#,#,4,#,#,11,5,#,#,6,#,#";
            t = ',';
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.IsSymmetricTree(root);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_023_SameTree()
        {
            _023_SameTree target = new _023_SameTree();

            string inputstring = "5,4,11,#,#,2,#,#,4,2,#,#,11,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);

            string inputstring2 = "5,4,11,#,#,2,#,#,4,2,#,#,11,#,#";
            char t2 = ',';
            TreeNode root2 = TreeNode.DeserializeTree(inputstring2, t2);

            bool actual = target.IsSameTree(root, root2);
            Assert.IsTrue(actual);

            inputstring = "5,4,11,6,#,#,5,#,#,2,3,#,#,4,#,#,4,2,3,#,#,4,#,#,11,5,#,#,6,#,#";
            t = ',';
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.IsSameTree(root, root2);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_024_RecoverBST()
        {
            // make this test case always fail for now.
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void Test_025_InterLeavingString()
        {
            _025_InterLeavingString target = new _025_InterLeavingString();
            string s1 = "aabcc";
            string s2 = "dbbca";
            string p1 = "aadbbcbcac";

            bool actual = target.IsInterLeavingString(s1, s2, p1);
            Assert.IsTrue(actual);

            p1 = "aadbbbaccc";
            actual = target.IsInterLeavingString(s1, s2, p1);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_026_UniqueBinarySearchTree()
        {
            _026_UniqueBinarySearchTree target = new _026_UniqueBinarySearchTree();
            int left = 1;
            int right = 3;
            int actual = target.FindCountOfTree(left, right);

            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void Test_026_UniqueBinarySearchTreeII()
        {
            _026_UniqueBinarySearchTree target = new _026_UniqueBinarySearchTree();
            int left = 1;
            int right = 3;
            List<TreeNode> actual = target.CreateTree(left, right);

            Assert.AreEqual(5, actual.Count);
        }

        [TestMethod]
        public void Test_027_InOrderTraversal()
        {
            _027_InOrderTraversal target = new _027_InOrderTraversal();
            string inputstring = "5,4,11,#,#,2,#,#,4,2,#,#,11,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            List<int> actual = target.Inorder(root);

            List<int> expected = new List<int>() { 11, 4, 2, 5, 2, 4, 11 };

            Assert.AreEqual(actual.Count, expected.Count);
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void Test_028_RestoreIPAddress()
        {
            _028_RestoreIPAddress target = new _028_RestoreIPAddress();
            string input = "25525511135";
            List<string> actual = target.RestoreIPAddress(input);
            Assert.AreEqual(2, actual.Count);
        }

        [TestMethod]
        public void Test_030_ReverseLinkedList()
        {
            _030_ReverseLinkedList target = new _030_ReverseLinkedList();
            LinkListNode header = LinkListNode.CreateLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            target.RevertLinkedList(header, 2, 5);
            Assert.AreEqual(5, header.Next.Value);
            Assert.AreEqual(4, header.Next.Next.Value);
            Assert.AreEqual(3, header.Next.Next.Next.Value);
            Assert.AreEqual(2, header.Next.Next.Next.Next.Value);
        }

        [TestMethod]
        public void Test_031_SubSetsII()
        {
            _031_SubSetsII target = new _031_SubSetsII();
            List<string> actual = target.AllSubSet("122");
            Assert.AreEqual(6, actual.Count);
        }

        [TestMethod]
        public void Test_032_DecodeWays()
        {
            _032_DecodeWays target = new _032_DecodeWays();
            int actual = target.DecodeWays("3578192842147195591192396897759642198876762254143579341828893614332239365526549738642966692968639262");
            Assert.AreEqual(62208, actual);

            actual = target.DecodeWays("2458572165554798885765445448293852851118898685623693683848369117322831534583873934593964897519439836");
            Assert.AreEqual(1440, actual);
        }

        [TestMethod]
        public void Test_033_GrayCode()
        {
            _032_RestCodes target = new _032_RestCodes();
            List<string> actual = target._033_GrayCode(4);
            Assert.AreEqual(16, actual.Count);
            Assert.AreEqual("0000", actual[0]);

            actual = target._033_GrayCode(2);
            Assert.AreEqual(4, actual.Count);
            Assert.AreEqual("00", actual[0]);

        }

        [TestMethod]
        public void Test_034_MergeSortedArray()
        {
            _032_RestCodes target = new _032_RestCodes();
            int[] a = new int[] { 1, 3, 5, 7, 9, 0, 0, 0, 0, 0, 0 };
            int[] b = new int[] { 2, 4, 6 };
            target._034_MergeSortedArray(a, 5, b, 3);

            Assert.AreEqual(7, a[6]);
            Assert.AreEqual(9, a[7]);
        }

        [TestMethod]
        public void Test_035_scrambleStrings()
        {
            _032_RestCodes target = new _032_RestCodes();
            string s1 = "great";
            string s2 = "rgtae";
            bool actual = target._035_scrambleStrings(s1, s2);
            Assert.IsTrue(actual);

            s1 = "xstjzkfpkggnhjzkpfjoguxvkbuopi";
            s2 = "xbouipkvxugojfpkzjhnggkpfkzjts";
            actual = target._035_scrambleStrings(s1, s2);
            Assert.IsTrue(actual);

            s1 = "ymjmfxshglxwrrgufcvvzjuietjzzz";
            s2 = "fxczujvmwizrzgxgjmvzelyjthusrf";
            actual = target._035_scrambleStrings(s1, s2);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_035_scrambleStringsII()
        {
            _032_RestCodes target = new _032_RestCodes();
            string s1 = "great";
            string s2 = "rgtae";
            bool actual = target._035_scrambleStringsII(s1, s2);
            Assert.IsTrue(actual);

            s1 = "xstjzkfpkggnhjzkpfjoguxvkbuopi";
            s2 = "xbouipkvxugojfpkzjhnggkpfkzjts";
            actual = target._035_scrambleStringsII(s1, s2);
            Assert.IsTrue(actual);

            s1 = "ymjmfxshglxwrrgufcvvzjuietjzzz";
            s2 = "fxczujvmwizrzgxgjmvzelyxthusrf";
            actual = target._035_scrambleStringsII(s1, s2);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_037_MaxRectangle()
        {
            _032_RestCodes target = new _032_RestCodes();
            List<string> input = new List<string>() { "00010111", "01100101", "10111101", "00010000", "00100010", "11100111", "10011001", "01001100" };
            int actual = target._037_MaxRectangle(input, 8);
            Assert.AreEqual(4, actual);

        }

        [TestMethod]
        public void Test_038_MaxRectangle()
        {
            _032_RestCodes target = new _032_RestCodes();
            int[] input = new int[] { 5, 4, 1, 2 };
            int actual = target._038_MaxRetangleInHistogram(input, 0, input.Length - 1);
            Assert.AreEqual(8, actual);


            input = new int[] { 4, 2, 0, 3, 2, 4, 3, 4 };
            actual = target._038_MaxRetangleInHistogram(input, 0, input.Length - 1);
            Assert.AreEqual(10, actual);

            input = new int[] { 3, 6, 5, 7, 4, 8, 1, 0 };
            actual = target._038_MaxRetangleInHistogram(input, 0, input.Length - 1);
            Assert.AreEqual(20, actual);

        }

        [TestMethod]
        public void Test_039_RemoveDup()
        {
            _032_RestCodes target = new _032_RestCodes();
            int[] input = new int[] { 1, 1, 2, 2, 4, 3, 3 };
            LinkListNode header = LinkListNode.CreateLinkList(input);
            target._039_RemoveDup(header);
            Assert.AreEqual(1, header.Value);
            Assert.AreEqual(2, header.Next.Value);
            Assert.AreEqual(4, header.Next.Next.Value);
            Assert.AreEqual(3, header.Next.Next.Next.Value);
        }

        [TestMethod]
        public void Test_040_RemoveDup()
        {
            _032_RestCodes target = new _032_RestCodes();
            int[] input = new int[] { 1, 1, 2, 2, 4, 3, 3 };
            LinkListNode header = LinkListNode.CreateLinkList(input);
            LinkListNode actual = target._040_RemoveDupII(header);
            Assert.AreEqual(4, actual.Value);
        }

        [TestMethod]
        public void Test_041_SearchInRotatedSortedArray()
        {
            _032_RestCodes target = new _032_RestCodes();
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, -5, -4, -3, -2, -1, 0 };
            int actual = target._041_SearchInRotatedSortedArray(input, 4, 0, input.Length - 1);
            Assert.AreEqual(3, actual);

            actual = target._041_SearchInRotatedSortedArray(input, -3, 0, input.Length - 1);
            Assert.AreEqual(11, actual);

            actual = target._041_SearchInRotatedSortedArray(input, 1, 0, input.Length - 1);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Test_042_SortColor()
        {
            _032_RestCodes target = new _032_RestCodes();
            int[] input = new int[] { 0, 1, 2, 1, 1, 2, 1, 2, 0, 1, 0, 2, };
            target._042_SortColor(input);

            for (int i = 1; i < input.Length; i++)
            {
                Assert.IsTrue(input[i] >= input[i - 1]);
            }
        }

        [TestMethod]
        public void Test_044_EditDistance()
        {
            _032_RestCodes target = new _032_RestCodes();
            string s1 = "algorithm";
            string s2 = "altruistic";
            int actual = target._044_EditDistance(s1, s2);
            Assert.AreEqual(6, actual);

            s1 = "prosperity";
            s2 = "properties";
            actual = target._044_EditDistance(s1, s2);
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void Test_044_EditDistanceII()
        {
            _032_RestCodes target = new _032_RestCodes();
            string s1 = "algorithm";
            string s2 = "altruistic";
            int actual = target._044_EditDistanceII(s1, s2);
            Assert.AreEqual(6, actual);

            s1 = "prosperity";
            s2 = "properties";
            actual = target._044_EditDistanceII(s1, s2);
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void Test_045_SimplifyPath()
        {
            _032_RestCodes target = new _032_RestCodes();
            string s = "/a/./b/../../c/";
            string actual = target._045_SimplifyPath(s);
            Assert.AreEqual("/c/", actual);

            s = "/home//foo/";
            actual = target._045_SimplifyPath(s);
            Assert.AreEqual("/home/foo/", actual);
        }

        [TestMethod]
        public void Test_046_MergeIntervals()
        {
            _032_RestCodes target = new _032_RestCodes();
            Tuple<int, int> t1 = new Tuple<int, int>(1,3);
            Tuple<int, int> t2 = new Tuple<int, int>(2, 6);
            Tuple<int, int> t3 = new Tuple<int, int>(8, 10);
            Tuple<int, int> t4 = new Tuple<int, int>(15, 18);
            //[1,3],[2,6],[8,10],[15,18],
            List<Tuple<int, int>> input = new List<Tuple<int, int>>() { t1, t2, t3, t4 };
            List<Tuple<int, int>> actual = target._046_MergeIntervals(input);

            Assert.AreEqual(3, actual.Count);
        }

        [TestMethod]
        public void Test_047_IsThereALoop()
        {
            _032_RestCodes target = new _032_RestCodes();
            int[] input = new int[] { 6, 7, 3, 4, 5 };
            bool actual = target._047_IsThereALoop(input);
            Assert.IsFalse(actual);

            input = new int[] { 2, 0, 4, 0, 1 };
            actual = target._047_IsThereALoop(input);
            Assert.IsTrue(actual);
        }
    }
}