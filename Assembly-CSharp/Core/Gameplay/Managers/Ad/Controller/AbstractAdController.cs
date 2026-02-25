using System;
using System.Collections.Generic;
using System.Threading;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Model;
using Core.Gameplay.Managers.Ad.Placements;
using Core.Gameplay.Managers.Ad.Providers;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Services;
using ServicesNamespace;
using Utils;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Controller
{
	// Token: 0x02001227 RID: 4647
	[Token(Token = "0x2001227")]
	public abstract class AbstractAdController : AbstractController<AbstractAdModel, AdEvents>, IAdController
	{
		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06006E00 RID: 28160 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001658")]
		private IAdProvider DefaultProvider
		{
			[Token(Token = "0x6006E00")]
			[Address(RVA = "0xB8B6", Offset = "0xB8B6", VA = "0xB8B6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006E01 RID: 28161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E01")]
		[Address(RVA = "0xB8B7", Offset = "0xB8B7", VA = "0xB8B7", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006E02 RID: 28162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E02")]
		[Address(RVA = "0xB8B8", Offset = "0xB8B8", VA = "0xB8B8")]
		protected AbstractAdController(ServicesService servicesService, AbstractAdModel model, AdEvents events)
		{
		}

		// Token: 0x06006E03 RID: 28163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E03")]
		[Address(RVA = "0xB8B9", Offset = "0xB8B9", VA = "0xB8B9")]
		private void InitializeAdProviders()
		{
		}

		// Token: 0x06006E04 RID: 28164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E04")]
		[Address(RVA = "0xB8BA", Offset = "0xB8BA", VA = "0xB8BA")]
		private void DestroyAllProviders()
		{
		}

		// Token: 0x06006E05 RID: 28165
		[Token(Token = "0x6006E05")]
		protected abstract IAdProvider CreateAdProvider(AdSource providerId);

		// Token: 0x06006E06 RID: 28166
		[Token(Token = "0x6006E06")]
		protected abstract void InitializeAdProvidersPreProcess();

		// Token: 0x06006E07 RID: 28167
		[Token(Token = "0x6006E07")]
		protected abstract void InitializeAdProvidersPostProcess();

		// Token: 0x06006E08 RID: 28168 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006E08")]
		[Address(RVA = "0xB8BB", Offset = "0xB8BB", VA = "0xB8BB")]
		private WaitForCallBack<bool> CheckIfAdAvailableByProvider(IAdPlacementData placement)
		{
			return null;
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006E09")]
		[Address(RVA = "0xB8BC", Offset = "0xB8BC", VA = "0xB8BC", Slot = "13")]
		public WaitForCallBack<bool> Check(IAdPlacementData placement)
		{
			return null;
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E0A")]
		[Address(RVA = "0xB8BD", Offset = "0xB8BD", VA = "0xB8BD", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06006E0B RID: 28171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E0B")]
		[Address(RVA = "0xB8BE", Offset = "0xB8BE", VA = "0xB8BE", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06006E0C RID: 28172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E0C")]
		[Address(RVA = "0xB8BF", Offset = "0xB8BF", VA = "0xB8BF")]
		private void ValidateInit()
		{
		}

		// Token: 0x06006E0D RID: 28173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E0D")]
		[Address(RVA = "0xB8C0", Offset = "0xB8C0", VA = "0xB8C0")]
		private void RequestPlacementInfo(IEnumerable<uint> placementIds)
		{
		}

		// Token: 0x06006E0E RID: 28174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E0E")]
		[Address(RVA = "0xB8C1", Offset = "0xB8C1", VA = "0xB8C1")]
		private void RequestPlacementInfo(uint placementId)
		{
		}

		// Token: 0x06006E0F RID: 28175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E0F")]
		[Address(RVA = "0xB8C2", Offset = "0xB8C2", VA = "0xB8C2")]
		private void HandleServiceCreateAdPlacementTx(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06006E10 RID: 28176 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006E10")]
		[Address(RVA = "0xB8C3", Offset = "0xB8C3", VA = "0xB8C3")]
		private Dictionary<string, string> GetPayloadParameters(MapField<string, string> rawPayload)
		{
			return null;
		}

		// Token: 0x06006E11 RID: 28177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E11")]
		[Address(RVA = "0xB8C4", Offset = "0xB8C4", VA = "0xB8C4")]
		private void HandleServiceGetPlacementInfo(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E12")]
		[Address(RVA = "0xB8C5", Offset = "0xB8C5", VA = "0xB8C5")]
		private void UpdatePlacementInfo(AdPlacementInfo info)
		{
		}

		// Token: 0x06006E13 RID: 28179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E13")]
		[Address(RVA = "0xB8C6", Offset = "0xB8C6", VA = "0xB8C6", Slot = "12")]
		private void ShowAd(uint adPlacementId, uint optionId)
		{
		}

		// Token: 0x06006E14 RID: 28180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E14")]
		[Address(RVA = "0xB8C7", Offset = "0xB8C7", VA = "0xB8C7")]
		private void OnCurrentAdRejected()
		{
		}

		// Token: 0x06006E15 RID: 28181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E15")]
		[Address(RVA = "0xB8C8", Offset = "0xB8C8", VA = "0xB8C8")]
		private void PlacementOnBacktimerCompleteEvent(IAdPlacementData data)
		{
		}

		// Token: 0x06006E16 RID: 28182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E16")]
		[Address(RVA = "0xB8C9", Offset = "0xB8C9", VA = "0xB8C9")]
		private void CreateCurrentTransaction(AdPlacement adPlacement, uint optionId)
		{
		}

		// Token: 0x06006E17 RID: 28183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E17")]
		[Address(RVA = "0xB8CA", Offset = "0xB8CA", VA = "0xB8CA")]
		private void ClearCurrentTransaction()
		{
		}

		// Token: 0x06006E18 RID: 28184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E18")]
		[Address(RVA = "0xB8CB", Offset = "0xB8CB", VA = "0xB8CB")]
		private void ServicesServiceOnTransactionClosedEvent(AdTransactionClosedEvt evt)
		{
		}

		// Token: 0x06006E19 RID: 28185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E19")]
		[Address(RVA = "0xB8CC", Offset = "0xB8CC", VA = "0xB8CC")]
		private void ProviderOnAdErrorEvent(IAdProvider.AdErrorEventData e)
		{
		}

		// Token: 0x06006E1A RID: 28186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E1A")]
		[Address(RVA = "0xB8CD", Offset = "0xB8CD", VA = "0xB8CD")]
		private void ShowError(string adId, int errorCode, string message)
		{
		}

		// Token: 0x06006E1B RID: 28187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E1B")]
		[Address(RVA = "0xB8CE", Offset = "0xB8CE", VA = "0xB8CE")]
		private void AdAvailabilityChangedEventHandler(IAdProvider.AdAvailabilityEventData e)
		{
		}

		// Token: 0x06006E1C RID: 28188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E1C")]
		[Address(RVA = "0xB8CF", Offset = "0xB8CF", VA = "0xB8CF")]
		private void ProviderOnAdClosedEvent(IAdProvider.BaseAdEventData e)
		{
		}

		// Token: 0x06006E1D RID: 28189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E1D")]
		[Address(RVA = "0xB8D0", Offset = "0xB8D0", VA = "0xB8D0")]
		private void ProviderOnAdRewardedEvent(IAdProvider.AdInfoEventData e)
		{
		}

		// Token: 0x0400398D RID: 14733
		[Token(Token = "0x400398D")]
		[FieldOffset(Offset = "0x18")]
		private readonly ServicesService _servicesService;

		// Token: 0x0400398E RID: 14734
		[Token(Token = "0x400398E")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Dictionary<uint, IAdProvider> _adProviders;

		// Token: 0x0400398F RID: 14735
		[Token(Token = "0x400398F")]
		[FieldOffset(Offset = "0x20")]
		private readonly CancellationTokenSource _cancellationTokenSource;
	}
}
