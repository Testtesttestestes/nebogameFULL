using System;
using Gameplay.Clans.Buildings.MagicTower.Events;
using Gameplay.Clans.Buildings.MagicTower.Model;
using Gameplay.Clans.Buildings.MagicTower.View;
using Gameplay.MageSchool.View;
using Gameplay.School.Model;
using Gameplay.School.View;
using Il2CppDummyDll;
using MVC;
using UI.Windows;

namespace Gameplay.Clans.Buildings.MagicTower.Controller
{
	// Token: 0x02000ABB RID: 2747
	[Token(Token = "0x2000ABB")]
	public class MagicTowerViewMediator : AbstractViewMediator<MagicTowerModel, MagicTowerEvents, MagicTowerController, MagicTowerWindow>
	{
		// Token: 0x0600424D RID: 16973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424D")]
		[Address(RVA = "0x9101", Offset = "0x9101", VA = "0x9101")]
		public MagicTowerViewMediator(MagicTowerModel model, MagicTowerEvents events, MagicTowerController controller)
		{
		}

		// Token: 0x17000D0D RID: 3341
		// (set) Token: 0x0600424E RID: 16974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0D")]
		public override MagicTowerWindow View
		{
			[Token(Token = "0x600424E")]
			[Address(RVA = "0x9102", Offset = "0x9102", VA = "0x9102", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424F")]
		[Address(RVA = "0x9103", Offset = "0x9103", VA = "0x9103")]
		private void UseSpellButtonClickedEvent(SchoolSpellData data)
		{
		}

		// Token: 0x06004250 RID: 16976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004250")]
		[Address(RVA = "0x9104", Offset = "0x9104", VA = "0x9104")]
		private void DeselectSpellEventHandler()
		{
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004251")]
		[Address(RVA = "0x9105", Offset = "0x9105", VA = "0x9105")]
		private void SelectSpellEventHandler(SchoolSpellData spell)
		{
		}

		// Token: 0x17000D0E RID: 3342
		// (set) Token: 0x06004252 RID: 16978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0E")]
		public override MagicTowerEvents Events
		{
			[Token(Token = "0x6004252")]
			[Address(RVA = "0x9106", Offset = "0x9106", VA = "0x9106", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004253")]
		[Address(RVA = "0x9107", Offset = "0x9107", VA = "0x9107")]
		private void TowerInfoRequestedEventHandler()
		{
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004254")]
		[Address(RVA = "0x9108", Offset = "0x9108", VA = "0x9108")]
		private void UpdateState(uint spellId)
		{
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004255")]
		[Address(RVA = "0x9109", Offset = "0x9109", VA = "0x9109")]
		private void SetSpellToTitleList(SchoolSpellData schoolSpellData)
		{
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004256")]
		[Address(RVA = "0x910A", Offset = "0x910A", VA = "0x910A")]
		private void OnLearnSpellClicked()
		{
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004257")]
		[Address(RVA = "0x910B", Offset = "0x910B", VA = "0x910B")]
		private void OnBoostSpellClicked()
		{
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004258")]
		[Address(RVA = "0x910C", Offset = "0x910C", VA = "0x910C")]
		private void OnCancelSpellClicked()
		{
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004259")]
		[Address(RVA = "0x910D", Offset = "0x910D", VA = "0x910D")]
		private void ValidateButtons()
		{
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600425A")]
		[Address(RVA = "0x910E", Offset = "0x910E", VA = "0x910E")]
		private void UpdateSpell(uint spellId)
		{
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600425B")]
		[Address(RVA = "0x910F", Offset = "0x910F", VA = "0x910F")]
		private DialogWindow ShowConfirmCancelImproveSpell(SchoolSpellData spell)
		{
			return null;
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600425C")]
		[Address(RVA = "0x9110", Offset = "0x9110", VA = "0x9110")]
		private DialogWindow ShowAccelerateImroveSpell(SchoolSpellData spell)
		{
			return null;
		}

		// Token: 0x04002493 RID: 9363
		[Token(Token = "0x4002493")]
		[FieldOffset(Offset = "0x18")]
		private SchoolSpellData _selectedSpell;

		// Token: 0x04002494 RID: 9364
		[Token(Token = "0x4002494")]
		[FieldOffset(Offset = "0x1C")]
		private SpellCurrentDescriptionTitledListElement _spellCurrentDescription;

		// Token: 0x04002495 RID: 9365
		[Token(Token = "0x4002495")]
		[FieldOffset(Offset = "0x20")]
		private SpellUpgradeTitledListElement _spellUpgradeElement;

		// Token: 0x04002496 RID: 9366
		[Token(Token = "0x4002496")]
		[FieldOffset(Offset = "0x24")]
		private ClanSpellUpgradeRequirementsTitledListElement _spellUpgradeRequirements;
	}
}
