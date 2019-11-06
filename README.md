
## FriendPlace
<p>Wrapper ASP.NET Core tag helper for Google Place AutoComplete.</p>
<img src="https://github.com/Friendwork/FriendPlace/blob/master/captured.gif?raw=true" />

## Installing
#### Package Manager
```console
Install-Package FriendPlace
```
#### .NET CLI
```console
dotnet add package FriendPlace
```

## Usage

#### _ViewImports.cshtml
Add this line :
```csharp
@addTagHelper *, FriendPlace
```
#### _Layout.cshtml
```html
<head>
<script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=<YOUR_API_KEY>&libraries=places&language=vi"></script>
</head>
```
#### using in cshtml
```html
<googleplace custom-css=".google-places-autocomplete { width:50%; margin:0 auto;  }" on-item-selected="SelectedIndexChange" name="PlaceName"  />
```

## Properties

#### OnItemSelected event

A Callback function when an item has selected.
```html
<googleplace on-item-selected="SelectedIndexChange" />
<script>
  function SelectedIndexChange(index, selectedData) {
    // do something
  }
</script>
```

#### name property
```html
<googleplace name="MyPlace" />
</googleplace>
```
Name property used to indicate the form element name which use to post to server
```csharp
var address = Request.Form["MyPlace"];
var placeId = Request.Form["MyPlace.PlaceId"];
```

#### custom-css
Used to custom css. Or simply you can overwrite css anywhere.
