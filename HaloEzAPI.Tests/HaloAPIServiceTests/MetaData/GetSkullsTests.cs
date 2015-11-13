using NUnit.Framework;

namespace HaloEzAPI.Tests.HaloAPIServiceTests.MetaData
{
    [TestFixture]
    public class GetSkullsTests : BaseHaloAPIServiceTests
    {
        [Test]
        public void Default_DoesNotThrowException()
        {
            Assert.DoesNotThrow(async () => await HaloApiService.GetSkulls());
        }

        [Test]
        public async void Default_DoesNotReturnNull()
        {
            var result = await HaloApiService.GetSkulls();
            Assert.IsNotNull(result);
        }

        [Test]
        public async void Default_ReturnsValidCollection()
        {
            var result = await HaloApiService.GetSkulls();
            CollectionAssert.AllItemsAreNotNull(result);
        }
    }

    [TestFixture]
    public class GetVehiclesTests : BaseHaloAPIServiceTests
    {
        [Test]
        public void Default_DoesNotThrowException()
        {
            Assert.DoesNotThrow(async () => await HaloApiService.GetVehicles());
        }

        [Test]
        public async void Default_DoesNotReturnNull()
        {
            var result = await HaloApiService.GetVehicles();
            Assert.IsNotNull(result);
        }

        [Test]
        public async void Default_ReturnsValidCollection()
        {
            var result = await HaloApiService.GetVehicles();
            CollectionAssert.AllItemsAreNotNull(result);
        }
    }

    [TestFixture]
    public class GetWeaponsTests : BaseHaloAPIServiceTests
    {
        [Test]
        public void Default_DoesNotThrowException()
        {
            Assert.DoesNotThrow(async () => await HaloApiService.GetWeapons());
        }

        [Test]
        public async void Default_DoesNotReturnNull()
        {
            var result = await HaloApiService.GetWeapons();
            Assert.IsNotNull(result);
        }

        [Test]
        public async void Default_ReturnsValidCollection()
        {
            var result = await HaloApiService.GetWeapons();
            CollectionAssert.AllItemsAreNotNull(result);
        }
    }
}