using System;
using Il2CppDummyDll;
using MVC;
using UI.Windows.Buildings;

namespace Gameplay.Cave.Controller
{
	// Token: 0x02000B35 RID: 2869
	[Token(Token = "0x2000B35")]
	public class CaveWindowMediator : AbstractViewMediator<CaveModel, CaveEvents, CaveController, CaveWindow>
	{
		// Token: 0x060045AB RID: 17835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AB")]
		[Address(RVA = "0x944D", Offset = "0x944D", VA = "0x944D")]
		public CaveWindowMediator(CaveModel model, CaveEvents events, CaveController controller)
		{
		}

		// Token: 0x17000DBC RID: 3516
		// (set) Token: 0x060045AC RID: 17836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBC")]
		public override CaveEvents Events
		{
			[Token(Token = "0x60045AC")]
			[Address(RVA = "0x944E", Offset = "0x944E", VA = "0x944E", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AD")]
		[Address(RVA = "0x944F", Offset = "0x944F", VA = "0x944F")]
		private void MonsterStatusChangedEvent()
		{
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AE")]
		[Address(RVA = "0x9450", Offset = "0x9450", VA = "0x9450")]
		private void CaveStateChangedEvent()
		{
		}

		// Token: 0x17000DBD RID: 3517
		// (set) Token: 0x060045AF RID: 17839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBD")]
		public override CaveWindow View
		{
			[Token(Token = "0x60045AF")]
			[Address(RVA = "0x9451", Offset = "0x9451", VA = "0x9451", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B0")]
		[Address(RVA = "0x9452", Offset = "0x9452", VA = "0x9452")]
		private void EnableExitButtons(bool enable)
		{
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B1")]
		[Address(RVA = "0x9453", Offset = "0x9453", VA = "0x9453")]
		private void KickButtonClickHandler()
		{
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B2")]
		[Address(RVA = "0x9454", Offset = "0x9454", VA = "0x9454")]
		private void AttackButtonClickHandler()
		{
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B3")]
		[Address(RVA = "0x9455", Offset = "0x9455", VA = "0x9455")]
		private void OnSearchInCaveClicked()
		{
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B4")]
		[Address(RVA = "0x9456", Offset = "0x9456", VA = "0x9456")]
		private void OnChestClicked()
		{
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B5")]
		[Address(RVA = "0x9457", Offset = "0x9457", VA = "0x9457")]
		private void RenderRewards()
		{
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B6")]
		[Address(RVA = "0x9458", Offset = "0x9458", VA = "0x9458")]
		private void ShowMonsterWiki()
		{
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B7")]
		[Address(RVA = "0x9459", Offset = "0x9459", VA = "0x9459")]
		private void HideMonsterWiki()
		{
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B8")]
		[Address(RVA = "0x945A", Offset = "0x945A", VA = "0x945A")]
		private void RenderMonster()
		{
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B9")]
		[Address(RVA = "0x945B", Offset = "0x945B", VA = "0x945B")]
		private void CloseWindow()
		{
		}

		// Token: 0x0400261E RID: 9758
		[Token(Token = "0x400261E")]
		public const string CAVE_FIND_TIP = "CAVE/FINDING_TIP";

		// Token: 0x0400261F RID: 9759
		[Token(Token = "0x400261F")]
		public const string CAVE_FOUND_RESOURCE = "CAVE/FOUND_RESOURCE";
	}
}
