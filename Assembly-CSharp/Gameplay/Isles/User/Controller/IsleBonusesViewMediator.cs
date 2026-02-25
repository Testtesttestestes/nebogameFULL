using System;
using System.Collections.Generic;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UI.Windows;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D36 RID: 3382
	[Token(Token = "0x2000D36")]
	public class IsleBonusesViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, IsleBonusesView>
	{
		// Token: 0x060052B1 RID: 21169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B1")]
		[Address(RVA = "0xA087", Offset = "0xA087", VA = "0xA087")]
		public IsleBonusesViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		}

		// Token: 0x170010DB RID: 4315
		// (set) Token: 0x060052B2 RID: 21170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010DB")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x60052B2")]
			[Address(RVA = "0xA088", Offset = "0xA088", VA = "0xA088", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B3")]
		[Address(RVA = "0xA089", Offset = "0xA089", VA = "0xA089")]
		private void DiamondIsleFoundEvent()
		{
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B4")]
		[Address(RVA = "0xA08A", Offset = "0xA08A", VA = "0xA08A")]
		private void IsleBonusCollected(uint positionId)
		{
		}

		// Token: 0x060052B5 RID: 21173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B5")]
		[Address(RVA = "0xA08B", Offset = "0xA08B", VA = "0xA08B")]
		private void IsCurrentChangedEvent()
		{
		}

		// Token: 0x170010DC RID: 4316
		// (set) Token: 0x060052B6 RID: 21174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010DC")]
		public override IsleBonusesView View
		{
			[Token(Token = "0x60052B6")]
			[Address(RVA = "0xA08C", Offset = "0xA08C", VA = "0xA08C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B7")]
		[Address(RVA = "0xA08D", Offset = "0xA08D", VA = "0xA08D")]
		private void ViewOnBonusClickedEvent(uint positionId)
		{
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B8")]
		[Address(RVA = "0xA08E", Offset = "0xA08E", VA = "0xA08E")]
		private void SetupBonuses()
		{
		}

		// Token: 0x060052B9 RID: 21177 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60052B9")]
		[Address(RVA = "0xA08F", Offset = "0xA08F", VA = "0xA08F")]
		private Dictionary<TreeBonusAnimation, TreeBonusPosition> GetActualBonusDic()
		{
			return null;
		}

		// Token: 0x060052BA RID: 21178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052BA")]
		[Address(RVA = "0xA090", Offset = "0xA090", VA = "0xA090")]
		private void ConfirmSpentLicenseCallback(BaseDialogWindow<DialogWindow.DialogWindowArgs> window)
		{
		}

		// Token: 0x060052BB RID: 21179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052BB")]
		[Address(RVA = "0xA091", Offset = "0xA091", VA = "0xA091")]
		private void OnAgreeButtonClicked()
		{
		}

		// Token: 0x060052BC RID: 21180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052BC")]
		[Address(RVA = "0xA092", Offset = "0xA092", VA = "0xA092", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04002CFA RID: 11514
		[Token(Token = "0x4002CFA")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<TreeBonusAnimation, TreeBonusPosition> _actualBonusDic;
	}
}
