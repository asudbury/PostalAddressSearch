namespace Scorchio.PostalAddressSearch.Services
{
    using HtmlAgilityPack;
    using Models;
    using ScrapySharp.Extensions;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Post Address Service.
    /// </summary>
    /// <seealso cref="Scorchio.PostalAddressSearch.Services.IPostalAddressService" />
    public class PostalAddressService : IPostalAddressService
    {
        /// <inheritdoc />
        /// <summary>
        /// Gets the addresses from post code.
        /// </summary>
        /// <param name="postCode">The post code.</param>
        /// <returns></returns>
        public IEnumerable<AddressModel> GetAddressesFromPostCode(string postCode)
        {
            const string url = "https://address-data.co.uk/addresses-in-";

            const string cssSelectCommand = ".offer-content p";

            postCode = postCode.ToUpper();

            string searchPostCode = postCode.Replace(" ", "-");

            List<AddressModel> addresses = new List<AddressModel>();

            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url + searchPostCode);

            var nodes = doc.DocumentNode.CssSelect(cssSelectCommand).ToList();

            foreach (HtmlNode htmlNode in nodes)
            {
                string addressString = htmlNode.InnerText;

                string buildingNumber = string.Concat(addressString.TakeWhile(char.IsLetterOrDigit));

                AddressModel addressModel = new AddressModel
                {
                    BuildingNumber = buildingNumber,
                    Address = addressString,
                    PostCode = postCode
                };

                addresses.Add(addressModel);
            }

            return addresses.OrderBy(x => x.Address);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the addresses from post code and building number.
        /// </summary>
        /// <param name="postCode">The post code.</param>
        /// <param name="buildingNumber">The building number.</param>
        /// <returns></returns>
        public IEnumerable<AddressModel> GetAddressesFromPostCodeAndBuildingNumber(
            string postCode, 
            string buildingNumber)
        {
            List<AddressModel> addresses = GetAddressesFromPostCode(postCode).ToList();

            List<AddressModel> buildingNumberAddresses = addresses.Where(x => x.BuildingNumber == buildingNumber).ToList();

            if (buildingNumberAddresses.Any())
            {
                return buildingNumberAddresses;
            }

            return addresses;
        }
    }
}
