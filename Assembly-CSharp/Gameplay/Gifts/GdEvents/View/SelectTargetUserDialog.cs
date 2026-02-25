using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using frame8.Logic.Misc.Visual.UI.MonoBehaviours;
using Gameplay.Gifts.GdEvents.Control;
using Gameplay.Gifts.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Price;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Gifts.GdEvents.View
{
	// Token: 0x02000710 RID: 1808
	[Token(Token = "0x2000710")]
	public class SelectTargetUserDialog : BaseDialogWindow<SelectTargetUserDialog.SelectTargetUserDialogArgs>
	{
		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06002B40 RID: 11072 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700083F")]
		public override string WindowId
		{
			[Token(Token = "0x6002B40")]
			[Address(RVA = "0x7BDB", Offset = "0x7BDB", VA = "0x7BDB", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400015D RID: 349
		// (add) Token: 0x06002B41 RID: 11073 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002B42 RID: 11074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400015D")]
		public event Action<UserData> SelectEvent
		{
			[Token(Token = "0x6002B41")]
			[Address(RVA = "0x7BDC", Offset = "0x7BDC", VA = "0x7BDC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002B42")]
			[Address(RVA = "0x7BDD", Offset = "0x7BDD", VA = "0x7BDD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06002B43 RID: 11075 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000840")]
		public TextMeshProUGUI GiftsLeftField
		{
			[Token(Token = "0x6002B43")]
			[Address(RVA = "0x7BDE", Offset = "0x7BDE", VA = "0x7BDE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000841")]
		public TextMeshProUGUI GiftsMaxField
		{
			[Token(Token = "0x6002B44")]
			[Address(RVA = "0x7BDF", Offset = "0x7BDF", VA = "0x7BDF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06002B45 RID: 11077 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000842")]
		public TextMeshProUGUI ReasonDescription
		{
			[Token(Token = "0x6002B45")]
			[Address(RVA = "0x7BE0", Offset = "0x7BE0", VA = "0x7BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000843")]
		public Transform UsersList
		{
			[Token(Token = "0x6002B46")]
			[Address(RVA = "0x7BE1", Offset = "0x7BE1", VA = "0x7BE1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06002B47 RID: 11079 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000844")]
		public Transform ReasonDescriptionGroup
		{
			[Token(Token = "0x6002B47")]
			[Address(RVA = "0x7BE2", Offset = "0x7BE2", VA = "0x7BE2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06002B48 RID: 11080 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000845")]
		public UserItemView[] Renderers
		{
			[Token(Token = "0x6002B48")]
			[Address(RVA = "0x7BE3", Offset = "0x7BE3", VA = "0x7BE3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B49")]
		[Address(RVA = "0x7BE4", Offset = "0x7BE4", VA = "0x7BE4", Slot = "22")]
		protected override void OnShow(SelectTargetUserDialog.SelectTargetUserDialogArgs args)
		{
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4A")]
		[Address(RVA = "0x7BE5", Offset = "0x7BE5", VA = "0x7BE5", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4B")]
		[Address(RVA = "0x7BE6", Offset = "0x7BE6", VA = "0x7BE6", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4C")]
		[Address(RVA = "0x7BE7", Offset = "0x7BE7", VA = "0x7BE7")]
		private void ItemRenderOnSelectEvent(UserData user)
		{
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4D")]
		[Address(RVA = "0x7BE8", Offset = "0x7BE8", VA = "0x7BE8")]
		public SelectTargetUserDialog()
		{
		}

		// Token: 0x040017A7 RID: 6055
		[Token(Token = "0x40017A7")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Gifts/GdEvents/SelectTargetUserDialogWindow";

		// Token: 0x040017A8 RID: 6056
		[Token(Token = "0x40017A8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GiftView _gift;

		// Token: 0x040017A9 RID: 6057
		[Token(Token = "0x40017A9")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextMeshProUGUI _giftTitle;

		// Token: 0x040017AA RID: 6058
		[Token(Token = "0x40017AA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _giftsLeftField;

		// Token: 0x040017AB RID: 6059
		[Token(Token = "0x40017AB")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TextMeshProUGUI _giftsMaxField;

		// Token: 0x040017AC RID: 6060
		[Token(Token = "0x40017AC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _priceField;

		// Token: 0x040017AD RID: 6061
		[Token(Token = "0x40017AD")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private TextMeshProUGUI _reasonDescription;

		// Token: 0x040017AE RID: 6062
		[Token(Token = "0x40017AE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Price _price;

		// Token: 0x040017AF RID: 6063
		[Token(Token = "0x40017AF")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Transform _scrollContentOwner;

		// Token: 0x040017B0 RID: 6064
		[Token(Token = "0x40017B0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _usersList;

		// Token: 0x040017B1 RID: 6065
		[Token(Token = "0x40017B1")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Transform _reasonDescriptionGroup;

		// Token: 0x040017B2 RID: 6066
		[Token(Token = "0x40017B2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _bottom;

		// Token: 0x040017B3 RID: 6067
		[Token(Token = "0x40017B3")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private UserItemView _userItemRenderPrefab;

		// Token: 0x040017B4 RID: 6068
		[Token(Token = "0x40017B4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ScrollbarFixer8 _scrollbar;

		// Token: 0x040017B6 RID: 6070
		[Token(Token = "0x40017B6")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		private UserItemView[] _renderers;

		// Token: 0x040017B7 RID: 6071
		[Token(Token = "0x40017B7")]
		[FieldOffset(Offset = "0x8C")]
		private SelectTargetUserDialogMediator _mediator;

		// Token: 0x02000711 RID: 1809
		[Token(Token = "0x2000711")]
		public class SelectTargetUserDialogArgs : BaseDialogWindow<SelectTargetUserDialog.SelectTargetUserDialogArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06002B4E RID: 11086 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B4E")]
			[Address(RVA = "0x2181", Offset = "0x2181", VA = "0x2181")]
			public SelectTargetUserDialogArgs(SocialGiftDic gift, GiftController controller, IList<UserData> users)
			{
			}

			// Token: 0x040017B8 RID: 6072
			[Token(Token = "0x40017B8")]
			[FieldOffset(Offset = "0x2C")]
			public readonly SocialGiftDic Gift;

			// Token: 0x040017B9 RID: 6073
			[Token(Token = "0x40017B9")]
			[FieldOffset(Offset = "0x30")]
			public readonly GiftController Controller;

			// Token: 0x040017BA RID: 6074
			[Token(Token = "0x40017BA")]
			[FieldOffset(Offset = "0x34")]
			public readonly IList<UserData> Users;
		}
	}
}
