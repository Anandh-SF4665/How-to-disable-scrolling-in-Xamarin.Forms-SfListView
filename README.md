**[View document in Syncfusion Xamarin Knowledge base](https://www.syncfusion.com/kb/13057/how-to-disable-scrolling-in-xamarin-forms-listview-sflistview)**

## Sample

```xaml
<ScrollView>
    <StackLayout>
        <syncfusion:SfListView x:Name="listView"
                                ItemSize="60"
                                IsScrollingEnabled="False"
                                ItemsSource="{Binding ContactsInfo}">
            <syncfusion:SfListView.ItemTemplate>
                <DataTemplate>
                    <Grid x:Name="grid">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="70" />
                            <ColumnDefinition Width="*" />
                        </Grid.ColumnDefinitions>
                        <code>
                        . . .
                        . . .
                        <code>
                    </Grid>
                </DataTemplate>
            </syncfusion:SfListView.ItemTemplate>
        </syncfusion:SfListView>
    </StackLayout>
</ScrollView>

C#:
ListView.Loaded += ListView_Loaded;

private void ListView_Loaded(object sender, ListViewLoadedEventArgs e)
{
    DependencyService.Get<IDependencyServiceListView>().DisableScrolling(ListView);
}

public interface IDependencyServiceListView
{
    void DisableScrolling(SfListView ListView);
}
```