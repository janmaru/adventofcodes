using Mahamudra.AdventOfCode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Mahamudra.AdventOfCode.UnitTests
{
    [TestClass]
    public class UnitTest2015
    {
        private readonly string _inputDayOne;
        private readonly string _inputDayTwo;
        private readonly string _inputDayThree;
        private readonly string _secretKey;
        private readonly string _niceString;
        private readonly string _lights;
        public UnitTest2015()
        {
            _inputDayOne = @"()()(()()()(()()((()((()))((()((((()()((((()))()((((())(((((((()(((((((((()(((())(()()(()((()()(()(())(()((((()((()()()((((())((((((()(()(((()())(()((((()))())(())(()(()()))))))))((((((((((((()())()())())(())))(((()()()((((()(((()(()(()()(()(()()(()(((((((())(())(())())))((()())()((((()()((()))(((()()()())))(())))((((())(((()())(())(()))(()((((()())))())((()(())(((()((((()((()(())())))((()))()()(()(()))))((((((((()())((((()()((((()(()())(((((()(()())()))())(((()))()(()(()(()((((()(())(()))(((((()()(()()()(()(((())())(((()()(()()))(((()()(((())())(()(())())()()(())()()()((()(((()(())((()()((())()))((()()))((()()())((((()(()()(()(((()))()(()))))((()(((()()()))(()(((())()(()((()())(()(()()(()())(())()(((()(()())()((((()((()))))())()))((()()()()(())()())()()()((((()))))(()(((()()(((((((())()))()((((()((())()(()())(())()))(()(()())(((((((())))(((()))())))))()))())((())(()()((())()())()))))()((()()())(())((())((((()())())()()()(((()))())))()()))())(()()()(()((((((()()))())()))()(((()(((())((((()()()(()))())()()))))())()))())((())()())(((((())())((())())))(((())(((())(((((()(((((())(()(()())())(()(())(()))(()((((()))())()))))())))((()(()))))())))(((((())()))())()))))()))))(((()))()))))((()))((()((()(()(())()())))(()()()(())()))()((((())))))))(())(()((()()))(()))(()))(()((()))))))()()((((()()))()())()))))))()()()))(()((())(()))((()()()())()(((()((((())())))()((((()(()))))))())))()()())()))(()))))(()())()))))))((())))))))())()))()((())())))(()((()))()))(())))))(()))()())()()))((()(()))()()()()))))())()()))())(())()()))()))((()))))()()(()())))))()()()))((((()))()))))(()(())))(()())))((())())(()))()))))()())))()())()())))))))))()()))))())))((())((()))))())))(((()())))))))(()))()()))(()))()))))()())))))())((((()())))))))())))()()))))))))()))()))))()))))))(())))))))))())))))))))))))))())())((())))))))))()))((())))()))))))))())()(()))))))())))))()()()())()(()()()(()())(()))()()()(()())))())())))()))))())))))))()()()()())(())())()())()))))(()()()()()))))()))())())))((()())()())))()))()))))(()())))()))))))))(((()))()()))))))))))))))))))))(()))(()((()))())))())(()))(()(()(())))))()(()))()))()()))))))))))))()((()())(())())()(())))))())()())((()()))))(()()))))())()(())()))))))))))))))))))))()))(()(()())))))))()()((()))()))))))((())))()))))))))((()))())()()))())()()))((()))())))))))))))(()())()))(())((()(()()))(()())(())))()())(()(())()()))))()))()(()))))))(()))))))))))(()))())))))))))())))))())))(())))))()))))(())())))))))))()(()))))()())))())(()))()())))))))))))))())()()))))()))))))())))))()))))(())(()()()()((())()))())(()))((())()))())())(())(()()))))()))(())()()((())(())))(())))()))())))))))))()(((((())())))(())()))))(())))((()))()(((((((()))))()()))(())))))()(()))))(()()))()))())))))))(()())()))))))))())))(()))())()))(())()((())())()())())(()(()))))()))))))((()())(())()()(()())))()()))(())(())(()))())))()))(()))()()))((((()))))()))((()()()))))()))()))())))(()))()))))(())))()))())()(()))()())))())))))))())))())))()()))))))(()))())())))()))()()())())))))))))))))())))()))(()()))))())))())()(())))())))))))))))))))))()()())())))))()()()((()(()))()()(())()())()))()))))()()()))))))((()))))))))()(()(()((((((()()((()())))))))))))()))())))))((())())(()))())))())))))())()()())(())))())))()())())(())))))))()()(())))()))())))())())())()))))))))()))(()()()())())())))(())())))))))()()())()))))())))())()(())())))))))()())()))(()()(())())))()(()((()()((()()(((((())(()())()))(())()))(())))(())))))))()))()))((()))()))()))))))))()))))))))((()()())(()))(((()))(())))()))((())(((())))()())))())))))((())))))(())())((((((())())()(()))()(()((()())))((())()(()(()))))(())(()()())(())))())((()(((())())))(((()())())))())()(())())((((()()))))())((()))()()()()(())(((((((()()()((()))())(()())))(())())((((()()(()))))()((())))((())()))()(((()))())))()))((()(()))(())(()((((())((((()()(()()))(((())(()))))((((()(()))(())))))((()))(()))((()(((()(()))(()(()((()(())(()(()(()(()()((()))())(((())(()(()))))(()))()()))(())))(())()(((())(()))()((((()()))))())(()))))((())()((((()(((()))())())(((()))()())((())(())())(())()(())()(()()((((((()()))))()()(((()()))))()())()(((()(()))(()(()())(()(()))))(((((()(((())())))))(((((()((()()((())())((((((()(())(()()((()()()()()()()(()()))()(((()))()))(((((((())(((()((()())()((((())(((()(())))()((()(()()()((())((()())()))()))())))())((((((()))(()(()()()))(()((()(()(()))()((()(((()()()((())(((((())()(()))())())((()(())))(()(()())(())((())())())(((()()()(())))))())(()))))))()))))))())((()()()))((()((((((()))(((()((((()()()(((()))())()(()()(((()((()()()()())()()))()()()(()(())((()))))(()))())))))))()(()()(((((())()(()(((((()((()(()()())(()((((((((()((((((())()((((()()()((()((()((((((()))((())))))))())()))((()(()))()(()()(()((())((()()((((((((((((()())(()()()))((((()((((((())(()))())(()()((()()))()(((((((()((()()((((((()(((())))((())))((((((((()()(((((((())(((((()())(((())((())()((((()(((((((()(()(((()((((((()(((()(((((((((((()()((()()(()))((()()(((()(((())))((((())()(()(((())()(()(((())(((((((((((()))())))((((((())((()()((((()())())((((()()))((())(((((()(()()(()()()((())(()((()()((((()(((((()((()(()((((()())((((((()(((((()()(()(()((((())))(())(())(())((((()(()()((((()((((()()((()((((((())))(((((()))))()))(()((((((((()(((())())(((())))(()(()((())(((()((()()(((((()((()()(((())()(()))(((((((())(()(((((()))((()((()((()))(())())((((()((((())()(()))(((()(((((((((((((((())(((((((((()))(((()(()()()()((((((()((())()((((((((()(())(((((((((((()(()((())()((()()(()(()()((((()()((())(()((()()(()()((((()(((((((())))((((())(())()(((()()((()()((((()((()(((()((())(((()()()((((()((((()()(()(()((((((((())(()(((((())(()())(((((((()())()(()((((()((())(()()())((((()()(((()((((())(())(()()(((((((((()()))()(((())(()(()((((((())(()()())(()))()()(((()(((()((())(()(((((((()(()(()((()(((((()(()((()(()((((((()((((()()((((()(((()((())(()(()((()()((((()()(())()(())(((())(()((((((((()())(((((((((()(())()((((())))()))()()(((((()()((((((())(()()(((()(()(((((((()(()(((((((())(())((((()((()(())))((((()()())(()))((()())((((()(((((()(()(())(()(()()())(((((()(((((()((((()()((((((((()()))(()((((((())((((())()(()(((()()()(((()(()(())(())(((((()(())())((((())(())(()(((()(((((())((((())())((()(((((((()(((())(()(()))(((((((((()((()((()()(()((((())(((()((())((((())(()(((()(((()(()((((()(((())(()(((()(()()(()(()((()()(()())(())())((()(()(((()(((()(((()()(((((((((()(((((((((()()(((()(((()())((((()(()(((()()()((())((((((((((())(()(((()((((()())((((()((()))(((()()()(((((()(((((((())((()())(()((((())((((((((())(()((()((((((((((()()((()((()()))(((()())()())()(((()())()()(()(()(((((((())()))(())()))())()()((())()((()((((()((()((())(((((()((((((()(())))(()))())(((()))((()()(()(((()))((((())()(((()))))()(()(())()(((((())(()(()(())(())()((()()()((((()(())((()())(()(()))(()(()(()()(())()()(()((())()((()))))()))((()(()()()()((()())(()))())()(()(((((((((())())((()((()((((((())()((((())(((())((()(()()()((())(()((())(((()((((()()((()(()(((((())()))()((((((()))((())(((()()))(((())(())()))(((((((())(())())()(())(((((()))()((()))()(()()((()()()()()())(((((((";
            _inputDayTwo = @"3x11x24
13x5x19
1x9x27
24x8x21
6x8x17
19x18x22
10x9x12
12x2x5
26x6x11
9x23x15
12x8x17
13x29x10
28x18x6
22x28x26
1x5x11
29x26x12
8x28x29
27x4x21
12x7x16
7x4x23
15x24x8
15x14x2
11x6x29
28x19x9
10x3x1
5x20x13
10x25x1
22x17x7
16x29x3
18x22x8
18x11x19
21x24x20
4x7x17
22x27x12
1x26x6
5x27x24
29x21x3
25x30x2
21x26x2
10x24x27
10x16x28
18x16x23
6x5x26
19x12x20
6x24x25
11x20x7
4x8x5
2x13x11
11x17x1
13x24x6
22x29x16
4x24x20
10x25x10
12x29x23
23x27x12
11x21x9
13x2x6
15x30x2
8x26x24
24x7x30
22x22x8
29x27x8
28x23x27
13x16x14
9x28x20
21x4x30
21x20x20
11x17x30
9x14x22
20x2x6
10x11x14
1x8x23
23x19x19
26x10x13
21x12x12
25x7x24
1x28x17
20x23x9
2x24x27
20x24x29
1x3x10
5x20x14
25x21x3
15x5x22
14x17x19
27x3x18
29x23x19
14x21x19
20x8x3
22x27x12
24x15x18
9x10x19
29x25x28
14x22x6
4x19x28
4x24x14
17x19x17
7x19x29
28x8x26
7x20x16
11x26x29
2x18x3
12x7x18
11x15x21
24x7x26
2x22x23
2x30x5
1x19x8
15x29x10
15x26x22
20x16x14
25x29x22
3x13x19
1x12x30
3x15x27
19x9x11
30x8x21
26x12x20
11x17x19
17x25x1
19x24x12
30x6x20
11x19x18
18x15x29
18x8x9
25x15x5
15x6x26
13x27x19
23x24x12
3x15x28
17x10x10
15x4x7
15x27x7
21x8x11
9x18x2
7x20x20
17x23x12
2x19x1
7x26x26
13x23x8
10x3x12
11x1x9
1x11x19
25x14x26
16x10x15
7x6x11
8x1x27
20x28x17
3x25x9
30x7x5
17x17x4
23x25x27
23x8x5
13x11x1
15x10x21
22x16x1
12x15x28
27x18x26
25x18x5
21x3x27
15x25x5
29x27x19
11x10x12
22x16x21
11x8x18
6x10x23
21x21x2
13x27x28
2x5x20
23x16x20
1x21x7
22x2x13
11x10x4
7x3x4
19x2x5
21x11x1
7x27x26
12x4x23
12x3x15
25x7x4
20x7x15
16x5x11
1x18x26
11x27x10
17x6x24
19x13x16
6x3x11
4x19x18
16x15x15
1x11x17
19x11x29
18x19x1
1x25x7
8x22x14
15x6x19
5x30x18
30x24x22
11x16x2
21x29x19
20x29x11
27x1x18
20x5x30
12x4x28
3x9x30
26x20x15
18x25x18
20x28x28
21x5x3
20x21x25
19x27x22
8x27x9
1x5x15
30x6x19
16x5x15
18x30x21
4x15x8
9x3x28
18x15x27
25x11x6
17x22x15
18x12x18
14x30x30
1x7x23
27x21x12
15x7x18
16x17x24
11x12x19
18x15x21
6x18x15
2x21x4
12x9x14
19x7x25
22x3x1
29x19x7
30x25x7
6x27x27
5x13x9
21x4x18
13x1x16
11x21x25
27x20x27
14x25x9
23x11x15
22x10x26
15x16x4
14x16x21
1x1x24
17x27x3
25x28x16
12x2x29
9x19x28
12x7x17
6x9x19
15x14x24
25x21x23
26x27x25
7x18x13
15x10x6
22x28x2
15x2x14
3x24x18
30x22x7
18x27x17
29x18x7
20x2x4
4x20x26
23x30x15
5x7x3
4x24x12
24x30x20
26x18x17
6x28x3
29x19x29
14x10x4
15x5x23
12x25x4
7x15x19
26x21x19
18x2x23
19x20x3
3x13x9
29x21x24
26x13x29
30x27x4
20x10x29
21x18x8
7x26x10
29x16x21
22x5x11
17x15x2
7x29x5
6x18x15
23x6x14
10x30x14
26x6x16
24x13x25
17x29x20
4x27x19
28x12x11
23x20x3
22x6x20
29x9x19
10x16x22
30x26x4
29x26x11
2x11x15
1x3x30
30x30x29
9x1x3
30x13x16
20x4x5
23x28x11
24x27x1
4x25x10
9x3x6
14x4x15
4x5x25
27x14x13
20x30x3
28x15x25
5x19x2
10x24x29
29x30x18
30x1x25
7x7x15
1x13x16
23x18x4
1x28x8
24x11x8
22x26x19
30x30x14
2x4x13
27x20x26
16x20x17
11x12x13
28x2x17
15x26x13
29x15x25
30x27x9
2x6x25
10x26x19
16x8x23
12x17x18
26x14x22
13x17x4
27x27x29
17x13x22
9x8x3
25x15x20
14x13x16
8x7x13
12x4x21
27x16x15
6x14x5
28x29x17
23x17x25
10x27x28
1x28x21
18x2x30
25x30x16
25x21x7
2x3x4
9x6x13
19x6x10
28x17x8
13x24x28
24x12x7
5x19x5
18x10x27
16x1x6
12x14x30
1x2x28
23x21x2
13x3x23
9x22x10
10x17x2
24x20x11
30x6x14
28x1x16
24x20x1
28x7x7
1x24x21
14x9x7
22x8x15
20x1x21
6x3x7
7x26x14
5x7x28
5x4x4
15x7x28
30x16x23
7x26x2
1x2x30
24x28x20
5x17x28
4x15x20
15x26x2
1x3x23
22x30x24
9x20x16
7x15x2
6x21x18
21x21x29
29x10x10
4x3x23
23x2x18
29x24x14
29x29x16
22x28x24
21x18x24
16x21x6
3x9x22
9x18x4
22x9x9
12x9x13
18x21x14
7x8x29
28x28x14
1x6x24
11x11x3
8x28x6
11x16x10
9x16x16
6x6x19
21x5x12
15x17x12
3x6x29
19x1x26
10x30x25
24x26x21
1x10x18
6x1x16
4x17x27
17x11x27
15x15x21
14x23x1
8x9x30
22x22x25
20x27x22
12x7x9
9x26x19
26x25x12
8x8x16
28x15x10
29x18x2
25x22x6
4x6x15
12x18x4
10x3x20
17x28x17
14x25x13
14x10x3
14x5x10
7x7x22
21x2x14
1x21x5
27x29x1
6x20x4
7x19x23
28x19x27
3x9x18
13x17x17
18x8x15
26x23x17
10x10x13
11x5x21
25x15x29
6x23x24
10x7x2
19x10x30
4x3x23
22x12x6
11x17x16
6x8x12
18x20x11
6x2x2
17x4x11
20x23x22
29x23x24
25x11x21
22x11x15
29x3x9
13x30x5
17x10x12
10x30x8
21x16x17
1x5x26
22x15x16
27x7x11
16x8x18
29x9x7
25x4x17
10x21x25
2x19x21
29x11x16
18x26x21
2x8x20
17x29x27
25x27x4
14x3x14
25x29x29
26x18x11
8x24x28
7x30x24
12x30x22
29x20x6
3x17x1
6x15x14
6x22x20
13x26x26
12x2x1
7x14x12
15x16x11
3x21x4
30x17x29
9x18x27
11x28x16
22x3x25
18x15x15
2x30x12
3x27x22
10x8x8
26x16x14
15x2x29
12x10x7
21x20x15
2x15x25
4x14x13
3x15x13
29x8x3
7x7x28
15x10x24
23x15x5
5x7x14
24x1x22
1x11x13
26x4x19
19x16x26
5x25x5
17x25x14
23x7x14
24x6x17
5x13x12
20x20x5
22x29x17
11x17x29
25x6x4
29x8x16
28x22x24
24x23x17
16x17x4
17x8x25
22x9x13
24x4x8
18x10x20
21x23x21
13x14x12
23x26x4
4x10x29
2x18x18
19x5x21
2x27x23
6x29x30
21x9x20
6x5x16
25x10x27
5x29x21
24x14x19
19x11x8
2x28x6
19x25x6
27x1x11
6x8x29
18x25x30
4x27x26
8x12x1
7x17x25
7x14x27
12x9x5
14x29x13
18x17x5
23x1x3
28x5x13
3x2x26
3x7x11
1x8x7
12x5x4
2x30x21
16x30x11
3x26x4
16x9x4
11x9x22
23x5x6
13x20x3
4x3x2
14x10x29
11x8x12
26x15x16
7x17x29
18x19x18
8x28x4
22x6x13
9x23x7
11x23x20
13x11x26
15x30x13
1x5x8
5x10x24
22x25x17
27x20x25
30x10x21
16x28x24
20x12x8
17x25x1
30x14x9
14x18x6
8x28x29
12x18x29
9x7x18
6x12x25
20x13x24
22x3x12
5x23x22
8x10x17
7x23x5
10x26x27
14x26x19
10x18x24
8x4x4
16x15x11
3x14x9
18x5x30
29x12x26
16x13x12
15x10x7
18x5x26
14x1x6
10x8x29
3x4x9
19x4x23
28x17x23
30x7x17
19x5x9
26x29x28
22x13x17
28x2x1
20x30x8
15x13x21
25x23x19
27x23x1
4x6x23
29x29x24
5x18x7
4x6x30
17x15x2
27x4x2
25x24x14
28x8x30
24x29x5
14x30x14
10x18x19
15x26x22
24x19x21
29x23x27
21x10x16
7x4x29
14x21x3
21x4x28
17x16x15
24x7x13
21x24x15
25x11x16
10x26x13
23x20x14
20x29x27
14x24x14
14x23x12
18x6x5
3x18x9
8x18x19
20x26x15
16x14x13
30x16x3
17x13x4
15x19x30
20x3x8
13x4x5
12x10x15
8x23x26
16x8x15
22x8x11
12x11x18
28x3x30
15x8x4
13x22x13
21x26x21
29x1x15
28x9x5
27x3x26
22x19x30
4x11x22
21x27x20
22x26x7
19x28x20
24x23x16
26x12x9
13x22x9
5x6x23
20x7x2
18x26x30
3x6x28
24x18x13
28x19x16
25x21x25
25x19x23
22x29x10
29x19x30
4x7x27
5x12x28
8x26x6
14x14x25
17x17x2
5x27x11
8x2x2
3x20x24
26x10x9
22x28x27
18x15x20
12x11x1
5x14x30
7x3x16
2x16x16
18x20x15
13x14x29
1x17x12
13x5x23
19x4x10
25x19x11
15x17x14
1x28x27
11x9x28
9x10x18
30x11x22
21x21x20
2x1x5
2x25x1
7x3x4
22x15x29
21x28x15
12x12x4
21x30x6
15x10x7
10x14x6
21x26x18
14x25x6
9x7x11
22x3x1
1x16x27
1x14x23
2x13x8
14x19x11
21x26x1
4x28x13
12x16x20
21x13x9
3x4x13
14x9x8
21x21x12
27x10x17
6x20x6
28x23x23
2x28x12
8x10x10
3x9x2
20x3x29
19x4x16
29x24x9
26x20x8
15x28x26
18x17x10
7x22x10
20x15x9
6x10x8
7x26x21
8x8x16
15x6x29
22x30x11
18x25x8
6x21x20
7x23x25
8x25x26
11x25x27
22x18x23
3x2x14
16x16x1
15x13x11
3x9x25
29x25x24
9x15x1
12x4x1
23x30x20
3x1x23
6x10x29
28x13x24
4x19x17
6x6x25
27x29x17
12x13x2
10x7x13
14x15x8
22x2x3
27x17x19
23x10x16
5x9x25
9x25x14
11x18x6
18x10x12
9x4x15
7x16x14
17x24x10
11x4x6
12x9x17
22x18x12
6x24x24
6x22x23
5x17x30
6x9x5
17x20x10
6x8x12
14x17x13
29x10x17
22x4x5
10x19x30
22x29x11
10x12x29
21x22x26
16x6x25
1x26x24
30x17x16
27x28x5
30x13x22
7x26x12
11x24x30
1x17x25
22x1x3
29x24x6
4x8x24
13x9x20
8x12x9
21x25x4
23x23x28
5x2x19
29x3x15
22x1x14
3x23x30
8x25x3
15x8x14
30x14x6
23x27x24
19x1x2
10x9x13
13x8x7
8x13x22
5x15x20
17x14x8
5x11x20
5x10x27
24x17x19
21x2x3
15x30x26
21x19x15
2x7x23
13x17x25
30x15x19
26x4x10
2x25x8
9x9x10
2x25x8
19x21x30
17x26x12
7x5x10
2x22x14
10x17x30
1x8x5
23x2x25
22x29x8
13x26x1
26x3x30
25x17x8
25x18x26
26x19x15
8x28x10
12x16x29
30x6x29
28x19x4
27x26x18
15x23x17
5x21x30
8x11x13
2x26x7
19x9x24
3x22x23
6x7x18
4x26x30
13x25x20
17x3x15
8x20x18
23x18x23
28x23x9
16x3x4
1x29x14
20x26x22
3x2x22
23x8x17
19x5x17
21x18x20
17x21x8
30x28x1
29x19x23
12x12x11
24x18x7
21x18x14
14x26x25
9x11x3
10x7x15
27x6x28
14x26x4
28x4x1
22x25x29
6x26x6
1x3x13
26x22x12
6x21x26
23x4x27
26x13x24
5x24x28
22x16x7
3x27x24
19x28x2
11x13x9
29x16x22
30x10x24
14x14x22
22x23x16
14x8x3
20x5x14
28x6x13
3x15x25
4x12x22
15x12x25
10x11x24
7x7x6
8x11x9
21x10x29
23x28x30
8x29x26
16x27x11
1x10x2
24x20x16
7x12x28
28x8x20
14x10x30
1x19x6
4x12x20
18x2x7
24x18x17
16x11x10
1x12x22
30x16x28
18x12x11
28x9x8
23x6x17
10x3x11
5x12x8
22x2x23
9x19x14
15x28x13
27x20x23
19x16x12
19x30x15
8x17x4
10x22x18
13x22x4
3x12x19
22x16x23
11x8x19
8x11x6
7x14x7
29x17x29
21x8x12
21x9x11
20x1x27
1x22x11
5x28x4
26x7x26
30x12x18
29x11x20
3x12x15
24x25x17
14x6x11";
            _inputDayThree = "v>v<vvv<<vv^v<v>vv>v<<<^^^^^<<^<vv>^>v^>^>^>^>^><vvvv<^>^<<^><<<^vvvv>^>^><^v^><^<>^^>^vvv^<vv>>^>^^<>><>^>vvv>>^vv>^<><>^<v^>^>^><vv^vv^>><<^><<v>><>^<^>>vvv>v>>>v<<^<><^<v<>v>^^v^^^<^v^^>>><^>^>v<>^<>>^>^^v^><v<v>>><>v<v^v>^v<>>^><v>^<>v^>^<>^v^^^v^^>>vv<<^^><^<vvv>^>^^<^>>^^^^^v^<v>vv<>>v^v<^v^^<><^<^vv^><>><><>v>vvv^vv^^<<><<vvv><<^v^><v<>vvv^<^>vvvv^>^>>^v^<v^vv<^^v<>v>vv^<>><v<<<^v^<<><v<^<^<><^^^>^>>v>^>v^<>v><^<^<v^>^^vv<^^<>v^v^vv<>>>>v^v<>><^^v>vv^^>v^v>v<vv>>v>><v^v^v>vv>^^>^v><<vv^v^^vv<^v><^<<v<v^>vv^^^<v^>v>v^^^>><^^<v^<^>>v><vv<v^^>^^v>>v^^^<^^v>^v>><^<^<>>v<<^^vv>^^^v<^<^<v<v^^vv>^vv^>>v^><v>><<<>^vv^<^<>v^^<<<v<^>^><><v^^>>^^^<^vv<^^^>><^^v>^^v^<v^v^>^^<v>^<^v<^<<<<^<v^>v^<^^<>^^>^><<>>^v><>><^<v><^^^>>vv>^><vv>^^^^^v^vvv><><^<^>v>v^v^>^><><^<^><>v<<vv<^>><>^v^^v>^<<<>^v^>^<<v^vv<>v^<v^^vv><<v^<>>>^<v>vv>v>>>^<^>><vv<>>>>v<v>>>^v>v><>>vvv<^^><<^>^>v<^vvvv<v><vv<><^^^v^^^>v^v<>v<^^v>>><>v<v^>>v><v^>>^^<v<<<^<v<><^^v><<v^><<<<^vv<^<>^><vv<<<<^>>>^v>^v>vv>^v<>v>v<v><^>>v>>^>^><^<v^v^>^v<><><^^>^<vvvv^^<>^^^>vv^v^v>^v^^v^^v><v^<^<>><^<v>v>>vv<<v>>vvvv<vv><>>^v^>^>>v^v^<<<vv<><v<<>>>^v<<v>^^vv^><>v>^>v><<<<<<<^>^^v^<<^^>>vvv^<><>><>^^v<<vv><^^v<^^><vv>v^>>>v^v><v^v<^>v^><>v<<>v>^^v><<<<><^v^v>>^<>^<<>^<v<<>>v<<>><^<<<<^v>^<^v>v>vv<v<v<<>^>v<^<<>v^<vvvv^>v>><<v><v<>v>v>>v^vvv^^>>>v^<^<<^^<<<><v>v^<<v<<<>v<^^<><v<v^^<v>^>v>>v<>^>^^>>^v<<>v^^^>>>^vv<^v<v>^>v>^><>v^^<>^^v^^vv^<^>^<<>><<^>^v>>><<<vvvv><<><v<^v^v<vvv^<><<^<vv><v^v^v^>v>v^<vvv^><^><^<vv><>>v^>^^^<>><v^<^^^<>v<<v<^v>>>^>>v^><<>vvv><^>>v><v><>v>>^>v><<><<>^<>^^^vv><v^>v^^>>^>^<^v<v<^^<^vvvv>v<v>^>v^>^><^<vvvv><^><><<v<>v<v^><^<v^>^v^^<<<<^><^^<^><>>^v<<^<<^vv>v>>v<^<^vv>><v<vv>v<v<v>^v<>^>v<>^v<<<v>>^^v>>><vvv>v^>^v^v>^^^v<vvvv>><^>vvv^<vv^^vv><<<>v<>v>^<vvv^<^<v<v<^vv^^>>vv^<^^v^><^^^^^v<^<v<^>>>vv^v^>^<v>^<><v^<^v>>><^v^<<v<<v<>v>^v<v^v>>^^v<<v<v<<>>>vv>>^v>>^<<<<^><<<><^^>>v<>^vvvv>v^^^>^^^>^<vvvv><^^v<v<>v<^v^v<<v^^^v^<v<^v>v^^<>^>^<^v>vv<v^vv<^<<>v><<^><><^^v<<><^^><>^v>^<><<^<^^<<>vv<>^^<<^>><<<>>vvv>^>v^^v^><<^>v>^>^<^<<>v<^>vv^v^v<>vv<<v>vv<vv><^>v^<>^vv^v^<v<^>>>>v^v><^<><<>vv^<vvv^>>vvv^>v>>><^^vv<vvvv>v<^<^>>^^>^^vv>>><^v<>^v^<<>v^^^<v>^>>^<^<v>>^v<^^^<v>^v>^>>v<vv>>^<v^<<>>^>>><v>v^<<^<v>>^<<^^<>v<^v<^<>v^v>^^v<vvvv>^vv>vvv>v^<^>><v^^vv<<<^>vvvv<>>^^<>v^<><>v<^<>v<>^>v<>vv<v^v>>v<v<^<v^^v^vv^vvv><^^>v>><>>^<^^<>>^>^<v^>>vvv^v><v>>^>^>v><><<><vv^v>v<>^v<^vv^^^<>^^<<^^^v<>><v<^<^<^<^^><v^v<^>v^>vvvv>^^v^>^<v<^^^>>^<<vv^<><><^^^^<<>^<><v>vv^<><^>^^<>v^<>>>v><>vvvvv>v>v^^>^<<vvvv<>vv>>v<<^<>^^^v^<><>>^<<<v<v<>>>><><v>v<v<>>^>^^^^vv^^<<><^^<<vv<^<>v>vv<v<><<<^<<v<<<<>v<>>^<^>^>><v>v>><^^<>><<<><<><v^^v<<><^<^v<v^><^^v<<>><<<<^>v^<v>><v^><v<vvv>v^v^<v><<>>v<><<v>^<>><>>^><>v^v>v<<>v<>v^^><<>>>v<<>>>>^>v>><v<<>>>vv>v>^<^^^<>v<v>^<^^v^vvv^>vv>^<v><vvvv>^<<>vvv<<<vv>^^<^>^>>v>v<<<<<>^^vv^>>v>^<^<v^v^>^v>>v>^v<><>^<^>v>v<<<^^^v>^<<<>vvv^v^^>^>>^>v>v<>^^><>>v>^>v<<<^^^v^<v^vv>><><^<^<><vvv<v^>>^v>vv<^v<<^vv>v^<<v>v>v>^v^>^v<<^v^vv>v<v>^<<><v^>>v<>><v<<<^v<<>vvv^<vv<vvv<<>^vv^^v><^>v^vv<<v^<<^^^<^<>^^<<>v<><<v>^><>^<><<v<v^^>vv<>^<v<^<vvv>vv>v><^^v<>><^v^v><><>><v<v>vv<>>><v^^v<>><<^>>><^^^vvv<<<vv<<^v<<<>><<vv>>>>v<<<<<vv><><v>v^^<<^vv^<vv<>>vv>^<>^v^^<>^^^vv>v^^<v<><v>v<v>>^v<v<>>^<v^^><>v^^^>v^^v<vv><^>v^v^<>v>v<v<^^>>v<^^vv^v<^^^^vv<<><<^>>^^<<v^^<<^>v^>>^^^><^^>^v^v>^<<v<vv<<<v<^^^>^>>^v<>^<^>v>^>^v^<^^^<^vv<v><^^>>v<v>^>^v^>>>>^v>^^<<^<v^v<^<<v<<^><^^<v^<><v>v^<<v^^<><<>>><vv<<><>^<>>>v<<v^^^v^^<<<vv<<^<^<^vv^<><><<^^<^^>v^>^<v<>>v^v<><<v>^^v>^<^<vvv<v>v^v>>>^^<^<v^>^vv<<<v<<>^><><^<>v>>>v<v^<>v>><^^^v^^^v<^^<vv^^^>v>v<>>^^<><>v>^<v<>^>>>><>v>^v>^vv^v<vv<<^^>><v<>^>^^<v<^>^<vvv>><>^<<>>><<<><>^^<<<v<>v^>v>v<v>^^^>^>^v<<>v>vv>><<<v>^^<v><vv<<v^^>^>>^><^>v<^<^v>><^^>v<vv^^><><>^><<><>v^>v<><^^>><>^<^^v<^<<v>><v><<<^^<<v<^vv^v<>><>>>^>v<vvv^>^<><v^><^<<^vv<^v^v^v<>v^^v>v^<^>^vv^>>><<>v^vv^<>^v^><<v^v<v>v^<><>>v^v^><>v^vvv^^^<<^<<v<<v<^vv^>>v^v>^^<v<>><>v>>v^<>^>v>^>><<>v^v><^v>v>>><v<v><^<^^>vv<v><^>^<^>^^v><><v<^^v<<><^<<v^<v<<><^^vvv^v>^>^<>>vv>v^^v^^vv<^^>><v^^vv><^v>v^<<v<^v>vvv<>>^v><<>^v<<<>^><^vv><<^^<v^>v<<v>^vv<>^v>>>><<<<^^<^v>^<^^<^<^^>>^^v>^^^^v^^^<<>^^vv<<v^^><v>><^<<><>^>v<>>v^^^>^v^^v^<v^v>v>>>>>^v>^>^^<vvv^^<v^<<<v<<>v>><^^^v<<^^<v>>^<^<^><^<<v^v><<vv<^<>>v>v>^v<><<v>^>vv^v<v>v><^<v>><>^<vv<v^^^^v<^^>><<^^>v>v>^^^<>v>^v^^>vv^vv<^^>><>^>^<>v>><>^v<<v>v>^><^^^v^<vv><<^v^>v^>vv>v^<>v><vv><^v>v<><v^v^v<^v<>^v<v^<<><<v>>^v><v>^^<>vvv^>^<<v^>><^>><^<>^v<v<v<^vvv<><<^v^<v>><<<v>^<^<v>v>^vv^v>v<^^vv<<vvv^<v>><>vv^>v<<>v<vvvv>>v>^^>>><<<^>^vv>><v>^^^>v<^vv<>v<<<v<<<<v>>>>^<^^^^>v<^^<><v>v>v<v^>vv^>v>v<^>^v^<>v>>vvv>^^><^vvv>><>>>^<<^<v<>>>v^^><v<v>>^><>v<^^v^<<v><>^<>>><^v^v>>>^vvvv^<><<<v<^>>v>^v^<v<v<<^<<v^vv^v>v<v<>>v<v^<<<><v^>><^<<^>^^><v>v<^v^<^>v>^<<v>v^<>v^<>vv^<>^>^>v^>^vv<>^^<<>>v<>^v<><v^><><<<vv>v>v^>vv^><<<<v>^v<><>^^<vv>v^^v^^^<v<^^><v^v<>><v<vv>^<>>><vv<^v<<>>^><>>v<v^v^>>>v<<>v<<<<<<<^v<<^^^v<^v<>v^^<<<^<>>v^vv<v>^<^^<^^<<^>vv><^<^^v<<<^><^v<^><>v<vv^>^v^^>>><<vv^^v><^<<^<>>^>>^<<<<v^vv<>>>v>^v>><>v>>v>><>v>><^^><v>^^vv<^^<^>vv><<^>><<><v>^vvv><^v^>vvv^>>^<><^>^<<>>v^v>v<<>^>>^>v<^^<^<<>^^v<vvvvv^^^<^<>^^v>v<>^<^^<<v>v^^vvv^^v>^vv<v^>^<>v<^v^>^<v><v<<<^v<v<v^^<vvv>vv<<vv>v^<<v<^<vv><^>^><^^<^^<<v^^<v^v<v^^^^>^>vv^<>^<>^>^^<^v><<<^>vv^vv>v^v<>^^v^<^^^vvv^><v^<v^^<v<>v^<><>v>vv<^v^>>^v<^^vv>vv>^>><<<<v^^<^><>^><>>v<>>v>^v<^vv>^^>^<^<<v^>>v^v<^^v<vv<^<><^^>^^<>^^^<vv<v<<^^>^>^vv<^>><^<vvv^<>>vv^><v>v^>^vv>^>v^^<>>^v<>>v<^>^v>vv^<vv<^^>>^<v>>>>vvv>vv>^><^v<<<>^^v>v^v<^^^v^^>^><<^^>^<v>><^^^^^<v<vv<v<^<>^^<^v<^>>vv>>^v^vv<>><>^>>>^<v>^^^^><^<<<v<>^v<><vvv^<^^>vv^>>v<vvvv><v^v><^vv<^v<><vvv<vv>v<>^v^<<>>>>v^^>^vv<<vvv<^^><v><><<>v^v<^<^>><vv>^^><^>^><<><v<^v^><^<><>vv>>>>^><<^^^<^v^>^>^^>^<^><v><^^<^^<>><><v>><<<>^>^^v<>^<<<v>>vv>^>>^>^<>>vv<^^vv<>v<>^^>^v<v^^^^v<>^<v>v^v>^^^<v>v<<<^vv^><>^<v>>^^vv>v^<<^><>>vv^^^^^>v>>v<<<>^<vvv<<><><^v<^v<^>^<>^vvv>^>v><<<vv<>v>vv<v<<v>^<^^>v^v>^<^v^<<vvv^^<>^v<<^>^<><>^^<>>^^<^v^<^<v<><<^><v<>v^^>v^v^^^<^v<<^v>^>>^^^^^><<<vv^>>v^><v^^vv><>v^^<^v<^<v^^><<v>v^^^><^^^><<<<<>^<<^<>>v<<v^v^^v<<>^<vv>>><^^^<>>>>vvv>v<>>>v^v^v<^<<^>^<<>v>>^>^^><^><<^v^^<^<>v^v>vv<>>>>>>v<<><v^<v<>>^^>v<<<>^<<v><^><<^v>vv>>>><><>v^<^v><v^<<<<^v><^>v>>^^^v<^>>^>>v<<^<<>vvv>>^v<>>^v><<<^v^v<><v>^vvv<v<v>^^^<><vv^<<>vvv<v<^^v^^><v<^v<^v^<v<^>^^^>>v>^<v^>>^<><<><vv<>vv>^v^>>^<<v<^^v>v<v<vvv>><><<><vvvvv<^v<^>^^><>^<<>^v<<>>v^vv<<>^^v^v^v><^>v>v<^<<^<^>vv>^v<<^>^>>v^<<v^>v^^v^^<v^v>>><vv><<<>^v>><><v<vv<^>v<>><^v>^^v<<<<^v^vv<<<<><><^<^<^v><<^^v^<<<<<^^><^^>vv<v<^<v>v<^><><v<>vvv^<vv>v^>^>^^^v<<^<^^>vv<v^v^v>^vv^><^v^<<>v<^^>^vv<<>^<<><^>v^<<^<>v><><>v<<^^><^^^v>>v>^vv<v^>>^v^^<><<<<<^>^v^<^<^^>^vv<^>v^^v^<>v<><v>v^v>vvv><><<><>vv<vvv^v>^^>^^^<><^>^^^>v<vvvv<>vv<v<v^^>><>v<>>v^>v^^vv^>v>>><v<<<<v<^v>><^^>^v^v<v^v^^^vvv>>>vv<^>><<<^>><^<^>^<^>^>>v^<^<>^<^^<><vvv^^<>^<>>><<v>^<^<v<<><^<<^><^^>vv<>^^><v^v<vv<^<vvv<<^>v^>>v>>>v<<^vv^<><>>>^^<^v^>>^>>><<v<<^<vv><^<>^>>^v>>><^^^<<<vv<<v<v>^vv><><<>^^^<>^<vv^<^<<v>^^><vv>><>>>^>vv>^<^<>>^<^^><v>v^><v>vv><><>>><><<^^v<<^v<v>vv<><><<^v>^v<>^<^^^v^>^<^><^v>v>^v<>><^^v^^^^^<><v<>>vvv<v^^<>v>>>>^<<><^v>vv>>^^><<><><^^^<^<^<<^v>^^^><v>>>>><<v<v>v^^^<>>v<vv<^<>v^^^v<><^>v>><<><>v<^><<>>><>v>^<>>^>v^v<<<<>^<v^vv^>vv<<><v^vv<v<v<<>>>>>vv<><>^<^v>vv^<<v<^v^^<<^<<^^v^>>><<>^<>><^>>><v<>><<>^^>><<<^^^^^v>>^<<>>vvvv<^v<v^^<^>^vv<vv<>v<<<^><>>>>vv^<^v>v<^<>^v>>^<^^v^>>><>^^<^v>>v<<>vv<vvvv<>vv>^><>v^<>^<<^vv<v^^v<vvvv><^>>^v^>^^<<<^>>^^>^<^^<^<<<v^<^^v<<vv^<<^^^vv><v<vv^>v^^v<v>^^<^v<^>>><<>vv<<^><<v^v^^^v<vv>^>vv<^>>^<v<>vv>>>^>>><<v<^<>^<<<>>^<<>><^<<^^^>>v^^>v<<<>v>v>v<v<^>^<>>>^vvv><<^^<<><v<><^<v<vvv>v>>>>vv^^v<v<^<^><v>^v<<v<vv>>v>v<<<<><<>vv<><^^^<>>v<v<vvv><v^<vv^>>><v^^<>>>^^<><^<^v^><vv>>^^v>^<<v^>v>^^>^v^<v<^<v^v><>>v^^<^v^^<<>^^>v^^>><<<<^<^^v>^^v>v<<vv^^vv>^>v^<v<v><>vv>>^<v^v^<v<^>^v>v^^>vvvvv<v><<>vv>vvvvvv>>v>>^^^<v>vv^^><<v>>v^^^^v>vv>v<^v>>>>^>^><v^>^<v<vv>v>^>><v>><<>>^vv<vv^^<^^>>>>><><<^<v<><<v>^><^vv^v>>>>>v>^>^<vv>^v^>v<^v^<^<<vv<<>v<>>^vv<<>^v^v>><><<>>v^^<<>^^<v><>v<<^^<^^>^^>^<^><>>v<>>^^<^>><<<v<>>>^v^>v>v<<^^<<^>v<v^>>v^^v^^<<>^v>v><v^>v<^^>^<vv><vv^<>v<><^<<<vv<<v>v<^<<<<^^>v^v^^><<><^^^<v>v^^>>>vvv><>vv<>>^^v^v<<^>v^^v^>vv>^<<v<^<v^>^^<<v<^^>^v^^<^^v<<>>vv<^>>^><><>v>>v<>^<v^^><<>>>";
            _secretKey = "ckczppom";
            _niceString = @"uxcplgxnkwbdwhrp
suerykeptdsutidb
dmrtgdkaimrrwmej
ztxhjwllrckhakut
gdnzurjbbwmgayrg
gjdzbtrcxwprtery
fbuqqaatackrvemm
pcjhsshoveaodyko
lrpprussbesniilv
mmsebhtqqjiqrusd
vumllmrrdjgktmnb
ptsqjcfbmgwdywgi
mmppavyjgcfebgpl
zexyxksqrqyonhui
npulalteaztqqnrl
mscqpccetkktaknl
ydssjjlfejdxrztr
jdygsbqimbxljuue
ortsthjkmlonvgci
jfjhsbxeorhgmstc
vdrqdpojfuubjbbg
xxxddetvrlpzsfpq
zpjxvrmaorjpwegy
laxrlkntrukjcswz
pbqoungonelthcke
niexeyzvrtrlgfzw
zuetendekblknqng
lyazavyoweyuvfye
tegbldtkagfwlerf
xckozymymezzarpy
ehydpjavmncegzfn
jlnespnckgwmkkry
bfyetscttekoodio
bnokwopzvsozsbmj
qpqjhzdbuhrxsipy
vveroinquypehnnk
ykjtxscefztrmnen
vxlbxagsmsuuchod
punnnfyyufkpqilx
zibnnszmrmtissww
cxoaaphylmlyljjz
zpcmkcftuuesvsqw
wcqeqynmbbarahtz
kspontxsclmbkequ
jeomqzucrjxtypwl
ixynwoxupzybroij
ionndmdwpofvjnnq
tycxecjvaxyovrvu
uxdapggxzmbwrity
csskdqivjcdsnhpe
otflgdbzevmzkxzx
verykrivwbrmocta
ccbdeemfnmtputjw
suyuuthfhlysdmhr
aigzoaozaginuxcm
ycxfnrjnrcubbmzs
fgbqhrypnrpiizyy
taoxrnwdhsehywze
echfzdbnphlwjlew
jhmomnrbfaawicda
fywndkvhbzxxaihx
aftuyacfkdzzzpem
yytzxsvwztlcljvb
iblbjiotoabgnvld
kvpwzvwrsmvtdxcx
ardgckwkftcefunk
oqtivsqhcgrcmbbd
wkaieqxdoajyvaso
rkemicdsrtxsydvl
sobljmgiahyqbirc
pbhvtrxajxisuivj
ggqywcbfckburdrr
gmegczjawxtsywwq
kgjhlwyonwhojyvq
bpqlmxtarjthtjpn
pxfnnuyacdxyfclr
isdbibbtrqdfuopn
vucsgcviofwtdjcg
ywehopujowckggkg
mzogxlhldvxytsgl
mllyabngqmzfcubp
uwvmejelibobdbug
brebtoppnwawcmxa
fcftkhghbnznafie
sqiizvgijmddvxxz
qzvvjaonnxszeuar
abekxzbqttczywvy
bkldqqioyhrgzgjs
lilslxsibyunueff
ktxxltqgfrnscxnx
iwdqtlipxoubonrg
twncehkxkhouoctj
bdwlmbahtqtkduxz
smbzkuoikcyiulxq
bjmsdkqcmnidxjsr
icbrswapzdlzdanh
eyszxnhbjziiplgn
pdxhrkcbhzqditwb
nfulnpvtzimbzsze
glayzfymwffmlwhk
bejxesxdnwdlpeup
ukssntwuqvhmsgwj
hoccqxlxuuoomwyc
rapztrdfxrosxcig
cxowzhgmzerttdfq
yzhcurqhdxhmolak
kqgulndpxbwxesxi
yjkgcvtytkitvxiu
xnhfqhnnaceaqyue
qkuqreghngfndifr
xesxgeaucmhswnex
occbvembjeuthryi
dmefxmxqjncirdwj
ystmvxklmcdlsvin
pplykqlxmkdrmydq
cbbjkpbdvjhkxnuc
embhffzsciklnxrz
asrsxtvsdnuhcnco
xcbcrtcnzqedktpi
mglwujflcnixbkvn
mnurwhkzynhahbjp
cekjbablkjehixtj
kbkcmjhhipcjcwru
usifwcsfknoviasj
rsfgocseyeflqhku
prgcyqrickecxlhm
asbawplieizkavmq
sylnsirtrxgrcono
nzspjfovbtfkloya
qfxmsprfytvaxgtr
yckpentqodgzngnv
ycsfscegcexcnbwq
kbmltycafudieyuh
tpahmvkftilypxuf
qivqozjrmguypuxu
gdhbfradjuidunbk
vxqevjncsqqnhmkl
rpricegggcfeihst
xucvzpprwtdpzifq
egyjcyyrrdnyhxoo
kfbrzmbtrrwyeofp
qpjdsocrtwzpjdkd
reboldkprsgmmbit
vwkrzqvvhqkensuy
ydvmssepskzzvfdp
vqbigplejygdijuu
mzpgnahrhxgjriqm
uiejixjadpfsxqcv
tosatnvnfjkqiaha
yipuojpxfqnltclx
pcxwvgcghfpptjlf
shrudjvvapohziaj
jdckfjdtjsszdzhj
hgisfhcbdgvxuilk
gytnfjmrfujnmnpp
ohflkgffnxmpwrrs
jzxajbkwwjknasjh
xrcxfollmejrislv
djjlwykouhyfukob
rittommltkbtsequ
lpbvkxdcnlikwcxm
vkcrjmcifhwgfpdj
dkhjqwtggdrmcslq
swnohthfvjvoasvt
yrzoksmcnsagatii
duommjnueqmdxftp
inlvzlppdlgfmvmx
xibilzssabuqihtq
inkmwnvrkootrged
ldfianvyugqtemax
gbvwtiexcuvtngti
temjkvgnwxrhdidc
askbbywyyykerghp
onezejkuwmrqdkfr
kybekxtgartuurbq
ubzjotlasrewbbkl
stueymlsovqgmwkh
lhduseycrewwponi
yohdmucunrgemqcu
onnfbxcuhbuifbyc
odrjkigbrsojlqbt
imqkqqlkgmttpxtx
sxmlkspqoluidnxw
akaauujpxhnccleb
xvgpghhdtpgvefnk
jdxeqxzsbqtvgvcq
mdusenpygmerxnni
agihtqvgkmgcbtaw
dovxcywlyvspixad
uulgazeyvgtxqkfz
ndhmvrwuflhktzyo
hcaqkmrbvozaanvm
tvfozbqavqxdqwqv
rlkpycdzopitfbsv
dmyjtmjbtnvnedhs
fmwmqeigbzrxjvdu
twgookcelrjmczqi
grxosmxvzgymjdtz
zsstljhzugqybueo
jpeapxlytnycekbd
iasykpefrwxrlvxl
azohkkqybcnsddus
aoaekngakjsgsonx
awsqaoswqejanotc
sgdxmketnjmjxxcp
ylnyuloaukdrhwuy
ewoqjmakifbefdib
ytjfubnexoxuevbp
ewlreawvddptezdd
vmkonztwnfgssdog
ahbpuqygcwmudyxn
kmahpxfjximorkrh
otjbexwssgpnpccn
aewskyipyztvskkl
urqmlaiqyfqpizje
nrfrbedthzymfgfa
vndwwrjrwzoltfgi
iiewevdzbortcwwe
qiblninjkrkhzxgi
xmvaxqruyzesifuu
yewuzizdaucycsko
hmasezegrhycbucy
dwpjrmkhsmnecill
hnffpbodtxprlhss
avmrgrwahpsvzuhm
nksvvaswujiukzxk
zzzapwhtffilxphu
vwegwyjkbzsrtnol
qurpszehmkfqwaok
iknoqtovqowthpno
brlmpjviuiagymek
efxebhputzeulthq
mzkquarxlhlvvost
xsigcagzqbhwwgps
qufztljyzjxgahdp
dlfkavnhobssfxvx
hgdpcgqxjegnhjlr
fboomzcvvqudjfbi
wnjuuiivaxynqhrd
nhcgzmpujgwisguw
wjeiacxuymuhykgk
qmeebvxijcgdlzpf
nmmnxsehhgsgoich
ejluaraxythbqfkl
mdbsbwnaypvlatcj
nnfshfibmvfqrbka
dvckdmihzamgqpxr
foztgqrjbwyxvewk
okpryqcbvorcxhoh
fpiwsndulvtthctx
zrbiovlmzdmibsiq
setwafbnnzcftutg
nyvqghxhgkxfobdm
enpvqadzarauhajl
twblhpvkazpdmhmr
lbhlllsgswvhdesh
tdfwkgxnqjxcvsuo
lnvyjjbwycjbvrrb
jsxqdvmzaydbwekg
xirbcbvwlcptuvoa
hwnukxenilatlfsk
khwopjqkxprgopmd
sljzdoviweameskw
stkrdmxmpaijximn
fdilorryzhmeqwkc
mfchaaialgvoozra
gjxhoxeqgkbknmze
beowovcoqnginrno
mkgmsgwkwhizunxo
phnhfusyoylvjdou
csehdlcmwepcpzmq
pgojomirzntgzohj
fkffgyfsvwqhmboz
mrvduasiytbzfwdn
epzrmsifpmfaewng
ooqxnoyqrlozbbyf
ahcxfmgtedywrbnx
ibqktvqmgnirqjot
xarssauvofdiaefn
xradvurskwbfzrnw
nxklmulddqcmewad
twichytatzoggchg
qmgvroqwrjgcycyv
yvezgulgrtgvyjjm
jgmcklzjdmznmuqk
bytajdwwconasjzt
apjttucpycyghqhu
flfejjzihodwtyup
gmrtrwyewucyqotv
nlohdrlymbkoenyl
wxcmqwbrwgtmkyfe
njtzlceyevmisxfn
htbbidsfbbshmzlt
gxhjeypjwghnrbsf
cifcwnbtazronikv
ezvjijcjcyszwdjy
srffeyrvyetbecmc
xpjefrtatrlkbkzl
yhncvfqjcyhsxhbb
pqhcufzlcezhihpr
qtdsfvxfqmsnzisp
dfonzdicxxhzxkrx
mqqqzhxkyfpofzty
dodjadoqyxsuazxt
jjwkrlquazzjbvlm
ttosfloajukoytfb
llateudmzxrzbqph
criqihrysgesmpsx
npszvlittbcxxknj
qmzojrvraitrktil
cfyoozzpwxwkwoto
daxohtcgvtktggfw
vthkpkoxmiuotjaj
pkfkyobvzjeecnui
ojcjiqrfltbhcdze
scbivhpvjkjbauun
ysowvwtzmqpjfwyp
laeplxlunwkfeaou
jufhcikovykwjhsa
xrucychehzksoitr
pyaulaltjkktlfkq
oypfrblfdhwvqxcv
zybrgxixvhchgzcf
puoagefcmlxelvlp
xjnhfdrsbhszfsso
ocgvzryoydaoracw
bxpnqllmptkpeena
pziyeihxlxbbgdio
bvtrhtlbfzmglsfc
ggpuvtseebylsrfk
pukenexjqecnivfj
jswabfbzpnhhdbpn
enojrtwqpfziyqsv
rjtmxudgcudefuiz
iqmjxynvtvdacffc
uheywxlsusklitvl
kwhxduejafdpmqdc
rspgblenbqlmcltn
rczhurnrqqgjutox
dqhytibjzxkdblzl
hpbieadydiycvfys
pucztfoqvenxiuym
nqpfzgpblwijiprf
ltgseeblgajbvltk
mwxukbsnapewhfrc
dvxluiflicdtnxix
pexfbpgnqiqymxcq
dakudfjjwtpxuzxy
letlceyzlgmnrewu
ojktahbsdifdfhmd
anezoybbghjudbih
sawxtlvzysaqkbbf
ttnkctcevpjiwqua
edrwrdvbaoqraejd
wnbfilvuienjxlcr
wqhzwvyybyxhhtsm
jxbgvyaqczwdlxfo
wbypqfmbwrsvfmdv
izdxjyfpidehbets
vbxbggqseurknjor
egpmpoxickhvwdlz
ivfrzklvpwoemxsy
xkziseheibmrpdww
xnrmtoihaudozksa
efemdmbxdsaymlrw
yjdjeckmsrckaagx
vlftqxxcburxnohv
fwyquwgajaxebduj
dwpmqvcxqwwnfkkr
isduxxjfsluuvwga
avdtdppodpntojgf
vrcoekdnutbnlgqk
kbhboxjmgomizxkl
cgsfpjrmewexgzfy
usdtnhjxbvtnafvp
bjoddgxbuxzhnsqd
hoyqdzofddedevsb
rwiwbvqfjajotaoj
iabomphsuyfptoos
bubeonwbukprpvhy
xurgunofmluhisxm
puyojzdvhktawkua
dbvqhztzdsncrxkb
oaeclqzyshuuryvm
nmgwfssnflxvcupr
vjkiwbpunkahtsrw
romyflhrarxchmyo
yecssfmetezchwjc
qwtocacqdslhozkd
mesexvfbtypblmam
mtjucgtjesjppdtt
pvodhqqoeecjsvwi
vvlcwignechiqvxj
wiqmzmmjgjajwgov
kwneobiiaixhclev
lkdeglzrrxuomsyt
oqovuwcpwbghurva
lfsdcxsasmuarwwg
awkbafhswnfbhvck
sztxlnmyvqsiwljg
hozxgyxbcxjzedvs
oifkqgfqmflxvyzn
mfvnehsajlofepib
delgbyfhsyhmyrfa
uenimmwriihxoydv
vjqutpilsztquutn
kfebsaixycrodhvl
coifyqfwzlovrpaj
xiyvdxtkqhcqfsqr
hoidcbzsauirpkyt
fiumhfaazfkbaglq
fzwdormfbtkdjgfm
faxqrortjdeihjfv
ljhaszjklhkjvrfi
pzrxsffkuockoqyl
immbtokjmwyrktzn
lzgjhyiywwnuxpfx
vhkocmwzkfwjuzog
ghntjkszahmdzfbl
gbcthxesvqbmzggy
oyttamhpquflojkh
nbscpfjwzylkfbtv
wnumxzqbltvxtbzs
jfhobjxionolnouc
nrtxxmvqjhasigvm
hweodfomsnlgaxnj
lfgehftptlfyvvaj
ccoueqkocrdgwlvy
euhgvirhsaotuhgf
pdlsanvgitjvedhd
seokvlbhrfhswanv
pntdqaturewqczti
jkktayepxcifyurj
dhzzbiaisozqhown
wehtwakcmqwczpbu
zwvozvspqmuckkcd
efucjlrwxuhmjubr
lzodaxuyntrnxwvp
qdezfvpyowfpmtwd
mizijorwrkanesva
txmitbiqoiryxhpz
xhsqgobpouwnlvps
muixgprsknlqaele
disgutskxwplodra
bmztllsugzsqefrm
ymwznyowpaaefkhm
ebfifzloswvoagqh
pkldomvvklefcicw
ziqzbbfunmcgrbtq
iuekfpbkraiwqkic
jflgjidirjapcuqo
achsfbroyrnqnecg
udbhouhlgjjzapzr
arerrohyhhkmwhyo
txyjzkqexgvzdtow
ogzrjwibvzoucrpg
rfdftaesxdnghwhd
axdhwmpuxelmpabo
gtktemowbsvognac
wkfuclilhqjzxztk
qbwjouutzegaxhrz
opfziwqqbwhzzqhj
pvcvcsupfwsmeacs
xsbohvbguzsgpawn
sczoefukwywxriwj
oqkhcqfdeaifbqoc
vtsrholxbjkhwoln
yuvapljnwbssfbhi
dxdfwccqvyzeszyl
gdbmjtonbiugitmb
qunirtqbubxalmxr
zzxsirhdaippnopr
fibtndkqjfechbmq
gqgqyjvqmfiwiyio
ihwsfkwhtzuydlzw
eygyuffeyrbbhlit
zdlsaweqomzrhdyy
ptbgfzuvxiuuxyds
llxlfdquvovzuqva
wfrltggyztqtyljv
kwipfevnbralidbm
gbhqfbrvuseellbx
obkbuualrzrakknv
hlradjrwyjgfqugu
vtqlxbyiaiorzdsp
tedcbqoxsmbfjeyy
cxdppfvklbdayghy
gjnofexywmdtgeft
ldzeimbbjmgpgeax
egrwsmshbvbawvja
vadfrjvcrdlonrkg
mojorplakzfmzvtp
jyurlsoxhubferpo
ijwqogivvzpbegkm
cnmetoionfxlutzg
lawigelyhegqtyil
mqosapvnduocctcd
eqncubmywvxgpfld
vigfretuzppxkrfy
ncwynsziydoflllq
cbllqinsipfknabg
ndtbvdivzlnafziq
iqrrzgzntjquzlrs
damkuheynobqvusp
jxctymifsqilyoxa
ylritbpusymysmrf
paoqcuihyooaghfu
obhpkdaibwixeepl
igrmhawvctyfjfhd
ybekishyztlahopt
vkbniafnlfqhhsrq
kltdigxmbhazrywf
ufhcoyvvxqzeixpr
klcxdcoglwmeynjt
funpjuvfbzcgdhgs
akgyvyfzcpmepiuc
zhlkgvhmjhwrfmua
ibsowtbnrsnxexuz
vpufbqilksypwlrn
ngrintxhusvdkfib
ziuwswlbrxcxqslw
sucledgxruugrnic
zwnsfsyotmlpinew
oaekskxfcwwuzkor
qjmqwaktpzhwfldu
tmgfgqgpxaryktxo
qfaizepgauqxvffk
addkqofusrstpamf
shdnwnnderkemcts
gwfygbsugzptvena
fpziernelahopdsj
bkkrqbsjvyjtqfax
gxrljlqwxghbgjox
ipfwnqaskupkmevm
nnyoyhnqyfydqpno
lgzltbrrzeqqtydq
fgzxqurhtdfucheb
jvpthtudlsoivdwj
bmlhymalgvehvxys
fhklibetnvghlgnp
hfcyhptxzvblvlst
donanindroexgrha
oqawfmslbgjqimzx
jzgehjfjukizosep
bhlgamcjqijpvipb
jrcrdjrvsyxzidsk
ouwfwwjqezkofqck
wrvsbnkhyzayialf
knhivfqjxrxnafdl
hbxbgqsqwzijlngf
qlffukpfmnxpfiyq
evhxlouocemdkwgk
baxhdrmhaukpmatw
nwlyytsvreqaminp
ljsjjzmlsilvxgal
onunatwxfzwlmgpk
njgolfwndqnwdqde
ngdgcjzxupkzzbqi
ieawycvvmvftbikq
ccyvnexuvczvtrit
enndfwjpwjyasjvv
tcihprzwzftaioqu
bkztdkbrxfvfeddu
qkvhtltdrmryzdco
rurtxgibkeaibofs
mjxypgscrqiglzbp
unpkojewduprmymd
csqtkhjxpbzbnqog
mednhjgbwzlhmufi
sfrwfazygygzirwd
ijqeupbrhhpqxota
cmhpncanwudyysyh
wwcxbwzrplfzrwxd
jriomldifuobjpmq
radonyagpulnnyee
ryqjwxsspbbhnptd
yeoqpnsdhludlmzf
qsqlkeetyalenueh
qnnedenwsjdrcrzt
lejkuhsllxbhfcrx
anddbvllrrqefvke
wdtljquijaksvdsv
adslgvfuqqdkzvbc
whbccefjpcnjwhaq
kqrfuankaibohqsg
fyxisfwihvylgnfd
rwqdrddghyqudcif
syhzowthaaiiouaf
zjmrtgrnohxmtidu
deecwkfvjffxrzge
dztmvolqxkhdscxe
cdghcrgavygojhqn
pepqmdbjhnbugqeu
pnumdjpnddbxhieg
jzfhxeyahiagizfw
hdkwugrhcniueyor
gmgudeqlbmqynflu
toidiotdmfkxbzvm
pyymuoevoezlfkjb
etrbwuafvteqynlr
usvytbytsecnmqtd
dfmlizboawrhmvim
vrbtuxvzzefedlvs
vslcwudvasvxbnje
xdxyvoxaubtwjoif
mduhzhascirittdf
cqoqdhdxgvvvxamk
dshnfwhqjbhuznqr
zimthfxbdmkulkjg
luylgfmmwbptyzpj
iujpcgogshhotqrc
caqcyzqcumfljvsp
sprtitjlbfpygxya
fnconnrtnigkpykt
irmqaqzjexdtnaph
bbqrtoblmltvwome
ozjkzjfgnkhafbye
hwljjxpxziqbojlw
zahvyqyoqnqjlieb
dptshrgpbgusyqsc
uzlbnrwetkbkjnlm
yccaifzmvbvwxlcc
wilnbebdshcrrnuu
evxnoebteifbffuq
khbajekbyldddzfo
kjivdcafcyvnkojr
wtskbixasmakxxnv
uzmivodqzqupqkwx
rxexcbwhiywwwwnu
rowcapqaxjzcxwqi
fkeytjyipaxwcbqn
pyfbntonlrunkgvq
qiijveatlnplaifi
ltnhlialynlafknw
urrhfpxmpjwotvdn
xklumhfyehnqssys
civrvydypynjdoap
fvbmxnfogscbbnyd
oznavyflpzzucuvg
iyshrpypfbirahqo
qmzbfgelvpxvqecy
xkkxaufomsjbofmk
irlouftdmpitwvlq
csjoptbdorqxhnjg
bkryeshfsaqpdztm
guxbdqzfafsjoadl
tgrltexgrzatzwxf
cwsgsijqdanubxad
xafnexgturwrzyrg
apcrsqdbsbaxocxr
pspgxnzcevmvvejk
szephmeegvegugdt
ndjsoloeacasxjap
bdnfksliscnirjfu
ehglacmzpcgglpux
jwweijomqfcupvzw
yesblmmkqhbazmdu
sjsmalypmuslzgac
fkiqatyttlnuhdho
tlhnyuzdocvfdihq
ngehtjmycevnybga
obxodzcdgtrycgry
stkyrvdfbwovawmk
bdkhqcfrqaxhxloo
gpvumnuoiozipnrk
jbhanddinpqhxeol
hwkzkmbmsrvunzit
rfuomegkxbyamjpw
yzbljuksletipzwm
eafedkagwitzqigl
prenqvsbotqckgwy
spedpbwzphdrfxfz
cmsuqwemhwixkxet
xgdyeqbqfldvaccq
eooxgsrfsbdaolja
kyhqylxooewrhkho
mswieugqpoefmspt
uszoqundysdyeqlc
hkmjdggxefdyykbq
dtuhjnlaliodtlvh
oalbueqbhpxoxvvx
oowxtxsoqdwhzbya
lclajfsrpmtwvzkm
fxmjufpqtpyazeqo
ozlmreegxhfwwwmf
mqzrajxtxbaemrho
nfglecsyqduhakjr
nkxqtmasjjkpkqbp
jjfonbqimybvzeus
vjqkhkhjlmvpwkud
wxxhnvfhetsamzjr
pladhajujzttgmsw
dbycgxeymodsdlhm
qxszeuaahuoxjvwu
adultomodzrljxve
dmhgrbhvvpxyzwdn
slohrlwxerpahtyp
mngbocwyqrsrrxdb
facyrtflgowfvfui
hyvazpjucgghmmxh
twtrvjtncmewcxit
uejkrpvilgccfpfr
psqvolfagjfvqkum
nvzolslmiyavugpp
lpjfutvtwbddtqiu
fkjnfcdorlugmcha
eaplrvdckbcqqvhq
xrcydhkockycburw
iswmarpwcazimqxn
kicnnkjdppitjwrl
vwywaekzxtmeqrsu
dxlgesstmqaxtjta
pmeljgpkykcbujbb
vhpknqzhgnkyeosz
jprqitpjbxkqqzmz
fiprxgsqdfymyzdl
dzvfwvhfjqqsifga
aeakhfalplltmgui
frqrchzvenhozzsu
hsvikeyewfhsdbmy
puedjjhvxayiwgvg
zmsonnclfovjoewb
bnirelcaetdyaumi
szvudroxhcitatvf
sccfweuyadvrjpys
yiouqrnjzsdwyhwa
xyjhkqbnfmjjdefz
fjwgemkfvettucvg
aapqpwapzyjnusnr
dytxpkvgmapdamtc
hgocpfoxlheqpumw
twzuiewwxwadkegg
qdbosnhyqmyollqy
fclbrlkowkzzitod
sgxnrrpwhtkjdjth
xckvsnkvnvupmirv
nioicfeudrjzgoas
lcemtyohztpurwtf
oyjxhhbswvzekiqn
idkblbyjrohxybob
rthvloudwmktwlwh
oyzhmirzrnoytaty
ysdfhuyenpktwtks
wxfisawdtbpsmwli
vgmypwlezbmzeduk
rpepcfpelvhzzxzj
zxbovsmixfvmamnj
cpkabmaahbnlrhiz
jvomcbqeoqrmynjj
iqdeisnegnkrkdws
ilhemlrtxdsdnirr
fjimtscrwbfuwmpo
lmfiylebtzwtztmx
ddouhysvomrkcpgu
xtjwvzdhgnwwauwi
cntzuwcumbsebwyy
hieqvdlvnxkygeda
hushfszxskjdrjxi
xvdfzqblccfoxvyq
nldnrtieteunyxnb
vszpidfocenlhzqb
ofcuvtwhortxesoq
bwniqemqwxlejcfq
wkqiwdjnytjnomps
rbadoommlmrictte
nsmxhpothlulxivt
bvzbfcvenskqxejr
sdqeczmzpqqtqabq
bjveyzniaaliatkw
zxsqlntyjajjxytk
jkoxlerbtidsuepg
ewtlibdkeqwgxnqt
lmrshemwxrdwzrgc
nekcdyxmftlymfir
edaqvmulzkskzsfy
znmvqaupykjmyebx
ximtebuxwhqpzubd
rrlstppkknqyxlho
uyibwcitxixjfwcr
chrvoierkimesqmm
dltxmwhheldvxwqe
xfuthxjuuizanfjy
vtiwavmxwonpkpug
phchnujfnxewglht
owvmetdjcynohxtw
cbtujdrumixxatry
iirzildsfxipfipe
sqxcscqyofohotcy
sbubnekndkvovuqg
jzhsqqxqdrtibtcd
mscwasyvxkhlvwbn
bpafxtagbuxivbwz
uhvueesygaxrqffw
trrxlibhtmzuwkkl
yktkmkokmfslgkml
gfzzzdptaktytnqg
pgqmaiwzhplnbyhg
qjiptlkwfshunsfb
lewvlpescsyunxck
tywsfatykshogjas
qtrnwjjgxdektjgi
arypcritpwijczkn
jwxvngigbhfpiubf
upsjdctitlbqlnhf
lvpjlrpnmdjiscrq
jvzchdrsnkgpgsti
wuoesbwunpseyqzu
xuqspvoshgxmrnrb
icdawnmfnpnmyzof
hwcwtibgpvctznuo
bzdjrniddyamfloq
hffkxtzuazageruv
deixfxjvzbitalnc
zihsohukiqrgsnvw
nwoondfnlgowavkg
qnuulsywgnoillgn
koozejhfjyzuhviy
oetcoipohymhpump
cizwpfczfoodwuly
jghlinczhtaxifau
svjejifbidnvvdvy
rxmbsnaqhzcnbfcl
vveubmiecvdtrket
sbihpvrcnzjtgfep
iqbuljuxkwrlebvw
ptrhvxrpezqvmmvv
duwzugnhktpiybjw
lijafjnujfeflkva
coylvegferuuyfop
fowsjrgammrqkkof
pgmcruaioccmbrbz
osejwflxagwqtjoi
otqflckqgxzvtper
slwyntdcrncktoka
hzcdzsppcfkrblqg
jksdmmvtzkqaompg
galwwwgugetdohkg
zbghtjvuikmfjuef
dmqwcamjtlcofqib
zbczldlfdzemxeys
mdlqoklybhppdkwe
tuyajhkexrrrvnlb
ylfolaubymxmkowo
nnsyrfnoyrxswzxn
zkhunhhhigbsslfk
spbokzdfkbmflanz
zmzxvrwdhiegfely
imywhfczvmgahxwl
fnvabvxeiqvsarqq
yschramprctnputs
ubyjrgdzsvxzvouj
qnvdhpptympctfer
smipxcntyhjpowug
ouhjibgcmotegljy
zpflubaijjqqsptz
fgysnxrnfnxprdmf
pbpznrexzxomzfvj
thhzjresjpmnwtdv
sbmokolkhvbfqmua
sxxpdohxlezmqhhx
pevvsyqgoirixtqh
wdxrornmhqsbfznb
zjqziqbctxkshqcn
nbqcwpzfwfaahylk
bxbvkonpcxprxqjf
xplbpqcnwzwqxheb
prsakggmnjibrpoy
xoguxbpnrvyqarjl
ilrgryrmgwjvpzjy
efwrmokaoigjtrij
yhcncebopycjzuli
gwcmzbzaissohjgn
lggmemwbbjuijtcf
fkqedbfrluvkrwwl
jcbppekecevkwpuk
onvolrckkxeyzfjt
zzousprgrmllxboy
cajthmamvxuesujl
rmiozfsikufkntpg
lvekypkwjbpddkcv
dwaqzfnzcnabersa
pcdsskjopcqwhyis
uabepbrrnxfbpyvx
yxlgdomczciiunrk
ccerskfzctqxvrkz
edvmkntljlncwhax
xtcbwecdwygrvowo
axqgqjqkqwrgcqot
tyjrynolpzqwnjgj
thrtmlegdjsuofga
mpgoeqkzzqqugait
emuslxgoefdjyivl
klehpcehdznpssfb
xfgvugyrdxolixkc
acenyrbdwxywmwst
yqgperajsfsamgan
dbjxlnumrmhipquw
hsnhirmswcenewxm
qehqkbhmgucjjpwo
gprjdglsbtsfzqcw
wvqkyrkoratfmvfi
myhzlerupqbduqsl
couyazesiuhwwhht
scxzehubxhkfejrr
gqlitwfriqkmzqdd
pxtbmqelssoagxko
dzhklewjqzmrfzsw
yxgeypduywntnbji
kwzbgzhkzbgedlfh
vukmuyfstgmscuab
vcmaybfvdgwnasgt
qmybkqqdhjigzmum
cbnuicuncvczyalu
qdgpsdpdlgjasjqr
kdzxqqheurupejjo
mcatrxfchbqnxelm
badunwkeggdkcgco
ntaeanvcylpoqmxi
ghnyfytpzgvuokjn
ozepydixmjijdmts
qefcfwzdhwmcyfvp
ycyktmpaqgaxqsxt
edpizkxnsxeeebfl
uwciveajsxxwoqyr
rbvjkljpxtglqjsh
nbplrskduutrptfk
vewrbadvkseuloec
upaotnjxquomoflx
qfwxkinrousqywdd
mqzxvvskslbxvyjt
oxicszyiqifoyugx
bkitxwzjpabvhraj
ydrbyjecggynjpir
hezyteaublxxpamq
hxkuektnoovsehnd
cwtbbavnhlpiknza
qrwvkhbyasgfxwol
qryjbohkprfazczc
wjksnogpxracrbud
znmsxbhliqxhvesr
gkippedrjzmnnwkp
pklylwsnsyyxwcwg
osdpwbxoegwaiemr
kpslrrrljgtjiqka
vuqkloqucpyzfxgk
bvtdsisgvkuzghyl
qlcayluuyvlhdfyy
kbimqwnzanlygaya
nvoeanlcfhczijed
kqvcijcuobtdwvou
pmhdpcmxnprixitl
yueilssewzabzmij
zqxhafrvjyeyznyg
mhdounmxkvnnsekx
hnacyglnzicxjakg
iaxfdqibnrcjdlyl
iypoelspioegrwix
uiqouxzmlnjxnbqt
kslgjfmofraorvjo
bgvotsdqcdlpkynk
huwcgxhvrrbvmmth
vpqyfnkqqjacpffw
hpjgdfovgmrzvrcl
vbntbhbvdeszihzj
nrbyyuviwyildzuw
wckeoadqzsdnsbox
xgsobwuseofxsxox
anvhsxdshndembsd
iygmhbegrwqbqerg
ylrsnwtmdsrgsvlh
zvvejnrarsavahvc
yncxhmmdtxxeafby
kekgiglblctktnes
uoqgymsrlrwdruzc
saaoymtmnykusicw
bqvcworpqimwglcp
zbpgtheydoyzipjv
pkykzslwsjbhcvcj
jhwxxneyuuidrzvl
pafeyajcrlehmant
klszcvtmcdeyfsmj
ledsltggvrbvlefn
hubpbvxknepammep
gthxhaapfpgtilal
jtfhbozlometwztj
jrhshycyenurbpwb
fyaxbawrsievljqv
lgfcgbenlqxqcxsd
dhedabbwbdbpfmxp
mxzgwhaqobyvckcm
qboxojoykxvwexav
jcpzfjnmvguwjnum
ohpsxnspfwxkkuqe
nyekrqjlizztwjqp
thuynotacpxjzroj
wymbolrlwosnbxqx
iyaqihnqvewxdtjm
hdvdbtvfpdrejenu
gtjscincktlwwkkf
wtebigbaythklkbd
";
            _lights = @"toggle 461,550 through 564,900
turn off 370,39 through 425,839
turn off 464,858 through 833,915
turn off 812,389 through 865,874
turn on 599,989 through 806,993
turn on 376,415 through 768,548
turn on 606,361 through 892,600
turn off 448,208 through 645,684
toggle 50,472 through 452,788
toggle 205,417 through 703,826
toggle 533,331 through 906,873
toggle 857,493 through 989,970
turn off 631,950 through 894,975
turn off 387,19 through 720,700
turn off 511,843 through 581,945
toggle 514,557 through 662,883
turn off 269,809 through 876,847
turn off 149,517 through 716,777
turn off 994,939 through 998,988
toggle 467,662 through 555,957
turn on 952,417 through 954,845
turn on 565,226 through 944,880
turn on 214,319 through 805,722
toggle 532,276 through 636,847
toggle 619,80 through 689,507
turn on 390,706 through 884,722
toggle 17,634 through 537,766
toggle 706,440 through 834,441
toggle 318,207 through 499,530
toggle 698,185 through 830,343
toggle 566,679 through 744,716
toggle 347,482 through 959,482
toggle 39,799 through 981,872
turn on 583,543 through 846,710
turn off 367,664 through 595,872
turn on 805,439 through 964,995
toggle 209,584 through 513,802
turn off 106,497 through 266,770
turn on 975,2 through 984,623
turn off 316,684 through 369,876
turn off 30,309 through 259,554
turn off 399,680 through 861,942
toggle 227,740 through 850,829
turn on 386,603 through 552,879
turn off 703,795 through 791,963
turn off 573,803 through 996,878
turn off 993,939 through 997,951
turn on 809,221 through 869,723
turn off 38,720 through 682,751
turn off 318,732 through 720,976
toggle 88,459 through 392,654
turn off 865,654 through 911,956
toggle 264,284 through 857,956
turn off 281,776 through 610,797
toggle 492,660 through 647,910
turn off 879,703 through 925,981
turn off 772,414 through 974,518
turn on 694,41 through 755,96
turn on 452,406 through 885,881
turn off 107,905 through 497,910
turn off 647,222 through 910,532
turn on 679,40 through 845,358
turn off 144,205 through 556,362
turn on 871,804 through 962,878
turn on 545,676 through 545,929
turn off 316,716 through 413,941
toggle 488,826 through 755,971
toggle 957,832 through 976,992
toggle 857,770 through 905,964
toggle 319,198 through 787,673
turn on 832,813 through 863,844
turn on 818,296 through 818,681
turn on 71,699 through 91,960
turn off 838,578 through 967,928
toggle 440,856 through 507,942
toggle 121,970 through 151,974
toggle 391,192 through 659,751
turn on 78,210 through 681,419
turn on 324,591 through 593,939
toggle 159,366 through 249,760
turn off 617,167 through 954,601
toggle 484,607 through 733,657
turn on 587,96 through 888,819
turn off 680,984 through 941,991
turn on 800,512 through 968,691
turn off 123,588 through 853,603
turn on 1,862 through 507,912
turn on 699,839 through 973,878
turn off 848,89 through 887,893
toggle 344,353 through 462,403
turn on 780,731 through 841,760
toggle 693,973 through 847,984
toggle 989,936 through 996,958
toggle 168,475 through 206,963
turn on 742,683 through 769,845
toggle 768,116 through 987,396
turn on 190,364 through 617,526
turn off 470,266 through 530,839
toggle 122,497 through 969,645
turn off 492,432 through 827,790
turn on 505,636 through 957,820
turn on 295,476 through 698,958
toggle 63,298 through 202,396
turn on 157,315 through 412,939
turn off 69,789 through 134,837
turn off 678,335 through 896,541
toggle 140,516 through 842,668
turn off 697,585 through 712,668
toggle 507,832 through 578,949
turn on 678,279 through 886,621
toggle 449,744 through 826,910
turn off 835,354 through 921,741
toggle 924,878 through 985,952
turn on 666,503 through 922,905
turn on 947,453 through 961,587
toggle 525,190 through 795,654
turn off 62,320 through 896,362
turn on 21,458 through 972,536
turn on 446,429 through 821,970
toggle 376,423 through 805,455
toggle 494,896 through 715,937
turn on 583,270 through 667,482
turn off 183,468 through 280,548
toggle 623,289 through 750,524
turn on 836,706 through 967,768
turn on 419,569 through 912,908
turn on 428,260 through 660,433
turn off 683,627 through 916,816
turn on 447,973 through 866,980
turn on 688,607 through 938,990
turn on 245,187 through 597,405
turn off 558,843 through 841,942
turn off 325,666 through 713,834
toggle 672,606 through 814,935
turn off 161,812 through 490,954
turn on 950,362 through 985,898
turn on 143,22 through 205,821
turn on 89,762 through 607,790
toggle 234,245 through 827,303
turn on 65,599 through 764,997
turn on 232,466 through 965,695
turn on 739,122 through 975,590
turn off 206,112 through 940,558
toggle 690,365 through 988,552
turn on 907,438 through 977,691
turn off 838,809 through 944,869
turn on 222,12 through 541,832
toggle 337,66 through 669,812
turn on 732,821 through 897,912
toggle 182,862 through 638,996
turn on 955,808 through 983,847
toggle 346,227 through 841,696
turn on 983,270 through 989,756
turn off 874,849 through 876,905
turn off 7,760 through 678,795
toggle 973,977 through 995,983
turn off 911,961 through 914,976
turn on 913,557 through 952,722
turn off 607,933 through 939,999
turn on 226,604 through 517,622
turn off 3,564 through 344,842
toggle 340,578 through 428,610
turn on 248,916 through 687,925
toggle 650,185 through 955,965
toggle 831,359 through 933,536
turn off 544,614 through 896,953
toggle 648,939 through 975,997
turn on 464,269 through 710,521
turn off 643,149 through 791,320
turn off 875,549 through 972,643
turn off 953,969 through 971,972
turn off 236,474 through 772,591
toggle 313,212 through 489,723
toggle 896,829 through 897,837
toggle 544,449 through 995,905
turn off 278,645 through 977,876
turn off 887,947 through 946,977
turn on 342,861 through 725,935
turn on 636,316 through 692,513
toggle 857,470 through 950,528
turn off 736,196 through 826,889
turn on 17,878 through 850,987
turn on 142,968 through 169,987
turn on 46,470 through 912,853
turn on 182,252 through 279,941
toggle 261,143 through 969,657
turn off 69,600 through 518,710
turn on 372,379 through 779,386
toggle 867,391 through 911,601
turn off 174,287 through 900,536
toggle 951,842 through 993,963
turn off 626,733 through 985,827
toggle 622,70 through 666,291
turn off 980,671 through 985,835
turn off 477,63 through 910,72
turn off 779,39 through 940,142
turn on 986,570 through 997,638
toggle 842,805 through 943,985
turn off 890,886 through 976,927
turn off 893,172 through 897,619
turn off 198,780 through 835,826
toggle 202,209 through 219,291
turn off 193,52 through 833,283
toggle 414,427 through 987,972
turn on 375,231 through 668,236
turn off 646,598 through 869,663
toggle 271,462 through 414,650
turn off 679,121 through 845,467
toggle 76,847 through 504,904
turn off 15,617 through 509,810
toggle 248,105 through 312,451
turn off 126,546 through 922,879
turn on 531,831 through 903,872
toggle 602,431 through 892,792
turn off 795,223 through 892,623
toggle 167,721 through 533,929
toggle 813,251 through 998,484
toggle 64,640 through 752,942
turn on 155,955 through 892,985
turn on 251,329 through 996,497
turn off 341,716 through 462,994
toggle 760,127 through 829,189
turn on 86,413 through 408,518
toggle 340,102 through 918,558
turn off 441,642 through 751,889
turn on 785,292 through 845,325
turn off 123,389 through 725,828
turn on 905,73 through 983,270
turn off 807,86 through 879,276
toggle 500,866 through 864,916
turn on 809,366 through 828,534
toggle 219,356 through 720,617
turn off 320,964 through 769,990
turn off 903,167 through 936,631
toggle 300,137 through 333,693
toggle 5,675 through 755,848
turn off 852,235 through 946,783
toggle 355,556 through 941,664
turn on 810,830 through 867,891
turn off 509,869 through 667,903
toggle 769,400 through 873,892
turn on 553,614 through 810,729
turn on 179,873 through 589,962
turn off 466,866 through 768,926
toggle 143,943 through 465,984
toggle 182,380 through 569,552
turn off 735,808 through 917,910
turn on 731,802 through 910,847
turn off 522,74 through 731,485
turn on 444,127 through 566,996
turn off 232,962 through 893,979
turn off 231,492 through 790,976
turn on 874,567 through 943,684
toggle 911,840 through 990,932
toggle 547,895 through 667,935
turn off 93,294 through 648,636
turn off 190,902 through 532,970
turn off 451,530 through 704,613
toggle 936,774 through 937,775
turn off 116,843 through 533,934
turn on 950,906 through 986,993
turn on 910,51 through 945,989
turn on 986,498 through 994,945
turn off 125,324 through 433,704
turn off 60,313 through 75,728
turn on 899,494 through 940,947
toggle 832,316 through 971,817
toggle 994,983 through 998,984
toggle 23,353 through 917,845
toggle 174,799 through 658,859
turn off 490,878 through 534,887
turn off 623,963 through 917,975
toggle 721,333 through 816,975
toggle 589,687 through 890,921
turn on 936,388 through 948,560
turn off 485,17 through 655,610
turn on 435,158 through 689,495
turn on 192,934 through 734,936
turn off 299,723 through 622,847
toggle 484,160 through 812,942
turn off 245,754 through 818,851
turn on 298,419 through 824,634
toggle 868,687 through 969,760
toggle 131,250 through 685,426
turn off 201,954 through 997,983
turn on 353,910 through 832,961
turn off 518,781 through 645,875
turn off 866,97 through 924,784
toggle 836,599 through 857,767
turn on 80,957 through 776,968
toggle 277,130 through 513,244
turn off 62,266 through 854,434
turn on 792,764 through 872,842
turn off 160,949 through 273,989
turn off 664,203 through 694,754
toggle 491,615 through 998,836
turn off 210,146 through 221,482
turn off 209,780 through 572,894
turn on 766,112 through 792,868
turn on 222,12 through 856,241";
        }

        #region 1 Day
        [TestMethod]
        public void DayOneWhatFloorBigO2ɛn_ShouldGetToTheRightFloor_Equal()
        {
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorBigO2ɛn("(())"), 0);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorBigO2ɛn("()()"), 0);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorBigO2ɛn("))((((("), 3);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorBigO2ɛn("(()(()("), 3);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorBigO2ɛn("((("), 3);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorBigO2ɛn("())"), -1);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorBigO2ɛn("))("), -1);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorBigO2ɛn(_inputDayOne), 280);
        }

        [TestMethod]
        public void DayOneWhatFloorv2BigO2ɛn_ShouldGetToTheRightFloor_Equal()
        {
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv2BigO2ɛn("(())"), 0);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv2BigO2ɛn("()()"), 0);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv2BigO2ɛn("))((((("), 3);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv2BigO2ɛn("(()(()("), 3);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv2BigO2ɛn("((("), 3);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv2BigO2ɛn("())"), -1);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv2BigO2ɛn("))("), -1);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv2BigO2ɛn(_inputDayOne), 280);
        }

        [TestMethod]
        public void DayOneWhatFloorv3BigO2ɛn_ShouldGetToTheRightFloor_Equal()
        {
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv3BigO2ɛn("(())"), 0);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv3BigO2ɛn("()()"), 0);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv3BigO2ɛn("))((((("), 3);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv3BigO2ɛn("(()(()("), 3);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv3BigO2ɛn("((("), 3);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv3BigO2ɛn("())"), -1);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv3BigO2ɛn("))("), -1);
            Assert.AreEqual(TwoThousandFifteen.DayOneWhatFloorv3BigO2ɛn(_inputDayOne), 280);
        }
        #endregion

        #region 2 Day
        [TestMethod]
        public void DayOneSecondQuestionWhatFloorBigO2ɛn_ShouldGetToTheRightFloor_Equal()
        {
            Assert.AreEqual(TwoThousandFifteen.DayOneSecondQuestionWhatFloorBigO2ɛn(")"), 1);
            Assert.AreEqual(TwoThousandFifteen.DayOneSecondQuestionWhatFloorBigO2ɛn("()())"), 5);
            Assert.AreEqual(TwoThousandFifteen.DayOneSecondQuestionWhatFloorBigO2ɛn(_inputDayOne), 1797);
        }


        [TestMethod]
        public void DayTwoPaperBigOɛn_ShouldCalculateExactAmountOfPaper_Equal()
        {
            Assert.AreEqual(TwoThousandFifteen.DayTwoPaperBigOɛn(new string[] { "2x3x4" }), 58);
            Assert.AreEqual(TwoThousandFifteen.DayTwoPaperBigOɛn(new string[] { "1x1x10" }), 43);
            Assert.AreEqual(TwoThousandFifteen.DayTwoPaperBigOɛn(_inputDayTwo.Split(Environment.NewLine)), 1588178);
        }

        [TestMethod]
        public void DayTwoRibbonBigOɛn_ShouldCalculateExactAmountOfPaper_Equal()
        {
            Assert.AreEqual(TwoThousandFifteen.DayTwoRibbonBigOɛn(new string[] { "2x3x4" }), 34);
            Assert.AreEqual(TwoThousandFifteen.DayTwoRibbonBigOɛn(new string[] { "1x1x10" }), 14);
            Assert.AreEqual(TwoThousandFifteen.DayTwoRibbonBigOɛn(_inputDayTwo.Split(Environment.NewLine)), 3783758);
        }

        #endregion

        #region 3 Day
        [TestMethod]
        public void DayThreeHouseBigOɛn_ShouldCalculateHouseVisited_Equal()
        {
            Assert.AreEqual(TwoThousandFifteen.DayThreeHouseBigOɛn(">"), 2);
            Assert.AreEqual(TwoThousandFifteen.DayThreeHouseBigOɛn("^>v<"), 4);
            Assert.AreEqual(TwoThousandFifteen.DayThreeHouseBigOɛn("^v^v^v^v^v"), 2);
            Assert.AreEqual(TwoThousandFifteen.DayThreeHouseBigOɛn(_inputDayThree), 2572);
        }

        [TestMethod]
        public void DayThreeHouseTwoSantaBigO2ɛn_ShouldCalculateHouseVisited_Equal()
        {
            Assert.AreEqual(TwoThousandFifteen.DayThreeHouseTwoSantaBigO2ɛn("^v"), 3);
            Assert.AreEqual(TwoThousandFifteen.DayThreeHouseTwoSantaBigO2ɛn("^>v<"), 3);
            Assert.AreEqual(TwoThousandFifteen.DayThreeHouseTwoSantaBigO2ɛn("^v^v^v^v^v"), 11);
            Assert.AreEqual(TwoThousandFifteen.DayThreeHouseTwoSantaBigO2ɛn(_inputDayThree), 2631);
        }
        #endregion


        #region 4 Day
        [TestMethod]
        public void DayFourAdventCoinsBigO2ɛn_ShouldCalculateExactAmountOfPaper_Equal()
        {
            Assert.AreEqual(TwoThousandFifteen.DayFourAdventCoinsBigO2ɛn("abcdef", 5), 609043);
            Assert.AreEqual(TwoThousandFifteen.DayFourAdventCoinsBigO2ɛn("pqrstuv", 5), 1048970);
            Assert.AreEqual(TwoThousandFifteen.DayFourAdventCoinsBigO2ɛn(_secretKey, 5), 117946);
            Assert.AreEqual(TwoThousandFifteen.DayFourAdventCoinsBigO2ɛn(_secretKey, 6), 3938038);
        }

        [TestMethod]
        public void DayFiveNiceStringBigOɛnPower2_ShouldCalculateIsNice_AreEqual()
        {
            Assert.AreEqual(TwoThousandFifteen.DayFiveNiceStringBigOɛnPower2("ugknbfddgicrmopn"), 1); //is nice!
            Assert.AreEqual(TwoThousandFifteen.DayFiveNiceStringBigOɛnPower2("aaa"), 1);
            Assert.AreEqual(TwoThousandFifteen.DayFiveNiceStringBigOɛnPower2("jchzalrnumimnmhp"), 0);
            Assert.AreEqual(TwoThousandFifteen.DayFiveNiceStringBigOɛnPower2("haegwjzuvuyypxyu"), 0);
            Assert.AreEqual(TwoThousandFifteen.DayFiveNiceStringBigOɛnPower2("dvszwmarrgswjxmb"), 0);
            Assert.AreEqual(TwoThousandFifteen.DayFiveNiceStringBigOɛnPower2(_niceString), 236);
        }
        #endregion

        #region 5 Day
        [TestMethod]
        public void DayFive2QuestionNiceStringBigOɛnPower2_ShouldCalculateIsNice_AreEqual()
        {
            Assert.AreEqual(TwoThousandFifteen.DayFive2QuestionNiceStringBigOɛnPower2("qjhvhtzxzqqjkmpb"), 1); //is nice!
            Assert.AreEqual(TwoThousandFifteen.DayFive2QuestionNiceStringBigOɛnPower2("xxyxx"), 1);
            Assert.AreEqual(TwoThousandFifteen.DayFive2QuestionNiceStringBigOɛnPower2("uurcxstgmygtbstg"), 0);
            Assert.AreEqual(TwoThousandFifteen.DayFive2QuestionNiceStringBigOɛnPower2("ieodomkazucvgmuy"), 0);
            Assert.AreEqual(TwoThousandFifteen.DayFive2QuestionNiceStringBigOɛnPower2(_niceString), 236);
        }
        #endregion

        #region 6 Day
        [TestMethod]
        public void DaySixQuestionLightsBigOɛnPower2_ShouldCalculateIsNice_AreEqual()
        {
            Assert.AreEqual(TwoThousandFifteen.DaySixQuestionLightsBigOɛnPower2(_lights), 543903);
        }

        [TestMethod]
        public void DaySixQuestion2LightsBigOɛnPower2_ShouldCalculateIsNice_AreEqual()
        {
            var firstCase = @"turn on 0,0 through 0,0";
            Assert.AreEqual(TwoThousandFifteen.DaySixQuestion2LightsBigOɛnPower2(firstCase), 1);
            var secondCase = @"toggle 0,0 through 999,999";
            Assert.AreEqual(TwoThousandFifteen.DaySixQuestion2LightsBigOɛnPower2(secondCase), 2000000);
            Assert.AreEqual(TwoThousandFifteen.DaySixQuestion2LightsBigOɛnPower2(_lights), 14687245);
        }
        #endregion

        #region 7 Day
        #endregion

        #region 8 Day
        [TestMethod]
        public void DayEightQuestionStringLiteralO2ɛn_ShouldBeEqual_True()
        {
            //var input = new string[] { "", "abc", "aaa\"aaa", "\x27" };
            //Assert.AreEqual(TwoThousandFifteen.DayEightQuestionStringLiteralO2ɛn(input), 12); 
            string str = null;
            var len = SafeGetLength(str); 
            Assert.AreEqual(len, 0);
        }
        private static int SafeGetLength(string valueOrNull)
        {
            return (valueOrNull ?? string.Empty).Length;
        }
        #endregion

    }
}
