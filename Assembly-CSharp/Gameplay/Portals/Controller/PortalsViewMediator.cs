using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.MVC.Interfaces;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Gameplay.Portals.View;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005E8 RID: 1512
	[Token(Token = "0x20005E8")]
	public class PortalsViewMediator : AbstractViewMediator<PortalsModel, PortalsEvents, PortalsController, PortalsWindow>
	{
		// Token: 0x0600248B RID: 9355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600248B")]
		[Address(RVA = "0x75D9", Offset = "0x75D9", VA = "0x75D9")]
		public PortalsViewMediator(PortalsModel model, PortalsEvents events, PortalsController controller)
		{
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006D8")]
		private PortalsView PortalsView
		{
			[Token(Token = "0x600248C")]
			[Address(RVA = "0x75DA", Offset = "0x75DA", VA = "0x75DA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006D9")]
		private PortalsRewardView PortalsRewardView
		{
			[Token(Token = "0x600248D")]
			[Address(RVA = "0x75DB", Offset = "0x75DB", VA = "0x75DB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006DA")]
		private PortalsMonsterInfoView MonsterInfoView
		{
			[Token(Token = "0x600248E")]
			[Address(RVA = "0x75DC", Offset = "0x75DC", VA = "0x75DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (set) Token: 0x0600248F RID: 9359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006DB")]
		public override PortalsWindow View
		{
			[Token(Token = "0x600248F")]
			[Address(RVA = "0x75DD", Offset = "0x75DD", VA = "0x75DD", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170006DC RID: 1756
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006DC")]
		public override PortalsEvents Events
		{
			[Token(Token = "0x6002490")]
			[Address(RVA = "0x75DE", Offset = "0x75DE", VA = "0x75DE", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002491")]
		[Address(RVA = "0x75DF", Offset = "0x75DF", VA = "0x75DF")]
		public void ShowNavigation()
		{
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002492")]
		[Address(RVA = "0x75E0", Offset = "0x75E0", VA = "0x75E0")]
		private void ResetView()
		{
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002493")]
		[Address(RVA = "0x75E1", Offset = "0x75E1", VA = "0x75E1")]
		private void SetupView()
		{
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002494")]
		[Address(RVA = "0x75E2", Offset = "0x75E2", VA = "0x75E2")]
		private void Init()
		{
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002495")]
		[Address(RVA = "0x75E3", Offset = "0x75E3", VA = "0x75E3")]
		private void DeInit()
		{
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002496")]
		[Address(RVA = "0x75E4", Offset = "0x75E4", VA = "0x75E4")]
		private void RatingButtonHandler()
		{
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002497")]
		[Address(RVA = "0x75E5", Offset = "0x75E5", VA = "0x75E5")]
		private void MyBetsButtonHandler()
		{
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002498")]
		[Address(RVA = "0x75E6", Offset = "0x75E6", VA = "0x75E6")]
		private void TotalButtonHandler()
		{
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002499")]
		[Address(RVA = "0x75E7", Offset = "0x75E7", VA = "0x75E7")]
		private void ShopButtonHandler()
		{
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249A")]
		[Address(RVA = "0x75E8", Offset = "0x75E8", VA = "0x75E8")]
		private void BattleButtonHandler()
		{
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249B")]
		[Address(RVA = "0x75E9", Offset = "0x75E9", VA = "0x75E9")]
		private void CurrentMonsterReceivedHandler()
		{
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249C")]
		[Address(RVA = "0x75EA", Offset = "0x75EA", VA = "0x75EA")]
		private void CurrentMonsterChangedHandler()
		{
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249D")]
		[Address(RVA = "0x75EB", Offset = "0x75EB", VA = "0x75EB")]
		private void SetStageBackTimeOnLastStage()
		{
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249E")]
		[Address(RVA = "0x75EC", Offset = "0x75EC", VA = "0x75EC")]
		private void TabChangedEventHandler()
		{
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249F")]
		[Address(RVA = "0x75ED", Offset = "0x75ED", VA = "0x75ED")]
		private void PortalStateChangedHandler()
		{
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A0")]
		[Address(RVA = "0x75EE", Offset = "0x75EE", VA = "0x75EE")]
		private void PortalInfoButtonHandler()
		{
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A1")]
		[Address(RVA = "0x75EF", Offset = "0x75EF", VA = "0x75EF")]
		private void JackpotInfoReceivedHandler()
		{
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A2")]
		[Address(RVA = "0x75F0", Offset = "0x75F0", VA = "0x75F0")]
		private void TotalizatorInfoButtonHandler()
		{
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A3")]
		[Address(RVA = "0x75F1", Offset = "0x75F1", VA = "0x75F1")]
		private void BetPoolInfoReceivedHandler()
		{
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024A4")]
		[Address(RVA = "0x75F2", Offset = "0x75F2", VA = "0x75F2")]
		private string GetDiamondValue(ResourceSet rs)
		{
			return null;
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A5")]
		[Address(RVA = "0x75F3", Offset = "0x75F3", VA = "0x75F3")]
		private void ShowPortalsInfoWindow(PortalDic.Types.ContentString descriptionContentString, string counterTitle, string counterValue)
		{
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A6")]
		[Address(RVA = "0x75F4", Offset = "0x75F4", VA = "0x75F4")]
		private void RegisterButtonClickHandler()
		{
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A7")]
		[Address(RVA = "0x75F5", Offset = "0x75F5", VA = "0x75F5")]
		private void UserRegisteredHandler()
		{
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A8")]
		[Address(RVA = "0x75F6", Offset = "0x75F6", VA = "0x75F6")]
		private void UserInfoChangedHandler()
		{
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A9")]
		[Address(RVA = "0x75F7", Offset = "0x75F7", VA = "0x75F7")]
		private void StageInfoChangedHandler()
		{
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AA")]
		[Address(RVA = "0x75F8", Offset = "0x75F8", VA = "0x75F8")]
		private void UpdateCurrentState()
		{
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AB")]
		[Address(RVA = "0x75F9", Offset = "0x75F9", VA = "0x75F9")]
		private void StageInfoReceivedHandler()
		{
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AC")]
		[Address(RVA = "0x75FA", Offset = "0x75FA", VA = "0x75FA")]
		private void UpdateProgress()
		{
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AD")]
		[Address(RVA = "0x75FB", Offset = "0x75FB", VA = "0x75FB")]
		private void UpdateRewardView()
		{
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AE")]
		[Address(RVA = "0x75FC", Offset = "0x75FC", VA = "0x75FC")]
		private void IncreasePortalTarget()
		{
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AF")]
		[Address(RVA = "0x75FD", Offset = "0x75FD", VA = "0x75FD")]
		private void DecreasePortalTarget()
		{
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B0")]
		[Address(RVA = "0x75FE", Offset = "0x75FE", VA = "0x75FE")]
		private void ShowLastPortalTarget()
		{
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x00007038 File Offset: 0x00005238
		[Token(Token = "0x60024B1")]
		[Address(RVA = "0x75FF", Offset = "0x75FF", VA = "0x75FF")]
		private bool LastPortalTargetChangeHandler()
		{
			return default(bool);
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B2")]
		[Address(RVA = "0x7600", Offset = "0x7600", VA = "0x7600")]
		private void AttackButtonClickHandler()
		{
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B3")]
		[Address(RVA = "0x7601", Offset = "0x7601", VA = "0x7601")]
		private void ReturnButtonClickHandler()
		{
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B4")]
		[Address(RVA = "0x7602", Offset = "0x7602", VA = "0x7602")]
		private void RenderMonster()
		{
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024B5")]
		[Address(RVA = "0x7603", Offset = "0x7603", VA = "0x7603")]
		private void CloseAll()
		{
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024B6")]
		[Address(RVA = "0x7604", Offset = "0x7604", VA = "0x7604")]
		private IHideableMediator ShowRatingTab()
		{
			return null;
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024B7")]
		[Address(RVA = "0x7605", Offset = "0x7605", VA = "0x7605")]
		private IHideableMediator ShowTotalizatorTab()
		{
			return null;
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024B8")]
		[Address(RVA = "0x7606", Offset = "0x7606", VA = "0x7606")]
		private IHideableMediator ShowMyBetsTab()
		{
			return null;
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024B9")]
		[Address(RVA = "0x7607", Offset = "0x7607", VA = "0x7607")]
		private IHideableMediator ShowShopTab()
		{
			return null;
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BA")]
		[Address(RVA = "0x7608", Offset = "0x7608", VA = "0x7608", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BC")]
		[Address(RVA = "0x760A", Offset = "0x760A", VA = "0x760A")]
		[CompilerGenerated]
		internal static void <Dispose>g__DisposeMediator|58_0(IViewMediator mediator)
		{
		}

		// Token: 0x04001408 RID: 5128
		[Token(Token = "0x4001408")]
		[FieldOffset(Offset = "0x18")]
		private PortalsTotalizatorViewMediator _portalsTotalizatorViewMediator;

		// Token: 0x04001409 RID: 5129
		[Token(Token = "0x4001409")]
		[FieldOffset(Offset = "0x1C")]
		private PortalsRatingViewMediator _portalsRatingViewMediator;

		// Token: 0x0400140A RID: 5130
		[Token(Token = "0x400140A")]
		[FieldOffset(Offset = "0x20")]
		private PortalsShopViewMediator _portalsShopViewMediator;

		// Token: 0x0400140B RID: 5131
		[Token(Token = "0x400140B")]
		[FieldOffset(Offset = "0x24")]
		private PortalsMyBetsViewMediator _portalsMyBetsViewMediator;

		// Token: 0x0400140C RID: 5132
		[Token(Token = "0x400140C")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<PortalsTargets, Func<IHideableMediator>> _tabsOpenersById;

		// Token: 0x0400140D RID: 5133
		[Token(Token = "0x400140D")]
		[FieldOffset(Offset = "0x2C")]
		private IHideableMediator _currentMediator;
	}
}
