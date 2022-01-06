[![](https://github.com/MiracleGames/MiracleGamesUWPSDK/blob/master/images/MGLogo.png)](https://www.mguwp.net/index.html)
# MiracleGamesSDK
为UWP开发者提供一站式服务的解决方案!
## Overview
 * Miracle Games SDK（简称：MG SDK）随着微软Windows 10系统发布后应运而生，始终以服务开发者为使命，SDK中充分使用了微软所提供的各项支持与服务，并结合自主研发的登录、社区、广告、分享等功能，为开发者登陆微软生态提供良好的基础。
 * MG SDK基于UWP开发，预留了C++、C#、JS等语言的功能接口，让开发者可以在多种开发环境中使用MG SDK，针对不同引擎不同终端研发的应用，我们提供开发者将安卓、iOS、H5、Web、Win32等应用程序快捷移植Win10 UWP版本对应的解决方案，并免费提供技术支持服务。
 * 经过多年Windows10 UWP应用开发技术沉淀和对接经验，MG SDK中的各种功能运作已经变的高效且稳定，并且在对接过程中总结出了一套专属于MG SDK的接入流程，能够让合作的开发者更加便捷的在应用或游戏中使用MG SDK，将其轻松的发布到微软应用商店。
 * MG汇聚了大量的技术专家成员打造了UWP开发者社区，免费为UWP开发者提供技术支持服务及技术培训，让更多的开发者加入到微软生态，为微软生态建设添砖加瓦。

## 声明
1. 本程序为MGSDK功能演示工程，仅用作学习交流使用，禁止用于商业用途。
## MGSDK现有功能
1. MG账号登录功能
2. 开屏广告、横幅广告、对联广告、插屏广告、全屏插播广告、退屏广告
3. 微软支付功能
4. 分享功能
5. 社区功能
6. 微软好评功能
## 如何运行工程
### 环境需求
- 需要win10开发系统
- win10SDK 14393及以上版本
- Visual Studio 2015及以上版本
### 引用MGSDK
 通过Nuget包的引用方式将MGSDKFile文件夹中的SDK文件引入示例工程中.
SDK引用完成后即可运行示例工程,工程中演示了如何在UWP项目中接入MGSDK的各种功能.
![](https://github.com/MiracleGames/MiracleGamesUWPSDK/blob/master/images/uwpvs2.png)
## 安装已上线的示例应用
在浏览器中打开链接	https://www.microsoft.com/store/apps/9N3GWKK61FL5 跳转微软商店后下载应用
## MGSDK功能调用代码示例（C#）
### 初始化
在接入MG SDK其他功能之前，首先需要进行SDK的初始化，初始化完成后，才可以配合后台系统使用本SDK中的全部功能。
一般情况下，在进入程序后即进行SDK初始化接口的调用。初始化接口中使用到的参数为“APPKEY”，该参数需要在MG开发者管理中心系统申请创建，是该应用在MG的唯一关联标识。
```C#
Public Mainpage（）
{
    This.InitializeComponent（）;
    Load + =（sender，args）=>
    {      
          var result = await MiracleGames.ApplicationManager.SetupAsync("YOUR_APP_KEY");      
          if (!result.ReturnValue)
             return;
   };
}
```
### 登录
调用登录功能时要确保SDK初始化已经成功，登录面板会根据用户当前区域位置自动进行语言的适配，用户可以进行MG平台账号的登录和注册，也可以使用微软账号、谷歌账号等第三方账号进行登录。账号成功登录后会返回Token值和用户ID等信息，开发者可以使用这些信息在MG服务器进行账号在线状态的验证。
```C#
public MainPage()
{
    this.InitializeComponent();
    Loaded += (sender, args) =>
    {
         var auth = await MiracleGames.AuthenticationManager.AuthenticateAsync();
         if (auth.ReturnValue)
         {
             //Log in success.
             var uid =  MiracleGames.AuthenticationManager.UserInfo.Id;
             var token =  MiracleGames.AuthenticationManager.UserInfo.Token;
          }
    };
}
```
### 微软支付
  在发起支付调用时，在开发者的系统中先生成一个订单号，然后把此订单号通过comment参数传递给支付接口。<br>
  支付过程完成后，会由MG的服务器给开发者发起回调，其中包含了此comment信息，开发者可以通过此信息将该订单号标记为支付成功，所有订单状态可在MG开发者管理中心查询。<br>
  当关闭支付窗口时，通过订单号在开发者的系统中查询是否成功，若成功则给用户发送道具。<br>
```C#
public async void ShowPayChannel()
{
    if (!MiracleGames.ApplicationManager.SetupCompletedSuccessfully)
        return;
    var result = await MiracleGames.PaymentManager.OpenPayChannelAsync(goodsKey,comment, callbackId, true);
    if (result.ReturnValue)
    {
       
    }
    else
    {
        var msg = new MessageDialog("Cancel payment.");
        await msg.ShowAsync();
    }
}
```
### 广告
广告表现形式：全屏广告、横幅广告、插屏广告、对联广告、全屏插播广告<br>
广告素材：图片、视频、网页<br>
其中横幅广告、插屏广告、对联广告、全屏插播广告都有特殊的设置，根据设置相应的参数来满足不同的呈现需求。<br>
```C#
//1.展示全屏广告
public async void ShowFullScreenAd()
{
       AdvertisingManager.ShowAd(FullScreenAdID, AdType.FullScreen);
}

//2.展示插屏广告
public async void ShowInterstitialAdWithClose()
{
      await AdvertisingManager.ShowAd(InterstitialAdUnitId,AdType.Interstitial, new InterstitialAdSettingOptions {DisplayCloseButton = true});
}
//3.展示全屏插播广告
public async void ShowFullScreenInterstitialAd()
{
      await AdvertisingManager.ShowAd(FullScreenInterstitialAdUnitId,AdType.FullScreenInterstitial);
}
//4.展示横幅广告
public async void ShowBannerAdWithClose()
{
      var bannerAd = await AdvertisingManager.ShowAd(BannerAdUnitId, AdType.Banner, 
      new BannerAdSettingOptions
      {
                DisplayCloseButton = true,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Top
      });
}
//5.展示对联广告
public async void ShowCoupletAdWithClose()
 {
      var coupletAd = await AdvertisingManager.ShowAd(CoupletAdUnitId,AdType.Couplet,
      new CoupletAdSettingOptions
      {
                DisplayCloseButton = true,
                VerticalAlignment = VerticalAlignment.Top,
                CoupletDisplayMode = CoupletDisplayMode.Both
      });
}
```
### 分享
MG SDK中的分享接口，直接在工程中实现方法并调用即可。
该功能的回调接口中，可以获得用户的分享结果通知。
```C#
public async void ShowShareChannel()
{
	if (!MiracleGames.ApplicationManager.SetupCompletedSuccessfully)
	{
		return;
	}	 
	var sharingCommand = new MiracleGames.Models.SharingCommand
	{
		Title = "MyTitle",
		Content = "MyContent",
		LinkUrl = "http://www.mguwp.com"
	};
	var result = await    MiracleGames.SharingManager.OpenSharingChannelAsync(sharingCommand);
	if (result.ReturnValue)
	{
	  //Share finished
	}
}
```
### 评级
接入MG SDK后，通过调用MG SDK中提供的接口实现微软评级功能，
并在该方法的回调接口中获得评级操作的返回信息。
```C#
public async void isRatingReview()
{
	if (!MiracleGames.ApplicationManager.SetupCompletedSuccessfully)
	{
		return;
	}
	var result = await MiracleGames.ApplicationManager.IsRatingReviewedAsync();
	if (result.ReturnValue)
	{
		result.ReturnValue==true: //got favourable comment from the user
		result.ReturnValue==false:
	}
}
```
