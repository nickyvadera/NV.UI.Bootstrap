# NV.UI.Bootstrap

## Initialise

1. Add the package
```bash
dotnet add PROJECT package NV.UI.Bootstrap
```

2. Add configuration settings
appsettings.json
```json
{
  "BootstrapSettings": {
    "ComponentStyles": {
    }
  },
}
```

3. Add startup registration
Startup.cs
```c#
public void ConfigureServices(IServiceCollection services)
{
  // Your configuration
  
  services.AddUIBootstrap(Configuration.GetSection(BootstrapSettingsOptions.BootstrapSettings));
}
```

## Configure
You can change the default style of any component using the configuration in appsettings.json, for example
appsettings.json
```json
{
  "BootstrapSettings": {
    "ComponentStyles": {
      "Card": {
        "BorderWidth": "One",
        "BorderColour": "Light",
        "Shadow": "Small"
      },
      "Card-Header": {
        "BackgroundColour": "White"
      },
      "List-Group": {
        "Shadow": "Small"
      }
    }
  },
}
```

## Use
For example:
```html
<BootstrapSelect OnChangeCallback=HandleChange Value=@Value IsDirty=@IsDirty IsInvalid=@IsInvalid>
  <option></option>
  <option value=@value.Key>@value.Value</option>
</BootstrapSelect>
```
