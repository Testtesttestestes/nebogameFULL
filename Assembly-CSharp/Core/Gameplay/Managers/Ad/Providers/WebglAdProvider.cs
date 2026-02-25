using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Core.Gameplay.Managers.Ad.Placements;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Protocol.Services;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Providers
{
	// Token: 0x02001200 RID: 4608
	[Token(Token = "0x2001200")]
	public class WebglAdProvider : IAdProvider, IDisposable
	{
		// Token: 0x140002D7 RID: 727
		// (add) Token: 0x06006D61 RID: 28001 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D62 RID: 28002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002D7")]
		public event Action<IAdProvider.BaseAdEventData> AdClosedEvent
		{
			[Token(Token = "0x6006D61")]
			[Address(RVA = "0xB83C", Offset = "0xB83C", VA = "0xB83C", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D62")]
			[Address(RVA = "0xB83D", Offset = "0xB83D", VA = "0xB83D", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002D8 RID: 728
		// (add) Token: 0x06006D63 RID: 28003 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D64 RID: 28004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002D8")]
		public event Action<IAdProvider.AdAvailabilityEventData> AdAvailabilityChangedEvent
		{
			[Token(Token = "0x6006D63")]
			[Address(RVA = "0xB83E", Offset = "0xB83E", VA = "0xB83E", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D64")]
			[Address(RVA = "0xB83F", Offset = "0xB83F", VA = "0xB83F", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002D9 RID: 729
		// (add) Token: 0x06006D65 RID: 28005 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D66 RID: 28006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002D9")]
		public event Action<IAdProvider.AdErrorEventData> AdErrorEvent
		{
			[Token(Token = "0x6006D65")]
			[Address(RVA = "0xB840", Offset = "0xB840", VA = "0xB840", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D66")]
			[Address(RVA = "0xB841", Offset = "0xB841", VA = "0xB841", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002DA RID: 730
		// (add) Token: 0x06006D67 RID: 28007 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D68 RID: 28008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002DA")]
		public event Action<IAdProvider.AdInfoEventData> AdRewardedEvent
		{
			[Token(Token = "0x6006D67")]
			[Address(RVA = "0xB842", Offset = "0xB842", VA = "0xB842", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D68")]
			[Address(RVA = "0xB843", Offset = "0xB843", VA = "0xB843", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06006D69 RID: 28009 RVA: 0x00014190 File Offset: 0x00012390
		[Token(Token = "0x1700163F")]
		public AdSource ProviderId
		{
			[Token(Token = "0x6006D69")]
			[Address(RVA = "0xB844", Offset = "0xB844", VA = "0xB844", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return AdSource.UnknownSource;
			}
		}

		// Token: 0x06006D6A RID: 28010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D6A")]
		[Address(RVA = "0xB845", Offset = "0xB845", VA = "0xB845")]
		public WebglAdProvider(AdSource providerId)
		{
		}

		// Token: 0x06006D6B RID: 28011 RVA: 0x000141A8 File Offset: 0x000123A8
		[Token(Token = "0x6006D6B")]
		[Address(RVA = "0xB846", Offset = "0xB846", VA = "0xB846", Slot = "13")]
		public UniTask Init(string userId, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D6C")]
		[Address(RVA = "0xB847", Offset = "0xB847", VA = "0xB847", Slot = "14")]
		public void ShowAd(string placementName, Dictionary<string, string> payload)
		{
		}

		// Token: 0x06006D6D RID: 28013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D6D")]
		[Address(RVA = "0xB848", Offset = "0xB848", VA = "0xB848")]
		private void ShowAdAsync(string providerName, string adName, string payload)
		{
		}

		// Token: 0x06006D6E RID: 28014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D6E")]
		[Address(RVA = "0x223D", Offset = "0x223D", VA = "0x223D")]
		private void ShowAdResponseHandler(WebglAdProvider.ShowAdResponse response)
		{
		}

		// Token: 0x06006D6F RID: 28015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D6F")]
		[Address(RVA = "0xB849", Offset = "0xB849", VA = "0xB849")]
		private void CallAdErrorEvent(WebglAdProvider.ShowAdResponse response, WebglAdProvider.Status status)
		{
		}

		// Token: 0x06006D70 RID: 28016 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006D70")]
		[Address(RVA = "0xB84A", Offset = "0xB84A", VA = "0xB84A", Slot = "15")]
		public WaitForCallBack<bool> IsAdAvailable(IAdPlacementData placement)
		{
			return null;
		}

		// Token: 0x06006D71 RID: 28017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D71")]
		[Address(RVA = "0xB84B", Offset = "0xB84B", VA = "0xB84B")]
		private void CheckAvailAdsAsync(string providerName, string adName, WaitForCallBack<bool> waitForCallBack)
		{
		}

		// Token: 0x06006D72 RID: 28018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D72")]
		[Address(RVA = "0x223A", Offset = "0x223A", VA = "0x223A")]
		private void CheckAdResponseHandler(bool isAvailable, WaitForCallBack<bool> waitForCallBack)
		{
		}

		// Token: 0x06006D73 RID: 28019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D73")]
		[Address(RVA = "0xB84C", Offset = "0xB84C", VA = "0xB84C", Slot = "16")]
		public void Dispose()
		{
		}

		// Token: 0x04003940 RID: 14656
		[Token(Token = "0x4003940")]
		[FieldOffset(Offset = "0x1C")]
		private readonly List<WebglAdProvider.AdInfo> _currentAds;

		// Token: 0x04003941 RID: 14657
		[Token(Token = "0x4003941")]
		[FieldOffset(Offset = "0x20")]
		private bool _lastAvailabilityResponse;

		// Token: 0x04003942 RID: 14658
		[Token(Token = "0x4003942")]
		[FieldOffset(Offset = "0x21")]
		private bool _waitingForResponse;

		// Token: 0x02001201 RID: 4609
		[Token(Token = "0x2001201")]
		[Serializable]
		public class ShowAdResponse
		{
			// Token: 0x06006D74 RID: 28020 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006D74")]
			[Address(RVA = "0xB84D", Offset = "0xB84D", VA = "0xB84D")]
			public ShowAdResponse()
			{
			}

			// Token: 0x04003943 RID: 14659
			[Token(Token = "0x4003943")]
			[FieldOffset(Offset = "0x8")]
			public string status;

			// Token: 0x04003944 RID: 14660
			[Token(Token = "0x4003944")]
			[FieldOffset(Offset = "0xC")]
			public string result;

			// Token: 0x04003945 RID: 14661
			[Token(Token = "0x4003945")]
			[FieldOffset(Offset = "0x10")]
			public string info;
		}

		// Token: 0x02001202 RID: 4610
		[Token(Token = "0x2001202")]
		[Serializable]
		private class AdInfo
		{
			// Token: 0x06006D75 RID: 28021 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006D75")]
			[Address(RVA = "0xB84E", Offset = "0xB84E", VA = "0xB84E")]
			public AdInfo()
			{
			}

			// Token: 0x04003946 RID: 14662
			[Token(Token = "0x4003946")]
			[FieldOffset(Offset = "0x8")]
			public string AdName;

			// Token: 0x04003947 RID: 14663
			[Token(Token = "0x4003947")]
			[FieldOffset(Offset = "0xC")]
			public string Payload;
		}

		// Token: 0x02001203 RID: 4611
		[Token(Token = "0x2001203")]
		public enum Status
		{
			// Token: 0x04003949 RID: 14665
			[Token(Token = "0x4003949")]
			Unknown,
			// Token: 0x0400394A RID: 14666
			[Token(Token = "0x400394A")]
			Success,
			// Token: 0x0400394B RID: 14667
			[Token(Token = "0x400394B")]
			Cancel,
			// Token: 0x0400394C RID: 14668
			[Token(Token = "0x400394C")]
			Fail
		}
	}
}
