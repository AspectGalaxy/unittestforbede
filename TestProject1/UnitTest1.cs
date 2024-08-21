using Microsoft.VisualStudio.TestPlatform.Common.Utilities;

namespace TestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestDepositAndReward()
		{
			Deposit deposit = new Deposit(100);
			deposit.addReward(100);
			decimal check = deposit.getBalance();

			Assert.AreEqual(200, check);
		}

		[TestMethod]
		public void TestStakeInDeposit()
		{
			Deposit deposit = new Deposit(100);
			deposit.stakeFurtherFunds(100);
			decimal check = deposit.getStake();

			Assert.AreEqual(100, check);
		}

		[TestMethod]
		public void TestSlots()
		{
			Apple apple = new Apple();
			Banana banana = new Banana();
			Pineapple pineapple = new Pineapple();
			Wildcard wildcard = new Wildcard();

			decimal appleco = apple.getCoeffcient();
			decimal bananaco = banana.getCoeffcient();
			decimal pineappleco = pineapple.getCoeffcient();
			decimal wildcardco = wildcard.getCoeffcient();

			Assert.IsTrue(appleco > 0);
			Assert.IsTrue(bananaco > 0);
			Assert.IsTrue(pineappleco > 0);
			Assert.IsTrue(wildcardco == 0);

		}

		[TestMethod]
		public void TestSlotManager()
		{
			Deposit deposit = new Deposit(100);
			SlotManager manager = new SlotManager(deposit);
			manager.spinTheSlots();
			Assert.IsTrue(manager.spin);

		}
	}
}