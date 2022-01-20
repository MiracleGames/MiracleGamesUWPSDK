using System;
using System.Diagnostics;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
//引用MGSDK命名空间
//quote MGSDK namespace
using MiracleGames;
using MiracleGames.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AdSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Loaded += MainPage_Loaded;
        }


        //以下参数需要在MG后台申请创建
        //following parameter need to be applied at MG backstage
        //应用标识
        //application logo 
        public const string AppKey = "C84E218F4B";

        //商品标识
        //product identification
        public const string GoodsKey = "D7B23935F949A18";
        //回调地址标识
        //callback address identification
        public const string CallbackId = "7d585649-eb8a-11eb-a23f-51c7f2652589";
        //开屏广告ID
        //opening screen Ad ID 
        public const string FullScreenAdUnitId = "82DBADEE78";
        //横幅广告ID
        //banner Ad ID
        public const string BannerAdUnitId = "0D0D6CDDC4";
        //全屏插播广告ID
        //full screen insert Ads ID
        public const string FullScreenInterstitialAdUnitId = "A2253DFA9D";
        //插屏广告ID
        //interstitial Ads ID
        public const string InterstitialAdUnitId = "98DF007152";
        //对联广告ID
        //couplet Ad ID
        public const string CoupletAdUnitId = "16812117D2";
        //退屏广告ID 
        //quiting screen Ad ID
        public const string ExitScreenAdUnitId = "C1D7AD0660";



        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            //第一步需要进行MGSDK的初始化  只有初始化完成之后才可以使用SDK中的功能
            //initialization is needed for the first step, only after the initialization, the function of the SDK can be used
            var result = await ApplicationManager.SetupAsync(AppKey);
            if (result.ReturnValue)
            {

                //“XXXXXXXX”参数需要传入广告key，广告key 来自MG后台创建。	
                MiracleGames.AdvertisingManager.SetupExitAdUnitId(ExitScreenAdUnitId);
                //开屏广告展示
                //opening screen Ad Show
                var fiAd = await AdvertisingManager.ShowAd(FullScreenAdUnitId, AdType.FullScreen);
                if (fiAd.ReturnValue)
                {

                }

            }
        }



        //MG登录窗口调用
        //MG login window call
        public async void MGLogin()
        {
            var auth = await AuthenticationManager.AuthenticateAsync();
            if (auth.ReturnValue)
            {

            }

        }



        //微软支付方法
        //Microsoft payment method
        public async void ShowPayChannel()
        {

            var result = await PaymentManager.OpenPayChannelAsync(GoodsKey, "comment", CallbackId, true);
            if (result.ReturnValue)
            {

            }
            else
            {

            }
        }



        //评级接口
        //rating interface
        public async void RatingReview()
        {
            var result = await MiracleGames.ApplicationManager.IsRatingReviewedAsync();
            if (result.ReturnValue)
            {
                //该用户已进行过评级
                //got favourable comment from the user
                //result.ReturnValue==true:
                //该用户未进行评级
                //No favourable comment from the user
                //result.ReturnValue==false:
            }

        }


        //分享接口
        //sharing interface
        public async void ShowShareChannel()
        {

            var sharingCommand = new SharingCommand
            {
                Title = "MyTitle",
                Content = "MyContent",
                LinkUrl = "http://www.mguwp.com"
            };

            var result = await MiracleGames.SharingManager.OpenSharingChannelAsync(sharingCommand);
            if (result.ReturnValue)
            {
                //分享完成
                //share finished
            }
        }



        //插屏广告
        //interstitial Ad
        public async void ShowInterstitialAdWithClose()
        {
            var interstitialAd = await AdvertisingManager.ShowAd(InterstitialAdUnitId,
                AdType.Interstitial,
                new InterstitialAdSettingOptions { DisplayCloseButton = true });
        }


        //对联广告
        //couplet Ad ID
        public async void ShowCoupletAdWithClose()
        {
            var coupletAd = await AdvertisingManager.ShowAd(CoupletAdUnitId,
                AdType.Couplet,
                new CoupletAdSettingOptions
                {
                    DisplayCloseButton = true,
                    VerticalAlignment = VerticalAlignment.Top,
                    CoupletDisplayMode = CoupletDisplayMode.Both
                });
        }






        //全屏插播广告接入
        //full screen in-stream Ad access
        public async void ShowFullScreenInterstitialAd()
        {
            var fiAd = await AdvertisingManager.ShowAd(FullScreenInterstitialAdUnitId, AdType.FullScreenInterstitial);
            if (fiAd.ReturnValue)
            {

            }
        }

        //横幅广告
        //banner Ad
        public async void ShowBannerAdWithClose()
        {
            var bannerAd = await AdvertisingManager.ShowAd(BannerAdUnitId, AdType.Banner, new BannerAdSettingOptions
            {
                DisplayCloseButton = true,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Bottom,
            });
            if (bannerAd.ReturnValue)
            {

            }
        }


    }
}
