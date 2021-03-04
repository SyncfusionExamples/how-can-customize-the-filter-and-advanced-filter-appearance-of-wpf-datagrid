# How can customize the filter and advanced filter appearance of  WPF DataGrid (SfDataGrid) ? 

This sample show cases how can customize the filter and advanced filter appearance of  [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid) ? 

# About the sample

You can customize the appearance of [GridFilterControl](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridFilterControl.html) and [AdvancedFilterControl](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.AdvancedFilterControl.html) by overriding its ControlTemplate in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid).

```Xaml
<!--Filter Style-->
<Style x:Key="ButtonFocusVisual">
    <Setter Property="Control.Template">
        <Setter.Value>
            <ControlTemplate>
                <Rectangle SnapsToDevicePixels="true"
                            Stroke="{DynamicResource {x:Static SystemColors.ControlTextBrushKey}}"
                            StrokeDashArray="1 2"
                            StrokeThickness="1" />
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>

<!--Advanced Filter Style-->
<Style x:Key="ComboBoxFocusVisual">
    <Setter Property="Control.Template">
        <Setter.Value>
            <ControlTemplate>
                <Rectangle Margin="4,4,19,4"
                            SnapsToDevicePixels="true"
                            Stroke="Black"
                            StrokeDashArray="1 2"
                            StrokeThickness="1" />
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```
## Requirements to run the demo
 Visual Studio 2015 and above versions
