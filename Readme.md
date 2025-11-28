<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128659385/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4649)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF FlipView - Create and Bind to Data

This example demonstrates how to create a [WPF FlipView](https://docs.devexpress.com/WPF/15021/controls-and-libraries/windows-modern-ui/content-containers/flip-view), bind it to data, and use a template (`ItemContentTemplate`) to visualize data items.

```xaml
<dxwui:FlipView  ItemsSource="{Binding DataSource}" ItemTemplate="{StaticResource ItemContentTemplate}"/>
```

![WPF FlipView, DevExpress](https://raw.githubusercontent.com/DevExpress-Examples/wpf-flipview-create-bind-to-data/22.2.2%2B/i/wpf-flipview-devexpress.png)


## Files to Review

* [MainWindow.xaml](./CS/FlipViewSample/MainWindow.xaml)
* [DataStorage.cs](./CS/FlipViewSample/DataStorage.cs)


## Documentation

* [Windows Modern UI](https://docs.devexpress.com/WPF/15018/controls-and-libraries/windows-modern-ui)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-flipview-create-bind-to-data&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-flipview-create-bind-to-data&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
