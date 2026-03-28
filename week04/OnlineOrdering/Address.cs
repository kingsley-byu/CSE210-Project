using System;
public class Address
{
    // create private string for the attributes
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    //Create a Constructor for the address class
    public Address(string street, string city, string state, string country)
    {
      _streetAddress = street;
      _city = city;
      _stateProvince = state;
      _country = country;

    }
    /*create a bool method that check if the person ordering the product live in the USA or outside
    and return true or false */ 

    public bool IsInUSA()
    {
       if (_country == "USA")
        {
            return true;
        } 
        else
        {
            return false;
        }
    }
    // Create a getter that  will return the address, city state province and country
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n {_city}\n {_stateProvince}\n {_country}";
    }
} 
 