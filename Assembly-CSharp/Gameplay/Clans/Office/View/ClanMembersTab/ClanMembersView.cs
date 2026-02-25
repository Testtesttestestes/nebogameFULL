using System;
using System.Collections.Generic;
using Gameplay.Clans.Office.Model;
using Il2CppDummyDll;
using UI;
using UI.Elements.Buttons;
using UI.Elements.Filters.GenericFilter;
using UI.Elements.RatingElements.SubRatings;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.ClanMembersTab
{
	// Token: 0x02000A3D RID: 2621
	[Token(Token = "0x2000A3D")]
	public class ClanMembersView : MonoBehaviourWithStates<ClanInfoWindow.State>
	{
		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06003E02 RID: 15874 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C61")]
		public SubRatingsList SubRatings
		{
			[Token(Token = "0x6003E02")]
			[Address(RVA = "0x8CC1", Offset = "0x8CC1", VA = "0x8CC1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06003E03 RID: 15875 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C62")]
		public GenericFilterView FilterView
		{
			[Token(Token = "0x6003E03")]
			[Address(RVA = "0x8CC2", Offset = "0x8CC2", VA = "0x8CC2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06003E04 RID: 15876 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C63")]
		public ClanMemberView ClanMemberView
		{
			[Token(Token = "0x6003E04")]
			[Address(RVA = "0x8CC3", Offset = "0x8CC3", VA = "0x8CC3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06003E05 RID: 15877 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C64")]
		public ButtonWithCost JoinButton
		{
			[Token(Token = "0x6003E05")]
			[Address(RVA = "0x8CC4", Offset = "0x8CC4", VA = "0x8CC4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06003E06 RID: 15878 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C65")]
		public Button WithdrawButton
		{
			[Token(Token = "0x6003E06")]
			[Address(RVA = "0x8CC5", Offset = "0x8CC5", VA = "0x8CC5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06003E07 RID: 15879 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C66")]
		public ButtonWithCost AddVacancyButton
		{
			[Token(Token = "0x6003E07")]
			[Address(RVA = "0x8CC6", Offset = "0x8CC6", VA = "0x8CC6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06003E08 RID: 15880 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C67")]
		public Toggle OpenClanToggle
		{
			[Token(Token = "0x6003E08")]
			[Address(RVA = "0x8CC7", Offset = "0x8CC7", VA = "0x8CC7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06003E09 RID: 15881 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C68")]
		public Button OwnButton
		{
			[Token(Token = "0x6003E09")]
			[Address(RVA = "0x8CC8", Offset = "0x8CC8", VA = "0x8CC8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06003E0A RID: 15882 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C69")]
		public GameObject AdditionalButtons
		{
			[Token(Token = "0x6003E0A")]
			[Address(RVA = "0x8CC9", Offset = "0x8CC9", VA = "0x8CC9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E0B")]
		[Address(RVA = "0x8CCA", Offset = "0x8CCA", VA = "0x8CCA")]
		public void Init(IList<ClanMemberListElement.ClanMemberListElementArgs> members)
		{
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E0C")]
		[Address(RVA = "0x8CCB", Offset = "0x8CCB", VA = "0x8CCB")]
		public void Init(ClanOfficeData data)
		{
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E0D")]
		[Address(RVA = "0x8CCC", Offset = "0x8CCC", VA = "0x8CCC")]
		public void UpdateToggle(ClanOfficeData data)
		{
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E0E")]
		[Address(RVA = "0x8CCD", Offset = "0x8CCD", VA = "0x8CCD")]
		public ClanMembersView()
		{
		}

		// Token: 0x040022CD RID: 8909
		[Token(Token = "0x40022CD")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private SubRatingsList _subRatings;

		// Token: 0x040022CE RID: 8910
		[Token(Token = "0x40022CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GenericFilterView _filterView;

		// Token: 0x040022CF RID: 8911
		[Token(Token = "0x40022CF")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ClanMembersOSAView _clanMembersOSAView;

		// Token: 0x040022D0 RID: 8912
		[Token(Token = "0x40022D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ClanMemberView _clanMemberView;

		// Token: 0x040022D1 RID: 8913
		[Token(Token = "0x40022D1")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _ownButton;

		// Token: 0x040022D2 RID: 8914
		[Token(Token = "0x40022D2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ClanVacanciesBasicInfo _vacanciesBasicInfo;

		// Token: 0x040022D3 RID: 8915
		[Token(Token = "0x40022D3")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ButtonWithCost _joinButton;

		// Token: 0x040022D4 RID: 8916
		[Token(Token = "0x40022D4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _withdrawButton;

		// Token: 0x040022D5 RID: 8917
		[Token(Token = "0x40022D5")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ButtonWithCost _addVacancyButton;

		// Token: 0x040022D6 RID: 8918
		[Token(Token = "0x40022D6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Toggle _openClanToggle;

		// Token: 0x040022D7 RID: 8919
		[Token(Token = "0x40022D7")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameObject _additionalButtons;
	}
}
