using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sample.Domain.Entities;
using Sample.Domain.Repositories;
using Sample.WPF.ViewModels;

namespace SampleTest.Tests.ViewModelTests
{
    [TestClass]
    public class LatestViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var measureMock = new Mock<IMeasureRepository>();
            var entity = new MeasureEntity(
                1,
                Convert.ToDateTime("2012/12/12 12:34:56"),
                12.341f);
            measureMock.Setup(x => x.GetLatest()).Returns(entity);
            var vm = new LatestViewModel(measureMock.Object);

            vm.Search();
            vm.AreaIdText.Is("0001");
            vm.MeasureDateText.Is("2012/12/12 12:34:56");
            vm.MeasureValueText.Is("12.34℃");
        }
    }
}
