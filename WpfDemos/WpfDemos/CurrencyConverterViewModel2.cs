using System;
using System.Collections.Generic;

namespace WpfDemos
{
    public class Currency
    {
        public Currency(string title, decimal rate)
        {
            Title = title;
            Rate = rate;
        }

        public string Title { get; set; }
        public decimal Rate { get; set; }
    }

    public class CurrencyConverterViewModel2 : Notifier
    {
        private decimal _euros;
        private decimal _converted;
        private Currency _selectedCurrency;
        private IEnumerable<Currency> _currencies;
        private string _resultText;


        public CurrencyConverterViewModel2()
        {
            Currencies = new Currency[] {
                new Currency("US Dollar", 1.1M),
                new Currency("British Pound", 0.9M),
            };
        }
        public decimal Euros
        {
            get => _euros;
            set
            {
                _euros = value;
                OnPropertyChanged("Euros");
                OnEurosChanged();
            }
        }

        public decimal Converted
        {
            get => _converted;
            set
            {
                _converted = value;
                OnPropertyChanged("Converted");
            }
        }

        public Currency SelecedCurrency
        {
            get => _selectedCurrency;
            set
            {
                _selectedCurrency = value;
                OnPropertyChanged("SelecedCurrency");
                OnSelectedCurrencyChanged();
            }
        }


        public IEnumerable<Currency> Currencies
        {
            get => _currencies;
            set
            {
                _currencies = value;
                OnPropertyChanged("Currencies");
            }
        }

        public string ResultText
        {
            get => _resultText;
            set
            {
                _resultText = value;
                OnPropertyChanged("ResultText");
            }
        }

        private void OnSelectedCurrencyChanged() => ComputeConverted();

        private void OnEurosChanged() => ComputeConverted();

        private void ComputeConverted()
        {
            if (SelecedCurrency == null) return;
            Converted = Euros * SelecedCurrency.Rate;
            ResultText = $"Amount in {SelecedCurrency.Title}";
        }
    }
}
