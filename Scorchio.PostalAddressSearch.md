<a name='contents'></a>
# Contents [#](#contents 'Go To Here')

- [AddressModel](#T-Scorchio-PostalAddressSearch-Models-AddressModel 'Scorchio.PostalAddressSearch.Models.AddressModel')
  - [Address](#P-Scorchio-PostalAddressSearch-Models-AddressModel-Address 'Scorchio.PostalAddressSearch.Models.AddressModel.Address')
  - [BuildingNumber](#P-Scorchio-PostalAddressSearch-Models-AddressModel-BuildingNumber 'Scorchio.PostalAddressSearch.Models.AddressModel.BuildingNumber')
  - [PostCode](#P-Scorchio-PostalAddressSearch-Models-AddressModel-PostCode 'Scorchio.PostalAddressSearch.Models.AddressModel.PostCode')
- [IPostalAddressService](#T-Scorchio-PostalAddressSearch-Services-IPostalAddressService 'Scorchio.PostalAddressSearch.Services.IPostalAddressService')
  - [GetAddressesFromPostCode(postCode)](#M-Scorchio-PostalAddressSearch-Services-IPostalAddressService-GetAddressesFromPostCode-System-String- 'Scorchio.PostalAddressSearch.Services.IPostalAddressService.GetAddressesFromPostCode(System.String)')
  - [GetAddressesFromPostCodeAndBuildingNumber(postCode,buildingNumber)](#M-Scorchio-PostalAddressSearch-Services-IPostalAddressService-GetAddressesFromPostCodeAndBuildingNumber-System-String,System-String- 'Scorchio.PostalAddressSearch.Services.IPostalAddressService.GetAddressesFromPostCodeAndBuildingNumber(System.String,System.String)')
- [PostalAddressService](#T-Scorchio-PostalAddressSearch-Services-PostalAddressService 'Scorchio.PostalAddressSearch.Services.PostalAddressService')
  - [CssSelectCommand](#F-Scorchio-PostalAddressSearch-Services-PostalAddressService-CssSelectCommand 'Scorchio.PostalAddressSearch.Services.PostalAddressService.CssSelectCommand')
  - [Url](#F-Scorchio-PostalAddressSearch-Services-PostalAddressService-Url 'Scorchio.PostalAddressSearch.Services.PostalAddressService.Url')
  - [GetAddressesFromPostCode(postCode)](#M-Scorchio-PostalAddressSearch-Services-PostalAddressService-GetAddressesFromPostCode-System-String- 'Scorchio.PostalAddressSearch.Services.PostalAddressService.GetAddressesFromPostCode(System.String)')
  - [GetAddressesFromPostCodeAndBuildingNumber(postCode,buildingNumber)](#M-Scorchio-PostalAddressSearch-Services-PostalAddressService-GetAddressesFromPostCodeAndBuildingNumber-System-String,System-String- 'Scorchio.PostalAddressSearch.Services.PostalAddressService.GetAddressesFromPostCodeAndBuildingNumber(System.String,System.String)')

<a name='assembly'></a>
# Scorchio.PostalAddressSearch [#](#assembly 'Go To Here') [=](#contents 'Back To Contents')

<a name='T-Scorchio-PostalAddressSearch-Models-AddressModel'></a>
## AddressModel [#](#T-Scorchio-PostalAddressSearch-Models-AddressModel 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Scorchio.PostalAddressSearch.Models

##### Summary

Address Model

<a name='P-Scorchio-PostalAddressSearch-Models-AddressModel-Address'></a>
### Address `property` [#](#P-Scorchio-PostalAddressSearch-Models-AddressModel-Address 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets or sets the full address.

<a name='P-Scorchio-PostalAddressSearch-Models-AddressModel-BuildingNumber'></a>
### BuildingNumber `property` [#](#P-Scorchio-PostalAddressSearch-Models-AddressModel-BuildingNumber 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets or sets the building number.

<a name='P-Scorchio-PostalAddressSearch-Models-AddressModel-PostCode'></a>
### PostCode `property` [#](#P-Scorchio-PostalAddressSearch-Models-AddressModel-PostCode 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets or sets the post code.

<a name='T-Scorchio-PostalAddressSearch-Services-IPostalAddressService'></a>
## IPostalAddressService [#](#T-Scorchio-PostalAddressSearch-Services-IPostalAddressService 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Scorchio.PostalAddressSearch.Services

##### Summary

Post Address Service Interface.

<a name='M-Scorchio-PostalAddressSearch-Services-IPostalAddressService-GetAddressesFromPostCode-System-String-'></a>
### GetAddressesFromPostCode(postCode) `method` [#](#M-Scorchio-PostalAddressSearch-Services-IPostalAddressService-GetAddressesFromPostCode-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the addresses from post code.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| postCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The post code. |

<a name='M-Scorchio-PostalAddressSearch-Services-IPostalAddressService-GetAddressesFromPostCodeAndBuildingNumber-System-String,System-String-'></a>
### GetAddressesFromPostCodeAndBuildingNumber(postCode,buildingNumber) `method` [#](#M-Scorchio-PostalAddressSearch-Services-IPostalAddressService-GetAddressesFromPostCodeAndBuildingNumber-System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the addresses from post code and building number.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| postCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The post code. |
| buildingNumber | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The building number. |

<a name='T-Scorchio-PostalAddressSearch-Services-PostalAddressService'></a>
## PostalAddressService [#](#T-Scorchio-PostalAddressSearch-Services-PostalAddressService 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Scorchio.PostalAddressSearch.Services

##### Summary

Post Address Service.

##### See Also

- [Scorchio.PostalAddressSearch.Services.IPostalAddressService](#T-Scorchio-PostalAddressSearch-Services-IPostalAddressService 'Scorchio.PostalAddressSearch.Services.IPostalAddressService')

<a name='F-Scorchio-PostalAddressSearch-Services-PostalAddressService-CssSelectCommand'></a>
### CssSelectCommand `constants` [#](#F-Scorchio-PostalAddressSearch-Services-PostalAddressService-CssSelectCommand 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The CSS select command.

<a name='F-Scorchio-PostalAddressSearch-Services-PostalAddressService-Url'></a>
### Url `constants` [#](#F-Scorchio-PostalAddressSearch-Services-PostalAddressService-Url 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The URL.

<a name='M-Scorchio-PostalAddressSearch-Services-PostalAddressService-GetAddressesFromPostCode-System-String-'></a>
### GetAddressesFromPostCode(postCode) `method` [#](#M-Scorchio-PostalAddressSearch-Services-PostalAddressService-GetAddressesFromPostCode-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

*Inherit from parent.*

##### Summary

Gets the addresses from post code.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| postCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The post code. |

<a name='M-Scorchio-PostalAddressSearch-Services-PostalAddressService-GetAddressesFromPostCodeAndBuildingNumber-System-String,System-String-'></a>
### GetAddressesFromPostCodeAndBuildingNumber(postCode,buildingNumber) `method` [#](#M-Scorchio-PostalAddressSearch-Services-PostalAddressService-GetAddressesFromPostCodeAndBuildingNumber-System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

*Inherit from parent.*

##### Summary

Gets the addresses from post code and building number.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| postCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The post code. |
| buildingNumber | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The building number. |
