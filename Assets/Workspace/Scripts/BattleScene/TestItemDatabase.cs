using NUnit.Framework;
using Other.Infrastructure;
using UnityEngine;

namespace Tests {
	public class TestItemDatabase {
		[Test]
		public void TestFetchByName1() {
			var queryService = new ItemDataQueryService();
			var item = queryService.FetchByName("AmmoRefill");
			Assert.IsNotNull(item);
			Assert.AreEqual(item.EntityName, "AmmoRefill");
			Debug.Log($"item info: {item.EntityName}, {item.Id}");
		}

		[Test]
		public void TestFetchByName2() {
			var queryService = new ItemDataQueryService();
			var item = queryService.FetchByName("AssaultArmor");
			Assert.IsNotNull(item);
			Assert.AreEqual(item.EntityName, "AssaultArmor");
			Debug.Log($"item info: {item.EntityName}, {item.Id}");
		}
	
	}
}