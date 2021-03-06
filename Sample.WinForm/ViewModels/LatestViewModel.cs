﻿using Sample.Domain.Entities;
using Sample.Domain.Repositories;
using Sample.Infrastructure;
using System;

namespace Sample.WinForm.ViewModels
{
    public class LatestViewModel : ViewModelBase
    {
        private IMeasureRepository _measureRepository;

        private string _areaIdText = string.Empty;
        private string _measureDateText = string.Empty;
        private string _measureValue = string.Empty;

        private static log4net.ILog _logger =
    log4net.LogManager.GetLogger(
        System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LatestViewModel():this(Factories.CreateMesure())
        {

        }
        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository;
        }
        public string AreaIdText {
            get
            {
                return _areaIdText;
            }
            set
            {
                SetProperty(ref _areaIdText, value);
            }
        }
        public string MeasureDateText
        {
            get
            {
                return _measureDateText;
            }
            set
            {
                SetProperty(ref _measureDateText, value);
            }
        }
        public string MeasureValueText {
            get
            {
                return _measureValue;
            }
            set
            {
                SetProperty(ref _measureValue, value);
            }
        }

        public void Search()
        {
            _logger.Debug("検索");
            var measure = _measureRepository.GetLatest();
            AreaIdText = measure.AreaId.DisplayValue;
            MeasureDateText = measure.MeasureDate.DisplayValue;
            MeasureValueText = Math.Round(measure.MeasureValue, 2) + "℃";
        }
    }
}
