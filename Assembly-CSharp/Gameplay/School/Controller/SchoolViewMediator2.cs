using System;
using Gameplay.MageSchool.Events;
using Gameplay.School.Model;
using Il2CppDummyDll;
using MVC;
using UI.Windows;
using UI.Windows.Buildings.MageSchoolWindow;

namespace Gameplay.School.Controller
{
	// Token: 0x0200064D RID: 1613
	[Token(Token = "0x200064D")]
	public class SchoolViewMediator2 : AbstractViewMediator<SchoolModel, SchoolEvents, SchoolController, SchoolWindow2>
	{
		// Token: 0x17000760 RID: 1888
		// (set) Token: 0x06002724 RID: 10020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000760")]
		public override SchoolEvents Events
		{
			[Token(Token = "0x6002724")]
			[Address(RVA = "0x7858", Offset = "0x7858", VA = "0x7858", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000761 RID: 1889
		// (set) Token: 0x06002725 RID: 10021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000761")]
		public override SchoolWindow2 View
		{
			[Token(Token = "0x6002725")]
			[Address(RVA = "0x7859", Offset = "0x7859", VA = "0x7859", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002726")]
		[Address(RVA = "0x785A", Offset = "0x785A", VA = "0x785A")]
		public SchoolViewMediator2(SchoolModel model, SchoolEvents events, SchoolController controller)
		{
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002727")]
		[Address(RVA = "0x785B", Offset = "0x785B", VA = "0x785B")]
		private void OnInitEvent()
		{
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002728")]
		[Address(RVA = "0x785C", Offset = "0x785C", VA = "0x785C")]
		private void SpellInfoButtonClickedEventHandler()
		{
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002729")]
		[Address(RVA = "0x785D", Offset = "0x785D", VA = "0x785D")]
		private void InitSpells()
		{
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272A")]
		[Address(RVA = "0x785E", Offset = "0x785E", VA = "0x785E")]
		private void UpdateSpell(uint spellId)
		{
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272B")]
		[Address(RVA = "0x785F", Offset = "0x785F", VA = "0x785F")]
		private void OnSelectSpell(uint spellId)
		{
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272C")]
		[Address(RVA = "0x7860", Offset = "0x7860", VA = "0x7860")]
		private void OnDeselectSpell(uint spellId)
		{
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272D")]
		[Address(RVA = "0x7861", Offset = "0x7861", VA = "0x7861")]
		private void ShowEmptyInfo()
		{
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272E")]
		[Address(RVA = "0x7862", Offset = "0x7862", VA = "0x7862")]
		private void OnLearnSpellClicked()
		{
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272F")]
		[Address(RVA = "0x7863", Offset = "0x7863", VA = "0x7863")]
		private void OnBoostSpellClicked()
		{
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002730")]
		[Address(RVA = "0x7864", Offset = "0x7864", VA = "0x7864")]
		private void OnCancelSpellClicked()
		{
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002731")]
		[Address(RVA = "0x7865", Offset = "0x7865", VA = "0x7865")]
		private void UpdateState(uint spellId)
		{
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002732")]
		[Address(RVA = "0x7866", Offset = "0x7866", VA = "0x7866")]
		private DialogWindow ShowConfirmCancelImproveSpell(SchoolSpellData spell)
		{
			return null;
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002733")]
		[Address(RVA = "0x7867", Offset = "0x7867", VA = "0x7867")]
		private BaseWindow ShowAccelerateImproveSpell(SchoolSpellData spell)
		{
			return null;
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002734")]
		[Address(RVA = "0x7868", Offset = "0x7868", VA = "0x7868")]
		private void OnWindowClose()
		{
		}

		// Token: 0x0400156A RID: 5482
		[Token(Token = "0x400156A")]
		[FieldOffset(Offset = "0x18")]
		private string MAGE_SCHOOL_NEUTRAL_SPELLS;

		// Token: 0x0400156B RID: 5483
		[Token(Token = "0x400156B")]
		[FieldOffset(Offset = "0x1C")]
		private string MAGE_SCHOOL_SPECIAL_SPELLS;

		// Token: 0x0400156C RID: 5484
		[Token(Token = "0x400156C")]
		[FieldOffset(Offset = "0x20")]
		private uint? _selectedSpell;
	}
}
