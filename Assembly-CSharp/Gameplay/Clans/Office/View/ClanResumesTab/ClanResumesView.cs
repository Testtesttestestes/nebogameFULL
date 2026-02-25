using System;
using System.Collections.Generic;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanMembersTab;
using Il2CppDummyDll;
using UI;
using UI.Elements.Buttons;
using UI.Elements.Filters.GenericFilter;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.ClanResumesTab
{
	// Token: 0x02000A2C RID: 2604
	[Token(Token = "0x2000A2C")]
	public class ClanResumesView : MonoBehaviourWithStates<ClanResumesView.ResumesState>
	{
		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06003DB9 RID: 15801 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C4C")]
		public GenericFilterView FilterView
		{
			[Token(Token = "0x6003DB9")]
			[Address(RVA = "0x8C78", Offset = "0x8C78", VA = "0x8C78")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06003DBA RID: 15802 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C4D")]
		public GenericSubFilterView SubFilters
		{
			[Token(Token = "0x6003DBA")]
			[Address(RVA = "0x8C79", Offset = "0x8C79", VA = "0x8C79")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06003DBB RID: 15803 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C4E")]
		public ClanMemberView CandidateInfo
		{
			[Token(Token = "0x6003DBB")]
			[Address(RVA = "0x8C7A", Offset = "0x8C7A", VA = "0x8C7A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06003DBC RID: 15804 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C4F")]
		public ClanVacanciesBasicInfo VacanciesBasicInfo
		{
			[Token(Token = "0x6003DBC")]
			[Address(RVA = "0x8C7B", Offset = "0x8C7B", VA = "0x8C7B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06003DBD RID: 15805 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C50")]
		public ButtonWithCost AddVacancyButton
		{
			[Token(Token = "0x6003DBD")]
			[Address(RVA = "0x8C7C", Offset = "0x8C7C", VA = "0x8C7C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06003DBE RID: 15806 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C51")]
		public Toggle OpenClanToggle
		{
			[Token(Token = "0x6003DBE")]
			[Address(RVA = "0x8C7D", Offset = "0x8C7D", VA = "0x8C7D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06003DBF RID: 15807 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C52")]
		public GameObject AdditionalButtons
		{
			[Token(Token = "0x6003DBF")]
			[Address(RVA = "0x8C7E", Offset = "0x8C7E", VA = "0x8C7E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06003DC0 RID: 15808 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003DC1 RID: 15809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C53")]
		public Action MoreItemsAfterNeededEvent
		{
			[Token(Token = "0x6003DC0")]
			[Address(RVA = "0x8C7F", Offset = "0x8C7F", VA = "0x8C7F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DC1")]
			[Address(RVA = "0x8C80", Offset = "0x8C80", VA = "0x8C80")]
			set
			{
			}
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC2")]
		[Address(RVA = "0x8C81", Offset = "0x8C81", VA = "0x8C81")]
		public void Init(ClanOfficeData data)
		{
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC3")]
		[Address(RVA = "0x8C82", Offset = "0x8C82", VA = "0x8C82")]
		public void UpdateToggle(ClanOfficeData data)
		{
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC4")]
		[Address(RVA = "0x8C83", Offset = "0x8C83", VA = "0x8C83")]
		public void Init(IList<UserInRatingListElement.UserInRatingListElementArgs> items)
		{
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC5")]
		[Address(RVA = "0x8C84", Offset = "0x8C84", VA = "0x8C84")]
		public void Add(IList<UserInRatingListElement.UserInRatingListElementArgs> items)
		{
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC6")]
		[Address(RVA = "0x8C85", Offset = "0x8C85", VA = "0x8C85")]
		public void ActivateUpperBound(bool activate)
		{
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC7")]
		[Address(RVA = "0x8C86", Offset = "0x8C86", VA = "0x8C86")]
		public void Remove(ulong userId)
		{
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC8")]
		[Address(RVA = "0x8C87", Offset = "0x8C87", VA = "0x8C87")]
		public ClanResumesView()
		{
		}

		// Token: 0x04002289 RID: 8841
		[Token(Token = "0x4002289")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ClanResumesOSAView _osaView;

		// Token: 0x0400228A RID: 8842
		[Token(Token = "0x400228A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GenericFilterView _filterView;

		// Token: 0x0400228B RID: 8843
		[Token(Token = "0x400228B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GenericSubFilterView _subFilters;

		// Token: 0x0400228C RID: 8844
		[Token(Token = "0x400228C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ClanMemberView _candidateInfo;

		// Token: 0x0400228D RID: 8845
		[Token(Token = "0x400228D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ClanVacanciesBasicInfo _vacanciesBasicInfo;

		// Token: 0x0400228E RID: 8846
		[Token(Token = "0x400228E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ButtonWithCost _addVacancyButton;

		// Token: 0x0400228F RID: 8847
		[Token(Token = "0x400228F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Toggle _openClanToggle;

		// Token: 0x04002290 RID: 8848
		[Token(Token = "0x4002290")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _additionalButtons;

		// Token: 0x02000A2D RID: 2605
		[Token(Token = "0x2000A2D")]
		public enum ResumesState
		{
			// Token: 0x04002292 RID: 8850
			[Token(Token = "0x4002292")]
			UNKNOWN_STATE,
			// Token: 0x04002293 RID: 8851
			[Token(Token = "0x4002293")]
			COMMON,
			// Token: 0x04002294 RID: 8852
			[Token(Token = "0x4002294")]
			NO_RESUMES
		}
	}
}
