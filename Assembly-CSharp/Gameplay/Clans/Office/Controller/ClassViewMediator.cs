using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClassTab;
using Gameplay.School.Model;
using Gameplay.UserInfo.View.Equipment;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Dic;
using UI.Elements.Buildings;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A76 RID: 2678
	[Token(Token = "0x2000A76")]
	public class ClassViewMediator : AbstractViewMediator<ClassModel, ClassEvents, ClassController, ClassView>, IHideableMediator
	{
		// Token: 0x06003FB9 RID: 16313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB9")]
		[Address(RVA = "0x8E73", Offset = "0x8E73", VA = "0x8E73")]
		public ClassViewMediator(ClassModel model, ClassEvents events, ClassController controller)
		{
		}

		// Token: 0x17000CA9 RID: 3241
		// (set) Token: 0x06003FBA RID: 16314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA9")]
		public override ClassView View
		{
			[Token(Token = "0x6003FBA")]
			[Address(RVA = "0x8E74", Offset = "0x8E74", VA = "0x8E74", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FBB")]
		[Address(RVA = "0x8E75", Offset = "0x8E75", VA = "0x8E75")]
		private void Init()
		{
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FBC")]
		[Address(RVA = "0x8E76", Offset = "0x8E76", VA = "0x8E76")]
		private void InfoButtonClickedEventHandler()
		{
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FBD")]
		[Address(RVA = "0x8E77", Offset = "0x8E77", VA = "0x8E77")]
		private void TabChangedEventHandler()
		{
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FBE")]
		[Address(RVA = "0x8E78", Offset = "0x8E78", VA = "0x8E78")]
		private void ClassFilterClickedEventHandler(SubFilterListElement element)
		{
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FBF")]
		[Address(RVA = "0x8E79", Offset = "0x8E79", VA = "0x8E79")]
		private void SelectFilter(SubFilterListElement element)
		{
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC0")]
		[Address(RVA = "0x8E7A", Offset = "0x8E7A", VA = "0x8E7A")]
		private void SelectSpellEventHandler(SpellItemArgs spellItemArgs)
		{
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC1")]
		[Address(RVA = "0x8E7B", Offset = "0x8E7B", VA = "0x8E7B")]
		private void SetSpellToTitleList(SchoolSpellData schoolSpellData)
		{
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC2")]
		[Address(RVA = "0x8E7C", Offset = "0x8E7C", VA = "0x8E7C")]
		private void DeselectSpellEventHandler(SpellItemArgs args)
		{
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC3")]
		[Address(RVA = "0x8E7D", Offset = "0x8E7D", VA = "0x8E7D")]
		private void HandleSpellDeselected()
		{
		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC4")]
		[Address(RVA = "0x8E7E", Offset = "0x8E7E", VA = "0x8E7E")]
		private void HandleSpellSelected()
		{
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC5")]
		[Address(RVA = "0x8E7F", Offset = "0x8E7F", VA = "0x8E7F")]
		private void CloseSpellDescButtonClickedEventHandler()
		{
		}

		// Token: 0x17000CAA RID: 3242
		// (set) Token: 0x06003FC6 RID: 16326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAA")]
		public override ClassEvents Events
		{
			[Token(Token = "0x6003FC6")]
			[Address(RVA = "0x8E80", Offset = "0x8E80", VA = "0x8E80", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC7")]
		[Address(RVA = "0x8E81", Offset = "0x8E81", VA = "0x8E81")]
		private void DollSkillsRequestedEventHandler(ulong dollId)
		{
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC8")]
		[Address(RVA = "0x8E82", Offset = "0x8E82", VA = "0x8E82")]
		private void DollSpellsRequestedEventHandler()
		{
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC9")]
		[Address(RVA = "0x8E83", Offset = "0x8E83", VA = "0x8E83")]
		private void SlotsChangedEventHandler()
		{
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCA")]
		[Address(RVA = "0x8E84", Offset = "0x8E84", VA = "0x8E84")]
		private void EquipmentViewOnSlotClickedEventHandler(UserEquipmentSlotConfig slotConfig)
		{
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCB")]
		[Address(RVA = "0x8E85", Offset = "0x8E85", VA = "0x8E85", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x040023B4 RID: 9140
		[Token(Token = "0x40023B4")]
		[FieldOffset(Offset = "0x18")]
		private SubFilterListElement _selectedFilter;

		// Token: 0x040023B5 RID: 9141
		[Token(Token = "0x40023B5")]
		[FieldOffset(Offset = "0x1C")]
		private DollsInfoDic _selectedDoll;
	}
}
