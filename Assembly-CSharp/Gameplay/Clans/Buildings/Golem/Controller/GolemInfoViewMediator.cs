using System;
using Gameplay.Clans.Buildings.Golem.Events;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Clans.Buildings.Golem.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Clans;
using UI;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000ADD RID: 2781
	[Token(Token = "0x2000ADD")]
	public class GolemInfoViewMediator : AbstractViewMediator<GolemModel, GolemEvents, GolemController, GolemInfoWindow>
	{
		// Token: 0x060042FA RID: 17146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FA")]
		[Address(RVA = "0x91AE", Offset = "0x91AE", VA = "0x91AE")]
		public GolemInfoViewMediator(GolemModel model, GolemEvents events, GolemController controller)
		{
		}

		// Token: 0x17000D38 RID: 3384
		// (set) Token: 0x060042FB RID: 17147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D38")]
		public override GolemInfoWindow View
		{
			[Token(Token = "0x60042FB")]
			[Address(RVA = "0x91AF", Offset = "0x91AF", VA = "0x91AF", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FC")]
		[Address(RVA = "0x91B0", Offset = "0x91B0", VA = "0x91B0")]
		private void ResetView()
		{
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FD")]
		[Address(RVA = "0x91B1", Offset = "0x91B1", VA = "0x91B1")]
		private void SetupView()
		{
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FE")]
		[Address(RVA = "0x91B2", Offset = "0x91B2", VA = "0x91B2")]
		private void ClansServiceOnClanUnregisteredEvent(ProtoUnregisterClanAns ans)
		{
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FF")]
		[Address(RVA = "0x91B3", Offset = "0x91B3", VA = "0x91B3")]
		private void ClansServiceOnUserLeftClanEvent(ProtoUserLeftClanEvt evt)
		{
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004300")]
		[Address(RVA = "0x91B4", Offset = "0x91B4", VA = "0x91B4")]
		private void ArmoryButtonClickedEventHandler(IndexButtonBasic btn)
		{
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004301")]
		[Address(RVA = "0x91B5", Offset = "0x91B5", VA = "0x91B5")]
		private void WarStatusButtonClickedEventHandler(IndexButtonBasic op)
		{
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004302")]
		[Address(RVA = "0x91B6", Offset = "0x91B6", VA = "0x91B6")]
		private void EquipmentViewOnSlotClickedEventHandler(GolemEquipmentSlotConfig slotConfig)
		{
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004303")]
		[Address(RVA = "0x91B7", Offset = "0x91B7", VA = "0x91B7")]
		private void ChestButtonClickedEventHandler(IndexButtonBasic btn)
		{
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004304")]
		[Address(RVA = "0x91B8", Offset = "0x91B8", VA = "0x91B8")]
		private void InfoButtonClickedEventHandler()
		{
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004305")]
		[Address(RVA = "0x91B9", Offset = "0x91B9", VA = "0x91B9")]
		private void UpgradeButtonClickedEventHandler(IndexButtonBasic btn)
		{
		}

		// Token: 0x17000D39 RID: 3385
		// (set) Token: 0x06004306 RID: 17158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D39")]
		public override GolemEvents Events
		{
			[Token(Token = "0x6004306")]
			[Address(RVA = "0x91BA", Offset = "0x91BA", VA = "0x91BA", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004307")]
		[Address(RVA = "0x91BB", Offset = "0x91BB", VA = "0x91BB")]
		private void EquipmentChangedEventHandler()
		{
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004308")]
		[Address(RVA = "0x91BC", Offset = "0x91BC", VA = "0x91BC")]
		private void GolemSkillsRequestedEventHandler()
		{
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004309")]
		[Address(RVA = "0x91BD", Offset = "0x91BD", VA = "0x91BD")]
		private void GolemUserInfoRequestedEventHandler()
		{
		}
	}
}
