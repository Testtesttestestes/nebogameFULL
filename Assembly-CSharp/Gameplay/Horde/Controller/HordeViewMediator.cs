using System;
using Gameplay.Horde.Events;
using Gameplay.Horde.Model;
using Gameplay.Horde.View;
using Gameplay.Isles.User;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Horde.Controller
{
	// Token: 0x02000703 RID: 1795
	[Token(Token = "0x2000703")]
	public class HordeViewMediator : AbstractViewMediator<HordeModel, HordeEvents, HordeController, HordeView>
	{
		// Token: 0x06002AF7 RID: 10999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF7")]
		[Address(RVA = "0x7B92", Offset = "0x7B92", VA = "0x7B92")]
		public HordeViewMediator(HordeModel model, HordeEvents events, HordeController controller)
		{
		}

		// Token: 0x1700082A RID: 2090
		// (set) Token: 0x06002AF8 RID: 11000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082A")]
		public override HordeEvents Events
		{
			[Token(Token = "0x6002AF8")]
			[Address(RVA = "0x7B93", Offset = "0x7B93", VA = "0x7B93", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x1700082B RID: 2091
		// (set) Token: 0x06002AF9 RID: 11001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082B")]
		public override HordeView View
		{
			[Token(Token = "0x6002AF9")]
			[Address(RVA = "0x7B94", Offset = "0x7B94", VA = "0x7B94", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFA")]
		[Address(RVA = "0x7B95", Offset = "0x7B95", VA = "0x7B95")]
		private void RequestHordeInfoEventHandler(uint mainMonsterId)
		{
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFB")]
		[Address(RVA = "0x7B96", Offset = "0x7B96", VA = "0x7B96")]
		private void HordeRequestedEventHandler()
		{
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFC")]
		[Address(RVA = "0x7B97", Offset = "0x7B97", VA = "0x7B97")]
		private void OverrideCloseMasterWindow()
		{
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFD")]
		[Address(RVA = "0x7B98", Offset = "0x7B98", VA = "0x7B98")]
		private void HordeExitedEventHandler()
		{
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFE")]
		[Address(RVA = "0x7B99", Offset = "0x7B99", VA = "0x7B99")]
		private void ExitHorde()
		{
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFF")]
		[Address(RVA = "0x7B9A", Offset = "0x7B9A", VA = "0x7B9A")]
		private void AttackButtonClickedEventHandler()
		{
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B00")]
		[Address(RVA = "0x7B9B", Offset = "0x7B9B", VA = "0x7B9B")]
		private void AttackMonster(IMonsterSource source)
		{
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x00008670 File Offset: 0x00006870
		[Token(Token = "0x6002B01")]
		[Address(RVA = "0x7B9C", Offset = "0x7B9C", VA = "0x7B9C")]
		private bool CheckItemsDurability()
		{
			return default(bool);
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B02")]
		[Address(RVA = "0x7B9D", Offset = "0x7B9D", VA = "0x7B9D")]
		private void MonsterAprClickedEventHandler(HordeMonsterAprView view)
		{
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B03")]
		[Address(RVA = "0x7B9E", Offset = "0x7B9E", VA = "0x7B9E")]
		private void SelectMonsterView(HordeMonsterAprView view)
		{
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B04")]
		[Address(RVA = "0x7B9F", Offset = "0x7B9F", VA = "0x7B9F")]
		private void ShowExitHordeConfirmationWindow()
		{
		}

		// Token: 0x0400177C RID: 6012
		[Token(Token = "0x400177C")]
		[FieldOffset(Offset = "0x18")]
		private HordeMonsterAprView _selectedView;
	}
}
