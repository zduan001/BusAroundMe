#include "stdafx.h"
#include "CppUnitTest.h"
#include "CInsertRange.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace ArrayAndString
{
	TEST_CLASS(InseartRangeTest)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			CInsertRange *target = new CInsertRange();

			std::pair<int, int> a;
			a.first = 1;
			a.second = 3;

		}

	};
}