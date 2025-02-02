using System;

class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public Boolean IsAddressInTheUSA()
    {
        if (_country == "USA" || _country == "United States Of America")
        {
            return true;
        }

        return false;
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvince} - {_country}";
    }
}