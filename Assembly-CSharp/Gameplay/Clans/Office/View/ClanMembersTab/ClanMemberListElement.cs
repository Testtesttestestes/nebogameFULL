using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using Protocol.Rating;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.Clans.Office.View.ClanMembersTab
{
	// Token: 0x02000A35 RID: 2613
	[Token(Token = "0x2000A35")]
	public class ClanMemberListElement : GenericListElement<ClanMemberListElement.ClanMemberListElementArgs>
	{
		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06003DDE RID: 15838 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003DDF RID: 15839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5A")]
		public ClanMemberListElement.ClanMemberListElementArgs Data
		{
			[Token(Token = "0x6003DDE")]
			[Address(RVA = "0x8C9D", Offset = "0x8C9D", VA = "0x8C9D")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DDF")]
			[Address(RVA = "0x8C9E", Offset = "0x8C9E", VA = "0x8C9E")]
			set
			{
			}
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE0")]
		[Address(RVA = "0x8C9F", Offset = "0x8C9F", VA = "0x8C9F")]
		private void Awake()
		{
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE1")]
		[Address(RVA = "0x8CA0", Offset = "0x8CA0", VA = "0x8CA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE2")]
		[Address(RVA = "0x8CA1", Offset = "0x8CA1", VA = "0x8CA1")]
		private void CallElementClickedEvent(ClanMemberListElement.ClanMemberListElementArgs args)
		{
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE3")]
		[Address(RVA = "0x8CA2", Offset = "0x8CA2", VA = "0x8CA2", Slot = "4")]
		protected override void OnInit(ClanMemberListElement.ClanMemberListElementArgs args)
		{
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE4")]
		[Address(RVA = "0x8CA3", Offset = "0x8CA3", VA = "0x8CA3")]
		private void SelectChangedEventHandler(bool select)
		{
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE5")]
		[Address(RVA = "0x8CA4", Offset = "0x8CA4", VA = "0x8CA4", Slot = "7")]
		protected virtual void Select(bool isSelected)
		{
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE6")]
		[Address(RVA = "0x8CA5", Offset = "0x8CA5", VA = "0x8CA5", Slot = "8")]
		protected virtual void ApplyArgs()
		{
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE7")]
		[Address(RVA = "0x8CA6", Offset = "0x8CA6", VA = "0x8CA6")]
		public ClanMemberListElement()
		{
		}

		// Token: 0x040022B0 RID: 8880
		[Token(Token = "0x40022B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectedImage;

		// Token: 0x040022B1 RID: 8881
		[Token(Token = "0x40022B1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UserView _userView;

		// Token: 0x040022B2 RID: 8882
		[Token(Token = "0x40022B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameImage _cultIcon;

		// Token: 0x040022B3 RID: 8883
		[Token(Token = "0x40022B3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _nickname;

		// Token: 0x040022B4 RID: 8884
		[Token(Token = "0x40022B4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _place;

		// Token: 0x040022B5 RID: 8885
		[Token(Token = "0x40022B5")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _score;

		// Token: 0x040022B6 RID: 8886
		[Token(Token = "0x40022B6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _ribbon;

		// Token: 0x040022B7 RID: 8887
		[Token(Token = "0x40022B7")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ClanMemberListElementBg _background;

		// Token: 0x02000A36 RID: 2614
		[Token(Token = "0x2000A36")]
		public class ClanMemberListElementArgs : GenericListElementArgs
		{
			// Token: 0x14000198 RID: 408
			// (add) Token: 0x06003DE8 RID: 15848 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06003DE9 RID: 15849 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x14000198")]
			public event Action<bool> SelectChangedEvent
			{
				[Token(Token = "0x6003DE8")]
				[Address(RVA = "0x8CA7", Offset = "0x8CA7", VA = "0x8CA7")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6003DE9")]
				[Address(RVA = "0x8CA8", Offset = "0x8CA8", VA = "0x8CA8")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x17000C5B RID: 3163
			// (get) Token: 0x06003DEA RID: 15850 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
			// (set) Token: 0x06003DEB RID: 15851 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C5B")]
			public ulong Rating
			{
				[Token(Token = "0x6003DEA")]
				[Address(RVA = "0x8CA9", Offset = "0x8CA9", VA = "0x8CA9")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
				[Token(Token = "0x6003DEB")]
				[Address(RVA = "0x8CAA", Offset = "0x8CAA", VA = "0x8CAA")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000C5C RID: 3164
			// (get) Token: 0x06003DEC RID: 15852 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
			// (set) Token: 0x06003DED RID: 15853 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C5C")]
			public bool Selected
			{
				[Token(Token = "0x6003DEC")]
				[Address(RVA = "0x8CAB", Offset = "0x8CAB", VA = "0x8CAB")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003DED")]
				[Address(RVA = "0x8CAC", Offset = "0x8CAC", VA = "0x8CAC")]
				set
				{
				}
			}

			// Token: 0x06003DEE RID: 15854 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
			[Token(Token = "0x6003DEE")]
			[Address(RVA = "0x8CAD", Offset = "0x8CAD", VA = "0x8CAD")]
			public ulong SelectUserRating(UserRatingTypes ratingType, RatingPeriods period)
			{
				return 0UL;
			}

			// Token: 0x06003DEF RID: 15855 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003DEF")]
			[Address(RVA = "0x8CAE", Offset = "0x8CAE", VA = "0x8CAE")]
			public ClanMemberListElementArgs()
			{
			}

			// Token: 0x06003DF0 RID: 15856 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6003DF0")]
			[Address(RVA = "0x8CAF", Offset = "0x8CAF", VA = "0x8CAF")]
			[CompilerGenerated]
			private IList<ulong> <SelectUserRating>g__SelectPeriod|17_0(ref ClanMemberListElement.ClanMemberListElementArgs.<>c__DisplayClass17_0 A_1)
			{
				return null;
			}

			// Token: 0x040022B8 RID: 8888
			[Token(Token = "0x40022B8")]
			[FieldOffset(Offset = "0xC")]
			private bool _selected;

			// Token: 0x040022BA RID: 8890
			[Token(Token = "0x40022BA")]
			[FieldOffset(Offset = "0x14")]
			public Action<ClanMemberListElement> MemberButtonClickedEventHandler;

			// Token: 0x040022BB RID: 8891
			[Token(Token = "0x40022BB")]
			[FieldOffset(Offset = "0x18")]
			public UserData UserData;

			// Token: 0x040022BC RID: 8892
			[Token(Token = "0x40022BC")]
			[FieldOffset(Offset = "0x1C")]
			public IList<ulong> TodayRating;

			// Token: 0x040022BD RID: 8893
			[Token(Token = "0x40022BD")]
			[FieldOffset(Offset = "0x20")]
			public IList<ulong> YesterdayRating;

			// Token: 0x040022BE RID: 8894
			[Token(Token = "0x40022BE")]
			[FieldOffset(Offset = "0x24")]
			public bool IsHead;

			// Token: 0x040022BF RID: 8895
			[Token(Token = "0x40022BF")]
			[FieldOffset(Offset = "0x25")]
			public bool IsMy;
		}
	}
}
