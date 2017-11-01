#include "stdafx.h"
#include "CppUnitTest.h"
#include "..\Lib1\HRectangular.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;


namespace UnitTest1
{
	TEST_CLASS(HRect)
	{
	public:

		TEST_METHOD(computeArea)
		{
			HRectangular HRect = HRectangular(4.0, 5.0);
			auto actual = HRect.computeArea();
			Assert::AreEqual(20.0, actual);// , L"4,5 rect should have area of 20");
		}
		TEST_METHOD(computeAreaPosPos)
		{
			// TODO: Your test code here
			Assert::Fail(L"Die Pond Scum!");
		}
		TEST_METHOD(computeAreaPosNeg)
		{
			// TODO: Your test code here
			Assert::Fail(L"Die Pond Scum!");
		}

	};
}