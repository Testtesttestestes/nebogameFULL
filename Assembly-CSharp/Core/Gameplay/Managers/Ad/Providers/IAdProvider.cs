using System;
using System.Collections.Generic;
using System.Threading;
using Core.Gameplay.Managers.Ad.Placements;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Protocol.Services;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Providers
{
	// Token: 0x020011FB RID: 4603
	[Token(Token = "0x20011FB")]
	public interface IAdProvider : IDisposable
	{
		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06006D51 RID: 27985
		[Token(Token = "0x1700163E")]
		AdSource ProviderId { [Token(Token = "0x6006D51")] get; }

		// Token: 0x140002D3 RID: 723
		// (add) Token: 0x06006D52 RID: 27986
		// (remove) Token: 0x06006D53 RID: 27987
		[Token(Token = "0x140002D3")]
		event Action<IAdProvider.BaseAdEventData> AdClosedEvent;

		// Token: 0x140002D4 RID: 724
		// (add) Token: 0x06006D54 RID: 27988
		// (remove) Token: 0x06006D55 RID: 27989
		[Token(Token = "0x140002D4")]
		event Action<IAdProvider.AdAvailabilityEventData> AdAvailabilityChangedEvent;

		// Token: 0x140002D5 RID: 725
		// (add) Token: 0x06006D56 RID: 27990
		// (remove) Token: 0x06006D57 RID: 27991
		[Token(Token = "0x140002D5")]
		event Action<IAdProvider.AdErrorEventData> AdErrorEvent;

		// Token: 0x140002D6 RID: 726
		// (add) Token: 0x06006D58 RID: 27992
		// (remove) Token: 0x06006D59 RID: 27993
		[Token(Token = "0x140002D6")]
		event Action<IAdProvider.AdInfoEventData> AdRewardedEvent;

		// Token: 0x06006D5A RID: 27994
		[Token(Token = "0x6006D5A")]
		UniTask Init(string userId, CancellationToken cancellationToken);

		// Token: 0x06006D5B RID: 27995
		[Token(Token = "0x6006D5B")]
		void ShowAd(string placementName, Dictionary<string, string> payload);

		// Token: 0x06006D5C RID: 27996
		[Token(Token = "0x6006D5C")]
		WaitForCallBack<bool> IsAdAvailable(IAdPlacementData placement);

		// Token: 0x020011FC RID: 4604
		[Token(Token = "0x20011FC")]
		public class BaseAdEventData
		{
			// Token: 0x06006D5D RID: 27997 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006D5D")]
			[Address(RVA = "0xB838", Offset = "0xB838", VA = "0xB838")]
			public BaseAdEventData(IAdProvider provider)
			{
			}

			// Token: 0x04003935 RID: 14645
			[Token(Token = "0x4003935")]
			[FieldOffset(Offset = "0x8")]
			public readonly IAdProvider Provider;
		}

		// Token: 0x020011FD RID: 4605
		[Token(Token = "0x20011FD")]
		public sealed class AdInfoEventData : IAdProvider.BaseAdEventData
		{
			// Token: 0x06006D5E RID: 27998 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006D5E")]
			[Address(RVA = "0xB839", Offset = "0xB839", VA = "0xB839")]
			public AdInfoEventData(IAdProvider provider, string placementName)
			{
			}

			// Token: 0x04003936 RID: 14646
			[Token(Token = "0x4003936")]
			[FieldOffset(Offset = "0xC")]
			public readonly string PlacementName;
		}

		// Token: 0x020011FE RID: 4606
		[Token(Token = "0x20011FE")]
		public sealed class AdErrorEventData : IAdProvider.BaseAdEventData
		{
			// Token: 0x06006D5F RID: 27999 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006D5F")]
			[Address(RVA = "0xB83A", Offset = "0xB83A", VA = "0xB83A")]
			public AdErrorEventData(IAdProvider provider, string adId, int errorCode, string message)
			{
			}

			// Token: 0x04003937 RID: 14647
			[Token(Token = "0x4003937")]
			[FieldOffset(Offset = "0xC")]
			public readonly string AdId;

			// Token: 0x04003938 RID: 14648
			[Token(Token = "0x4003938")]
			[FieldOffset(Offset = "0x10")]
			public readonly int ErrorCode;

			// Token: 0x04003939 RID: 14649
			[Token(Token = "0x4003939")]
			[FieldOffset(Offset = "0x14")]
			public readonly string Message;
		}

		// Token: 0x020011FF RID: 4607
		[Token(Token = "0x20011FF")]
		public sealed class AdAvailabilityEventData : IAdProvider.BaseAdEventData
		{
			// Token: 0x06006D60 RID: 28000 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006D60")]
			[Address(RVA = "0xB83B", Offset = "0xB83B", VA = "0xB83B")]
			public AdAvailabilityEventData(IAdProvider provider, bool available)
			{
			}

			// Token: 0x0400393A RID: 14650
			[Token(Token = "0x400393A")]
			[FieldOffset(Offset = "0xC")]
			public readonly bool Available;
		}
	}
}
