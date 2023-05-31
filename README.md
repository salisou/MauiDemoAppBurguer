# MauiDemoAppBurguer
![delivery_android](https://github.com/salisou/MauiDemoAppBurguer/blob/master/ImageProject.PNG)

## Install Packages 
    CommunityToolkit.Maui
    Syncfusion.Maui.Inputs

## Confiure MauiProgram.cs 
    using CommunityToolkit.Maui;
    using Microsoft.Extensions.Logging;
    using Syncfusion.Maui.Core.Hosting;

    namespace MauiDemoAppBurguer;

    public static class MauiProgram
    {
	      public static MauiApp CreateMauiApp()
	      {
		        var builder = MauiApp.CreateBuilder();
            builder

              .UseMauiApp<App>()
              // Initialize the .NET MAUI Community Toolkit and Syncfusion Maui Inputs by adding the below line of code
              .UseMauiCommunityToolkit()
              .ConfigureSyncfusionCore()
               // After initializing the .NET MAUI Community Toolkit, optionally add additional fonts     
              .ConfigureFonts(fonts =>
              {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("SpaceGrotesk-Bold.ttf", "SpaceB");
                fonts.AddFont("SpaceGrotesk-Regular.ttf", "SpaceR");
                fonts.AddFont("SpaceGrotesk-Medium.ttf", "SpaceM");
                fonts.AddFont("SpaceGrotesk-SemiBold.ttf", "SpaceSB");
                fonts.AddFont("Roboto-Regular.ttf", "RobotoR");
                fonts.AddFont("Roboto-Light.ttf ", "RobotoL");
                fonts.AddFont("fontello.ttf", "icons");
              });

     #if DEBUG
		 builder.Logging.AddDebug();
     #endif

		 return builder.Build();
	      }
     }
     
   ## Add this code 
   
      <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                 xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                 xmlns:rating="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
                 xmlns:toolkit="http://schemas.microsoft.com/dotnet/2022/maui/toolkit"
                 BackgroundColor="{StaticResource Gray900}"
                 x:Class="MauiDemoAppBurguer.MainPage">

        <Page.Behaviors>
            <toolkit:StatusBarBehavior StatusBarColor="{StaticResource Gray900}"/>
        </Page.Behaviors>



        <Grid  RowDefinitions=".1*, .1*, .55*, .15*, .15*">
            <!--Header-->
            <Grid ColumnDefinitions="*,*,*" Margin="20">
                <Image  HorizontalOptions="Start" 
                        VerticalOptions="Center" Source="back"/>
                <Label Grid.Column="1"
                       FontFamily="RobotoR"
                       FontSize="18"
                       HorizontalTextAlignment="Center"
                       Text="Food Detail"
                       VerticalOptions="Center"
                       TextColor="{StaticResource Gray200}"/>
                <!--<Image Grid.Column="2" HorizontalOptions="End" VerticalOptions="Center">
                    <Image.Source>
                        <FontImageSource FontFamily="icons"
                                         Glyph="&#xE800;"
                                         Size="20"
                                         Color="{StaticResource Gray200}"/>
                    </Image.Source>
                </Image>-->
                <Image Grid.Column="2" HorizontalOptions="End" 
                        VerticalOptions="Center" Source="heart"/>
            </Grid>

            <!--Description-->
            <Label Grid.Row="1" 
                   Margin="20,10,0,0"
                   FontFamily="SpaceB"
                   FontSize="25"
                   Text="Double Smokey Burguer"
                   TextColor="{StaticResource Gray200}"/>

            <Grid Grid.Row="2"
                  Margin="0,0,-50,0"
                  ColumnDefinitions=".3*,.7*">


                <!--Left Info Product-->
                <Grid RowDefinitions="*,*,*,*,*">
                    <RoundRectangle Grid.RowSpan="5" Fill="{StaticResource Gray700}" CornerRadius="0,40,0,40"/>
                    <Grid Margin="10,10,0,0" RowDefinitions="*,*, *">
                        <Label FontSize="12"
                               FontFamily="SpaceR"
                               Text="Rate"
                               TextColor="{StaticResource Gray200}"/>

                        <Label FontSize="13"
                               FontFamily="SpaceB"
                               Grid.Row="1"
                               Text="4.8/5 (12,343)"
                               TextColor="{StaticResource Gray200}"/>

                        <rating:SfRating Grid.Row="2"
                                         BackgroundColor="Transparent"
                                         HorizontalOptions="Start"
                                         ItemSize="15"
                                         Precision="Exact"
                                         Value="4.5">
                            <rating:SfRating.RatingSettings>
                                <rating:RatingSettings RatedFill="#FFC71F"
                                                       RatedStroke="#FFC71F0"
                                                       UnratedFill="Gray"
                                                       UnratedStroke="Gray"/>
                            </rating:SfRating.RatingSettings> 
                        </rating:SfRating>
                    </Grid>
                    <Grid Grid.Row="1"
                          Margin="10,10,0,0"
                          RowDefinitions="*,*"
                          RowSpacing="5">
                        <Label FontFamily="SpaceR"
                               FontSize="12"
                               Text="Delivery Time"
                               TextColor="{StaticResource Gray200}"
                               VerticalOptions="End"/>
                        <HorizontalStackLayout Grid.Row="1" 
                                               Spacing="5">
                            <Image HorizontalOptions="End" 
                                   VerticalOptions="Start" 
                                   HeightRequest="20"
                                   WidthRequest="20"
                                   Source="clock" />

                            <Label FontFamily="SpaceB"
                                   FontSize="15"
                                   Text="20 Mins"
                                   TextColor="{StaticResource Gray100}"
                                   VerticalOptions="Start"/>
                        </HorizontalStackLayout>
                    </Grid>

                    <Grid Grid.Row="2"
                          Margin="10,10,0,0"
                          RowDefinitions="*,*"
                          RowSpacing="5">
                        <Label FontFamily="SpaceR"
                               FontSize="12"
                               Text="Calories"
                               TextColor="{StaticResource Gray200}"
                               VerticalOptions="End"/>

                        <Label FontFamily="SpaceSB"
                               Grid.Row="1"
                                   FontSize="15"
                                   Text="1,200 Cal"
                                   TextColor="{StaticResource Gray100}"
                                   VerticalOptions="Start"/>
                    </Grid>

                    <Grid Grid.Row="3"
                          Margin="10,10,0,0"
                          RowDefinitions="*,*"
                          RowSpacing="5">
                        <Label FontFamily="SpaceR"
                               FontSize="12"
                               Text="Branch"
                               TextColor="{StaticResource Gray200}"
                               VerticalOptions="End"/>

                        <Label FontFamily="SpaceSB"
                               Grid.Row="1"
                                   FontSize="15"
                                   Text="Creeck Road"
                                   TextColor="{StaticResource Gray100}"
                                   VerticalOptions="Start"/>
                    </Grid>

                    <Grid Grid.Row="4"
                          Margin="10,10,0,0"
                          RowDefinitions="*,*"
                          RowSpacing="5">
                        <Label FontFamily="SpaceR"
                               FontSize="12"
                               Text="Price"
                               TextColor="{StaticResource Gray200}"
                               VerticalOptions="End"/>

                        <Label FontFamily="SpaceSB"
                               Grid.Row="1"
                                   FontSize="15"
                                   Text="10.99 €"
                                   TextColor="{StaticResource Gray100}"
                                   VerticalOptions="Start"/>
                    </Grid>
                </Grid>

                <Image Grid.Column="1" Source="burger_thumbnail" Aspect="Fill" />


            </Grid>

            <!--Description Ingredients-->
            <Grid Grid.Row="3"
                  Margin="20,10,0,0"
                  RowDefinitions=".3*,.7*">
                <Label Text="Ingredients"
                       FontSize="18"
                       FontFamily="SpaceM"
                       VerticalTextAlignment="Center"   
                       TextColor="{StaticResource Gray100}"/>
                <Label Grid.Row="1"
                       LineHeight="1.3"
                       FontFamily="RobotoL"
                       VerticalTextAlignment="Center"
                       TextColor="{StaticResource Gray200}"
                       Text="Two flame-grilled beff patties with crispy bacon, melted American cheese. Ketchup and creamy mayonnaise on a tosted seame seed but."/>
            </Grid>

            <Button Grid.Row="4"
                    Margin="15,0"
                    FontSize="18"
                    CornerRadius="30"
                    HeightRequest="50"
                    TextColor="Black"
                    Text=" Add to Card"
                    FontFamily="RobotoL"
                    FontAttributes="Bold"
                    BackgroundColor="#FFC71F"/>
        </Grid>

    </ContentPage>
